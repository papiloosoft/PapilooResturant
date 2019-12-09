namespace Laundry
{
    partial class FormReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormReports));
            this.PanelDate = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.dtEnd = new BPersianCalender.BPersianCalenderTextBox();
            this.btnReport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dtStart = new BPersianCalender.BPersianCalenderTextBox();
            this.dgSearch = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblTotallTakhfif = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lblTotalMande = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lblTotalResive = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.PanelUser = new System.Windows.Forms.Panel();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEshterak = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btnReportUser = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnWordExport = new System.Windows.Forms.Button();
            this.btnExcelExport = new System.Windows.Forms.Button();
            this.btnPdfExport = new System.Windows.Forms.Button();
            this.PanelDate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PanelUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelDate
            // 
            this.PanelDate.Controls.Add(this.label6);
            this.PanelDate.Controls.Add(this.dtEnd);
            this.PanelDate.Controls.Add(this.btnReport);
            this.PanelDate.Controls.Add(this.label1);
            this.PanelDate.Controls.Add(this.dtStart);
            this.PanelDate.Location = new System.Drawing.Point(281, 12);
            this.PanelDate.Name = "PanelDate";
            this.PanelDate.Size = new System.Drawing.Size(685, 47);
            this.PanelDate.TabIndex = 0;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(365, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 19);
            this.label6.TabIndex = 55;
            this.label6.Text = "تا تاریخ";
            // 
            // dtEnd
            // 
            this.dtEnd.BackColor = System.Drawing.Color.White;
            this.dtEnd.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtEnd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dtEnd.Location = new System.Drawing.Point(205, 10);
            this.dtEnd.Miladi = new System.DateTime(((long)(0)));
            this.dtEnd.Name = "dtEnd";
            this.dtEnd.NowDateSelected = false;
            this.dtEnd.ReadOnly = true;
            this.dtEnd.SelectedDate = null;
            this.dtEnd.Shamsi = null;
            this.dtEnd.Size = new System.Drawing.Size(154, 27);
            this.dtEnd.TabIndex = 54;
            this.dtEnd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnReport
            // 
            this.btnReport.Location = new System.Drawing.Point(13, 6);
            this.btnReport.Name = "btnReport";
            this.btnReport.Size = new System.Drawing.Size(105, 32);
            this.btnReport.TabIndex = 5;
            this.btnReport.Text = "گزارش";
            this.btnReport.UseVisualStyleBackColor = true;
            this.btnReport.Click += new System.EventHandler(this.btnReport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(621, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 53;
            this.label1.Text = "از تاریخ";
            // 
            // dtStart
            // 
            this.dtStart.BackColor = System.Drawing.Color.White;
            this.dtStart.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtStart.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dtStart.Location = new System.Drawing.Point(461, 10);
            this.dtStart.Miladi = new System.DateTime(((long)(0)));
            this.dtStart.Name = "dtStart";
            this.dtStart.NowDateSelected = false;
            this.dtStart.ReadOnly = true;
            this.dtStart.SelectedDate = null;
            this.dtStart.Shamsi = null;
            this.dtStart.Size = new System.Drawing.Size(154, 27);
            this.dtStart.TabIndex = 3;
            this.dtStart.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // dgSearch
            // 
            this.dgSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSearch.Location = new System.Drawing.Point(5, 65);
            this.dgSearch.Name = "dgSearch";
            this.dgSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgSearch.Size = new System.Drawing.Size(945, 501);
            this.dgSearch.TabIndex = 23;
            this.dgSearch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSearch_CellDoubleClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.dgSearch);
            this.panel1.Location = new System.Drawing.Point(12, 65);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(954, 569);
            this.panel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblTotallTakhfif);
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.lblTotalMande);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.lblTotalResive);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.lblTotalPrice);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Location = new System.Drawing.Point(5, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(945, 56);
            this.panel2.TabIndex = 25;
            // 
            // lblTotallTakhfif
            // 
            this.lblTotallTakhfif.AutoSize = true;
            this.lblTotallTakhfif.Location = new System.Drawing.Point(53, 17);
            this.lblTotallTakhfif.Name = "lblTotallTakhfif";
            this.lblTotallTakhfif.Size = new System.Drawing.Size(18, 19);
            this.lblTotallTakhfif.TabIndex = 64;
            this.lblTotallTakhfif.Text = "0";
            this.lblTotallTakhfif.TextChanged += new System.EventHandler(this.lblTotallTakhfif_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(168, 17);
            this.label9.Name = "label9";
            this.label9.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label9.Size = new System.Drawing.Size(84, 19);
            this.label9.TabIndex = 63;
            this.label9.Text = "کل تخفیف:";
            // 
            // lblTotalMande
            // 
            this.lblTotalMande.AutoSize = true;
            this.lblTotalMande.Location = new System.Drawing.Point(269, 17);
            this.lblTotalMande.Name = "lblTotalMande";
            this.lblTotalMande.Size = new System.Drawing.Size(18, 19);
            this.lblTotalMande.TabIndex = 62;
            this.lblTotalMande.Text = "0";
            this.lblTotalMande.TextChanged += new System.EventHandler(this.lblTotalMande_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(412, 17);
            this.label7.Name = "label7";
            this.label7.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label7.Size = new System.Drawing.Size(74, 19);
            this.label7.TabIndex = 61;
            this.label7.Text = "کل مانده:";
            // 
            // lblTotalResive
            // 
            this.lblTotalResive.AutoSize = true;
            this.lblTotalResive.Location = new System.Drawing.Point(509, 17);
            this.lblTotalResive.Name = "lblTotalResive";
            this.lblTotalResive.Size = new System.Drawing.Size(18, 19);
            this.lblTotalResive.TabIndex = 58;
            this.lblTotalResive.Text = "0";
            this.lblTotalResive.TextChanged += new System.EventHandler(this.lblTotalResive_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(640, 17);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(91, 19);
            this.label4.TabIndex = 57;
            this.label4.Text = "کل دریافتی:";
            // 
            // lblTotalPrice
            // 
            this.lblTotalPrice.AutoSize = true;
            this.lblTotalPrice.Location = new System.Drawing.Point(750, 17);
            this.lblTotalPrice.Name = "lblTotalPrice";
            this.lblTotalPrice.Size = new System.Drawing.Size(18, 19);
            this.lblTotalPrice.TabIndex = 56;
            this.lblTotalPrice.Text = "0";
            this.lblTotalPrice.TextChanged += new System.EventHandler(this.lblTotalPrice_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(862, 17);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(81, 19);
            this.label3.TabIndex = 55;
            this.label3.Text = "کل کارکرد:";
            // 
            // PanelUser
            // 
            this.PanelUser.Controls.Add(this.txtPhone);
            this.PanelUser.Controls.Add(this.txtEshterak);
            this.PanelUser.Controls.Add(this.label5);
            this.PanelUser.Controls.Add(this.btnReportUser);
            this.PanelUser.Controls.Add(this.label2);
            this.PanelUser.Location = new System.Drawing.Point(280, 12);
            this.PanelUser.Name = "PanelUser";
            this.PanelUser.Size = new System.Drawing.Size(685, 47);
            this.PanelUser.TabIndex = 26;
            // 
            // txtPhone
            // 
            this.txtPhone.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPhone.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPhone.Location = new System.Drawing.Point(165, 10);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(165, 27);
            this.txtPhone.TabIndex = 59;
            this.txtPhone.TextChanged += new System.EventHandler(this.txtPhone_TextChanged);
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtEshterak
            // 
            this.txtEshterak.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtEshterak.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtEshterak.Location = new System.Drawing.Point(439, 10);
            this.txtEshterak.MaxLength = 5;
            this.txtEshterak.Name = "txtEshterak";
            this.txtEshterak.Size = new System.Drawing.Size(147, 27);
            this.txtEshterak.TabIndex = 58;
            this.txtEshterak.TextChanged += new System.EventHandler(this.txtEshterak_TextChanged);
            this.txtEshterak.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEshterak_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(336, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 19);
            this.label5.TabIndex = 57;
            this.label5.Text = "شماره تماس";
            // 
            // btnReportUser
            // 
            this.btnReportUser.Location = new System.Drawing.Point(13, 6);
            this.btnReportUser.Name = "btnReportUser";
            this.btnReportUser.Size = new System.Drawing.Size(105, 32);
            this.btnReportUser.TabIndex = 2;
            this.btnReportUser.Text = "گزارش";
            this.btnReportUser.UseVisualStyleBackColor = true;
            this.btnReportUser.Click += new System.EventHandler(this.btnReportUser_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(592, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 19);
            this.label2.TabIndex = 53;
            this.label2.Text = "کد اشتراک";
            // 
            // btnWordExport
            // 
            this.btnWordExport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnWordExport.Image = ((System.Drawing.Image)(resources.GetObject("btnWordExport.Image")));
            this.btnWordExport.Location = new System.Drawing.Point(80, 5);
            this.btnWordExport.Name = "btnWordExport";
            this.btnWordExport.Size = new System.Drawing.Size(58, 58);
            this.btnWordExport.TabIndex = 28;
            this.btnWordExport.UseVisualStyleBackColor = false;
            this.btnWordExport.Click += new System.EventHandler(this.btnWordExport_Click);
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcelExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelExport.Image")));
            this.btnExcelExport.Location = new System.Drawing.Point(16, 5);
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Size = new System.Drawing.Size(58, 58);
            this.btnExcelExport.TabIndex = 29;
            this.btnExcelExport.UseVisualStyleBackColor = false;
            this.btnExcelExport.Click += new System.EventHandler(this.btnExcelExport_Click);
            // 
            // btnPdfExport
            // 
            this.btnPdfExport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPdfExport.Image = ((System.Drawing.Image)(resources.GetObject("btnPdfExport.Image")));
            this.btnPdfExport.Location = new System.Drawing.Point(144, 5);
            this.btnPdfExport.Name = "btnPdfExport";
            this.btnPdfExport.Size = new System.Drawing.Size(58, 58);
            this.btnPdfExport.TabIndex = 30;
            this.btnPdfExport.UseVisualStyleBackColor = false;
            this.btnPdfExport.Click += new System.EventHandler(this.btnPdfExport_Click);
            // 
            // FormReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(977, 646);
            this.Controls.Add(this.btnPdfExport);
            this.Controls.Add(this.btnExcelExport);
            this.Controls.Add(this.PanelDate);
            this.Controls.Add(this.btnWordExport);
            this.Controls.Add(this.PanelUser);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(993, 685);
            this.MinimumSize = new System.Drawing.Size(993, 685);
            this.Name = "FormReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "گزارش";
            this.Load += new System.EventHandler(this.FormReports_Load);
            this.PanelDate.ResumeLayout(false);
            this.PanelDate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PanelUser.ResumeLayout(false);
            this.PanelUser.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnReport;
        private System.Windows.Forms.Label label1;
        public BPersianCalender.BPersianCalenderTextBox dtStart;
        public System.Windows.Forms.Panel PanelDate;
        private System.Windows.Forms.DataGridView dgSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblTotalMande;
        private System.Windows.Forms.Label lblTotalResive;
        private System.Windows.Forms.Label lblTotalPrice;
        public System.Windows.Forms.Panel PanelUser;
        private System.Windows.Forms.Button btnReportUser;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        public BPersianCalender.BPersianCalenderTextBox dtEnd;
        private System.Windows.Forms.Label lblTotallTakhfif;
        public System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnWordExport;
        private System.Windows.Forms.Button btnExcelExport;
        private System.Windows.Forms.Button btnPdfExport;
        public System.Windows.Forms.TextBox txtEshterak;
        public System.Windows.Forms.TextBox txtPhone;
    }
}