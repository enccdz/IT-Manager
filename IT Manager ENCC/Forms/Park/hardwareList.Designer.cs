namespace IT_Manager_ENCC.Forms
{
    partial class hardwareList
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
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.hardwareFormContainer = new DevExpress.XtraEditors.GroupControl();
            this.officeTxt = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.serialTxt = new DevExpress.XtraEditors.TextEdit();
            this.descriptionTxt = new DevExpress.XtraEditors.TextEdit();
            this.label13 = new System.Windows.Forms.Label();
            this.typeComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.manufacturerTxt = new DevExpress.XtraEditors.TextEdit();
            this.modelTxt = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.inventoryCodeTxt = new DevExpress.XtraEditors.TextEdit();
            this.stateComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.editBtn = new DevExpress.XtraEditors.SimpleButton();
            this.hardwareGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.hardwaresMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareFormContainer)).BeginInit();
            this.hardwareFormContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryCodeTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.hardwaresMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.hardwareFormContainer);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.hardwareGrid);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(737, 439);
            this.splitContainerControl1.SplitterPosition = 189;
            this.splitContainerControl1.TabIndex = 0;
            // 
            // hardwareFormContainer
            // 
            this.hardwareFormContainer.Controls.Add(this.officeTxt);
            this.hardwareFormContainer.Controls.Add(this.label1);
            this.hardwareFormContainer.Controls.Add(this.serialTxt);
            this.hardwareFormContainer.Controls.Add(this.descriptionTxt);
            this.hardwareFormContainer.Controls.Add(this.label13);
            this.hardwareFormContainer.Controls.Add(this.typeComboBox);
            this.hardwareFormContainer.Controls.Add(this.manufacturerTxt);
            this.hardwareFormContainer.Controls.Add(this.modelTxt);
            this.hardwareFormContainer.Controls.Add(this.label6);
            this.hardwareFormContainer.Controls.Add(this.label2);
            this.hardwareFormContainer.Controls.Add(this.label8);
            this.hardwareFormContainer.Controls.Add(this.label9);
            this.hardwareFormContainer.Controls.Add(this.label11);
            this.hardwareFormContainer.Controls.Add(this.label12);
            this.hardwareFormContainer.Controls.Add(this.inventoryCodeTxt);
            this.hardwareFormContainer.Controls.Add(this.stateComboBox);
            this.hardwareFormContainer.Controls.Add(this.editBtn);
            this.hardwareFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hardwareFormContainer.Location = new System.Drawing.Point(0, 0);
            this.hardwareFormContainer.Name = "hardwareFormContainer";
            this.hardwareFormContainer.Size = new System.Drawing.Size(737, 189);
            this.hardwareFormContainer.TabIndex = 2;
            this.hardwareFormContainer.Text = "Hardware list";
            // 
            // officeTxt
            // 
            this.officeTxt.Location = new System.Drawing.Point(508, 66);
            this.officeTxt.Name = "officeTxt";
            this.officeTxt.Size = new System.Drawing.Size(204, 22);
            this.officeTxt.TabIndex = 95;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 123);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 93;
            this.label1.Text = "Serial number :";
            // 
            // serialTxt
            // 
            this.serialTxt.Location = new System.Drawing.Point(508, 120);
            this.serialTxt.Name = "serialTxt";
            this.serialTxt.Size = new System.Drawing.Size(201, 22);
            this.serialTxt.TabIndex = 94;
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(136, 124);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(201, 22);
            this.descriptionTxt.TabIndex = 92;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 17);
            this.label13.TabIndex = 91;
            this.label13.Text = "Hardware Type :";
            // 
            // typeComboBox
            // 
            this.typeComboBox.Location = new System.Drawing.Point(136, 38);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.typeComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.typeComboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.typeComboBox.Size = new System.Drawing.Size(201, 22);
            this.typeComboBox.TabIndex = 2;
            // 
            // manufacturerTxt
            // 
            this.manufacturerTxt.Location = new System.Drawing.Point(136, 66);
            this.manufacturerTxt.Name = "manufacturerTxt";
            this.manufacturerTxt.Size = new System.Drawing.Size(201, 22);
            this.manufacturerTxt.TabIndex = 65;
            // 
            // modelTxt
            // 
            this.modelTxt.Location = new System.Drawing.Point(136, 96);
            this.modelTxt.Name = "modelTxt";
            this.modelTxt.Size = new System.Drawing.Size(201, 22);
            this.modelTxt.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 62;
            this.label6.Text = "Model :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(98, 17);
            this.label2.TabIndex = 64;
            this.label2.Text = "Manufacturer :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(364, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 74;
            this.label8.Text = "State :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(5, 125);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 17);
            this.label9.TabIndex = 75;
            this.label9.Text = "Description :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(361, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 17);
            this.label11.TabIndex = 77;
            this.label11.Text = "Office :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(363, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 17);
            this.label12.TabIndex = 78;
            this.label12.Text = "InventoryCode :";
            // 
            // inventoryCodeTxt
            // 
            this.inventoryCodeTxt.Location = new System.Drawing.Point(508, 94);
            this.inventoryCodeTxt.Name = "inventoryCodeTxt";
            this.inventoryCodeTxt.Size = new System.Drawing.Size(204, 22);
            this.inventoryCodeTxt.TabIndex = 84;
            // 
            // stateComboBox
            // 
            this.stateComboBox.Location = new System.Drawing.Point(508, 36);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.stateComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.stateComboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.stateComboBox.Size = new System.Drawing.Size(204, 22);
            this.stateComboBox.TabIndex = 87;
            // 
            // editBtn
            // 
            this.editBtn.Location = new System.Drawing.Point(601, 155);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(111, 25);
            this.editBtn.TabIndex = 68;
            this.editBtn.Text = "Edit user";
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // hardwareGrid
            // 
            this.hardwareGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hardwareGrid.Location = new System.Drawing.Point(0, 0);
            this.hardwareGrid.MainView = this.gridView1;
            this.hardwareGrid.Name = "hardwareGrid";
            this.hardwareGrid.Size = new System.Drawing.Size(737, 244);
            this.hardwareGrid.TabIndex = 1;
            this.hardwareGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.hardwareGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            this.gridView1.LostFocus += new System.EventHandler(this.gridView1_LostFocus);
            // 
            // hardwaresMenu
            // 
            this.hardwaresMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.hardwaresMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editToolStripMenuItem,
            this.deleateToolStripMenuItem});
            this.hardwaresMenu.Name = "hardwaresMenu";
            this.hardwaresMenu.Size = new System.Drawing.Size(131, 52);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.editToolStripMenuItem.Text = "Edit";
            this.editToolStripMenuItem.Click += new System.EventHandler(this.editToolStripMenuItem_Click);
            // 
            // deleateToolStripMenuItem
            // 
            this.deleateToolStripMenuItem.Name = "deleateToolStripMenuItem";
            this.deleateToolStripMenuItem.Size = new System.Drawing.Size(130, 24);
            this.deleateToolStripMenuItem.Text = "Deleate";
            this.deleateToolStripMenuItem.Click += new System.EventHandler(this.deleateToolStripMenuItem_Click);
            // 
            // hardwareList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 439);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "hardwareList";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.hardwareFormContainer)).EndInit();
            this.hardwareFormContainer.ResumeLayout(false);
            this.hardwareFormContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.officeTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryCodeTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stateComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.hardwaresMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraGrid.GridControl hardwareGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.ContextMenuStrip hardwaresMenu;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deleateToolStripMenuItem;
        private DevExpress.XtraEditors.GroupControl hardwareFormContainer;
        private DevExpress.XtraEditors.TextEdit officeTxt;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit serialTxt;
        private DevExpress.XtraEditors.TextEdit descriptionTxt;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.ComboBoxEdit typeComboBox;
        private DevExpress.XtraEditors.TextEdit manufacturerTxt;
        private DevExpress.XtraEditors.TextEdit modelTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.TextEdit inventoryCodeTxt;
        private DevExpress.XtraEditors.ComboBoxEdit stateComboBox;
        private DevExpress.XtraEditors.SimpleButton editBtn;
    }
}