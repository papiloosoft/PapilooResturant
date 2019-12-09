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
    public partial class FormEditUser : Form
    {
        public string phoneNumber = "";
        public FormEditUser()
        {
            InitializeComponent();
        }
        //**************
        //baraye inke faghat adad vared konad
        private void Enter_Number(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        //**************
        
        private void btnEdit_Click(object sender, EventArgs e)
        {
             try
            {
                lblError.Text = "";
                if (txtPhone.TextLength > 11 || txtPhone.TextLength < 11)
                {
                    lblError.ForeColor = Color.Red;
                    lblError.Text = "شماره موبایل 11 عدد نیست";
                    //txtPhone.Text = "0";
                    return;
                }
                using (var context = new kitchenEntities())
                {
                    var findPhone = context.User.Where(c => c.Phone == txtPhone.Text).ToList();
                    if (phoneNumber != txtPhone.Text || phoneNumber!=txtPhone.Text)
                    {
                        if (findPhone != null)
                        {
                            lblError.Text = "این شماره تماس قبلا ثبت شده";
                            return;
                        }
                    }
                    var editUser = context.User.Where(c => c.Eshterak == txtEshterak.Text).FirstOrDefault();
                    

                    editUser.Name = txtName.Text;
                    editUser.Phone = txtPhone.Text;
                    //editUser.Eshterak = txtEshterak.Text;
                    if (txtEnter.Text == "    /  /")
                    {

                        editUser.Date = 0;
                    }
                    else
                        editUser.Date = Int64.Parse(txtEnter.Text.Replace("/", ""));
                    editUser.Email = txtEmail.Text;
                    editUser.Address = txtAddress.Text;
                    editUser.PostiCode = txtPostiCode.Text;
                    if (txtBirthDay.Text == "    /  /")
                    {
                        
                        editUser.BirthDayDate = 0;
                    }
                    else
                        editUser.BirthDayDate = Int64.Parse(txtBirthDay.Text.Replace("/", ""));
                    //************
                    context.SaveChanges();
                    lblError.ForeColor = Color.Green;
                    lblError.Text = "اطلاعات با موفقیت ثبت شد";
                }
            }
            catch (Exception)
            {

                lblError.Text = "";
            }
        }

        private void FormEditUser_Load(object sender, EventArgs e)
        {
            if (txtBirthDay.Text == "0")
                txtBirthDay.Text = "";
            phoneNumber = txtPhone.Text;
            //if (txtBirthDay.TextLength >7)
            //{
            //    string birthday = txtBirthDay.Text;
            //    birthday=birthday.Insert(4, "/"); birthday=birthday.Insert(7, "/");
            //    txtBirthDay.Text = birthday;
            //}
            //if (txtEnter.TextLength >7)
            //{
            //    string DateEnter = txtEnter.Text;
            //    DateEnter=DateEnter.Insert(4, "/"); DateEnter=DateEnter.Insert(7, "/");
            //    txtEnter.Text = DateEnter;
            //}
        }

        private void txtEnter_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtPostiCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void txtBirthDay_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtName_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void txtPhone_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtEshterak_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void lblError_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);

        }

        private void txtEnter_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);

        }

        private void txtBirthDay_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);

        }

        private void txtPostiCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);

        }
    }
}
