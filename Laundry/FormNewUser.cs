using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry
{
    public partial class FormNewUser : Form
    {
        
        public FormNewUser()
        {
            InitializeComponent();
 
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dtEnter.Today_Click(null, null);
        }


        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("آقا /خانم " + txtName.Text + " به خشکشویی باران خوش آمدید\nکد اشتراک شما " + txtEshterak.Text, "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //MessageBox.Show("آقا /خانم " + txtName + " به خشکشویی باران خوش آمدید.کد اشتراک شما " + txtEshterak.Text);

            try
            {
                if (txtEshterak.Text == "")
                {
                    MessageBox.Show("شماره اشتراک خالی است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    using (var context = new kitchenEntities())
                    {

                        bool isContact = context.User.Where(check => check.Eshterak == txtEshterak.Text).Any();
                        if (isContact)
                        {
                            //MessageBox.Show("کاربری بااین شماره اشتراک وجود دارد", "اشتراک", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            lblError.ForeColor = Color.Red;
                            lblError.Text = "کاربری بااین شماره اشتراک وجود دارد";
                            txtEshterak.Focus();
                        }
                        else
                        {
                            if (txtPhone.Text == "")
                                txtPhone.Text = "0";
                            User user = new User
                            {
                                Name = txtName.Text,
                                Phone = txtPhone.Text,
                                Eshterak = txtEshterak.Text,
                                Date = int.Parse(dtEnter.Text.Replace("/","")),
                                Email = txtEmail.Text,
                                //************
                            };
                            context.User.Add(user);
                            context.SaveChanges();
                            lblError.ForeColor = Color.Green;
                            lblError.Text = "اطلاعات با موفقیت ثیت شد";
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            //-----ersal sms
            try
            {
            
                // PARSGREEN.API_SendSMS.SendSMS send = new PARSGREEN.API_SendSMS.SendSMS();
                PARSGREEN.API.SMS.Send.SendSMS send = new PARSGREEN.API.SMS.Send.SendSMS();
                int successCount = 0;
                int restStatus;
                string[] restr = null;
                restStatus = send.SendGroupSMS("8B0AA695-E750-4CB3-AF3E-98F9D03F06AC", "10001000300076", new string[] { txtPhone.Text }, "آقا /خانم " + txtName.Text + " به خشکشویی باران خوش آمدید\nکد اشتراک شما " + txtEshterak.Text, false, string.Empty, ref successCount, ref restr);
                //MessageBox.Show("تعداد پیام ها: " + restStatus.ToString() + "\r" + "تحویل داده شده: " + successCount);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }








        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            if (txtPhone.TextLength > 11)
                lblError.Text = "شماره تلفن را به صورت درست وارد کنید";
            if (txtPhone.TextLength <= 11)
                lblError.Text = "";
            
            
        }

        private void txtEshterak_TextChanged(object sender, EventArgs e)
        {
            using (var context = new kitchenEntities())
            {

                bool isContact = context.User.Where(check => check.Eshterak == txtEshterak.Text).Any();
                if (isContact)
                {
                    //MessageBox.Show("کاربری بااین شماره اشتراک وجود دارد", "اشتراک", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblError.ForeColor = Color.Red;
                    lblError.Text = "کاربری بااین شماره اشتراک وجود دارد";
                    
                }
                else
                {
                    lblError.Text = "";
                }
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtEshterak_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtYearCreate_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void txtPhone_TextChanged_1(object sender, EventArgs e)
        {
            lblError.Text = "";
            if(txtPhone.TextLength>12)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = "شماره موبایل اشتباه است";
                txtEshterak.Focus();
            }
            else 
                lblError.Text = "";
        }
   }
}
