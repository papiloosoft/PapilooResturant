using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry
{
    public partial class FormMain1 : Form
    {
        private int childFormNumber = 0;
        public int forDelete;
        public string frmManage = "1";//meghdare avalie
        public FormMain1()
        {
            InitializeComponent();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void toolCreateServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormServices frmLunServ = new FormServices();
            frmLunServ.MdiParent = this;
            frmLunServ.Show();
        }

        private void toolCreateUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormNewUser frmuser = new FormNewUser();
            frmuser.MdiParent = this;
            frmuser.Show();
        }

        private void toolDeleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDelete frmdelete = new FormDelete();
            frmdelete.lbldel.Text = "1";
            frmdelete.MdiParent = this;
            frmdelete.Show();
        }

        private void toolDeleteServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormDelete frmdelete = new FormDelete();
            frmdelete.lbldel.Text = "2";
            frmdelete.MdiParent = this;
            frmdelete.Show();
        }

        private void toolSearchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSearch frmsearch = new FormSearch();
            frmsearch.MdiParent = this;
            frmsearch.Show();
        }

        private void toolSmsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormSms frmSms = new FormSms();
            frmSms.MdiParent = this;
            frmSms.Show();
        }

        private void toolManageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormMange frmManage = new FormMange();
            frmManage.MdiParent = this;
            frmManage.label6.Text = stripLblLogin.Text;
            frmManage.Show();
        }

        private void toolManagePriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormManagePrice frmprice = new FormManagePrice();
            frmprice.MdiParent = this;
            frmprice.Show();
        }

        private void toolSoftwareEnabale_Click(object sender, EventArgs e)
        {

        }

        private void tooExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolManageToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        public string Get_Serial_Hard() // gereftan serial hard
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DiskDrive");
            string hard = "1";
            foreach (ManagementObject info in searcher.Get())
            {

                hard = (info["SerialNumber"].ToString()).Trim();
            }
            return hard;
        }        

        public void First_Enter() //vorod baraye avalin bar
        {
            try
            {
                using (var context = new kitchenEntities())
                {
                    string date = DateTime.Now.ToShortDateString().Replace("/", "");
                    //string hard = Get_Serial_Hard();
                    Reg reg = new Reg();
                    reg.State = IDGenerator.GetCPUId();
                    reg.Date = int.Parse(date);
                    //string version = "1";
                    //string s = hard + version + date;
                    //reg.Serial1 = s;
                    reg.CountOpen = 1;
                    //version = exsistSerial.CountOpen.ToString();

                    context.Reg.Add(reg);
                    //-----
                    Setting avlie = new Setting();
                    avlie.EndCreateCodeRahgiri = 0;
                    context.Setting.Add(avlie);

                    //-----
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
                    //-----
                    var whhiteSms = context.WhiteSms.Where(c => c.Id == 1).FirstOrDefault();
                    whhiteSms.R11 = "8a1e98m"; //baraye register
                    whhiteSms.R10 = "0"; //baraye ersal code rigister ba panel sms papiloo                    


                    context.SaveChanges();
                    strlblVersion.Text = "نسخه آزمایشی";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در ورود اولیه:\n" + ex.Message);
           }
        }

        public void Active() //Active kamel ba code hard barabar
        {
            try
            {
                using (var context = new kitchenEntities())
                {
                    strlblVersion.Text = "برنامه کامل";
                    Accsess();
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(" خطا در برنامه کامل:\n" + ex.Message);
            }
        }

        public void Active_NotEcoal() //Active hast vali serial hard yeki nist
        {
            try
            {
                using (var context = new kitchenEntities())
                {
                    string date = DateTime.Now.ToShortDateString().Replace("/", "");
                    string hard = Get_Serial_Hard();

                    MessageBox.Show("نرم افزار کپی شده است.هر کد فعال سازی مخصوص یک دستگاه است","نرم افزار",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    DialogResult result = MessageBox.Show("آیا همه اطلاعات پاک شود و نسخه آزمایشی استفاده شود؟", "نرم افزار", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        var deleteReg = context.Reg.FirstOrDefault();
                        if (deleteReg != null)
                            context.Reg.Remove(deleteReg);
                        //------
                        var del = context.Setting.FirstOrDefault();
                        if (del != null)
                            context.Setting.Remove(del);
                        //------
                        var delUser = context.User.ToList();
                        if (delUser != null)
                            context.User.RemoveRange(delUser);
                        //------
                        var delService = context.Service.ToList();
                        if (delService != null)
                            context.Service.RemoveRange(delService);
                        //------
                        var delReportService = context.ReportService.ToList();
                        if (delReportService != null)
                            context.ReportService.RemoveRange(delReportService);
                        //------
                        var delServicePrice = context.ServicesPrice.ToList();
                        if (delServicePrice != null)
                            context.ServicesPrice.RemoveRange(delServicePrice);
                        //------
                        //var delNameService = context.NameServices.ToList();
                        //if (delNameService != null)
                        //    context.NameServices.RemoveRange(delNameService);

                        //------
                        //var delKindService = context.KindServices.ToList();
                        //if (delKindService != null)
                        //    context.KindServices.RemoveRange(delKindService);
                        //------
                        //var delKindKala = context.KindKalas.ToList();
                        //if (delKindKala != null)
                        //    context.KindKalas.RemoveRange(delKindKala);
                        //------
                        var delErsalNashode = context.ErsalNashode.ToList();
                        if (delErsalNashode != null)
                            context.ErsalNashode.RemoveRange(delErsalNashode);
                        //-----
                        var delManege = context.Manage.ToList();
                        if (delManege != null)
                            context.Manage.RemoveRange(delManege);
                        //-----

                        context.SaveChanges();
                        //-----------
                        First_Enter();
                        //Application.Restart();
                    }
                    else
                    {
                        Application.Exit();
                    }
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در بررسی سریال های نامساوی:\n" + ex.Message);
            }
        }

        public void End_Lablator()  //tamoom shodan mohlate test
        {
            try
            {
                    MessageBox.Show("زمان نسخه ازمایشی به اتمام رسید.برای استفاده از نرم افزار نیاز به فعال سازی دارید", "فعال سازی", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    strlblVersion.Text = "زمان تست برنامه به اتمام رسید";
                    toolCreateServiceToolStripMenuItem.Enabled = false;
                    toolToolsToolStripMenuItem.Enabled = false;
                    toolSearchToolStripMenuItem.Enabled = false;
                    toolSmsToolStripMenuItem.Enabled = false;
                    toolReports.Enabled = false;
                    toolBackupRestore.Enabled = false;
                    toolManageToolStripMenuItem1.Visible = false;
                    toolManagePriceToolStripMenuItem.Visible = false;
                    tooSettingApplication.Visible = true;                
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در نسخه آزماشی محلت تموم شده:\n" + ex.Message);
            }
        }

        public void Endnot_Lablator()  //noskhe azmayeshi
        {
            try
            {
                    strlblVersion.Text = "نسخه آزمایشی";
                    Accsess();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در نسخه آزماشی:\n" + ex.Message);
            }
        }

        public void Accsess()  //dastresiha
        {
            try
            {
                using (var context = new kitchenEntities())
                {
                    var Access = context.Manage.Where(current => current.UserName == stripLblLogin.Text).FirstOrDefault();
                    if (Access.NewService == "1")
                    {
                        toolCreateServiceToolStripMenuItem.Visible = false;
                    }
                    if(Access.Tools=="1")
                    {
                        toolToolsToolStripMenuItem.Visible = false;
                    }
                    if(Access.Search=="1")
                    {
                        toolSearchToolStripMenuItem.Visible = false;
                    }
                    if(Access.Sms=="1")
                    {
                        toolSmsToolStripMenuItem.Visible = false;
                    }
                    if(Access.Report=="1")
                    {
                        toolReports.Visible = false;
                    }
                    if(Access.Backup=="1")
                    {
                        toolBackupRestore.Visible = false;
                    }
                    if(Access.Setting=="1")
                    {
                        toolManageToolStripMenuItem.Visible = false;
                    }
                    //----
                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("خطا در دسترسی:\n" + ex.Message);
            }
        }

        //public string Reg_Code()
        //{
        //    string code="";
        //    //------
        //    StringBuilder alph = new StringBuilder();
        //    StringBuilder num = new StringBuilder();
        //    string serial = Get_Serial_Hard();

        //    if (serial.Length > 14)
        //        serial = serial.Substring(0, 15);
        //    foreach (char c in serial)

        //        if (char.IsDigit(c))
        //            num.Append(c);
        //        else
        //            alph.Append(c);
        //    string alph1 = alph.ToString();
        //    string num1 = num.ToString();

        //    int[] reg = new int[num1.Length];
        //    for (int i = 0; i < num1.Length; i++)
        //    {
        //        reg[i] = Int16.Parse(num1.Substring(i, 1));
        //    }

        //    for (int i = 0; i < num1.Length; i++)
        //    {
        //        reg[i] = reg[i] + 7;

        //    }
        //    Array.Reverse(reg);

        //    //test namayesh
        //    string show, compelet = "";
        //    for (int i = 0; i < num1.Length; i++)
        //    {
        //        show = "";
        //        show = reg[i].ToString();
        //        compelet = compelet + show;

        //    }
        //    //------------------
        //    //------
        //    code = compelet;
        //    return code;
        //}
        private void FormMain1_Load(object sender, EventArgs e)
        {
            //Active();
            try
            {
                //Accsess();
                using (var context = new kitchenEntities())
                {

                    var check = context.Reg.Where(c => c.State != "" || c.State != null).FirstOrDefault();

                    var white = context.WhiteSms.FirstOrDefault();
                    //var wh = context.WhiteSms.Where(a => a.W1 != null || a.W1 != "").ToList();
                    if (context.Reg.ToList().Count == 0 || context.Reg.ToList() == null)
                    {
                        First_Enter();
                        return;
                    }
                    if (check.State == IDGenerator.GetCPUId())
                    {
                        string reg = IDGenerator.GetOpenLock(IDGenerator.GetCPUId());
                        reg = reg + "8a1e98m";
                        string code = check.Serial1 + white.R11;
                        if (code == reg)
                        {
                            Active();
                            //FormSettings frmSetting = new FormSettings();
                            //frmSetting.txtRegister.Text = "نرم افزار فعال است";
                            //frmSetting.txtSerial.Enabled = false;
                            //frmSetting.txtRegister.Enabled = false;
                            //frmSetting.btnCreate.Enabled = false;
                            //frmSetting.btnSendRegisterCode.Enabled = false;
                            //frmSetting.btnRegisterInternet.Enabled = false;
                        }

                        else
                        {
                            if (check.CountOpen >= 100)
                            {
                                End_Lablator();
                            }
                            else
                            {
                                Endnot_Lablator();
                                check.CountOpen++;
                                frmManage = stripLblLogin.Text;
                                context.SaveChanges();
                            }
                        }
                    }
                    else
                    {
                        Active_NotEcoal();
                    }


                }
            }
            
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                //Application.Exit();
            }

        }



        private void tooSettingApplication_Click(object sender, EventArgs e)
        {
            FormSettings frmSetting2 = new FormSettings();
            frmSetting2.MdiParent = this;
            frmSetting2.Show();
            if (strlblVersion.Text == "برنامه کامل")
            {
                frmSetting2.txtRegister.Text = "نرم افزار فعال است";
                frmSetting2.txtSerial.Enabled = false;
                frmSetting2.txtRegister.Enabled = false;
                frmSetting2.btnCreate.Enabled = false;
                frmSetting2.btnSendRegisterCode.Enabled = false;
                frmSetting2.btnRegisterInternet.Enabled = false;
            }
        }

        private void toolSaveBackup_Click(object sender, EventArgs e)
        {

        }

        private void toolRecoverBackup_Click(object sender, EventArgs e)
        {

        }

        private void toolDate_Click(object sender, EventArgs e)
        {
            FormReports frmReports = new FormReports();
            frmReports.MdiParent = this;
            //**********
            frmReports.PanelDate.Visible = true;
            frmReports.PanelUser.Visible = false;
            //**********
            frmReports.Show();
        }

        private void toolReportUser_Click(object sender, EventArgs e)
        {
            FormReports frmReports = new FormReports();
            frmReports.MdiParent = this;
            //**********
            frmReports.label3.Text = "کل سفارشات:";
            frmReports.label4.Text = "کل پرداختی:";
            frmReports.PanelDate.Visible = false;
            frmReports.PanelUser.Visible = true;
            frmReports.txtEshterak.Focus();
            frmReports.PanelUser.Location = frmReports.PanelDate.Location;
            //**********
            frmReports.Show();
        }

        private void toolBackup_Click(object sender, EventArgs e)
        {
            FormBackup frmBackup = new FormBackup();
            frmBackup.MdiParent = this;
            frmBackup.Show();
        }

        private void toolRestore_Click(object sender, EventArgs e)
        {
            FormRestore frmRestore = new FormRestore();
            frmRestore.MdiParent = this;
            frmRestore.Show();
        }

        private void toolBirthDay_Click(object sender, EventArgs e)
        {
            FormBirthDay frmBirthday =new FormBirthDay();
            frmBirthday.Show();
        }

        private void toolToolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void FormMain1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
        }

        private void FormMain1_FormClosed(object sender, FormClosedEventArgs e)
        {
            log frmLog = new log();
            frmLog.Show();
        }
    }
}
