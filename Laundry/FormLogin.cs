using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.Management;
namespace Laundry
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new kitchenEntities())
                {
                    var name = context.Setting.FirstOrDefault();
                    if (name == null)
                        label3.Text = " مدریت  خشکشویی ";
                    else
                    {
                        string titel = " مدریت خشکشویی " + name.CommercialName;
                        label3.Text = titel;
                    }
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

        private void btnEnter_Click(object sender, EventArgs e)
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
                            frmMain.Show();
                            this.Close();


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

        public static implicit operator FormLogin(log v)
        {
            throw new NotImplementedException();
        }
    }
}
