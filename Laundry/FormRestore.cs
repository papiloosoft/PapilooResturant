using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry
{
    public partial class FormRestore : Form
    {
        public FormRestore()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //فقط فایل های متنی نمایش داده شوند
            openFileDialog1.Filter = "|Lundry.db";
            //هیچ فایلی در ابتدا انتخاب نشود
            openFileDialog1.FileName = String.Empty;
            openFileDialog1.InitialDirectory = Application.StartupPath+ "\\Laundry\\";
            //پنجره ای برای انتخاب فایل باز شود
            DialogResult result = openFileDialog1.ShowDialog();

            //کلیک شد Open اگر دکمه
            if (result == DialogResult.OK)
            {
                textBox1.Text = openFileDialog1.FileName.ToString();

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (textBox1.Text != "")
            {
                    this.timer1.Enabled = true;
                    System.IO.File.Delete(Application.StartupPath + "\\Lundry.db");
                    File.Copy(textBox1.Text, Application.StartupPath + "\\Lundry.db", true);
            }
            else
            {
                MessageBox.Show("لطفا یک فایل پشتیبانی انتخاب نمایید", "اخطار", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "خطا", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            if (progressBar1.Value == 100)
            {
                this.timer1.Enabled = false;
                MessageBox.Show("عملیات بازیابی با موفقیت انجام شد", "پیغام", MessageBoxButtons.OK, MessageBoxIcon.Information);
                progressBar1.Value = 0;
            }
            else
            {
                progressBar1.Value += 10;
            }
        }

        private void frm_restore_Load(object sender, EventArgs e)
        {

        }
    }
}
