namespace IT_Manager_ENCC.Forms
{
    partial class settingAdmins
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
            this.adminsGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.AdminFormContainer = new DevExpress.XtraEditors.GroupControl();
            this.addAdminBtn = new DevExpress.XtraEditors.SimpleButton();
            this.fullNameTxt = new DevExpress.XtraEditors.TextEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userTxt = new DevExpress.XtraEditors.TextEdit();
            this.passTxt = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.roleComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.adminsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdminFormContainer)).BeginInit();
            this.AdminFormContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullNameTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleComboBox.Properties)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // adminsGrid
            // 
            this.adminsGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.adminsGrid.Location = new System.Drawing.Point(0, 0);
            this.adminsGrid.MainView = this.gridView1;
            this.adminsGrid.Name = "adminsGrid";
            this.adminsGrid.Size = new System.Drawing.Size(515, 354);
            this.adminsGrid.TabIndex = 0;
            this.adminsGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.adminsGrid;
            this.gridView1.Name = "gridView1";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.AdminFormContainer);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.adminsGrid);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(515, 502);
            this.splitContainerControl1.SplitterPosition = 142;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // AdminFormContainer
            // 
            this.AdminFormContainer.Controls.Add(this.addAdminBtn);
            this.AdminFormContainer.Controls.Add(this.fullNameTxt);
            this.AdminFormContainer.Controls.Add(this.label5);
            this.AdminFormContainer.Controls.Add(this.label2);
            this.AdminFormContainer.Controls.Add(this.label4);
            this.AdminFormContainer.Controls.Add(this.userTxt);
            this.AdminFormContainer.Controls.Add(this.passTxt);
            this.AdminFormContainer.Controls.Add(this.label1);
            this.AdminFormContainer.Controls.Add(this.roleComboBox);
            this.AdminFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AdminFormContainer.Location = new System.Drawing.Point(0, 0);
            this.AdminFormContainer.Name = "AdminFormContainer";
            this.AdminFormContainer.Size = new System.Drawing.Size(515, 142);
            this.AdminFormContainer.TabIndex = 0;
            this.AdminFormContainer.Text = "Add a new administrator";
            // 
            // addAdminBtn
            // 
            this.addAdminBtn.Location = new System.Drawing.Point(374, 108);
            this.addAdminBtn.Name = "addAdminBtn";
            this.addAdminBtn.Size = new System.Drawing.Size(129, 29);
            this.addAdminBtn.TabIndex = 44;
            this.addAdminBtn.Text = "Add Administrator";
            this.addAdminBtn.Click += new System.EventHandler(this.addAdminBtn_Click);
            // 
            // fullNameTxt
            // 
            this.fullNameTxt.Location = new System.Drawing.Point(83, 28);
            this.fullNameTxt.Name = "fullNameTxt";
            this.fullNameTxt.Size = new System.Drawing.Size(153, 22);
            this.fullNameTxt.TabIndex = 40;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(258, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 17);
            this.label5.TabIndex = 39;
            this.label5.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "FullName :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(258, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(83, 17);
            this.label4.TabIndex = 38;
            this.label4.Text = "User Name :";
            // 
            // userTxt
            // 
            this.userTxt.Location = new System.Drawing.Point(347, 28);
            this.userTxt.Name = "userTxt";
            this.userTxt.Size = new System.Drawing.Size(158, 22);
            this.userTxt.TabIndex = 42;
            // 
            // passTxt
            // 
            this.passTxt.Location = new System.Drawing.Point(347, 65);
            this.passTxt.Name = "passTxt";
            this.passTxt.Size = new System.Drawing.Size(158, 22);
            this.passTxt.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Role :";
            // 
            // roleComboBox
            // 
            this.roleComboBox.Location = new System.Drawing.Point(83, 65);
            this.roleComboBox.Name = "roleComboBox";
            this.roleComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.roleComboBox.Properties.Items.AddRange(new object[] {
            "Admin",
            "Super Admin"});
            this.roleComboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.roleComboBox.Size = new System.Drawing.Size(153, 22);
            this.roleComboBox.TabIndex = 43;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(123, 52);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.editToolStripMenuItem.Text = "Edit";
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(122, 24);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // settingAdmins
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 502);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "settingAdmins";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.settingAdmins_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdminFormContainer)).EndInit();
            this.AdminFormContainer.ResumeLayout(false);
            this.AdminFormContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fullNameTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roleComboBox.Properties)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.GridControl adminsGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.GroupControl AdminFormContainer;
        private DevExpress.XtraEditors.TextEdit fullNameTxt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.TextEdit userTxt;
        private DevExpress.XtraEditors.TextEdit passTxt;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.ComboBoxEdit roleComboBox;
        private DevExpress.XtraEditors.SimpleButton addAdminBtn;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleteToolStripMenuItem;
    }
}