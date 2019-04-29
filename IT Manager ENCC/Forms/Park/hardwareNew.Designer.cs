namespace IT_Manager_ENCC.Forms
{
    partial class hardwareNew
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.stateComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.inventoryCodeTxt = new DevExpress.XtraEditors.TextEdit();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.modelTxt = new DevExpress.XtraEditors.TextEdit();
            this.manufacturerTxt = new DevExpress.XtraEditors.TextEdit();
            this.typeComboBox = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label13 = new System.Windows.Forms.Label();
            this.descriptionTxt = new DevExpress.XtraEditors.TextEdit();
            this.serialTxt = new DevExpress.XtraEditors.TextEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.officeTxt = new DevExpress.XtraEditors.TextEdit();
            this.addhardwareFormContainer = new DevExpress.XtraEditors.GroupControl();
            ((System.ComponentModel.ISupportInitialize)(this.stateComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryCodeTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeComboBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addhardwareFormContainer)).BeginInit();
            this.addhardwareFormContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(601, 172);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(111, 25);
            this.simpleButton1.TabIndex = 68;
            this.simpleButton1.Text = "Add user";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // stateComboBox
            // 
            this.stateComboBox.Location = new System.Drawing.Point(508, 38);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.stateComboBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.stateComboBox.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.stateComboBox.Size = new System.Drawing.Size(204, 22);
            this.stateComboBox.TabIndex = 87;
            // 
            // inventoryCodeTxt
            // 
            this.inventoryCodeTxt.Location = new System.Drawing.Point(508, 94);
            this.inventoryCodeTxt.Name = "inventoryCodeTxt";
            this.inventoryCodeTxt.Size = new System.Drawing.Size(204, 22);
            this.inventoryCodeTxt.TabIndex = 84;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(364, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(110, 17);
            this.label12.TabIndex = 78;
            this.label12.Text = "InventoryCode :";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(362, 69);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 17);
            this.label11.TabIndex = 77;
            this.label11.Text = "Office :";
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
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(364, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 17);
            this.label8.TabIndex = 74;
            this.label8.Text = "State :";
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(5, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 62;
            this.label6.Text = "Model :";
            // 
            // modelTxt
            // 
            this.modelTxt.Location = new System.Drawing.Point(136, 94);
            this.modelTxt.Name = "modelTxt";
            this.modelTxt.Size = new System.Drawing.Size(201, 22);
            this.modelTxt.TabIndex = 66;
            // 
            // manufacturerTxt
            // 
            this.manufacturerTxt.Location = new System.Drawing.Point(136, 66);
            this.manufacturerTxt.Name = "manufacturerTxt";
            this.manufacturerTxt.Size = new System.Drawing.Size(201, 22);
            this.manufacturerTxt.TabIndex = 65;
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(110, 17);
            this.label13.TabIndex = 91;
            this.label13.Text = "Hardware Type :";
            // 
            // descriptionTxt
            // 
            this.descriptionTxt.Location = new System.Drawing.Point(136, 124);
            this.descriptionTxt.Name = "descriptionTxt";
            this.descriptionTxt.Size = new System.Drawing.Size(201, 22);
            this.descriptionTxt.TabIndex = 92;
            // 
            // serialTxt
            // 
            this.serialTxt.Location = new System.Drawing.Point(508, 122);
            this.serialTxt.Name = "serialTxt";
            this.serialTxt.Size = new System.Drawing.Size(204, 22);
            this.serialTxt.TabIndex = 94;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 17);
            this.label1.TabIndex = 93;
            this.label1.Text = "Serial number :";
            // 
            // officeTxt
            // 
            this.officeTxt.Location = new System.Drawing.Point(509, 66);
            this.officeTxt.Name = "officeTxt";
            this.officeTxt.Size = new System.Drawing.Size(204, 22);
            this.officeTxt.TabIndex = 95;
            // 
            // addhardwareFormContainer
            // 
            this.addhardwareFormContainer.Controls.Add(this.officeTxt);
            this.addhardwareFormContainer.Controls.Add(this.label1);
            this.addhardwareFormContainer.Controls.Add(this.serialTxt);
            this.addhardwareFormContainer.Controls.Add(this.descriptionTxt);
            this.addhardwareFormContainer.Controls.Add(this.label13);
            this.addhardwareFormContainer.Controls.Add(this.typeComboBox);
            this.addhardwareFormContainer.Controls.Add(this.manufacturerTxt);
            this.addhardwareFormContainer.Controls.Add(this.modelTxt);
            this.addhardwareFormContainer.Controls.Add(this.label6);
            this.addhardwareFormContainer.Controls.Add(this.label2);
            this.addhardwareFormContainer.Controls.Add(this.label8);
            this.addhardwareFormContainer.Controls.Add(this.label9);
            this.addhardwareFormContainer.Controls.Add(this.label11);
            this.addhardwareFormContainer.Controls.Add(this.label12);
            this.addhardwareFormContainer.Controls.Add(this.inventoryCodeTxt);
            this.addhardwareFormContainer.Controls.Add(this.stateComboBox);
            this.addhardwareFormContainer.Controls.Add(this.simpleButton1);
            this.addhardwareFormContainer.Location = new System.Drawing.Point(12, 12);
            this.addhardwareFormContainer.Name = "addhardwareFormContainer";
            this.addhardwareFormContainer.Size = new System.Drawing.Size(718, 205);
            this.addhardwareFormContainer.TabIndex = 1;
            this.addhardwareFormContainer.Text = "Add a new Hardware";
            // 
            // hardwareNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 226);
            this.Controls.Add(this.addhardwareFormContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "hardwareNew";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.stateComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventoryCodeTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.modelTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.manufacturerTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.typeComboBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.serialTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.officeTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addhardwareFormContainer)).EndInit();
            this.addhardwareFormContainer.ResumeLayout(false);
            this.addhardwareFormContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.ComboBoxEdit stateComboBox;
        private DevExpress.XtraEditors.TextEdit inventoryCodeTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.TextEdit modelTxt;
        private DevExpress.XtraEditors.TextEdit manufacturerTxt;
        private DevExpress.XtraEditors.ComboBoxEdit typeComboBox;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.TextEdit descriptionTxt;
        private DevExpress.XtraEditors.TextEdit serialTxt;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.TextEdit officeTxt;
        private DevExpress.XtraEditors.GroupControl addhardwareFormContainer;
    }
}