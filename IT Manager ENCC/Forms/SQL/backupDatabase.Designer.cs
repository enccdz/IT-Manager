﻿namespace IT_Manager_ENCC.Forms.SQL
{
    partial class backupDatabase
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
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
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
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(354, 302);
            this.groupControl1.TabIndex = 3;
            this.groupControl1.Text = "Backup database";
            // 
            // checkEdit1
            // 
            this.checkEdit1.Location = new System.Drawing.Point(5, 27);
            this.checkEdit1.Name = "checkEdit1";
            this.checkEdit1.Properties.Caption = "Select all";
            this.checkEdit1.Size = new System.Drawing.Size(94, 20);
            this.checkEdit1.TabIndex = 79;
            // 
            // DBList
            // 
            this.DBList.Location = new System.Drawing.Point(5, 53);
            this.DBList.Name = "DBList";
            this.DBList.Size = new System.Drawing.Size(340, 201);
            this.DBList.TabIndex = 78;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Location = new System.Drawing.Point(251, 260);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(94, 28);
            this.simpleButton1.TabIndex = 77;
            this.simpleButton1.Text = "Backup";
            // 
            // backupDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 302);
            this.Controls.Add(this.groupControl1);
            this.Name = "backupDatabase";
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
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
    }
}