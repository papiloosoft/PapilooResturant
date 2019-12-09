namespace Laundry
{
    partial class FormMain1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain1));
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolCreateUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolCreateServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDeleteUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDeleteServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBirthDay = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSearchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolSmsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolReports = new System.Windows.Forms.ToolStripMenuItem();
            this.toolDate = new System.Windows.Forms.ToolStripMenuItem();
            this.toolReportUser = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBackupRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBackup = new System.Windows.Forms.ToolStripMenuItem();
            this.toolRestore = new System.Windows.Forms.ToolStripMenuItem();
            this.toolManageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolManageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolManagePriceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tooSettingApplication = new System.Windows.Forms.ToolStripMenuItem();
            this.tooExitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.strlblVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.stripLblLogin = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolCreateUserToolStripMenuItem,
            this.toolCreateServiceToolStripMenuItem,
            this.toolToolsToolStripMenuItem,
            this.toolSearchToolStripMenuItem,
            this.toolSmsToolStripMenuItem,
            this.toolReports,
            this.toolBackupRestore,
            this.toolManageToolStripMenuItem,
            this.tooExitToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1274, 27);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolCreateUserToolStripMenuItem
            // 
            this.toolCreateUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("toolCreateUserToolStripMenuItem.Image")));
            this.toolCreateUserToolStripMenuItem.Name = "toolCreateUserToolStripMenuItem";
            this.toolCreateUserToolStripMenuItem.Size = new System.Drawing.Size(127, 23);
            this.toolCreateUserToolStripMenuItem.Text = "مشتری جدید";
            this.toolCreateUserToolStripMenuItem.Visible = false;
            this.toolCreateUserToolStripMenuItem.Click += new System.EventHandler(this.toolCreateUserToolStripMenuItem_Click);
            // 
            // toolCreateServiceToolStripMenuItem
            // 
            this.toolCreateServiceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("toolCreateServiceToolStripMenuItem.Image")));
            this.toolCreateServiceToolStripMenuItem.Name = "toolCreateServiceToolStripMenuItem";
            this.toolCreateServiceToolStripMenuItem.Size = new System.Drawing.Size(129, 23);
            this.toolCreateServiceToolStripMenuItem.Text = "سفارش جدید";
            this.toolCreateServiceToolStripMenuItem.Click += new System.EventHandler(this.toolCreateServiceToolStripMenuItem_Click);
            // 
            // toolToolsToolStripMenuItem
            // 
            this.toolToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolDeleteUserToolStripMenuItem,
            this.toolDeleteServiceToolStripMenuItem,
            this.toolBirthDay});
            this.toolToolsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("toolToolsToolStripMenuItem.Image")));
            this.toolToolsToolStripMenuItem.Name = "toolToolsToolStripMenuItem";
            this.toolToolsToolStripMenuItem.Size = new System.Drawing.Size(78, 23);
            this.toolToolsToolStripMenuItem.Text = "ابزارها";
            this.toolToolsToolStripMenuItem.Click += new System.EventHandler(this.toolToolsToolStripMenuItem_Click);
            // 
            // toolDeleteUserToolStripMenuItem
            // 
            this.toolDeleteUserToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("toolDeleteUserToolStripMenuItem.Image")));
            this.toolDeleteUserToolStripMenuItem.Name = "toolDeleteUserToolStripMenuItem";
            this.toolDeleteUserToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.toolDeleteUserToolStripMenuItem.Text = "حذف مشتری";
            this.toolDeleteUserToolStripMenuItem.Click += new System.EventHandler(this.toolDeleteUserToolStripMenuItem_Click);
            // 
            // toolDeleteServiceToolStripMenuItem
            // 
            this.toolDeleteServiceToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("toolDeleteServiceToolStripMenuItem.Image")));
            this.toolDeleteServiceToolStripMenuItem.Name = "toolDeleteServiceToolStripMenuItem";
            this.toolDeleteServiceToolStripMenuItem.Size = new System.Drawing.Size(172, 24);
            this.toolDeleteServiceToolStripMenuItem.Text = "حذف سرویس";
            this.toolDeleteServiceToolStripMenuItem.Click += new System.EventHandler(this.toolDeleteServiceToolStripMenuItem_Click);
            // 
            // toolBirthDay
            // 
            this.toolBirthDay.Name = "toolBirthDay";
            this.toolBirthDay.Size = new System.Drawing.Size(172, 24);
            this.toolBirthDay.Text = "تولد";
            this.toolBirthDay.Visible = false;
            this.toolBirthDay.Click += new System.EventHandler(this.toolBirthDay_Click);
            // 
            // toolSearchToolStripMenuItem
            // 
            this.toolSearchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("toolSearchToolStripMenuItem.Image")));
            this.toolSearchToolStripMenuItem.Name = "toolSearchToolStripMenuItem";
            this.toolSearchToolStripMenuItem.Size = new System.Drawing.Size(89, 23);
            this.toolSearchToolStripMenuItem.Text = "جستجو";
            this.toolSearchToolStripMenuItem.Click += new System.EventHandler(this.toolSearchToolStripMenuItem_Click);
            // 
            // toolSmsToolStripMenuItem
            // 
            this.toolSmsToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("toolSmsToolStripMenuItem.Image")));
            this.toolSmsToolStripMenuItem.Name = "toolSmsToolStripMenuItem";
            this.toolSmsToolStripMenuItem.Size = new System.Drawing.Size(75, 23);
            this.toolSmsToolStripMenuItem.Text = "پیامک";
            this.toolSmsToolStripMenuItem.Click += new System.EventHandler(this.toolSmsToolStripMenuItem_Click);
            // 
            // toolReports
            // 
            this.toolReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolDate,
            this.toolReportUser});
            this.toolReports.Image = ((System.Drawing.Image)(resources.GetObject("toolReports.Image")));
            this.toolReports.Name = "toolReports";
            this.toolReports.Size = new System.Drawing.Size(102, 23);
            this.toolReports.Text = "گزارش ها";
            // 
            // toolDate
            // 
            this.toolDate.Name = "toolDate";
            this.toolDate.Size = new System.Drawing.Size(145, 24);
            this.toolDate.Text = "بازه زمانی";
            this.toolDate.Click += new System.EventHandler(this.toolDate_Click);
            // 
            // toolReportUser
            // 
            this.toolReportUser.Name = "toolReportUser";
            this.toolReportUser.Size = new System.Drawing.Size(145, 24);
            this.toolReportUser.Text = "مشتری";
            this.toolReportUser.Click += new System.EventHandler(this.toolReportUser_Click);
            // 
            // toolBackupRestore
            // 
            this.toolBackupRestore.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBackup,
            this.toolRestore});
            this.toolBackupRestore.Image = ((System.Drawing.Image)(resources.GetObject("toolBackupRestore.Image")));
            this.toolBackupRestore.Name = "toolBackupRestore";
            this.toolBackupRestore.Size = new System.Drawing.Size(125, 23);
            this.toolBackupRestore.Text = "فایل پشتیبان";
            // 
            // toolBackup
            // 
            this.toolBackup.Name = "toolBackup";
            this.toolBackup.Size = new System.Drawing.Size(241, 24);
            this.toolBackup.Text = "تهیه پشتیبان اطلاعات";
            this.toolBackup.Click += new System.EventHandler(this.toolBackup_Click);
            // 
            // toolRestore
            // 
            this.toolRestore.Name = "toolRestore";
            this.toolRestore.Size = new System.Drawing.Size(241, 24);
            this.toolRestore.Text = "بازیابی اطلاعات سیستم";
            this.toolRestore.Click += new System.EventHandler(this.toolRestore_Click);
            // 
            // toolManageToolStripMenuItem
            // 
            this.toolManageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolManageToolStripMenuItem1,
            this.toolManagePriceToolStripMenuItem,
            this.tooSettingApplication});
            this.toolManageToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("toolManageToolStripMenuItem.Image")));
            this.toolManageToolStripMenuItem.Name = "toolManageToolStripMenuItem";
            this.toolManageToolStripMenuItem.Size = new System.Drawing.Size(92, 23);
            this.toolManageToolStripMenuItem.Text = "تنظیمات";
            this.toolManageToolStripMenuItem.Click += new System.EventHandler(this.toolManageToolStripMenuItem_Click);
            // 
            // toolManageToolStripMenuItem1
            // 
            this.toolManageToolStripMenuItem1.Name = "toolManageToolStripMenuItem1";
            this.toolManageToolStripMenuItem1.Size = new System.Drawing.Size(226, 24);
            this.toolManageToolStripMenuItem1.Text = "مدیریت کاربر";
            this.toolManageToolStripMenuItem1.Click += new System.EventHandler(this.toolManageToolStripMenuItem1_Click);
            // 
            // toolManagePriceToolStripMenuItem
            // 
            this.toolManagePriceToolStripMenuItem.Name = "toolManagePriceToolStripMenuItem";
            this.toolManagePriceToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.toolManagePriceToolStripMenuItem.Text = "مدیریت قیمت";
            this.toolManagePriceToolStripMenuItem.Click += new System.EventHandler(this.toolManagePriceToolStripMenuItem_Click);
            // 
            // tooSettingApplication
            // 
            this.tooSettingApplication.Name = "tooSettingApplication";
            this.tooSettingApplication.Size = new System.Drawing.Size(226, 24);
            this.tooSettingApplication.Text = "تنظیمات و فعال سازی";
            this.tooSettingApplication.Click += new System.EventHandler(this.tooSettingApplication_Click);
            // 
            // tooExitToolStripMenuItem
            // 
            this.tooExitToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("tooExitToolStripMenuItem.Image")));
            this.tooExitToolStripMenuItem.Name = "tooExitToolStripMenuItem";
            this.tooExitToolStripMenuItem.Size = new System.Drawing.Size(72, 23);
            this.tooExitToolStripMenuItem.Text = "خروج";
            this.tooExitToolStripMenuItem.Click += new System.EventHandler(this.tooExitToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strlblVersion,
            this.toolStripStatusLabel1,
            this.stripLblLogin});
            this.statusStrip1.Location = new System.Drawing.Point(0, 751);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1274, 30);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // strlblVersion
            // 
            this.strlblVersion.Name = "strlblVersion";
            this.strlblVersion.Size = new System.Drawing.Size(20, 25);
            this.strlblVersion.Text = "_";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(176, 25);
            this.toolStripStatusLabel1.Text = "وارد شده توسط==>";
            // 
            // stripLblLogin
            // 
            this.stripLblLogin.Name = "stripLblLogin";
            this.stripLblLogin.Size = new System.Drawing.Size(55, 25);
            this.stripLblLogin.Text = "login";
            // 
            // FormMain1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1274, 781);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(1278, 758);
            this.Name = "FormMain1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "خانه";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormMain1_FormClosed);
            this.Load += new System.EventHandler(this.FormMain1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.MenuStrip menuStrip1;
        public System.Windows.Forms.ToolStripMenuItem toolCreateUserToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem toolCreateServiceToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem toolToolsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem toolSearchToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem toolSmsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem toolManageToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem tooExitToolStripMenuItem;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel strlblVersion;
        private System.Windows.Forms.ToolStripMenuItem toolBackupRestore;
        private System.Windows.Forms.ToolStripMenuItem toolReports;
        private System.Windows.Forms.ToolStripMenuItem toolDate;
        private System.Windows.Forms.ToolStripMenuItem toolReportUser;
        public System.Windows.Forms.ToolStripMenuItem toolDeleteUserToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem toolDeleteServiceToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem toolManageToolStripMenuItem1;
        public System.Windows.Forms.ToolStripMenuItem toolManagePriceToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem tooSettingApplication;
        public System.Windows.Forms.ToolStripStatusLabel stripLblLogin;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripMenuItem toolBackup;
        private System.Windows.Forms.ToolStripMenuItem toolRestore;
        private System.Windows.Forms.ToolStripMenuItem toolBirthDay;
    }
}



