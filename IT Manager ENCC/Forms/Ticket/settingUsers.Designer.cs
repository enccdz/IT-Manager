namespace IT_Manager_ENCC.Forms
{
    partial class settingUsers
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
            this.usersMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.AddUserFormContainer = new DevExpress.XtraEditors.GroupControl();
            this.userNameTxt = new DevExpress.XtraEditors.TextEdit();
            this.addUserBtn = new DevExpress.XtraEditors.SimpleButton();
            this.passwordTxt = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.numTelTxt = new DevExpress.XtraEditors.TextEdit();
            this.label7 = new System.Windows.Forms.Label();
            this.fulNameTxt = new DevExpress.XtraEditors.TextEdit();
            this.jobTxt = new DevExpress.XtraEditors.TextEdit();
            this.emailTxt = new DevExpress.XtraEditors.TextEdit();
            this.label8 = new System.Windows.Forms.Label();
            this.localEmailTxt = new DevExpress.XtraEditors.TextEdit();
            this.directionTxt = new DevExpress.XtraEditors.TextEdit();
            this.usersGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.usersMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AddUserFormContainer)).BeginInit();
            this.AddUserFormContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userNameTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTelTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fulNameTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.localEmailTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.directionTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // usersMenu
            // 
            this.usersMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.usersMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.usersMenu.Name = "contextMenuStrip1";
            this.usersMenu.Size = new System.Drawing.Size(121, 52);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.editToolStripMenuItem.Text = "edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(120, 24);
            this.deleteToolStripMenuItem.Text = "delete";
            this.deleteToolStripMenuItem.Click += new System.EventHandler(this.deleteToolStripMenuItem_Click);
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.AddUserFormContainer);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.usersGrid);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(726, 459);
            this.splitContainerControl1.SplitterPosition = 161;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // AddUserFormContainer
            // 
            this.AddUserFormContainer.Controls.Add(this.userNameTxt);
            this.AddUserFormContainer.Controls.Add(this.addUserBtn);
            this.AddUserFormContainer.Controls.Add(this.passwordTxt);
            this.AddUserFormContainer.Controls.Add(this.label1);
            this.AddUserFormContainer.Controls.Add(this.label6);
            this.AddUserFormContainer.Controls.Add(this.label10);
            this.AddUserFormContainer.Controls.Add(this.label5);
            this.AddUserFormContainer.Controls.Add(this.label2);
            this.AddUserFormContainer.Controls.Add(this.label4);
            this.AddUserFormContainer.Controls.Add(this.numTelTxt);
            this.AddUserFormContainer.Controls.Add(this.label7);
            this.AddUserFormContainer.Controls.Add(this.fulNameTxt);
            this.AddUserFormContainer.Controls.Add(this.jobTxt);
            this.AddUserFormContainer.Controls.Add(this.emailTxt);
            this.AddUserFormContainer.Controls.Add(this.label8);
            this.AddUserFormContainer.Controls.Add(this.localEmailTxt);
            this.AddUserFormContainer.Controls.Add(this.directionTxt);
            this.AddUserFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddUserFormContainer.Location = new System.Drawing.Point(0, 0);
            this.AddUserFormContainer.Name = "AddUserFormContainer";
            this.AddUserFormContainer.Size = new System.Drawing.Size(726, 161);
            this.AddUserFormContainer.TabIndex = 0;
            this.AddUserFormContainer.Text = "Add a new user";
            // 
            // userNameTxt
            // 
            this.userNameTxt.Location = new System.Drawing.Point(324, 30);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(149, 22);
            this.userNameTxt.TabIndex = 45;
            this.userNameTxt.EditValueChanged += new System.EventHandler(this.userNameTxt_EditValueChanged);
            // 
            // addUserBtn
            // 
            this.addUserBtn.Location = new System.Drawing.Point(582, 127);
            this.addUserBtn.Name = "addUserBtn";
            this.addUserBtn.Size = new System.Drawing.Size(130, 29);
            this.addUserBtn.TabIndex = 54;
            this.addUserBtn.Text = "Add user";
            this.addUserBtn.Click += new System.EventHandler(this.addUserBtn_Click);
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(324, 63);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(149, 22);
            this.passwordTxt.TabIndex = 46;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 40;
            this.label1.Text = "Job :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 66);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Direction :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(235, 99);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 17);
            this.label10.TabIndex = 37;
            this.label10.Text = "Num Tel :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 66);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 43;
            this.label5.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 41;
            this.label2.Text = "FullName :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(235, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 42;
            this.label4.Text = "User Name :";
            // 
            // numTelTxt
            // 
            this.numTelTxt.Location = new System.Drawing.Point(324, 96);
            this.numTelTxt.Name = "numTelTxt";
            this.numTelTxt.Size = new System.Drawing.Size(149, 22);
            this.numTelTxt.TabIndex = 51;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(479, 66);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(83, 17);
            this.label7.TabIndex = 44;
            this.label7.Text = "Local Email :";
            // 
            // fulNameTxt
            // 
            this.fulNameTxt.Location = new System.Drawing.Point(80, 30);
            this.fulNameTxt.Name = "fulNameTxt";
            this.fulNameTxt.Size = new System.Drawing.Size(149, 22);
            this.fulNameTxt.TabIndex = 52;
            // 
            // jobTxt
            // 
            this.jobTxt.Location = new System.Drawing.Point(80, 96);
            this.jobTxt.Name = "jobTxt";
            this.jobTxt.Size = new System.Drawing.Size(149, 22);
            this.jobTxt.TabIndex = 53;
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(563, 30);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(149, 22);
            this.emailTxt.TabIndex = 49;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(479, 33);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 17);
            this.label8.TabIndex = 38;
            this.label8.Text = "Email :";
            // 
            // localEmailTxt
            // 
            this.localEmailTxt.Location = new System.Drawing.Point(563, 63);
            this.localEmailTxt.Name = "localEmailTxt";
            this.localEmailTxt.Size = new System.Drawing.Size(149, 22);
            this.localEmailTxt.TabIndex = 48;
            // 
            // directionTxt
            // 
            this.directionTxt.Location = new System.Drawing.Point(80, 63);
            this.directionTxt.Name = "directionTxt";
            this.directionTxt.Size = new System.Drawing.Size(149, 22);
            this.directionTxt.TabIndex = 55;
            // 
            // usersGrid
            // 
            this.usersGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersGrid.Location = new System.Drawing.Point(0, 0);
            this.usersGrid.MainView = this.gridView1;
            this.usersGrid.Name = "usersGrid";
            this.usersGrid.Size = new System.Drawing.Size(726, 292);
            this.usersGrid.TabIndex = 0;
            this.usersGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.usersGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.LostFocus += new System.EventHandler(this.gridView1_LostFocus);
            // 
            // settingUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(726, 459);
            this.Controls.Add(this.splitContainerControl1);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "settingUsers";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.settingUsers_Load);
            this.usersMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AddUserFormContainer)).EndInit();
            this.AddUserFormContainer.ResumeLayout(false);
            this.AddUserFormContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userNameTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numTelTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fulNameTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jobTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.localEmailTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.directionTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip usersMenu;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl AddUserFormContainer;
        private DevExpress.XtraEditors.TextEdit userNameTxt;
        private DevExpress.XtraEditors.SimpleButton addUserBtn;
        private DevExpress.XtraEditors.TextEdit passwordTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit numTelTxt;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.TextEdit fulNameTxt;
        private DevExpress.XtraEditors.TextEdit jobTxt;
        private DevExpress.XtraEditors.TextEdit emailTxt;
        private System.Windows.Forms.Label label8;
        private DevExpress.XtraEditors.TextEdit localEmailTxt;
        private DevExpress.XtraEditors.TextEdit directionTxt;
        private DevExpress.XtraGrid.GridControl usersGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
    }
}