namespace IT_Manager_ENCC.Forms.SQL
{
    partial class resetsResetPermitions
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.checkEdit1 = new DevExpress.XtraEditors.CheckEdit();
            this.DBList = new DevExpress.XtraEditors.CheckedListBoxControl();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBList)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.checkEdit1);
            this.groupControl1.Controls.Add(this.DBList);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(350, 301);
            this.groupControl1.TabIndex = 6;
            this.groupControl1.Text = "Reset permisions";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(5, 29);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Select all";
            this.checkEdit1.Size = new System.Drawing.Size(94, 20);
            this.checkEdit1.TabIndex = 85;
            // 
            // DBList
            // 
            this.DBList.Location = new System.Drawing.Point(5, 55);
            this.DBList.Name = "DBList";
            this.DBList.Size = new System.Drawing.Size(340, 201);
            this.DBList.TabIndex = 84;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(194, 262);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(151, 28);
            this.simpleButton2.TabIndex = 83;
            this.simpleButton2.Text = "Reset permisions";
            // 
            // resetsResetPermitions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(350, 301);
            this.Controls.Add(this.groupControl1);
            this.Name = "resetsResetPermitions";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DBList)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.CheckEdit checkEdit1;
        private DevExpress.XtraEditors.CheckedListBoxControl DBList;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
    }
}