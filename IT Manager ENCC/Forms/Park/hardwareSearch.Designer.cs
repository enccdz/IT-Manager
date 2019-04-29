namespace IT_Manager_ENCC.Forms.Park
{
    partial class hardwareSearch
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
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.hardwareGrid = new DevExpress.XtraGrid.GridControl();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.endDateBox = new DevExpress.XtraEditors.DateEdit();
            this.startDateBox = new DevExpress.XtraEditors.DateEdit();
            this.SearchTxt = new DevExpress.XtraEditors.TextEdit();
            this.label13 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimeChartRangeControlClient1 = new DevExpress.XtraEditors.DateTimeChartRangeControlClient();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endDateBox.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateBox.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateBox.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchTxt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView1
            // 
            this.gridView1.GridControl = this.hardwareGrid;
            this.gridView1.Name = "gridView1";
            // 
            // hardwareGrid
            // 
            this.hardwareGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.hardwareGrid.Location = new System.Drawing.Point(0, 0);
            this.hardwareGrid.MainView = this.gridView1;
            this.hardwareGrid.Name = "hardwareGrid";
            this.hardwareGrid.Size = new System.Drawing.Size(525, 351);
            this.hardwareGrid.TabIndex = 1;
            this.hardwareGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Horizontal = false;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.groupControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.hardwareGrid);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(525, 448);
            this.splitContainerControl1.SplitterPosition = 91;
            this.splitContainerControl1.TabIndex = 1;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.endDateBox);
            this.groupControl1.Controls.Add(this.startDateBox);
            this.groupControl1.Controls.Add(this.SearchTxt);
            this.groupControl1.Controls.Add(this.label13);
            this.groupControl1.Controls.Add(this.label2);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(525, 91);
            this.groupControl1.TabIndex = 82;
            this.groupControl1.Text = "Search hardware";
            // 
            // endDateBox
            // 
            this.endDateBox.EditValue = null;
            this.endDateBox.Location = new System.Drawing.Point(318, 60);
            this.endDateBox.Name = "endDateBox";
            this.endDateBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDateBox.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.endDateBox.Size = new System.Drawing.Size(192, 22);
            this.endDateBox.TabIndex = 75;
            this.endDateBox.EditValueChanged += new System.EventHandler(this.DateBox_EditValueChanged);
            // 
            // startDateBox
            // 
            this.startDateBox.EditValue = null;
            this.startDateBox.Location = new System.Drawing.Point(106, 60);
            this.startDateBox.Name = "startDateBox";
            this.startDateBox.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDateBox.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.startDateBox.Size = new System.Drawing.Size(192, 22);
            this.startDateBox.TabIndex = 74;
            this.startDateBox.EditValueChanged += new System.EventHandler(this.DateBox_EditValueChanged);
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(106, 32);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(404, 22);
            this.SearchTxt.TabIndex = 65;
            this.SearchTxt.EditValueChanged += new System.EventHandler(this.SearchTxt_EditValueChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 61);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(46, 17);
            this.label13.TabIndex = 73;
            this.label13.Text = "Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 17);
            this.label2.TabIndex = 64;
            this.label2.Text = "Search :";
            // 
            // hardwareSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(525, 448);
            this.Controls.Add(this.splitContainerControl1);
            this.Name = "hardwareSearch";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hardwareGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.endDateBox.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.endDateBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateBox.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.startDateBox.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SearchTxt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTimeChartRangeControlClient1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.GridControl hardwareGrid;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraEditors.TextEdit SearchTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label13;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.DateEdit endDateBox;
        private DevExpress.XtraEditors.DateEdit startDateBox;
        private DevExpress.XtraEditors.DateTimeChartRangeControlClient dateTimeChartRangeControlClient1;
    }
}