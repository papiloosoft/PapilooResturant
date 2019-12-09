namespace Laundry
{
    partial class FormEditService
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEditService));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.chxTasfiye = new System.Windows.Forms.CheckBox();
            this.txtReadySms = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.txtReadyDate = new System.Windows.Forms.MaskedTextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtSomeService = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotalSum = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtTakhfif = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPardakhti = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.txtBeiane = new System.Windows.Forms.TextBox();
            this.txtDateService = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCodeRahgiri = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnEdit = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.MaskedTextBox();
            this.lblError = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEshterak = new System.Windows.Forms.MaskedTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtReadySms)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSomeService)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtDescription);
            this.panel1.Controls.Add(this.chxTasfiye);
            this.panel1.Controls.Add(this.txtReadySms);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtReadyDate);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtSomeService);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtTotalSum);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtTakhfif);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtPardakhti);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.txtBeiane);
            this.panel1.Controls.Add(this.txtDateService);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtCodeRahgiri);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.btnEdit);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.lblError);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtEshterak);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(938, 415);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtDescription
            // 
            this.txtDescription.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDescription.Location = new System.Drawing.Point(276, 309);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtDescription.Size = new System.Drawing.Size(533, 60);
            this.txtDescription.TabIndex = 91;
            // 
            // chxTasfiye
            // 
            this.chxTasfiye.AutoSize = true;
            this.chxTasfiye.Checked = true;
            this.chxTasfiye.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chxTasfiye.Location = new System.Drawing.Point(125, 239);
            this.chxTasfiye.Name = "chxTasfiye";
            this.chxTasfiye.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chxTasfiye.Size = new System.Drawing.Size(97, 23);
            this.chxTasfiye.TabIndex = 90;
            this.chxTasfiye.Text = "تصفیه شد";
            this.chxTasfiye.UseVisualStyleBackColor = true;
            this.chxTasfiye.Visible = false;
            // 
            // txtReadySms
            // 
            this.txtReadySms.Location = new System.Drawing.Point(341, 190);
            this.txtReadySms.Name = "txtReadySms";
            this.txtReadySms.Size = new System.Drawing.Size(120, 27);
            this.txtReadySms.TabIndex = 88;
            this.txtReadySms.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReadySms_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(487, 192);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(121, 19);
            this.label11.TabIndex = 87;
            this.label11.Text = "تعداد پیامک اماده";
            this.label11.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtReadyDate
            // 
            this.txtReadyDate.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtReadyDate.Location = new System.Drawing.Point(625, 189);
            this.txtReadyDate.Mask = "0000/00/00";
            this.txtReadyDate.Name = "txtReadyDate";
            this.txtReadyDate.Size = new System.Drawing.Size(172, 27);
            this.txtReadyDate.TabIndex = 86;
            this.txtReadyDate.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReadyDate_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(840, 192);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 19);
            this.label9.TabIndex = 85;
            this.label9.Text = "تاریخ آماده";
            // 
            // txtSomeService
            // 
            this.txtSomeService.Location = new System.Drawing.Point(60, 82);
            this.txtSomeService.Name = "txtSomeService";
            this.txtSomeService.Size = new System.Drawing.Size(120, 27);
            this.txtSomeService.TabIndex = 84;
            this.txtSomeService.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSomeService_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(211, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 19);
            this.label6.TabIndex = 83;
            this.label6.Text = "شماره سفارش";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtTotalSum
            // 
            this.txtTotalSum.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotalSum.Location = new System.Drawing.Point(50, 189);
            this.txtTotalSum.MaxLength = 20;
            this.txtTotalSum.Name = "txtTotalSum";
            this.txtTotalSum.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTotalSum.Size = new System.Drawing.Size(172, 27);
            this.txtTotalSum.TabIndex = 66;
            this.txtTotalSum.TextChanged += new System.EventHandler(this.txtTotalSum_TextChanged);
            this.txtTotalSum.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTotalSum_KeyPress);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(262, 192);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 19);
            this.label10.TabIndex = 71;
            this.label10.Text = "مبلغ کل";
            // 
            // txtTakhfif
            // 
            this.txtTakhfif.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTakhfif.Location = new System.Drawing.Point(50, 137);
            this.txtTakhfif.MaxLength = 20;
            this.txtTakhfif.Name = "txtTakhfif";
            this.txtTakhfif.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtTakhfif.Size = new System.Drawing.Size(172, 27);
            this.txtTakhfif.TabIndex = 81;
            this.txtTakhfif.TextChanged += new System.EventHandler(this.txtTakhfif_TextChanged);
            this.txtTakhfif.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTakhfif_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(272, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 19);
            this.label3.TabIndex = 80;
            this.label3.Text = "تخفیف";
            // 
            // txtPardakhti
            // 
            this.txtPardakhti.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPardakhti.Location = new System.Drawing.Point(341, 137);
            this.txtPardakhti.MaxLength = 20;
            this.txtPardakhti.Name = "txtPardakhti";
            this.txtPardakhti.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPardakhti.Size = new System.Drawing.Size(172, 27);
            this.txtPardakhti.TabIndex = 79;
            this.txtPardakhti.TextChanged += new System.EventHandler(this.txtBaghimande_TextChanged);
            this.txtPardakhti.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBaghimande_KeyPress);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(528, 145);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(64, 19);
            this.label15.TabIndex = 73;
            this.label15.Text = "پرداختی";
            this.label15.Click += new System.EventHandler(this.label15_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(228, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 19);
            this.label2.TabIndex = 78;
            this.label2.Text = "شماره تماس";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(849, 312);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 19);
            this.label1.TabIndex = 77;
            this.label1.Text = "توضیحات";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(871, 140);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(45, 19);
            this.label14.TabIndex = 72;
            this.label14.Text = "بیعانه";
            this.label14.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(60, 26);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(162, 27);
            this.txtPhone.TabIndex = 63;
            this.txtPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhone_KeyPress);
            // 
            // txtBeiane
            // 
            this.txtBeiane.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBeiane.Location = new System.Drawing.Point(625, 140);
            this.txtBeiane.MaxLength = 20;
            this.txtBeiane.Name = "txtBeiane";
            this.txtBeiane.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtBeiane.Size = new System.Drawing.Size(172, 27);
            this.txtBeiane.TabIndex = 64;
            this.txtBeiane.TextChanged += new System.EventHandler(this.txtBeiane_TextChanged);
            this.txtBeiane.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBeiane_KeyPress);
            // 
            // txtDateService
            // 
            this.txtDateService.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateService.Location = new System.Drawing.Point(625, 84);
            this.txtDateService.Mask = "0000/00/00";
            this.txtDateService.Name = "txtDateService";
            this.txtDateService.Size = new System.Drawing.Size(172, 27);
            this.txtDateService.TabIndex = 76;
            this.txtDateService.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDateService_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(817, 84);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(98, 19);
            this.label7.TabIndex = 69;
            this.label7.Text = "تاریخ سفارش";
            // 
            // txtCodeRahgiri
            // 
            this.txtCodeRahgiri.Enabled = false;
            this.txtCodeRahgiri.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCodeRahgiri.Location = new System.Drawing.Point(341, 84);
            this.txtCodeRahgiri.MaxLength = 10;
            this.txtCodeRahgiri.Name = "txtCodeRahgiri";
            this.txtCodeRahgiri.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCodeRahgiri.Size = new System.Drawing.Size(145, 27);
            this.txtCodeRahgiri.TabIndex = 75;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(511, 87);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(84, 19);
            this.label16.TabIndex = 74;
            this.label16.Text = "کد رهگیری";
            // 
            // btnEdit
            // 
            this.btnEdit.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Location = new System.Drawing.Point(12, 363);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(111, 40);
            this.btnEdit.TabIndex = 67;
            this.btnEdit.Text = "ویرایش";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(341, 26);
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtName.Size = new System.Drawing.Size(211, 27);
            this.txtName.TabIndex = 61;
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.Location = new System.Drawing.Point(469, 383);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 19);
            this.lblError.TabIndex = 68;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(570, 29);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(27, 19);
            this.label8.TabIndex = 70;
            this.label8.Text = "نام";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(805, 29);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(111, 19);
            this.label5.TabIndex = 65;
            this.label5.Text = "شماره اشتراک";
            // 
            // txtEshterak
            // 
            this.txtEshterak.Enabled = false;
            this.txtEshterak.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEshterak.Location = new System.Drawing.Point(625, 26);
            this.txtEshterak.Name = "txtEshterak";
            this.txtEshterak.Size = new System.Drawing.Size(172, 27);
            this.txtEshterak.TabIndex = 60;
            // 
            // FormEditService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 415);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(954, 454);
            this.MinimumSize = new System.Drawing.Size(954, 454);
            this.Name = "FormEditService";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ویرایش سفارش";
            this.Load += new System.EventHandler(this.FormEditService_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtReadySms)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSomeService)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtTotalSum;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.TextBox txtTakhfif;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txtPardakhti;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label2;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.MaskedTextBox txtPhone;
        public System.Windows.Forms.TextBox txtBeiane;
        public System.Windows.Forms.MaskedTextBox txtDateService;
        public System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txtCodeRahgiri;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Button btnEdit;
        public System.Windows.Forms.MaskedTextBox txtName;
        public System.Windows.Forms.Label lblError;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.MaskedTextBox txtEshterak;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.MaskedTextBox txtReadyDate;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txtDescription;
        public System.Windows.Forms.NumericUpDown txtSomeService;
        public System.Windows.Forms.NumericUpDown txtReadySms;
        public System.Windows.Forms.CheckBox chxTasfiye;
    }
}