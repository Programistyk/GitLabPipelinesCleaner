using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using GitLabApiClient;
using GitLabApiClient.Models.Pipelines;
using GitLabApiClient.Models.Pipelines.Responses;

namespace GitlabCleaner
{
    public partial class MainForm : Form
    {
        private GitLabClient client;
        private readonly ListViewItemComparer lviComparer;
        private PictureBox userAvatar;

        public MainForm()
        {
            InitializeComponent();
            lviComparer = new ListViewItemComparer();
            listView1.ListViewItemSorter = lviComparer;
            
        }

        private void settingsButton_Click(object sender, EventArgs e)
        {
            SettingsForm form = new SettingsForm();
            form.ShowDialog();
            form.Dispose();
        }

        private async void connectButton_Click(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.apikey.Length == 0)
            {
                return;
            }

            if (client == null)
            {
                client = new GitLabClient(Properties.Settings.Default.url, Properties.Settings.Default.apikey);
                toolStripStatusLabel1.Text = Properties.Resources.Connecting;
                toolStripProgressBar1.Style = ProgressBarStyle.Marquee;
                GitLabApiClient.Models.Users.Responses.Session session = await client.Users.GetCurrentSessionAsync().ConfigureAwait(true);
                toolStripStatusLabel1.Text = Properties.Resources.DownloadingAvatar;
                toolStripLabel1.Text = session.Name;

                userAvatar = new PictureBox
                {
                    ImageLocation = session.AvatarUrl
                };
                userAvatar.LoadAsync();
                userAvatar.LoadCompleted += delegate { toolStripLabel1.Image = userAvatar.Image; };

                toolStripStatusLabel1.Text = Properties.Resources.DownloadingProjects;
                IList<GitLabApiClient.Models.Projects.Responses.Project> projects = await client.Projects.GetAsync().ConfigureAwait(true);
                toolStripStatusLabel1.Text = Properties.Resources.DownloadingPipelines;
                toolStripProgressBar1.Value = 0;
                toolStripProgressBar1.Maximum = projects.Count;
                toolStripProgressBar1.Style = ProgressBarStyle.Continuous;
                listView1.Items.Clear();
                listView1.UseWaitCursor = true;
                foreach (GitLabApiClient.Models.Projects.Responses.Project project in projects) {
                    toolStripProgressBar1.PerformStep();
                    toolStripStatusLabel1.Text = String.Format(CultureInfo.CurrentCulture, Properties.Resources.DownloadingPipelineProgress, toolStripProgressBar1.Value, toolStripProgressBar1.Maximum, Math.Ceiling(toolStripProgressBar1.Value / toolStripProgressBar1.Maximum * 100.0));
                    ListViewGroup group = new ListViewGroup(project.NameWithNamespace);
                    group.Tag = project;
                    listView1.Groups.Add(group);

                    IList<GitLabApiClient.Models.Pipelines.Responses.Pipeline> pipelines = await client.Pipelines.GetAsync(project.Id).ConfigureAwait(true);

                    listView1.BeginUpdate();
                    foreach (GitLabApiClient.Models.Pipelines.Responses.Pipeline pipeline in pipelines)
                    {
                        ListViewItem item = new ListViewItem(String.Format(CultureInfo.InvariantCulture, "{0}", pipeline.Id), group);
                        item.Tag = pipeline;
                        item.SubItems.Add(new ListViewItem.ListViewSubItem(item, Properties.Resources.ResourceManager.GetString(String.Format(CultureInfo.InvariantCulture, "status.{0}", pipeline.Status), CultureInfo.CurrentCulture)));
                        item.SubItems.Add(new ListViewItem.ListViewSubItem(item, pipeline.UpdatedAt.ToString()));

                        listView1.Items.Add(item);
                    }
                    listView1.EndUpdate();
                }

                selectDropdownButton.Enabled = true;
                connectButton.Enabled = false;
                toolStripStatusLabel1.Text = Properties.Resources.Ready;
                toolStripProgressBar1.Value = 0;
                listView1.UseWaitCursor = false;
            }
        }

        private void listView1_ColumnClick(object sender, ColumnClickEventArgs e)
        {
            lviComparer.toggleSortOnColumn(e.Column);
            listView1.Sort();
        }

        private void listView1_ItemChecked(object sender, ItemCheckedEventArgs e)
        {
            removeSelectionButton.Enabled = listView1.CheckedItems.Count > 0;
            toolStripStatusLabel1.Text = String.Format(CultureInfo.InvariantCulture, Properties.Resources.SelectedProgress, listView1.CheckedItems.Count, listView1.Items.Count);
        }

        private async void removeSelectionButton_Click(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = Properties.Resources.RemovingPipelines;
            toolStripProgressBar1.Style = ProgressBarStyle.Continuous;
            toolStripProgressBar1.Value = 0;
            toolStripProgressBar1.Maximum = listView1.CheckedItems.Count;
            listView1.Enabled = false;
            listView1.UseWaitCursor = true;
            listView1.BeginUpdate();
            foreach (ListViewItem item in listView1.CheckedItems)
            {
                toolStripProgressBar1.PerformStep();
                toolStripStatusLabel1.Text = String.Format(CultureInfo.CurrentCulture, Properties.Resources.RemovingPipelinesProgress, toolStripProgressBar1.Value, toolStripProgressBar1.Maximum, Math.Ceiling(toolStripProgressBar1.Value / toolStripProgressBar1.Maximum * 100.0));

                await client.Pipelines.DeleteAsync(((GitLabApiClient.Models.Projects.Responses.Project)item.Group.Tag).Id, ((GitLabApiClient.Models.Pipelines.Responses.Pipeline)item.Tag).Id).ConfigureAwait(true);
                listView1.Items.Remove(item);
            }
            listView1.EndUpdate();

            toolStripStatusLabel1.Text = Properties.Resources.RemovingFinished;
            toolStripProgressBar1.Value = 0;
            listView1.Enabled = true;
            listView1.UseWaitCursor = false;
        }

        private static bool statusComparator(ListViewItem item, PipelineStatus status)
        {
            return ((GitLabApiClient.Models.Pipelines.Responses.Pipeline)item.Tag).Status == status;
        }

        private static bool dateComparator(ListViewItem item, int months_old)
        {
            DateTime? pipeline_date = ((GitLabApiClient.Models.Pipelines.Responses.Pipeline)item.Tag).CreatedAt;
            if (pipeline_date != null)
            {
                DateTime limit = DateTime.Now.AddMonths(-1 * months_old);
                return pipeline_date <= limit;
            }
            return false;
        }

        private void selectAllMenuItem_Click(object sender, EventArgs e)
        {
            listView1.BeginUpdate();
            foreach (ListViewItem item in listView1.Items)
            {
                item.Checked = true;
            }
            listView1.EndUpdate();
        }

        private void selectNoneMenuItem_Click(object sender, EventArgs e)
        {
            listView1.BeginUpdate();
            foreach (ListViewItem item in listView1.Items)
            {
                item.Checked = false;
            }
            listView1.EndUpdate();
        }

        private void selectInvertMenuItem_Click(object sender, EventArgs e)
        {
            listView1.BeginUpdate();
            foreach (ListViewItem item in listView1.Items)
            {
                item.Checked = !item.Checked;
            }
            listView1.EndUpdate();
        }

        private void selectSuccessMenuItem_Click(object sender, EventArgs e)
        {
            listView1.BeginUpdate();
            foreach (ListViewItem item in listView1.Items)
            {
                item.Checked = statusComparator(item, PipelineStatus.Success);
            }
            listView1.EndUpdate();
        }

        private void selectFailureMenuItem_Click(object sender, EventArgs e)
        {
            listView1.BeginUpdate();
            foreach (ListViewItem item in listView1.Items)
            {
                item.Checked = statusComparator(item, PipelineStatus.Failed);
            }
            listView1.EndUpdate();
        }

        private void selectManualMenuItem_Click(object sender, EventArgs e)
        {
            listView1.BeginUpdate();
            foreach (ListViewItem item in listView1.Items)
            {
                item.Checked = statusComparator(item, PipelineStatus.Manual);
            }
            listView1.EndUpdate();
        }

        private void selectCanceledMenuitem_Click(object sender, EventArgs e)
        {
            listView1.BeginUpdate();
            foreach (ListViewItem item in listView1.Items)
            {
                item.Checked = statusComparator(item, PipelineStatus.Canceled);
            }
            listView1.EndUpdate();
        }

        private void selectOlder1mMenuItem_Click(object sender, EventArgs e)
        {
            listView1.BeginUpdate();
            foreach (ListViewItem item in listView1.Items)
            {
                item.Checked = dateComparator(item, 1);
            }
            listView1.EndUpdate();
        }

        private void selectOlder3mMenuItem_Click(object sender, EventArgs e)
        {
            listView1.BeginUpdate();
            foreach (ListViewItem item in listView1.Items)
            {
                item.Checked = dateComparator(item, 3);
            }
            listView1.EndUpdate();
        }

        private void selectOlder6mMenuItem_Click(object sender, EventArgs e)
        {
            listView1.BeginUpdate();
            foreach (ListViewItem item in listView1.Items)
            {
                item.Checked = dateComparator(item, 6);
            }
            listView1.EndUpdate();
        }

        private void selectOlder12mMenuItem_Click(object sender, EventArgs e)
        {
            listView1.BeginUpdate();
            foreach (ListViewItem item in listView1.Items)
            {
                item.Checked = dateComparator(item, 12);
            }
            listView1.EndUpdate();
        }
    }

    class ListViewItemComparer : IComparer
    {
        private int col;
        private int last_column;
        private bool revert;
        public ListViewItemComparer()
        {
            col = 0;
            last_column = 0;
            revert = false;
        }

        public void toggleSortOnColumn(int column)
        {
            if (column == last_column)
            {
                revert = !revert;
            } else
            {
                revert = false;
                col = column;
                last_column = col;
            }
        }
        
        public int Compare(object x, object y)
        {
            return (revert ? -1 : 1) * String.Compare(((ListViewItem)x).SubItems[col].Text, ((ListViewItem)y).SubItems[col].Text, StringComparison.OrdinalIgnoreCase);
        }
    }
}
