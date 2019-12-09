namespace Laundry
{
    partial class FormSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearch));
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.comSearch = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dtSearch = new BPersianCalender.BPersianCalenderTextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.dgSearch = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPdfExport = new System.Windows.Forms.Button();
            this.btnExcelExport = new System.Windows.Forms.Button();
            this.btnWordExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(231, 20);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(78, 31);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "جستجو";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(698, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 19);
            this.label1.TabIndex = 1;
            this.label1.Text = "جستجو ";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(316, 23);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(154, 27);
            this.txtSearch.TabIndex = 2;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // comSearch
            // 
            this.comSearch.FormattingEnabled = true;
            this.comSearch.Items.AddRange(new object[] {
            "اشتراک",
            "تاریخ  سرویس",
            "شماره تماس",
            "تاریخ ورود",
            "کد رهگیری",
            "نام و نام خانوادگی"});
            this.comSearch.Location = new System.Drawing.Point(528, 23);
            this.comSearch.Name = "comSearch";
            this.comSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comSearch.Size = new System.Drawing.Size(164, 27);
            this.comSearch.TabIndex = 1;
            this.comSearch.SelectedIndexChanged += new System.EventHandler(this.comSearch_SelectedIndexChanged);
            this.comSearch.TabIndexChanged += new System.EventHandler(this.comSearch_TabIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(475, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "مقدار";
            // 
            // dtSearch
            // 
            this.dtSearch.BackColor = System.Drawing.Color.White;
            this.dtSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSearch.ForeColor = System.Drawing.SystemColors.WindowText;
            this.dtSearch.Location = new System.Drawing.Point(316, 23);
            this.dtSearch.Miladi = new System.DateTime(((long)(0)));
            this.dtSearch.Name = "dtSearch";
            this.dtSearch.NowDateSelected = false;
            this.dtSearch.ReadOnly = true;
            this.dtSearch.SelectedDate = null;
            this.dtSearch.Shamsi = null;
            this.dtSearch.Size = new System.Drawing.Size(153, 27);
            this.dtSearch.TabIndex = 2;
            this.dtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.dtSearch.TextChanged += new System.EventHandler(this.dtSearch_TextChanged);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(358, 522);
            this.lblError.Name = "lblError";
            this.lblError.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblError.Size = new System.Drawing.Size(0, 19);
            this.lblError.TabIndex = 28;
            // 
            // dgSearch
            // 
            this.dgSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSearch.Location = new System.Drawing.Point(6, 3);
            this.dgSearch.Name = "dgSearch";
            this.dgSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgSearch.Size = new System.Drawing.Size(742, 430);
            this.dgSearch.TabIndex = 22;
            this.dgSearch.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSearch_CellContentClick);
            this.dgSearch.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSearch_CellDoubleClick);
            this.dgSearch.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSearch_CellEnter);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgSearch);
            this.panel1.Location = new System.Drawing.Point(12, 70);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(752, 436);
            this.panel1.TabIndex = 29;
            // 
            // btnPdfExport
            // 
            this.btnPdfExport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnPdfExport.Image = ((System.Drawing.Image)(resources.GetObject("btnPdfExport.Image")));
            this.btnPdfExport.Location = new System.Drawing.Point(146, 6);
            this.btnPdfExport.Name = "btnPdfExport";
            this.btnPdfExport.Size = new System.Drawing.Size(58, 58);
            this.btnPdfExport.TabIndex = 33;
            this.btnPdfExport.UseVisualStyleBackColor = false;
            this.btnPdfExport.Click += new System.EventHandler(this.btnPdfExport_Click);
            // 
            // btnExcelExport
            // 
            this.btnExcelExport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcelExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExcelExport.Image")));
            this.btnExcelExport.Location = new System.Drawing.Point(18, 6);
            this.btnExcelExport.Name = "btnExcelExport";
            this.btnExcelExport.Size = new System.Drawing.Size(58, 58);
            this.btnExcelExport.TabIndex = 32;
            this.btnExcelExport.UseVisualStyleBackColor = false;
            this.btnExcelExport.Click += new System.EventHandler(this.btnExcelExport_Click);
            // 
            // btnWordExport
            // 
            this.btnWordExport.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnWordExport.Image = ((System.Drawing.Image)(resources.GetObject("btnWordExport.Image")));
            this.btnWordExport.Location = new System.Drawing.Point(82, 6);
            this.btnWordExport.Name = "btnWordExport";
            this.btnWordExport.Size = new System.Drawing.Size(58, 58);
            this.btnWordExport.TabIndex = 31;
            this.btnWordExport.UseVisualStyleBackColor = false;
            this.btnWordExport.Click += new System.EventHandler(this.btnWordExport_Click);
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 551);
            this.Controls.Add(this.btnPdfExport);
            this.Controls.Add(this.btnExcelExport);
            this.Controls.Add(this.btnWordExport);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.dtSearch);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comSearch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSearch);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(788, 590);
            this.MinimumSize = new System.Drawing.Size(788, 590);
            this.Name = "FormSearch";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "جستجو";
            this.Load += new System.EventHandler(this.FormSearch_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.ComboBox comSearch;
        private System.Windows.Forms.Label label2;
        private BPersianCalender.BPersianCalenderTextBox dtSearch;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DataGridView dgSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPdfExport;
        private System.Windows.Forms.Button btnExcelExport;
        private System.Windows.Forms.Button btnWordExport;
    }
}