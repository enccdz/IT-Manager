namespace IT_Manager_ENCC.Forms.Pass
{
    partial class externalEmailList
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
            this.components = new System.ComponentModel.Container();
            this.deleateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.emailsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchTxt = new DevExpress.XtraEditors.TextEdit();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.emailGrid = new DevExpress.XtraGrid.GridControl();
            this.label2 = new System.Windows.Forms.Label();
            this.addEmailBtn = new DevExpress.XtraEditors.SimpleButton();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.hardwareFormContainer = new DevExpress.XtraEditors.GroupControl();
            this.emailsMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.searchTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareFormContainer)).BeginInit();
            this.hardwareFormContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // deleateToolStripMenuItem
            // 
            this.deleateToolStripMenuItem.Name = "deleateToolStripMenuItem";
            this.deleateToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.deleateToolStripMenuItem.Text = "Deleate";
            this.deleateToolStripMenuItem.Click += new System.EventHandler(this.deleateToolStripMenuItem_Click);
            // 
            // emailsMenu
            // 
            this.emailsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.emailsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleateToolStripMenuItem});
            this.emailsMenu.Name = "hardwaresMenu";
            this.emailsMenu.Size = new System.Drawing.Size(131, 52);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(104, 28);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(421, 22);
            this.searchTxt.TabIndex = 65;
            this.searchTxt.EditValueChanged += new System.EventHandler(this.searchTxt_EditValueChanged);
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.emailGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.LostFocus += new System.EventHandler(this.gridView1_LostFocus);
            // 
            // emailGrid
            // 
            this.emailGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.emailGrid.Location = new System.Drawing.Point(0, 0);
            this.emailGrid.MainView = this.gridView1;
            this.emailGrid.Name = "emailGrid";
            this.emailGrid.Size = new System.Drawing.Size(536, 306);
            this.emailGrid.TabIndex = 1;
            this.emailGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(93, 17);
            this.label2.TabIndex = 64;
            this.label2.Text = "Search email :";
            // 
            // addEmailBtn
            // 
            this.addEmailBtn.Location = new System.Drawing.Point(414, 56);
            this.addEmailBtn.Name = "addEmailBtn";
            this.addEmailBtn.Size = new System.Drawing.Size(111, 25);
            this.addEmailBtn.TabIndex = 68;
            this.addEmailBtn.Text = "Add Email";
            this.addEmailBtn.Click += new System.EventHandler(this.addEmailBtn_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.hardwareFormContainer);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.emailGrid);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(536, 402);
            this.splitContainerControl1.SplitterPosition = 90;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // hardwareFormContainer
            // 
            this.hardwareFormContainer.Controls.Add(this.searchTxt);
            this.hardwareFormContainer.Controls.Add(this.label2);
            this.hardwareFormContainer.Controls.Add(this.addEmailBtn);
            this.hardwareFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hardwareFormContainer.Location = new System.Drawing.Point(0, 0);
            this.hardwareFormContainer.Name = "hardwareFormContainer";
            this.hardwareFormContainer.Size = new System.Drawing.Size(536, 90);
            this.hardwareFormContainer.TabIndex = 2;
            this.hardwareFormContainer.Text = "External email list";
            // 
            // externalEmailList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 402);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "externalEmailList";
            this.ShowIcon = false;
            this.emailsMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.searchTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hardwareFormContainer)).EndInit();
            this.hardwareFormContainer.ResumeLayout(false);
            this.hardwareFormContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem deleateToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip emailsMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private DevExpress.XtraEditors.TextEdit searchTxt;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl emailGrid;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton addEmailBtn;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl hardwareFormContainer;
    }
}