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
    public partial class FormMange : Form
    {

        public FormMange()
        {
            InitializeComponent();
            
        }
        public void Refresh_Manage()//tanzim deta gride
        {
            using (var context=new kitchenEntities())
            {
                dgManage.DataSource = context.Manage.Where(ex => ex.UserName != null).ToList();
                dgManage.Columns[0].HeaderText = "نام کاربری";
                dgManage.Columns[1].HeaderText = "کلمه عبور";
                dgManage.Columns[2].HeaderText = "دسترسی";
                dgManage.Columns[3].HeaderText = "شماره";
                dgManage.Columns[3].Visible = false;
                dgManage.Columns[4].Visible = false;
                dgManage.Columns[5].Visible = false;
                dgManage.Columns[6].Visible = false;
                dgManage.Columns[7].Visible = false;
                dgManage.Columns[8].Visible = false;
                dgManage.Columns[9].Visible = false;
                dgManage.Columns[10].Visible = false;
            }
        }

        public void load_Access()
        {
            try
            {
                //FormMain1 frmMain = new FormMain1();
                
                using (var context = new kitchenEntities())
                {
                    var select = context.Manage.Where(current => current.UserName == label6.Text).FirstOrDefault();

                    if (select.NewService == "1")
                        chxNewService.Checked = true;
                    //-----
                    if (select.Tools == "1")
                        chxTools.Checked = true;
                    //-----
                    if (select.Search == "1")
                        chxSearch.Checked = true;
                    //-----
                    if (select.Sms == "1")
                        chxSms.Checked = true;
                    //----
                    if (select.Report == "1")
                        chxReport.Checked = true;
                    //----
                    if (select.Backup == "1")
                        chxBackup.Checked = true;
                    //----
                    if (select.Setting == "1")
                        chxSetting.Checked = true;
                    //----
                    //comAccess.SelectedIndex = int.Parse(select.Access);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("load access"+"\n" + ex.Message);
            }
        }
        private void FormMange_Load(object sender, EventArgs e)
        {
            comAccess.SelectedIndex = 0;
            Refresh_Manage();
            load_Access();
        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            try
            {
                if(txtPassword.Text==txtConfrimPasword.Text)
                {
                using (var context=new kitchenEntities())
                {
                    var exist = context.Manage.Where(ex => ex.UserName == txtUsername.Text).ToList();
                        if (exist.Count == 0)
                        {
                            Manage admin = new Manage();
                            admin.UserName = txtUsername.Text;
                            admin.Password = txtPassword.Text;
                            admin.Access = comAccess.SelectedIndex.ToString();
                            //---
                            if (chxNewService.Checked)
                                admin.NewService = "1";
                            else
                                admin.NewService = "0";
                            //---
                            if (chxTools.Checked)
                                admin.Tools = "1";
                            else
                                admin.Tools = "0";
                            //---
                            if (chxSearch.Checked)
                                admin.Search = "1";
                            else
                                admin.Search = "0";
                            //---
                            if (chxSms.Checked)
                                admin.Sms = "1";
                            else
                                admin.Sms = "0";
                            //---
                            if (chxReport.Checked)
                                admin.Report = "1";
                            else
                                admin.Report = "0";
                            //---
                            if (chxBackup.Checked)
                                admin.Backup = "1";
                            else
                                admin.Backup = "0";
                            //---
                            if (chxSetting.Checked)
                                admin.Setting = "1";
                            else
                                admin.Setting = "0";

                            context.Manage.Add(admin);
                            context.SaveChanges();
                            lblError.ForeColor = Color.Green;
                            lblError.Text = "مدیر جدید ثبت شد";

                            Refresh_Manage();

                        }
                        else
                        {
                            lblError.ForeColor = Color.Red;
                            lblError.Text = "این نام کاربری وجود دارد";
                        }
                }
            }
                else
                {
                    lblError.ForeColor = Color.Red;
                    lblError.Text = "کلمه عبورها با هم یکسان نیست";
                }
            }
            catch (Exception ex)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = ex.Message;
                
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            try
            {
                using (var context = new kitchenEntities())
                {
                    var delete = context.Manage.Where(current => current.UserName.Contains(txtUsername.Text)).ToList();
                    if (delete.Count == 0)
                    {
                        var result = MessageBox.Show("کاربر مورد نظر پیدا نشد،آیا همه موارد را میخواهید؟", "مدیریت", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if (result == DialogResult.Yes)
                        {
                            dgManage.DataSource = context.Manage.ToList();
                            Refresh_Manage();
                        }
                        else
                        {
                            txtUsername.Focus();
                        }
                    }
                    if (delete.Count == 1)
                    {
                        Manage del = context.Manage.Where(current => current.UserName == txtUsername.Text).FirstOrDefault();
                        context.Manage.Remove(del);
                        context.SaveChanges();
                        lblError.ForeColor = Color.Green;
                        lblError.Text = "کاربر با موفقیت حذف شد";
                        context.Dispose();



                        Refresh_Manage(); txtUsername.Text = ""; txtPassword.Text = ""; txtConfrimPasword.Text = "";
                    }
                    if (delete.Count > 1)
                    {
                        dgManage.DataSource = delete.ToList();
                    }

                }
            }
            catch (Exception)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = "عملیات حذف با مشکل مواجه شد";
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            try
            {
                using (var context = new kitchenEntities())
                {
                    if (txtUsername.Text != "")
                    {
                        var admin = context.Manage.Where(current => current.UserName == txtUsername.Text).ToList();
                        if (admin.Count == 1)
                        {
                            var update = context.Manage.Where(current => current.UserName == txtUsername.Text).FirstOrDefault();
                            if (update != null)
                            {
                                update.UserName = txtUsername.Text;
                                if (txtPassword.Text == txtConfrimPasword.Text)
                                {
                                    update.Password = txtPassword.Text;
                                    update.Access = comAccess.SelectedIndex.ToString();
                                    //---
                                    if (chxNewService.Checked)
                                        update.NewService = "1";
                                    else
                                        update.NewService = "0";
                                    //---
                                    if (chxTools.Checked)
                                        update.Tools = "1";
                                    else
                                        update.Tools = "0";
                                    //---
                                    if (chxSearch.Checked)
                                        update.Search = "1";
                                    else
                                        update.Search = "0";
                                    //---
                                    if (chxSms.Checked)
                                        update.Sms = "1";
                                    else
                                        update.Sms = "0";
                                    //---
                                    if (chxReport.Checked)
                                        update.Report = "1";
                                    else
                                        update.Report = "0";
                                    //---
                                    if (chxBackup.Checked)
                                        update.Backup = "1";
                                    else
                                        update.Backup = "0";
                                    //---
                                    if (chxSetting.Checked)
                                        update.Setting = "1";
                                    else
                                        update.Setting = "0";

                                    context.SaveChanges();
                                    context.Dispose();
                                    lblError.ForeColor = Color.Green;
                                    lblError.Text = "ویرایش با موفقبت اتجام شد";
                                    Refresh_Manage();

                                }
                                else
                                {
                                    lblError.ForeColor = Color.Red;
                                    lblError.Text = "کلمه عبورها با هم یکسان نیست";
                                }

                            }
                            else { lblError.ForeColor = Color.Red; lblError.Text = "نام کاربر را وارد کنید"; }
                        }
                        else { lblError.ForeColor = Color.Red; lblError.Text = "کاربری با این نام وجود ندارد"; }

                    }
                    else { lblError.ForeColor = Color.Red; lblError.Text = "نام کاربر را وارد کنید"; }

                }
            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            
        }

        private void dgManage_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtUsername.Text = dgManage.CurrentRow.Cells[0].Value.ToString();
            txtPassword.Text = dgManage.CurrentRow.Cells[1].Value.ToString();
            txtConfrimPasword.Text = txtPassword.Text;
            comAccess.SelectedIndex = Convert.ToInt16(dgManage.CurrentRow.Cells[2].Value);

        }
    }
}
