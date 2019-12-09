namespace Laundry
{
    partial class FormDelete
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormDelete));
            this.txtEshterak = new System.Windows.Forms.TextBox();
            this.lblEshterak = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgDelete = new System.Windows.Forms.DataGridView();
            this.lblError = new System.Windows.Forms.Label();
            this.lbldel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgDelete)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEshterak
            // 
            this.txtEshterak.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEshterak.Location = new System.Drawing.Point(383, 18);
            this.txtEshterak.Name = "txtEshterak";
            this.txtEshterak.Size = new System.Drawing.Size(130, 27);
            this.txtEshterak.TabIndex = 0;
            this.txtEshterak.TextChanged += new System.EventHandler(this.txtEshterak_TextChanged);
            // 
            // lblEshterak
            // 
            this.lblEshterak.AutoSize = true;
            this.lblEshterak.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEshterak.Location = new System.Drawing.Point(519, 21);
            this.lblEshterak.Name = "lblEshterak";
            this.lblEshterak.Size = new System.Drawing.Size(111, 19);
            this.lblEshterak.TabIndex = 6;
            this.lblEshterak.Text = "شماره اشتراک";
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(302, 18);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 28);
            this.btnDelete.TabIndex = 1;
            this.btnDelete.Text = "حذف";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgDelete
            // 
            this.dgDelete.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgDelete.Location = new System.Drawing.Point(12, 52);
            this.dgDelete.Name = "dgDelete";
            this.dgDelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgDelete.Size = new System.Drawing.Size(623, 522);
            this.dgDelete.TabIndex = 7;
            this.dgDelete.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgDelete_CellClick);
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.Red;
            this.lblError.Location = new System.Drawing.Point(22, 14);
            this.lblError.Name = "lblError";
            this.lblError.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblError.Size = new System.Drawing.Size(0, 19);
            this.lblError.TabIndex = 24;
            // 
            // lbldel
            // 
            this.lbldel.AutoSize = true;
            this.lbldel.Location = new System.Drawing.Point(28, 21);
            this.lbldel.Name = "lbldel";
            this.lbldel.Size = new System.Drawing.Size(35, 13);
            this.lbldel.TabIndex = 25;
            this.lbldel.Text = "label1";
            this.lbldel.Visible = false;
            // 
            // FormDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 582);
            this.Controls.Add(this.lbldel);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.dgDelete);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.txtEshterak);
            this.Controls.Add(this.lblEshterak);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(661, 621);
            this.MinimumSize = new System.Drawing.Size(661, 621);
            this.Name = "FormDelete";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حذف";
            this.Load += new System.EventHandler(this.FormDelete_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgDelete)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEshterak;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgDelete;
        private System.Windows.Forms.Label lblError;
        public System.Windows.Forms.Label lblEshterak;
        public System.Windows.Forms.Label lbldel;
    }
}