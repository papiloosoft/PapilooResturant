namespace Laundry
{
    partial class FormMange
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMange));
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtConfrimPasword = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.comAccess = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.dgManage = new System.Windows.Forms.DataGridView();
            this.btnExit = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chxSetting = new System.Windows.Forms.CheckBox();
            this.chxBackup = new System.Windows.Forms.CheckBox();
            this.chxReport = new System.Windows.Forms.CheckBox();
            this.chxSms = new System.Windows.Forms.CheckBox();
            this.chxSearch = new System.Windows.Forms.CheckBox();
            this.chxTools = new System.Windows.Forms.CheckBox();
            this.chxNewService = new System.Windows.Forms.CheckBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgManage)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(384, 21);
            this.txtUsername.Margin = new System.Windows.Forms.Padding(4);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(172, 27);
            this.txtUsername.TabIndex = 0;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(384, 69);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(172, 27);
            this.txtPassword.TabIndex = 1;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // txtConfrimPasword
            // 
            this.txtConfrimPasword.Location = new System.Drawing.Point(384, 122);
            this.txtConfrimPasword.Margin = new System.Windows.Forms.Padding(4);
            this.txtConfrimPasword.Name = "txtConfrimPasword";
            this.txtConfrimPasword.Size = new System.Drawing.Size(172, 27);
            this.txtConfrimPasword.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(21, 354);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 43);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "ثبت";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // comAccess
            // 
            this.comAccess.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comAccess.FormattingEnabled = true;
            this.comAccess.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.comAccess.Items.AddRange(new object[] {
            "کامل",
            "محدود"});
            this.comAccess.Location = new System.Drawing.Point(384, 179);
            this.comAccess.Name = "comAccess";
            this.comAccess.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.comAccess.Size = new System.Drawing.Size(172, 27);
            this.comAccess.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(585, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "نام کاربری جدید";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(624, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 19);
            this.label2.TabIndex = 7;
            this.label2.Text = "کلمه عبور";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(589, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 19);
            this.label3.TabIndex = 8;
            this.label3.Text = "تکرار کلمه عبور";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(582, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(118, 19);
            this.label4.TabIndex = 9;
            this.label4.Text = "میزان دسترسی";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(321, 354);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(94, 43);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(121, 354);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(94, 43);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "ویرایش";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(563, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(136, 19);
            this.label5.TabIndex = 13;
            this.label5.Text = "نام کاربری مورد نظر";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(516, 369);
            this.lblError.Name = "lblError";
            this.lblError.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblError.Size = new System.Drawing.Size(0, 13);
            this.lblError.TabIndex = 24;
            // 
            // dgManage
            // 
            this.dgManage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgManage.Location = new System.Drawing.Point(12, 21);
            this.dgManage.Name = "dgManage";
            this.dgManage.Size = new System.Drawing.Size(349, 185);
            this.dgManage.TabIndex = 25;
            this.dgManage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgManage_CellClick);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(221, 354);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(94, 43);
            this.btnExit.TabIndex = 8;
            this.btnExit.Text = "انصراف";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.chxSetting);
            this.groupBox1.Controls.Add(this.chxBackup);
            this.groupBox1.Controls.Add(this.chxReport);
            this.groupBox1.Controls.Add(this.chxSms);
            this.groupBox1.Controls.Add(this.chxSearch);
            this.groupBox1.Controls.Add(this.chxTools);
            this.groupBox1.Controls.Add(this.chxNewService);
            this.groupBox1.Location = new System.Drawing.Point(21, 231);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(678, 113);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "دسترسی ها";
            // 
            // chxSetting
            // 
            this.chxSetting.AutoSize = true;
            this.chxSetting.Location = new System.Drawing.Point(189, 75);
            this.chxSetting.Name = "chxSetting";
            this.chxSetting.Size = new System.Drawing.Size(83, 23);
            this.chxSetting.TabIndex = 31;
            this.chxSetting.Text = "تنظیمات";
            this.chxSetting.UseVisualStyleBackColor = true;
            // 
            // chxBackup
            // 
            this.chxBackup.AutoSize = true;
            this.chxBackup.Location = new System.Drawing.Point(348, 75);
            this.chxBackup.Name = "chxBackup";
            this.chxBackup.Size = new System.Drawing.Size(116, 23);
            this.chxBackup.TabIndex = 30;
            this.chxBackup.Text = "فایل پشتیبان";
            this.chxBackup.UseVisualStyleBackColor = true;
            // 
            // chxReport
            // 
            this.chxReport.AutoSize = true;
            this.chxReport.Location = new System.Drawing.Point(565, 75);
            this.chxReport.Name = "chxReport";
            this.chxReport.Size = new System.Drawing.Size(93, 23);
            this.chxReport.TabIndex = 29;
            this.chxReport.Text = "گزارش ها";
            this.chxReport.UseVisualStyleBackColor = true;
            // 
            // chxSms
            // 
            this.chxSms.AutoSize = true;
            this.chxSms.Location = new System.Drawing.Point(31, 35);
            this.chxSms.Name = "chxSms";
            this.chxSms.Size = new System.Drawing.Size(66, 23);
            this.chxSms.TabIndex = 28;
            this.chxSms.Text = "پیامک";
            this.chxSms.UseVisualStyleBackColor = true;
            // 
            // chxSearch
            // 
            this.chxSearch.AutoSize = true;
            this.chxSearch.Location = new System.Drawing.Point(192, 35);
            this.chxSearch.Name = "chxSearch";
            this.chxSearch.Size = new System.Drawing.Size(80, 23);
            this.chxSearch.TabIndex = 27;
            this.chxSearch.Text = "جستجو";
            this.chxSearch.UseVisualStyleBackColor = true;
            // 
            // chxTools
            // 
            this.chxTools.AutoSize = true;
            this.chxTools.Location = new System.Drawing.Point(395, 35);
            this.chxTools.Name = "chxTools";
            this.chxTools.Size = new System.Drawing.Size(69, 23);
            this.chxTools.TabIndex = 1;
            this.chxTools.Text = "ابزارها";
            this.chxTools.UseVisualStyleBackColor = true;
            // 
            // chxNewService
            // 
            this.chxNewService.AutoSize = true;
            this.chxNewService.Location = new System.Drawing.Point(537, 35);
            this.chxNewService.Name = "chxNewService";
            this.chxNewService.Size = new System.Drawing.Size(121, 23);
            this.chxNewService.TabIndex = 0;
            this.chxNewService.Text = "سرویس جدید";
            this.chxNewService.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(-3, 378);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(18, 19);
            this.label6.TabIndex = 27;
            this.label6.Text = "u";
            this.label6.Visible = false;
            // 
            // FormMange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 411);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgManage);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comAccess);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtConfrimPasword);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtUsername);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(728, 450);
            this.MinimumSize = new System.Drawing.Size(728, 450);
            this.Name = "FormMange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت کاربران";
            this.Load += new System.EventHandler(this.FormMange_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgManage)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtUsername;
        public System.Windows.Forms.TextBox txtPassword;
        public System.Windows.Forms.TextBox txtConfrimPasword;
        public System.Windows.Forms.Button btnSave;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.ComboBox comAccess;
        public System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.Button btnUpdate;
        public System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.DataGridView dgManage;
        public System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chxSetting;
        private System.Windows.Forms.CheckBox chxBackup;
        private System.Windows.Forms.CheckBox chxReport;
        private System.Windows.Forms.CheckBox chxSms;
        private System.Windows.Forms.CheckBox chxSearch;
        private System.Windows.Forms.CheckBox chxTools;
        private System.Windows.Forms.CheckBox chxNewService;
        public System.Windows.Forms.Label label6;
    }
}