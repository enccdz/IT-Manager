namespace IT_Manager_ENCC.Forms
{
    partial class hardwareMovement
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.movementGrid = new DevExpress.XtraGrid.GridControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.hardwareMovementFormContainer = new DevExpress.XtraEditors.GroupControl();
            this.statusComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.hardwareIdTxt = new DevExpress.XtraEditors.TextEdit();
            this.addMovementBtn = new DevExpress.XtraEditors.SimpleButton();
            this.userComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.searchTxt = new DevExpress.XtraEditors.TextEdit();
            this.movementMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.returnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareMovementFormContainer)).BeginInit();
            this.hardwareMovementFormContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareIdTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchTxt.Properties)).BeginInit();
            this.movementMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.movementGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.LostFocus += new System.EventHandler(this.gridView1_LostFocus);
            // 
            // movementGrid
            // 
            this.movementGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.movementGrid.Location = new System.Drawing.Point(0, 0);
            this.movementGrid.MainView = this.gridView1;
            this.movementGrid.Name = "movementGrid";
            this.movementGrid.Size = new System.Drawing.Size(640, 316);
            this.movementGrid.TabIndex = 1;
            this.movementGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.hardwareMovementFormContainer);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.movementGrid);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(640, 453);
            this.splitContainerControl1.SplitterPosition = 131;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // hardwareMovementFormContainer
            // 
            this.hardwareMovementFormContainer.Controls.Add(this.statusComboBox);
            this.hardwareMovementFormContainer.Controls.Add(this.hardwareIdTxt);
            this.hardwareMovementFormContainer.Controls.Add(this.addMovementBtn);
            this.hardwareMovementFormContainer.Controls.Add(this.userComboBox);
            this.hardwareMovementFormContainer.Controls.Add(this.label13);
            this.hardwareMovementFormContainer.Controls.Add(this.label2);
            this.hardwareMovementFormContainer.Controls.Add(this.label11);
            this.hardwareMovementFormContainer.Controls.Add(this.label12);
            this.hardwareMovementFormContainer.Controls.Add(this.searchTxt);
            this.hardwareMovementFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hardwareMovementFormContainer.Location = new System.Drawing.Point(0, 0);
            this.hardwareMovementFormContainer.Name = "hardwareMovementFormContainer";
            this.hardwareMovementFormContainer.Size = new System.Drawing.Size(640, 131);
            this.hardwareMovementFormContainer.TabIndex = 81;
            this.hardwareMovementFormContainer.Text = "Hardware movement";
            // 
            // statusComboBox
            // 
            this.statusComboBox.Location = new System.Drawing.Point(496, 68);
            this.statusComboBox.Name = "statusComboBox";
            this.statusComboBox.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.statusComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.statusComboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.statusComboBox.Size = new System.Drawing.Size(138, 22);
            this.statusComboBox.TabIndex = 107;
            // 
            // hardwareIdTxt
            // 
            this.hardwareIdTxt.Location = new System.Drawing.Point(105, 68);
            this.hardwareIdTxt.Name = "hardwareIdTxt";
            this.hardwareIdTxt.Size = new System.Drawing.Size(95, 22);
            this.hardwareIdTxt.TabIndex = 106;
            // 
            // addMovementBtn
            // 
            this.addMovementBtn.Location = new System.Drawing.Point(491, 96);
            this.addMovementBtn.Name = "addMovementBtn";
            this.addMovementBtn.Size = new System.Drawing.Size(137, 29);
            this.addMovementBtn.TabIndex = 105;
            this.addMovementBtn.Text = "AddMovement";
            this.addMovementBtn.Click += new System.EventHandler(this.addMovementBtn_Click);
            // 
            // userComboBox
            // 
            this.userComboBox.Location = new System.Drawing.Point(278, 68);
            this.userComboBox.Name = "userComboBox";
            this.userComboBox.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.userComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.userComboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.userComboBox.Size = new System.Drawing.Size(138, 22);
            this.userComboBox.TabIndex = 104;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(14, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(93, 17);
            this.label13.TabIndex = 102;
            this.label13.Text = "Hardware ID :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(219, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 17);
            this.label2.TabIndex = 97;
            this.label2.Text = "User :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(434, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(56, 17);
            this.label11.TabIndex = 100;
            this.label11.Text = "Status :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 37);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 17);
            this.label12.TabIndex = 63;
            this.label12.Text = "Search :";
            // 
            // searchTxt
            // 
            this.searchTxt.Location = new System.Drawing.Point(105, 34);
            this.searchTxt.Name = "searchTxt";
            this.searchTxt.Size = new System.Drawing.Size(296, 22);
            this.searchTxt.TabIndex = 65;
            this.searchTxt.EditValueChanged += new System.EventHandler(this.searchTxt_EditValueChanged);
            // 
            // movementMenu
            // 
            this.movementMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.movementMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.returnToolStripMenuItem});
            this.movementMenu.Name = "movementMenu";
            this.movementMenu.Size = new System.Drawing.Size(122, 28);
            // 
            // returnToolStripMenuItem
            // 
            this.returnToolStripMenuItem.Name = "returnToolStripMenuItem";
            this.returnToolStripMenuItem.Size = new System.Drawing.Size(121, 24);
            this.returnToolStripMenuItem.Text = "Return";
            this.returnToolStripMenuItem.Click += new System.EventHandler(this.returnToolStripMenuItem_Click);
            // 
            // hardwareMovement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(640, 453);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "hardwareMovement";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.hardwareMovement_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.movementGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hardwareMovementFormContainer)).EndInit();
            this.hardwareMovementFormContainer.ResumeLayout(false);
            this.hardwareMovementFormContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareIdTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchTxt.Properties)).EndInit();
            this.movementMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl movementGrid;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.TextEdit searchTxt;
        private DevExpress.XtraEditors.GroupControl hardwareMovementFormContainer;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.ComboBoxEdit userComboBox;
        private DevExpress.XtraEditors.SimpleButton addMovementBtn;
        private DevExpress.XtraEditors.TextEdit hardwareIdTxt;
        private DevExpress.XtraEditors.ComboBoxEdit statusComboBox;
        private System.Windows.Forms.ContextMenuStrip movementMenu;
        private System.Windows.Forms.ToolStripMenuItem returnToolStripMenuItem;
    }
}