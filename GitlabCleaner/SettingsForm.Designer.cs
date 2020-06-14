namespace GitlabCleaner
{
    partial class SettingsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.verifyButton = new System.Windows.Forms.Button();
            this.apikeyTextBox = new System.Windows.Forms.TextBox();
            this.urlTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // saveButton
            // 
            resources.ApplyResources(this.saveButton, "saveButton");
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Name = "saveButton";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            resources.ApplyResources(this.cancelButton, "cancelButton");
            this.cancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.verifyButton);
            this.groupBox1.Controls.Add(this.apikeyTextBox);
            this.groupBox1.Controls.Add(this.urlTextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // verifyButton
            // 
            resources.ApplyResources(this.verifyButton, "verifyButton");
            this.verifyButton.Name = "verifyButton";
            this.verifyButton.UseVisualStyleBackColor = true;
            this.verifyButton.Click += new System.EventHandler(this.verifyButton_Click);
            // 
            // apikeyTextBox
            // 
            resources.ApplyResources(this.apikeyTextBox, "apikeyTextBox");
            this.apikeyTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", global::GitlabCleaner.Properties.Settings.Default, "apikey", true, System.Windows.Forms.DataSourceUpdateMode.OnPropertyChanged));
            this.apikeyTextBox.Name = "apikeyTextBox";
            this.apikeyTextBox.Text = global::GitlabCleaner.Properties.Settings.Default.apikey;
            this.apikeyTextBox.UseSystemPasswordChar = true;
            this.apikeyTextBox.TextChanged += new System.EventHandler(this.urlTextBox_TextChanged);
            // 
            // urlTextBox
            // 
            resources.ApplyResources(this.urlTextBox, "urlTextBox");
            this.urlTextBox.AutoCompleteCustomSource.AddRange(new string[] {
            resources.GetString("urlTextBox.AutoCompleteCustomSource"),
            resources.GetString("urlTextBox.AutoCompleteCustomSource1")});
            this.urlTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.urlTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.urlTextBox.Name = "urlTextBox";
            this.urlTextBox.Text = global::GitlabCleaner.Properties.Settings.Default.url;
            this.urlTextBox.TextChanged += new System.EventHandler(this.urlTextBox_TextChanged);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            this.pictureBox1.LoadCompleted += new System.ComponentModel.AsyncCompletedEventHandler(this.pictureBox1_LoadCompleted);
            // 
            // SettingsForm
            // 
            this.AcceptButton = this.saveButton;
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.cancelButton;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SettingsForm";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button verifyButton;
        private System.Windows.Forms.TextBox apikeyTextBox;
        private System.Windows.Forms.TextBox urlTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}