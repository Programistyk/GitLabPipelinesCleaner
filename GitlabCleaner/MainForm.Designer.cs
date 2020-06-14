namespace GitlabCleaner
{
    partial class MainForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.settingsButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.connectButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.selectDropdownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.selectAllMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectNoneMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectInvertMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.selectSuccessMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFailureMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectManualMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectCanceledMenuitem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.selectOlder1mMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectOlder3mMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectOlder6mMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectOlder12mMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeSelectionButton = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripProgressBar1 = new System.Windows.Forms.ToolStripProgressBar();
            this.toolStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            resources.ApplyResources(this.listView1, "listView1");
            this.listView1.CheckBoxes = true;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.listView1.FullRowSelect = true;
            this.listView1.HideSelection = false;
            this.listView1.Name = "listView1";
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.listView1_ColumnClick);
            this.listView1.ItemChecked += new System.Windows.Forms.ItemCheckedEventHandler(this.listView1_ItemChecked);
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // columnHeader3
            // 
            resources.ApplyResources(this.columnHeader3, "columnHeader3");
            // 
            // columnHeader4
            // 
            resources.ApplyResources(this.columnHeader4, "columnHeader4");
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.settingsButton,
            this.toolStripSeparator1,
            this.connectButton,
            this.toolStripSeparator2,
            this.selectDropdownButton,
            this.removeSelectionButton});
            resources.ApplyResources(this.toolStrip1, "toolStrip1");
            this.toolStrip1.Name = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            resources.ApplyResources(this.toolStripLabel1, "toolStripLabel1");
            // 
            // settingsButton
            // 
            this.settingsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.settingsButton, "settingsButton");
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.Click += new System.EventHandler(this.settingsButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            resources.ApplyResources(this.toolStripSeparator1, "toolStripSeparator1");
            // 
            // connectButton
            // 
            this.connectButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.connectButton, "connectButton");
            this.connectButton.Name = "connectButton";
            this.connectButton.Click += new System.EventHandler(this.connectButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            resources.ApplyResources(this.toolStripSeparator2, "toolStripSeparator2");
            // 
            // selectDropdownButton
            // 
            this.selectDropdownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.selectDropdownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllMenuItem,
            this.selectNoneMenuItem,
            this.selectInvertMenuItem,
            this.toolStripSeparator3,
            this.selectSuccessMenuItem,
            this.selectFailureMenuItem,
            this.selectManualMenuItem,
            this.selectCanceledMenuitem,
            this.toolStripSeparator4,
            this.selectOlder1mMenuItem,
            this.selectOlder3mMenuItem,
            this.selectOlder6mMenuItem,
            this.selectOlder12mMenuItem});
            resources.ApplyResources(this.selectDropdownButton, "selectDropdownButton");
            this.selectDropdownButton.Name = "selectDropdownButton";
            // 
            // selectAllMenuItem
            // 
            this.selectAllMenuItem.Name = "selectAllMenuItem";
            resources.ApplyResources(this.selectAllMenuItem, "selectAllMenuItem");
            this.selectAllMenuItem.Click += new System.EventHandler(this.selectAllMenuItem_Click);
            // 
            // selectNoneMenuItem
            // 
            this.selectNoneMenuItem.Name = "selectNoneMenuItem";
            resources.ApplyResources(this.selectNoneMenuItem, "selectNoneMenuItem");
            this.selectNoneMenuItem.Click += new System.EventHandler(this.selectNoneMenuItem_Click);
            // 
            // selectInvertMenuItem
            // 
            this.selectInvertMenuItem.Name = "selectInvertMenuItem";
            resources.ApplyResources(this.selectInvertMenuItem, "selectInvertMenuItem");
            this.selectInvertMenuItem.Click += new System.EventHandler(this.selectInvertMenuItem_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            resources.ApplyResources(this.toolStripSeparator3, "toolStripSeparator3");
            // 
            // selectSuccessMenuItem
            // 
            this.selectSuccessMenuItem.Name = "selectSuccessMenuItem";
            resources.ApplyResources(this.selectSuccessMenuItem, "selectSuccessMenuItem");
            this.selectSuccessMenuItem.Click += new System.EventHandler(this.selectSuccessMenuItem_Click);
            // 
            // selectFailureMenuItem
            // 
            this.selectFailureMenuItem.Name = "selectFailureMenuItem";
            resources.ApplyResources(this.selectFailureMenuItem, "selectFailureMenuItem");
            this.selectFailureMenuItem.Click += new System.EventHandler(this.selectFailureMenuItem_Click);
            // 
            // selectManualMenuItem
            // 
            this.selectManualMenuItem.Name = "selectManualMenuItem";
            resources.ApplyResources(this.selectManualMenuItem, "selectManualMenuItem");
            this.selectManualMenuItem.Click += new System.EventHandler(this.selectManualMenuItem_Click);
            // 
            // selectCanceledMenuitem
            // 
            this.selectCanceledMenuitem.Name = "selectCanceledMenuitem";
            resources.ApplyResources(this.selectCanceledMenuitem, "selectCanceledMenuitem");
            this.selectCanceledMenuitem.Click += new System.EventHandler(this.selectCanceledMenuitem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            resources.ApplyResources(this.toolStripSeparator4, "toolStripSeparator4");
            // 
            // selectOlder1mMenuItem
            // 
            this.selectOlder1mMenuItem.Name = "selectOlder1mMenuItem";
            resources.ApplyResources(this.selectOlder1mMenuItem, "selectOlder1mMenuItem");
            this.selectOlder1mMenuItem.Click += new System.EventHandler(this.selectOlder1mMenuItem_Click);
            // 
            // selectOlder3mMenuItem
            // 
            this.selectOlder3mMenuItem.Name = "selectOlder3mMenuItem";
            resources.ApplyResources(this.selectOlder3mMenuItem, "selectOlder3mMenuItem");
            this.selectOlder3mMenuItem.Click += new System.EventHandler(this.selectOlder3mMenuItem_Click);
            // 
            // selectOlder6mMenuItem
            // 
            this.selectOlder6mMenuItem.Name = "selectOlder6mMenuItem";
            resources.ApplyResources(this.selectOlder6mMenuItem, "selectOlder6mMenuItem");
            this.selectOlder6mMenuItem.Click += new System.EventHandler(this.selectOlder6mMenuItem_Click);
            // 
            // selectOlder12mMenuItem
            // 
            this.selectOlder12mMenuItem.Name = "selectOlder12mMenuItem";
            resources.ApplyResources(this.selectOlder12mMenuItem, "selectOlder12mMenuItem");
            this.selectOlder12mMenuItem.Click += new System.EventHandler(this.selectOlder12mMenuItem_Click);
            // 
            // removeSelectionButton
            // 
            this.removeSelectionButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            resources.ApplyResources(this.removeSelectionButton, "removeSelectionButton");
            this.removeSelectionButton.Name = "removeSelectionButton";
            this.removeSelectionButton.Click += new System.EventHandler(this.removeSelectionButton_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripProgressBar1});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            this.toolStripStatusLabel1.Spring = true;
            // 
            // toolStripProgressBar1
            // 
            this.toolStripProgressBar1.Name = "toolStripProgressBar1";
            resources.ApplyResources(this.toolStripProgressBar1, "toolStripProgressBar1");
            this.toolStripProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            // 
            // MainForm
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.listView1);
            this.DoubleBuffered = true;
            this.Name = "MainForm";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton settingsButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton connectButton;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripProgressBar toolStripProgressBar1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton removeSelectionButton;
        private System.Windows.Forms.ToolStripDropDownButton selectDropdownButton;
        private System.Windows.Forms.ToolStripMenuItem selectAllMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectNoneMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectInvertMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem selectSuccessMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectFailureMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectManualMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem selectOlder1mMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectOlder3mMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectOlder6mMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectOlder12mMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectCanceledMenuitem;
    }
}

