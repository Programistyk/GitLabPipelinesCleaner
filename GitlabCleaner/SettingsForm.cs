using System;
using System.Globalization;
using System.Threading.Tasks;
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
            GitLabApiClient.GitLabClient client = new GitLabApiClient.GitLabClient(urlTextBox.Text, apikeyTextBox.Text);
            Task<GitLabApiClient.Models.Users.Responses.Session> sessionTask = client.Users.GetCurrentSessionAsync();

            GitLabApiClient.Models.Users.Responses.Session response = await sessionTask.ConfigureAwait(true);

            pictureBox1.ImageLocation = response.AvatarUrl;
            pictureBox1.LoadAsync();
            MessageBox.Show(String.Format(CultureInfo.CurrentCulture, Properties.Resources.TestingSucceeded, response.Name));
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.url = urlTextBox.Text;
            Properties.Settings.Default.username = usernameTextBox.Text;
            Properties.Settings.Default.apikey = apikeyTextBox.Text;
            Properties.Settings.Default.Save();
        }
    }
}
