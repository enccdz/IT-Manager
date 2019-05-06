namespace IT_Manager_ENCC.Forms.Pass
{
    partial class externalEmailAdd
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
            this.hardwareFormContainer = new DevExpress.XtraEditors.GroupControl();
            this.generatePasswordBtn = new DevExpress.XtraEditors.SimpleButton();
            this.emailTxt = new DevExpress.XtraEditors.TextEdit();
            this.passwordTxt = new DevExpress.XtraEditors.TextEdit();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.confirmBtn = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareFormContainer)).BeginInit();
            this.hardwareFormContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTxt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // hardwareFormContainer
            // 
            this.hardwareFormContainer.Controls.Add(this.generatePasswordBtn);
            this.hardwareFormContainer.Controls.Add(this.emailTxt);
            this.hardwareFormContainer.Controls.Add(this.passwordTxt);
            this.hardwareFormContainer.Controls.Add(this.label6);
            this.hardwareFormContainer.Controls.Add(this.label2);
            this.hardwareFormContainer.Controls.Add(this.confirmBtn);
            this.hardwareFormContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hardwareFormContainer.Location = new System.Drawing.Point(0, 0);
            this.hardwareFormContainer.Name = "hardwareFormContainer";
            this.hardwareFormContainer.Size = new System.Drawing.Size(404, 141);
            this.hardwareFormContainer.TabIndex = 3;
            this.hardwareFormContainer.Text = "Add external email ";
            // 
            // generatePasswordBtn
            // 
            this.generatePasswordBtn.Location = new System.Drawing.Point(324, 69);
            this.generatePasswordBtn.Name = "generatePasswordBtn";
            this.generatePasswordBtn.Size = new System.Drawing.Size(68, 25);
            this.generatePasswordBtn.TabIndex = 69;
            this.generatePasswordBtn.Text = "Generate";
            this.generatePasswordBtn.Click += new System.EventHandler(this.generatePasswordBtn_Click);
            // 
            // emailTxt
            // 
            this.emailTxt.Location = new System.Drawing.Point(87, 39);
            this.emailTxt.Name = "emailTxt";
            this.emailTxt.Size = new System.Drawing.Size(305, 22);
            this.emailTxt.TabIndex = 65;
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(87, 72);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(231, 22);
            this.passwordTxt.TabIndex = 66;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 62;
            this.label6.Text = "Password :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 17);
            this.label2.TabIndex = 64;
            this.label2.Text = "Email :";
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(281, 100);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(111, 25);
            this.confirmBtn.TabIndex = 68;
            this.confirmBtn.Text = "Add Email";
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // externalEmailAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 141);
            this.Controls.Add(this.hardwareFormContainer);
            this.Name = "externalEmailAdd";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.hardwareFormContainer)).EndInit();
            this.hardwareFormContainer.ResumeLayout(false);
            this.hardwareFormContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.emailTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.passwordTxt.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl hardwareFormContainer;
        private DevExpress.XtraEditors.TextEdit emailTxt;
        private DevExpress.XtraEditors.TextEdit passwordTxt;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.SimpleButton confirmBtn;
        private DevExpress.XtraEditors.SimpleButton generatePasswordBtn;
    }
}