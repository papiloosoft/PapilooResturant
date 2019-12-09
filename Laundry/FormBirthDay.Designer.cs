namespace Laundry
{
    partial class FormBirthDay
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
            this.dgSearch = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtBirthDay = new BPersianCalender.BPersianCalenderTextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.comRemeberBirthDay = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgSearch
            // 
            this.dgSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSearch.Location = new System.Drawing.Point(4, 5);
            this.dgSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgSearch.Name = "dgSearch";
            this.dgSearch.Size = new System.Drawing.Size(444, 521);
            this.dgSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSearch.Location = new System.Drawing.Point(7, 72);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(112, 35);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "جستجو تولد";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgSearch);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(455, 531);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dtBirthDay);
            this.panel2.Controls.Add(this.label34);
            this.panel2.Controls.Add(this.comRemeberBirthDay);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Location = new System.Drawing.Point(473, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(297, 531);
            this.panel2.TabIndex = 3;
            // 
            // dtBirthDay
            // 
            this.dtBirthDay.BackColor = System.Drawing.Color.White;
            this.dtBirthDay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.dtBirthDay.Location = new System.Drawing.Point(7, 36);
            this.dtBirthDay.Miladi = new System.DateTime(((long)(0)));
            this.dtBirthDay.Name = "dtBirthDay";
            this.dtBirthDay.NowDateSelected = false;
            this.dtBirthDay.ReadOnly = true;
            this.dtBirthDay.SelectedDate = null;
            this.dtBirthDay.Shamsi = null;
            this.dtBirthDay.Size = new System.Drawing.Size(162, 27);
            this.dtBirthDay.TabIndex = 47;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label34.Location = new System.Drawing.Point(139, 5);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(145, 19);
            this.label34.TabIndex = 46;
            this.label34.Text = "روزهای مانده به تولد";
            this.label34.Click += new System.EventHandler(this.label34_Click);
            // 
            // comRemeberBirthDay
            // 
            this.comRemeberBirthDay.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.comRemeberBirthDay.FormattingEnabled = true;
            this.comRemeberBirthDay.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comRemeberBirthDay.Location = new System.Drawing.Point(175, 36);
            this.comRemeberBirthDay.Name = "comRemeberBirthDay";
            this.comRemeberBirthDay.Size = new System.Drawing.Size(109, 27);
            this.comRemeberBirthDay.TabIndex = 45;
            this.comRemeberBirthDay.SelectedIndexChanged += new System.EventHandler(this.comRemeberBirthDay_SelectedIndexChanged);
            // 
            // FormBirthDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 555);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormBirthDay";
            this.Text = "تولد";
            this.Load += new System.EventHandler(this.FormBirthDay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.ComboBox comRemeberBirthDay;
        private BPersianCalender.BPersianCalenderTextBox dtBirthDay;
    }
}