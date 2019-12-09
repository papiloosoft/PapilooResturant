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
    public partial class log : Form
    {
        public log()
        {
            InitializeComponent();
        }

        public void Enter_Application()
        {
            try
            {
                using (var context = new kitchenEntities())
                {
                    var userManage = context.Manage.Where(current => current.UserName == txtUsername.Text).FirstOrDefault();//ya avali o miyare ya hichi
                    if (userManage == null)
                    {
                        MessageBox.Show("نام کاربری یا رمز عبور اشتباه است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtUsername.Focus();
                        return;
                    }
                    else
                    {
                        if (userManage.Password == txtPassword.Text)
                        {

                            FormMain1 frmMain = new FormMain1();
                            frmMain.stripLblLogin.Text = txtUsername.Text;

                            this.Hide();
                            frmMain.Show();


                        }
                        else
                        {
                            MessageBox.Show("نام کاربری یا رمز عبور اشتباه است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            txtUsername.Focus();
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void txtPassword_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {
        }

        private void log_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new kitchenEntities())
                {
                    //var name = context.Settings.FirstOrDefault();
                    //if (name == null)
                    //    label3.Text = " مدریت  خشکشویی ";
                    //else
                    //{
                    //    string titel = " مدریت خشکشویی " + name.CommercialName;
                    //    label3.Text = titel;
                    //}
                    bool exsist = context.Manage.Where(c => c.UserName == "admin").Any();
                    if (exsist == false)
                    {
                        Manage manage = new Manage();
                        manage.UserName = "admin";
                        manage.Password = "123";
                        manage.Access = "0";
                        manage.NewService = "0";
                        manage.Tools = "0";
                        manage.Search = "0";
                        manage.Sms = "0";
                        manage.Report = "0";
                        manage.Backup = "0";
                        manage.Setting = "0";
                        context.Manage.Add(manage);
                        context.SaveChanges();

                    }



                }
            }
            catch (Exception)
            {

                Application.Exit();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtUsername_Enter(object sender, EventArgs e)
        {

        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            
        }

        private void txtUsername_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                Enter_Application();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter)
            {
                Enter_Application();
            }
        }

        private void btnEnter_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            Enter_Application();
        }
    }
}
