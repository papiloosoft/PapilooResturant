namespace Laundry
{
    partial class FormSms
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSms));
            this.dgView = new System.Windows.Forms.DataGridView();
            this.MsgIdEncrypt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Body = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SendDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Udh = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Receiver = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Parts = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsFlash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsRead = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IsUnicode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecCount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecFailed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RecSuccess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.btnSendMessage = new System.Windows.Forms.Button();
            this.btnRecevieMessage = new System.Windows.Forms.Button();
            this.chxIsRead = new System.Windows.Forms.CheckBox();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.lblDelivery = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSendMessage = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCountMessageRecevie = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnCountMessage = new System.Windows.Forms.Button();
            this.btnMoney = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.Label15 = new System.Windows.Forms.Label();
            this.lblCountMessagSend = new System.Windows.Forms.Label();
            this.Label9 = new System.Windows.Forms.Label();
            this.Label8 = new System.Windows.Forms.Label();
            this.Label7 = new System.Windows.Forms.Label();
            this.Label6 = new System.Windows.Forms.Label();
            this.Label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtMessageBody = new System.Windows.Forms.TextBox();
            this.txtMobilesNumbers = new System.Windows.Forms.TextBox();
            this.txtSMSnumber = new System.Windows.Forms.TextBox();
            this.txtSignature = new System.Windows.Forms.TextBox();
            this.lblMoney = new System.Windows.Forms.Label();
            this.dgSearch = new System.Windows.Forms.DataGridView();
            this.dtSearch = new BPersianCalender.BPersianCalenderTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAllUser = new System.Windows.Forms.Button();
            this.label34 = new System.Windows.Forms.Label();
            this.comRemeberBirthDay = new System.Windows.Forms.ComboBox();
            this.btnSearchBirthday = new System.Windows.Forms.Button();
            this.btnSearchServic = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).BeginInit();
            this.GroupBox2.SuspendLayout();
            this.GroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dgView
            // 
            this.dgView.AllowUserToAddRows = false;
            this.dgView.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MsgIdEncrypt,
            this.Body,
            this.SendDate,
            this.Udh,
            this.Sender,
            this.Receiver,
            this.Parts,
            this.IsFlash,
            this.IsRead,
            this.IsUnicode,
            this.Credit,
            this.RecCount,
            this.RecFailed,
            this.RecSuccess});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgView.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgView.Location = new System.Drawing.Point(456, 451);
            this.dgView.Name = "dgView";
            this.dgView.ReadOnly = true;
            this.dgView.Size = new System.Drawing.Size(585, 266);
            this.dgView.TabIndex = 29;
            // 
            // MsgIdEncrypt
            // 
            this.MsgIdEncrypt.DataPropertyName = "MsgIdEncrypt";
            this.MsgIdEncrypt.HeaderText = "مکID";
            this.MsgIdEncrypt.Name = "MsgIdEncrypt";
            this.MsgIdEncrypt.ReadOnly = true;
            this.MsgIdEncrypt.Visible = false;
            // 
            // Body
            // 
            this.Body.DataPropertyName = "Body";
            this.Body.HeaderText = "متن پیامک";
            this.Body.Name = "Body";
            this.Body.ReadOnly = true;
            // 
            // SendDate
            // 
            this.SendDate.DataPropertyName = "SendDate";
            this.SendDate.HeaderText = "تاریخ ارسال یا دریافت";
            this.SendDate.Name = "SendDate";
            this.SendDate.ReadOnly = true;
            // 
            // Udh
            // 
            this.Udh.DataPropertyName = "Udh";
            this.Udh.HeaderText = "سرامد";
            this.Udh.Name = "Udh";
            this.Udh.ReadOnly = true;
            this.Udh.Visible = false;
            // 
            // Sender
            // 
            this.Sender.DataPropertyName = "Sender";
            this.Sender.HeaderText = "فرستنده";
            this.Sender.Name = "Sender";
            this.Sender.ReadOnly = true;
            // 
            // Receiver
            // 
            this.Receiver.DataPropertyName = "Receiver";
            this.Receiver.HeaderText = "گیرنده";
            this.Receiver.Name = "Receiver";
            this.Receiver.ReadOnly = true;
            // 
            // Parts
            // 
            this.Parts.DataPropertyName = "Parts";
            this.Parts.HeaderText = "تعداد بخش های پیامک";
            this.Parts.Name = "Parts";
            this.Parts.ReadOnly = true;
            this.Parts.Visible = false;
            // 
            // IsFlash
            // 
            this.IsFlash.DataPropertyName = "IsFlash";
            this.IsFlash.HeaderText = "نوع پیامک ( عادی ، فلش )";
            this.IsFlash.Name = "IsFlash";
            this.IsFlash.ReadOnly = true;
            this.IsFlash.Visible = false;
            // 
            // IsRead
            // 
            this.IsRead.DataPropertyName = "IsRead";
            this.IsRead.HeaderText = "خوانده شده ، خوانده نشده";
            this.IsRead.Name = "IsRead";
            this.IsRead.ReadOnly = true;
            this.IsRead.Visible = false;
            // 
            // IsUnicode
            // 
            this.IsUnicode.DataPropertyName = "IsUnicode";
            this.IsUnicode.HeaderText = "فارسی یا انگلیسی";
            this.IsUnicode.Name = "IsUnicode";
            this.IsUnicode.ReadOnly = true;
            this.IsUnicode.Visible = false;
            // 
            // Credit
            // 
            this.Credit.DataPropertyName = "Credit";
            this.Credit.HeaderText = "قیمت";
            this.Credit.Name = "Credit";
            this.Credit.ReadOnly = true;
            // 
            // RecCount
            // 
            this.RecCount.DataPropertyName = "RecCount";
            this.RecCount.HeaderText = "تعداد درخواست";
            this.RecCount.Name = "RecCount";
            this.RecCount.ReadOnly = true;
            this.RecCount.Visible = false;
            // 
            // RecFailed
            // 
            this.RecFailed.DataPropertyName = "RecFailed";
            this.RecFailed.HeaderText = "تعداد ارسال ناموفق";
            this.RecFailed.Name = "RecFailed";
            this.RecFailed.ReadOnly = true;
            // 
            // RecSuccess
            // 
            this.RecSuccess.DataPropertyName = "RecSuccess";
            this.RecSuccess.HeaderText = "تعداد ارسال موفق";
            this.RecSuccess.Name = "RecSuccess";
            this.RecSuccess.ReadOnly = true;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnSendMessage);
            this.GroupBox2.Controls.Add(this.btnRecevieMessage);
            this.GroupBox2.Controls.Add(this.chxIsRead);
            this.GroupBox2.Location = new System.Drawing.Point(456, 383);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Size = new System.Drawing.Size(585, 62);
            this.GroupBox2.TabIndex = 28;
            this.GroupBox2.TabStop = false;
            // 
            // btnSendMessage
            // 
            this.btnSendMessage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendMessage.Location = new System.Drawing.Point(412, 10);
            this.btnSendMessage.Name = "btnSendMessage";
            this.btnSendMessage.Size = new System.Drawing.Size(143, 41);
            this.btnSendMessage.TabIndex = 24;
            this.btnSendMessage.Text = "پیام های ارسالی";
            this.btnSendMessage.UseVisualStyleBackColor = true;
            this.btnSendMessage.Click += new System.EventHandler(this.btnSendMessage_Click);
            // 
            // btnRecevieMessage
            // 
            this.btnRecevieMessage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecevieMessage.Location = new System.Drawing.Point(196, 10);
            this.btnRecevieMessage.Name = "btnRecevieMessage";
            this.btnRecevieMessage.Size = new System.Drawing.Size(139, 38);
            this.btnRecevieMessage.TabIndex = 23;
            this.btnRecevieMessage.Text = "پیام های دریافتی";
            this.btnRecevieMessage.UseVisualStyleBackColor = true;
            this.btnRecevieMessage.Click += new System.EventHandler(this.btnRecevieMessage_Click);
            // 
            // chxIsRead
            // 
            this.chxIsRead.AutoSize = true;
            this.chxIsRead.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chxIsRead.Location = new System.Drawing.Point(27, 19);
            this.chxIsRead.Name = "chxIsRead";
            this.chxIsRead.Size = new System.Drawing.Size(122, 23);
            this.chxIsRead.TabIndex = 23;
            this.chxIsRead.Text = "خوانده شده ؟";
            this.chxIsRead.UseVisualStyleBackColor = true;
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.lblDelivery);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.lblSendMessage);
            this.GroupBox1.Controls.Add(this.label10);
            this.GroupBox1.Controls.Add(this.lblCountMessageRecevie);
            this.GroupBox1.Controls.Add(this.label2);
            this.GroupBox1.Controls.Add(this.btnCountMessage);
            this.GroupBox1.Controls.Add(this.btnMoney);
            this.GroupBox1.Controls.Add(this.btnSend);
            this.GroupBox1.Controls.Add(this.Label15);
            this.GroupBox1.Controls.Add(this.lblCountMessagSend);
            this.GroupBox1.Controls.Add(this.Label9);
            this.GroupBox1.Controls.Add(this.Label8);
            this.GroupBox1.Controls.Add(this.Label7);
            this.GroupBox1.Controls.Add(this.Label6);
            this.GroupBox1.Controls.Add(this.Label5);
            this.GroupBox1.Controls.Add(this.label11);
            this.GroupBox1.Controls.Add(this.txtMessageBody);
            this.GroupBox1.Controls.Add(this.txtMobilesNumbers);
            this.GroupBox1.Controls.Add(this.txtSMSnumber);
            this.GroupBox1.Controls.Add(this.txtSignature);
            this.GroupBox1.Controls.Add(this.lblMoney);
            this.GroupBox1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.GroupBox1.Location = new System.Drawing.Point(459, 9);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.GroupBox1.Size = new System.Drawing.Size(582, 372);
            this.GroupBox1.TabIndex = 27;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "مشخصات";
            // 
            // lblDelivery
            // 
            this.lblDelivery.AutoSize = true;
            this.lblDelivery.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDelivery.Location = new System.Drawing.Point(37, 328);
            this.lblDelivery.Name = "lblDelivery";
            this.lblDelivery.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblDelivery.Size = new System.Drawing.Size(18, 19);
            this.lblDelivery.TabIndex = 33;
            this.lblDelivery.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(92, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(127, 19);
            this.label3.TabIndex = 32;
            this.label3.Text = "تحویل داده شده :";
            // 
            // lblSendMessage
            // 
            this.lblSendMessage.AutoSize = true;
            this.lblSendMessage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSendMessage.Location = new System.Drawing.Point(225, 328);
            this.lblSendMessage.Name = "lblSendMessage";
            this.lblSendMessage.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblSendMessage.Size = new System.Drawing.Size(18, 19);
            this.lblSendMessage.TabIndex = 31;
            this.lblSendMessage.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(328, 328);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 19);
            this.label10.TabIndex = 30;
            this.label10.Text = "ارسالی :";
            // 
            // lblCountMessageRecevie
            // 
            this.lblCountMessageRecevie.AutoSize = true;
            this.lblCountMessageRecevie.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountMessageRecevie.Location = new System.Drawing.Point(27, 109);
            this.lblCountMessageRecevie.Name = "lblCountMessageRecevie";
            this.lblCountMessageRecevie.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCountMessageRecevie.Size = new System.Drawing.Size(18, 19);
            this.lblCountMessageRecevie.TabIndex = 29;
            this.lblCountMessageRecevie.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 19);
            this.label2.TabIndex = 28;
            this.label2.Text = "پیام های دریافتی :";
            // 
            // btnCountMessage
            // 
            this.btnCountMessage.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCountMessage.Location = new System.Drawing.Point(412, 98);
            this.btnCountMessage.Name = "btnCountMessage";
            this.btnCountMessage.Size = new System.Drawing.Size(143, 47);
            this.btnCountMessage.TabIndex = 27;
            this.btnCountMessage.Text = "تعداد پیام های شما";
            this.btnCountMessage.UseVisualStyleBackColor = true;
            this.btnCountMessage.Click += new System.EventHandler(this.btnCountMessage_Click);
            // 
            // btnMoney
            // 
            this.btnMoney.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMoney.Location = new System.Drawing.Point(412, 52);
            this.btnMoney.Name = "btnMoney";
            this.btnMoney.Size = new System.Drawing.Size(143, 43);
            this.btnMoney.TabIndex = 26;
            this.btnMoney.Text = "چک کردن اعتبار";
            this.btnMoney.UseVisualStyleBackColor = true;
            this.btnMoney.Click += new System.EventHandler(this.btnMoney_Click);
            // 
            // btnSend
            // 
            this.btnSend.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(414, 314);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(143, 47);
            this.btnSend.TabIndex = 19;
            this.btnSend.Text = "ارسال پیامک";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Label15
            // 
            this.Label15.AutoSize = true;
            this.Label15.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label15.Location = new System.Drawing.Point(27, 62);
            this.Label15.Name = "Label15";
            this.Label15.Size = new System.Drawing.Size(34, 19);
            this.Label15.TabIndex = 23;
            this.Label15.Text = "ریال";
            // 
            // lblCountMessagSend
            // 
            this.lblCountMessagSend.AutoSize = true;
            this.lblCountMessagSend.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountMessagSend.Location = new System.Drawing.Point(215, 109);
            this.lblCountMessagSend.Name = "lblCountMessagSend";
            this.lblCountMessagSend.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblCountMessagSend.Size = new System.Drawing.Size(18, 19);
            this.lblCountMessagSend.TabIndex = 18;
            this.lblCountMessagSend.Text = "0";
            // 
            // Label9
            // 
            this.Label9.AutoSize = true;
            this.Label9.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label9.Location = new System.Drawing.Point(258, 109);
            this.Label9.Name = "Label9";
            this.Label9.Size = new System.Drawing.Size(136, 19);
            this.Label9.TabIndex = 17;
            this.Label9.Text = "پیام های ارسالی :";
            // 
            // Label8
            // 
            this.Label8.AutoSize = true;
            this.Label8.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label8.Location = new System.Drawing.Point(268, 62);
            this.Label8.Name = "Label8";
            this.Label8.Size = new System.Drawing.Size(126, 19);
            this.Label8.TabIndex = 14;
            this.Label8.Text = "مبلغ اعتبار شما :";
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(426, 264);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(121, 19);
            this.Label7.TabIndex = 13;
            this.Label7.Text = "متن پیام ارسالی";
            // 
            // Label6
            // 
            this.Label6.AutoSize = true;
            this.Label6.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label6.Location = new System.Drawing.Point(449, 25);
            this.Label6.Name = "Label6";
            this.Label6.Size = new System.Drawing.Size(98, 19);
            this.Label6.TabIndex = 12;
            this.Label6.Text = "امضاء دیجیتال";
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(436, 196);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(104, 19);
            this.Label5.TabIndex = 11;
            this.Label5.Text = "شماره موبایل ";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(436, 148);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(111, 19);
            this.label11.TabIndex = 10;
            this.label11.Text = "شماره ارسالی";
            // 
            // txtMessageBody
            // 
            this.txtMessageBody.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMessageBody.Location = new System.Drawing.Point(24, 236);
            this.txtMessageBody.Multiline = true;
            this.txtMessageBody.Name = "txtMessageBody";
            this.txtMessageBody.Size = new System.Drawing.Size(365, 77);
            this.txtMessageBody.TabIndex = 8;
            // 
            // txtMobilesNumbers
            // 
            this.txtMobilesNumbers.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMobilesNumbers.Location = new System.Drawing.Point(25, 177);
            this.txtMobilesNumbers.Multiline = true;
            this.txtMobilesNumbers.Name = "txtMobilesNumbers";
            this.txtMobilesNumbers.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtMobilesNumbers.Size = new System.Drawing.Size(365, 53);
            this.txtMobilesNumbers.TabIndex = 7;
            // 
            // txtSMSnumber
            // 
            this.txtSMSnumber.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSMSnumber.Location = new System.Drawing.Point(25, 145);
            this.txtSMSnumber.Name = "txtSMSnumber";
            this.txtSMSnumber.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSMSnumber.Size = new System.Drawing.Size(365, 27);
            this.txtSMSnumber.TabIndex = 6;
            // 
            // txtSignature
            // 
            this.txtSignature.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSignature.Location = new System.Drawing.Point(25, 22);
            this.txtSignature.Name = "txtSignature";
            this.txtSignature.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSignature.Size = new System.Drawing.Size(365, 27);
            this.txtSignature.TabIndex = 5;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoney.Location = new System.Drawing.Point(74, 62);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblMoney.Size = new System.Drawing.Size(18, 19);
            this.lblMoney.TabIndex = 5;
            this.lblMoney.Text = "0";
            // 
            // dgSearch
            // 
            this.dgSearch.AllowUserToAddRows = false;
            this.dgSearch.AllowUserToDeleteRows = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgSearch.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgSearch.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgSearch.Location = new System.Drawing.Point(12, 172);
            this.dgSearch.Name = "dgSearch";
            this.dgSearch.ReadOnly = true;
            this.dgSearch.Size = new System.Drawing.Size(438, 545);
            this.dgSearch.TabIndex = 32;
            // 
            // dtSearch
            // 
            this.dtSearch.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtSearch.Location = new System.Drawing.Point(223, 23);
            this.dtSearch.Miladi = new System.DateTime(((long)(0)));
            this.dtSearch.Name = "dtSearch";
            this.dtSearch.NowDateSelected = false;
            this.dtSearch.ReadOnly = true;
            this.dtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtSearch.SelectedDate = null;
            this.dtSearch.Shamsi = null;
            this.dtSearch.Size = new System.Drawing.Size(147, 30);
            this.dtSearch.TabIndex = 34;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(402, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 19);
            this.label1.TabIndex = 35;
            this.label1.Text = "تاریخ ";
            // 
            // btnAllUser
            // 
            this.btnAllUser.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAllUser.Location = new System.Drawing.Point(15, 119);
            this.btnAllUser.Name = "btnAllUser";
            this.btnAllUser.Size = new System.Drawing.Size(143, 36);
            this.btnAllUser.TabIndex = 36;
            this.btnAllUser.Text = "همه مشتری ها";
            this.btnAllUser.UseVisualStyleBackColor = true;
            this.btnAllUser.Click += new System.EventHandler(this.btnAllUser_Click);
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.label34.Location = new System.Drawing.Point(301, 73);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(145, 19);
            this.label34.TabIndex = 50;
            this.label34.Text = "روزهای مانده به تولد";
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
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20"});
            this.comRemeberBirthDay.Location = new System.Drawing.Point(223, 71);
            this.comRemeberBirthDay.Name = "comRemeberBirthDay";
            this.comRemeberBirthDay.Size = new System.Drawing.Size(72, 27);
            this.comRemeberBirthDay.TabIndex = 49;
            // 
            // btnSearchBirthday
            // 
            this.btnSearchBirthday.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSearchBirthday.Location = new System.Drawing.Point(15, 76);
            this.btnSearchBirthday.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchBirthday.Name = "btnSearchBirthday";
            this.btnSearchBirthday.Size = new System.Drawing.Size(143, 35);
            this.btnSearchBirthday.TabIndex = 48;
            this.btnSearchBirthday.Text = "جستجو تولد";
            this.btnSearchBirthday.UseVisualStyleBackColor = true;
            this.btnSearchBirthday.Click += new System.EventHandler(this.btnSearchBirthday_Click);
            // 
            // btnSearchServic
            // 
            this.btnSearchServic.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.btnSearchServic.Location = new System.Drawing.Point(15, 18);
            this.btnSearchServic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearchServic.Name = "btnSearchServic";
            this.btnSearchServic.Size = new System.Drawing.Size(143, 48);
            this.btnSearchServic.TabIndex = 51;
            this.btnSearchServic.Text = "جستجو تاریخ سرویس";
            this.btnSearchServic.UseVisualStyleBackColor = true;
            this.btnSearchServic.Click += new System.EventHandler(this.btnSearchServic_Click);
            // 
            // FormSms
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1053, 729);
            this.Controls.Add(this.btnSearchServic);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.comRemeberBirthDay);
            this.Controls.Add(this.btnSearchBirthday);
            this.Controls.Add(this.btnAllUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtSearch);
            this.Controls.Add(this.dgSearch);
            this.Controls.Add(this.dgView);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1069, 768);
            this.MinimumSize = new System.Drawing.Size(1069, 758);
            this.Name = "FormSms";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "پیامک";
            this.Load += new System.EventHandler(this.FormSms_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgView)).EndInit();
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dgView;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button btnSendMessage;
        internal System.Windows.Forms.Button btnRecevieMessage;
        internal System.Windows.Forms.CheckBox chxIsRead;
        internal System.Windows.Forms.GroupBox GroupBox1;
        internal System.Windows.Forms.Button btnCountMessage;
        internal System.Windows.Forms.Button btnMoney;
        internal System.Windows.Forms.Button btnSend;
        internal System.Windows.Forms.Label Label15;
        internal System.Windows.Forms.Label lblCountMessagSend;
        internal System.Windows.Forms.Label Label9;
        internal System.Windows.Forms.Label Label8;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.Label Label6;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label label11;
        internal System.Windows.Forms.TextBox txtMessageBody;
        internal System.Windows.Forms.TextBox txtMobilesNumbers;
        internal System.Windows.Forms.TextBox txtSMSnumber;
        internal System.Windows.Forms.TextBox txtSignature;
        internal System.Windows.Forms.Label lblMoney;
        internal System.Windows.Forms.Label lblCountMessageRecevie;
        internal System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Label lblDelivery;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label lblSendMessage;
        internal System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridViewTextBoxColumn MsgIdEncrypt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Body;
        private System.Windows.Forms.DataGridViewTextBoxColumn SendDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Udh;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sender;
        private System.Windows.Forms.DataGridViewTextBoxColumn Receiver;
        private System.Windows.Forms.DataGridViewTextBoxColumn Parts;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsFlash;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsRead;
        private System.Windows.Forms.DataGridViewTextBoxColumn IsUnicode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecCount;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecFailed;
        private System.Windows.Forms.DataGridViewTextBoxColumn RecSuccess;
        internal System.Windows.Forms.DataGridView dgSearch;
        private BPersianCalender.BPersianCalenderTextBox dtSearch;
        internal System.Windows.Forms.Label label1;
        internal System.Windows.Forms.Button btnAllUser;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.ComboBox comRemeberBirthDay;
        private System.Windows.Forms.Button btnSearchBirthday;
        private System.Windows.Forms.Button btnSearchServic;
    }
}