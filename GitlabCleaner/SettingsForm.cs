using System;
using System.Globalization;
using System.Windows.Forms;


namespace GitlabCleaner
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        private async void verifyButton_Click(object sender, EventArgs e)
        {
            try
            {
                GitLabApiClient.GitLabClient client = new GitLabApiClient.GitLabClient(urlTextBox.Text, apikeyTextBox.Text);
                GitLabApiClient.Models.Users.Responses.Session response = await client.Users.GetCurrentSessionAsync().ConfigureAwait(true);
                pictureBox1.Visible = false;
                pictureBox1.ImageLocation = response.AvatarUrl;
                pictureBox1.LoadAsync();
                MessageBox.Show(String.Format(CultureInfo.CurrentCulture, Properties.Resources.TestingSucceeded, response.Name));
                saveButton.Enabled = true;
            }
            catch (Exception ex)
            {
                saveButton.Enabled = false;
                MessageBox.Show(ex.Message, Properties.Resources.Error, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.url = urlTextBox.Text;
            Properties.Settings.Default.apikey = apikeyTextBox.Text;
            Properties.Settings.Default.Save();
        }

        private void urlTextBox_TextChanged(object sender, EventArgs e)
        {
            verifyButton.Enabled = urlTextBox.Text.Length > 0 && apikeyTextBox.Text.Length > 0;
        }

        private void pictureBox1_LoadCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            pictureBox1.Visible = true;
        }
    }
}
