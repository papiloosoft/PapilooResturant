namespace Laundry
{
    partial class FormManagePrice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormManagePrice));
            this.txtKindKala = new System.Windows.Forms.TextBox();
            this.btnSaveService = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comGroup = new System.Windows.Forms.TextBox();
            this.txtServiceName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtServisPrice = new System.Windows.Forms.MaskedTextBox();
            this.btnDeleteMotorOil = new System.Windows.Forms.Button();
            this.btnUpdateService = new System.Windows.Forms.Button();
            this.lblError = new System.Windows.Forms.Label();
            this.dgShow = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgShow)).BeginInit();
            this.SuspendLayout();
            // 
            // txtKindKala
            // 
            this.txtKindKala.Location = new System.Drawing.Point(67, 90);
            this.txtKindKala.Margin = new System.Windows.Forms.Padding(4);
            this.txtKindKala.Name = "txtKindKala";
            this.txtKindKala.Size = new System.Drawing.Size(192, 27);
            this.txtKindKala.TabIndex = 2;
            // 
            // btnSaveService
            // 
            this.btnSaveService.Location = new System.Drawing.Point(256, 228);
            this.btnSaveService.Name = "btnSaveService";
            this.btnSaveService.Size = new System.Drawing.Size(75, 34);
            this.btnSaveService.TabIndex = 5;
            this.btnSaveService.Text = "ثبت";
            this.btnSaveService.UseVisualStyleBackColor = true;
            this.btnSaveService.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 19);
            this.label1.TabIndex = 3;
            this.label1.Text = "محصول";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(307, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 19);
            this.label2.TabIndex = 4;
            this.label2.Text = "قیمت ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comGroup);
            this.groupBox1.Controls.Add(this.txtServiceName);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtServisPrice);
            this.groupBox1.Controls.Add(this.btnDeleteMotorOil);
            this.groupBox1.Controls.Add(this.btnUpdateService);
            this.groupBox1.Controls.Add(this.btnSaveService);
            this.groupBox1.Controls.Add(this.txtKindKala);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(564, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(393, 287);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "تعریف خدمت";
            // 
            // comGroup
            // 
            this.comGroup.Location = new System.Drawing.Point(67, 46);
            this.comGroup.Margin = new System.Windows.Forms.Padding(4);
            this.comGroup.Name = "comGroup";
            this.comGroup.Size = new System.Drawing.Size(192, 27);
            this.comGroup.TabIndex = 1;
            // 
            // txtServiceName
            // 
            this.txtServiceName.Location = new System.Drawing.Point(67, 137);
            this.txtServiceName.Margin = new System.Windows.Forms.Padding(4);
            this.txtServiceName.Name = "txtServiceName";
            this.txtServiceName.Size = new System.Drawing.Size(192, 27);
            this.txtServiceName.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(300, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 19);
            this.label4.TabIndex = 11;
            this.label4.Text = "سرویس";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(318, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 19);
            this.label3.TabIndex = 9;
            this.label3.Text = "دسته";
            // 
            // txtServisPrice
            // 
            this.txtServisPrice.Location = new System.Drawing.Point(67, 181);
            this.txtServisPrice.Name = "txtServisPrice";
            this.txtServisPrice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtServisPrice.Size = new System.Drawing.Size(192, 27);
            this.txtServisPrice.TabIndex = 4;
            this.txtServisPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceMotorOil_KeyPress);
            // 
            // btnDeleteMotorOil
            // 
            this.btnDeleteMotorOil.Location = new System.Drawing.Point(67, 228);
            this.btnDeleteMotorOil.Name = "btnDeleteMotorOil";
            this.btnDeleteMotorOil.Size = new System.Drawing.Size(74, 34);
            this.btnDeleteMotorOil.TabIndex = 7;
            this.btnDeleteMotorOil.Text = "حذف";
            this.btnDeleteMotorOil.UseVisualStyleBackColor = true;
            this.btnDeleteMotorOil.Click += new System.EventHandler(this.btnDeleteMotorOil_Click);
            // 
            // btnUpdateService
            // 
            this.btnUpdateService.Location = new System.Drawing.Point(165, 228);
            this.btnUpdateService.Name = "btnUpdateService";
            this.btnUpdateService.Size = new System.Drawing.Size(72, 34);
            this.btnUpdateService.TabIndex = 6;
            this.btnUpdateService.Text = "ویرایش ";
            this.btnUpdateService.UseVisualStyleBackColor = true;
            this.btnUpdateService.Click += new System.EventHandler(this.btnUpdatePriceOilMotor_Click);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(583, 579);
            this.lblError.Name = "lblError";
            this.lblError.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblError.Size = new System.Drawing.Size(0, 19);
            this.lblError.TabIndex = 23;
            // 
            // dgShow
            // 
            this.dgShow.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgShow.Location = new System.Drawing.Point(12, 19);
            this.dgShow.Name = "dgShow";
            this.dgShow.Size = new System.Drawing.Size(526, 579);
            this.dgShow.TabIndex = 24;
            this.dgShow.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgShow_CellClick);
            // 
            // FormManagePrice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 615);
            this.Controls.Add(this.dgShow);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblError);
            this.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(985, 654);
            this.MinimumSize = new System.Drawing.Size(985, 654);
            this.Name = "FormManagePrice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "مدیریت خدمات و قیمت";
            this.Load += new System.EventHandler(this.FormManagePrice_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKindKala;
        private System.Windows.Forms.Button btnSaveService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnUpdateService;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Button btnDeleteMotorOil;
        private System.Windows.Forms.DataGridView dgShow;
        private System.Windows.Forms.MaskedTextBox txtServisPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtServiceName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox comGroup;
    }
}