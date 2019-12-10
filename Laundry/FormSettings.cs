using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Laundry
{
    public partial class FormSettings : Form
    {
        public FormSettings()
        {
            InitializeComponent();
        }
        int key = 0;

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
        private void Enter_Number(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void btnCreate_Click(object sender, EventArgs e)
        {

            //------------------
            //******************
            if (txtName.Text == "")
            {
                txtName.BackColor = Color.LightPink;
                txtName.Focus();
                MessageBox.Show("مقدار نام تجاری و نام مدیر و شماره موبایل را باید وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                txtName.BackColor = Color.White;
            }
            //--------
            if (txtManageName.Text == "")
            {
                txtManageName.BackColor = Color.LightPink;
                txtManageName.Focus();
                MessageBox.Show("مقدار نام تجاری و نام مدیر و شماره موبایل را باید حتما وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            else
            {
                txtManageName.BackColor = Color.White;
            }
            //--------
            if (txtMobile.Text == "" || txtMobile.TextLength != 11)
            {
                txtMobile.BackColor = Color.LightPink;
                txtMobile.Focus();
                MessageBox.Show("شماره موبایل اشتباه است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                txtMobile.BackColor = Color.White;
            }
            //--baraye inke chek konad mobaile vared shode ba 09 shoroo mishavad ya na
            bool checkMobile = txtMobile.Text.StartsWith("09");
            if (checkMobile == false)
            {
                txtMobile.BackColor = Color.LightPink;
                txtMobile.Focus();
                MessageBox.Show("شماره موبایل اشتباه است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                txtMobile.BackColor = Color.White;
            }
            try
            {

                //************
                //**************
                if (txtRegister.Text == IDGenerator.GetOpenLock(IDGenerator.GetCPUId()))
                {
                    using (var context = new kitchenEntities())
                    {
                        var register = context.Reg.FirstOrDefault();
                        //string ser=txtRegister.Text+
                        register.Serial1 = txtRegister.Text;
                        context.SaveChanges();

                        MessageBox.Show("نرم افزار کامل فعال شد.سپاس از انتخاب شما", "فعال سازی", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        txtRegister.Text = "نرم افزار فعال است";
                        txtSerial.Enabled = false;
                        txtRegister.Enabled = false;
                        btnCreate.Enabled = false;
                        btnSendRegisterCode.Enabled = false;
                        btnRegisterInternet.Enabled = false;
                        //-------------
                        string message = "خشکشویی \n نام تجاری: " + txtName.Text + "\n نام مدیر : " + txtManageName.Text + "\n شماره تماس: " + txtMobile.Text + "\n سریال: " + txtSerial.Text + "\n فعال شد";

                        //--------
                        //System.Web.HttpUtility.HtmlDecode(text);
                        MessageBox.Show(message);
                        //string pattern = "http://login.parsgreen.com/UrlService/sendSMS.ashx?from=" + "10001000300076" + "&to=" + "09127173428" + "&text=" + message + "&signature=" + "8B0AA695-E750-4CB3-AF3E-98F9D03F06AC";
                        ////MessageBox.Show(pattern);
                        //System.IO.Stream st = null;
                        //System.IO.StreamReader sr = null;

                        //HttpWebRequest req = (HttpWebRequest)WebRequest.Create(pattern);
                        //Encoding encode = System.Text.Encoding.UTF8;

                        //System.Net.WebResponse resp = req.GetResponse();

                        //st = resp.GetResponseStream();
                        //sr = new System.IO.StreamReader(st, Encoding.UTF8);
                        //string result = sr.ReadToEnd().Substring(12, 1);
                        //sr.Close();
                        //resp.Close();
                        //-------------
                        Application.Restart();
                    }
                }
                else
                {
                    MessageBox.Show("کد فعال سازی اشتباه است", "فعال سازی", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtRegister.Text = "";
                    txtRegister.Focus();
                }

            }
            
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            //--------------------
            //*********************

            //txtName.Text = compelet;

        }

        //------

        //------
        private void FormSettings_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new kitchenEntities())
                {
                    var ser = context.Reg.FirstOrDefault();
                    if (ser == null)
                        return;
                    string serial = "";
                    if (ser.Serial1 == null || ser.Serial1 == "")
                        serial = "";
                    else
                        serial = ser.Serial1.ToString();
                    //if (serial.Length > 15)
                    //    serial = serial.Substring(0, 15);
                    txtSerial.Text = IDGenerator.GetCPUId() + "/" + ser.CountOpen + ser.Date;
                    //----------
                    var register = context.Reg.FirstOrDefault();
                    if (register.Serial1 == IDGenerator.GetOpenLock(IDGenerator.GetCPUId()))
                    {
                        txtRegister.Text = "نرم افزار فعال است";
                        txtSerial.Enabled = false;
                        txtRegister.Enabled = false;
                        btnCreate.Enabled = false;
                        btnSendRegisterCode.Enabled = false;
                        btnRegisterInternet.Enabled = false;
                    }
                    //FormMain1 frmMain = new FormMain1();

                    //if (frmMain.strlblVersion.Text== "برنامه کامل")
                    //{
                    //    txtRegister.Text = "نرم افزار فعال است";
                    //    txtSerial.Enabled = false;
                    //    txtRegister.Enabled = false;
                    //    btnCreate.Enabled = false;
                    //    btnSendRegisterCode.Enabled = false;
                    //    btnRegisterInternet.Enabled = false;
                    //}
                    //--------por kardane etelaate modir
                    var setting = context.Setting.FirstOrDefault();
                    //if (string.IsNullOrEmpty(setting.CommercialName))
                    //    txtName.Text = "";
                    //else
                    if (setting != null)
                    {
                        txtName.Text = setting.CommercialName;

                        txtManageName.Text = setting.ManageName;
                        txtMobile.Text = setting.Mobile;
                        txtTel.Text = setting.Tel;
                        txtEmail.Text = setting.Email;
                        txtAdress.Text = setting.Address;
                        //---------por kardane meghdare etelaate Sms
                        txtSignature.Text = setting.Signature;
                        txtNumberSms.Text = setting.NumberSms;
                        //----
                        if (setting.GroupSms == "true")
                            chxGroupSms.Checked = true;
                        if (setting.GroupSms == "false")
                            chxGroupSms.Checked = false;
                        //----
                        if (setting.WelcomeSms == "true")
                            chxWelcomeSms.Checked = true;
                        if (setting.WelcomeSms == "false")
                            chxWelcomeSms.Checked = false;
                        //----
                        if (setting.AcceptSms == "true")
                            chxAcceptSms.Checked = true;
                        if (setting.AcceptSms == "false")
                            chxAcceptSms.Checked = false;
                        //----
                        if (setting.ReadySms == "true")
                            chxReadySms.Checked = true;
                        if (setting.ReadySms == "false")
                            chxReadySms.Checked = false;
                        //----
                        if (setting.DeliverySms == "true")
                            chxDeliverySms.Checked = true;
                        if (setting.DeliverySms == "false")
                            chxDeliverySms.Checked = false;
                        //----
                        if (setting.BirthDaySms == "true")
                            chxBirthDaySms.Checked = true;
                        if (setting.BirthDaySms == "false")
                            chxBirthDaySms.Checked = false;
                    }
                    if (setting == null)
                    {
                        Setting set = new Setting();
                        set.CommercialName = "";

                        set.GroupSms = "true";
                        chxGroupSms.Checked = true;

                        set.WelcomeSms = "true";
                        chxWelcomeSms.Checked = true;

                        set.AcceptSms = "true";
                        chxAcceptSms.Checked = true;

                        set.ReadySms = "true";
                        chxReadySms.Checked = true;

                        set.DeliverySms = "true";
                        chxDeliverySms.Checked = true;

                        set.BirthDaySms = "true";
                        chxBirthDaySms.Checked = true;



                        context.Setting.Add(set);
                        context.SaveChanges();
                    }
                }
                //************ white sms
                using (var context = new kitchenEntities())
                {
                    var welcome = context.WhiteSms.Where(c => c.W1 != null || c.W1 != "").FirstOrDefault();
                    txtWelcome.Text = welcome.W1;
                    //-----
                    var accept = context.WhiteSms.Where(c => c.S1 != null || c.S1 != "").FirstOrDefault();
                    txtAccept.Text = accept.S1;
                    //-----
                    var ready = context.WhiteSms.Where(c => c.R1 != null || c.R1 != "").FirstOrDefault();
                    txtReady.Text = ready.R1;
                    //-----
                    var delivery = context.WhiteSms.Where(c => c.D1 != null || c.D1 != "").FirstOrDefault();
                    txtDelivery.Text = delivery.D1;

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            try
            {

                txtMoney.Text = "";
                PARSGREEN.API.SMS.Profile.ProfileService p = new PARSGREEN.API.SMS.Profile.ProfileService();
                double creidet = p.GetCredit(txtSignature.Text);
                if (creidet == -64)
                {
                    MessageBox.Show("امضا دیجیتال اشتباه است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                
                txtMoney.Text = creidet.ToString();
                //long cadir2 = Int64.Parse(txtMoney.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(txtName.Text=="")
            {
                txtName.BackColor = Color.LightPink;
                txtName.Focus();
                return;
            }
            else
            {
                txtName.BackColor = Color.White;
            }
            //--------
            if (txtManageName.Text == "")
            {
                txtManageName.BackColor = Color.LightPink;
                txtManageName.Focus();
                return;
            }
            else
            {
                txtManageName.BackColor = Color.White;
            }
            //--------
            if (txtMobile.Text == "" || txtMobile.TextLength!= 11)
            {
                txtMobile.BackColor = Color.LightPink;
                txtMobile.Focus();
                MessageBox.Show("شماره موبایل اشتباه است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                txtMobile.BackColor = Color.White;
            }
            try
            {
                using (var context = new kitchenEntities())
                {
                    var save = context.Setting.FirstOrDefault();
                    //var welcom = context.WhiteSms.Where(c => c.W1 != "" || c.W1 != null).FirstOrDefault();
                    //var service = context.WhiteSms.Where(c => c.S1 != "" || c.S1 != null).FirstOrDefault();
                    //var Ready = context.WhiteSms.Where(c => c.R1 != "" || c.R1 != null).FirstOrDefault();
                    //var Delivery = context.WhiteSms.Where(c => c.D1 != "" || c.D1 != null).FirstOrDefault();
                    //---------------bekhatere inke table faghat 1 record dashte bashad if gozashtam
                    if (save !=null)
                    {
                        //------------tarif etelaate foroshgah va modir
                        save.CommercialName = txtName.Text;
                        //welcom.W4 = txtName.Text;
                        //service.S11 = txtName.Text;
                        //Ready.R9 = txtName.Text;
                        save.ManageName = txtManageName.Text;
                        //Delivery.D9 = txtName.Text;
                        save.Mobile = txtMobile.Text;
                        save.Tel = txtTel.Text;
                        save.Email = txtEmail.Text;
                        save.Address = txtAdress.Text;
                        context.SaveChanges();
                        MessageBox.Show(" اطلاعات ویرایش شد", "وضعیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        Setting setting = new Setting();
                        //------------tarif etelaate foroshgah va modir
                        setting.CommercialName = txtName.Text;
                        setting.ManageName = txtManageName.Text;
                        setting.Mobile = txtMobile.Text;
                        setting.Tel = txtTel.Text;
                        setting.Email = txtEmail.Text;
                        setting.Address = txtAdress.Text;
                        //-----------tanzimate sms
                        setting.GroupSms = "true";
                        setting.WelcomeSms = "true";
                        setting.AcceptSms = "true";
                        setting.ReadySms = "true";
                        setting.DeliverySms = "true";
                        setting.BirthDaySms = "true";
                        setting.InviteClubeSms = "true";
                        //-----------------
                        context.Setting.Add(setting);
                        context.SaveChanges();
                        MessageBox.Show(" اطلاعات ثبت شد", "وضعیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveSing_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new kitchenEntities())
                {
                    var save = context.Setting.FirstOrDefault();
                    //---------------bekhatere inke table faghat 1 record dashte bashad if gozashtam
                    if (save != null)
                    {
                        save.Signature = txtSignature.Text;
                        context.SaveChanges();
                        MessageBox.Show(" امضا ویرایش شد", "وضعیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        Setting setting = new Setting();
                        setting.Signature = txtSignature.Text;
                        context.Setting.Add(setting);
                        context.SaveChanges();
                        MessageBox.Show(" امضا ثبت شد", "وضعیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveNumber_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new kitchenEntities())
                {
                    var save = context.Setting.FirstOrDefault();
                    //---------------bekhatere inke table faghat 1 record dashte bashad if gozashtam
                    if (save != null)
                    {
                        save.NumberSms = txtNumberSms.Text;
                        context.SaveChanges();
                        MessageBox.Show(" شماره ویرایش شد", "وضعیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        return;
                    }
                    else
                    {
                        Setting setting = new Setting();
                        setting.NumberSms = txtNumberSms.Text;
                        context.Setting.Add(setting);
                        context.SaveChanges();
                        MessageBox.Show(" شماره ثبت شد", "وضعیت", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void chxGroupSms_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new kitchenEntities())
                {
                    var setting = context.Setting.FirstOrDefault();
                    if (setting.GroupSms == "true")
                    {
                        setting.GroupSms = "false";
                        context.SaveChanges();

                        return;
                    }
                    else
                    {
                        setting.GroupSms = "true";
                        context.SaveChanges();

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void chxWelcomeSms_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new kitchenEntities())
                {
                    var setting = context.Setting.FirstOrDefault();
                    if (setting.WelcomeSms == "true")
                    {
                        setting.WelcomeSms = "false";
                        context.SaveChanges();

                        return;
                    }
                    else
                    {
                        setting.WelcomeSms = "true";
                        context.SaveChanges();

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void chxAcceptSms_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new kitchenEntities())
                {
                    var setting = context.Setting.FirstOrDefault();
                    if (setting.AcceptSms == "true")
                    {
                        setting.AcceptSms = "false";
                        context.SaveChanges();

                        return;
                    }
                    else
                    {
                        setting.AcceptSms = "true";
                        context.SaveChanges();

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void chxReadySms_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new kitchenEntities())
                {
                    var setting = context.Setting.FirstOrDefault();
                    if (setting.ReadySms == "true")
                    {
                        setting.ReadySms = "false";
                        context.SaveChanges();

                        return;
                    }
                    else
                    {
                        setting.ReadySms = "true";
                        context.SaveChanges();

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void chxDeliverySms_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new kitchenEntities())
                {
                    var setting = context.Setting.FirstOrDefault();
                    if (setting.DeliverySms == "true")
                    {
                        setting.DeliverySms = "false";
                        context.SaveChanges();

                        return;
                    }
                    else
                    {
                        setting.DeliverySms = "true";
                        context.SaveChanges();

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void chxBirthDaySms_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new kitchenEntities())
                {
                    var setting = context.Setting.FirstOrDefault();
                    if (setting.BirthDaySms == "true")
                    {
                        setting.BirthDaySms = "false";
                        context.SaveChanges();

                        return;
                    }
                    else
                    {
                        setting.BirthDaySms = "true";
                        context.SaveChanges();

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void chxInviteCluoeSms_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new kitchenEntities())
                {
                    var setting = context.Setting.FirstOrDefault();
                    if (setting.InviteClubeSms == "true")
                    {
                        setting.InviteClubeSms = "false";
                        context.SaveChanges();
                        return;
                    }
                    else
                    {
                        setting.InviteClubeSms = "true";
                        context.SaveChanges();

                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSendRegisterCode_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                txtName.BackColor = Color.LightPink;
                txtName.Focus();
                MessageBox.Show("مقدار نام تجاری و نام مدیر و شماره موبایل را باید وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                txtName.BackColor = Color.White;
            }
            //--------
            if (txtManageName.Text == "")
            {
                txtManageName.BackColor = Color.LightPink;
                txtManageName.Focus();
                MessageBox.Show("مقدار نام تجاری و نام مدیر و شماره موبایل را باید حتما وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            else
            {
                txtManageName.BackColor = Color.White;
            }
            //--------
            if (txtMobile.Text == "" || txtMobile.TextLength != 11)
            {
                txtMobile.BackColor = Color.LightPink;
                txtMobile.Focus();
                MessageBox.Show("شماره موبایل اشتباه است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                txtMobile.BackColor = Color.White;
            }
            //--baraye inke chek konad mobaile vared shode ba 09 shoroo mishavad ya na
            bool checkMobile = txtMobile.Text.StartsWith("09");
            if (checkMobile == false)
            {
                txtMobile.BackColor = Color.LightPink;
                txtMobile.Focus();
                MessageBox.Show("شماره موبایل اشتباه است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                txtMobile.BackColor = Color.White;
            }
            try
            {
                btnSendRegisterCode.Enabled = false;
                kitchenEntities context = new kitchenEntities();
                var countSmsRegister = context.WhiteSms.Where(c => c.Id == 1).FirstOrDefault();
                string count = countSmsRegister.R10;
                int reg = int.Parse(count);
                reg++;
                if (reg < 3)
                {
                    //PARSGREEN.API.SMS.Send.SendSMS send = new PARSGREEN.API.SMS.Send.SendSMS();
                    string message = "خشکشویی \n  تجاری:" + txtName.Text + "\n نام مدیر:" + txtManageName.Text + "\n شماره تماس:" + txtMobile.Text + "\n سریال: " + txtSerial.Text;

                    //int successCount = 0;
                    //int restStatus;
                    //string[] restr = null;
                    //restStatus = send.SendGroupSMS("8B0AA695-E750-4CB3-AF3E-98F9D03F06AC", "10001000300076", new string[] { "09127173428" }, message, false, string.Empty, ref successCount, ref restr);
                    //--------
                    //System.Web.HttpUtility.HtmlDecode(text);

                    string pattern = "http://login.parsgreen.com/UrlService/sendSMS.ashx?from=" + "10001000300076" + "&to=" + "09127173428" + "&text=" + message + "&signature=" + "8B0AA695-E750-4CB3-AF3E-98F9D03F06AC";

                    //MessageBox.Show(pattern);
                    System.IO.Stream st = null;
                    System.IO.StreamReader sr = null;

                    HttpWebRequest req = (HttpWebRequest)WebRequest.Create(pattern);
                    Encoding encode = System.Text.Encoding.UTF8;

                    System.Net.WebResponse resp = req.GetResponse();

                    st = resp.GetResponseStream();
                    sr = new System.IO.StreamReader(st, Encoding.UTF8);
                    string result = sr.ReadToEnd().Substring(12, 1);
                    //MessageBox.Show(sr.ReadToEnd()); //Get_Return_Message_Sms(int.Parse(result);
                    //MessageBox.Show( Get_Return_Message_Sms(int.Parse(result)));
                    sr.Close();
                    resp.Close();


                    //-------
                    if (result == "0")
                        MessageBox.Show("پیام فرستاده شد، پس از بررسی ،کد فعال سازی برای شما فرستاده میشود \n تشکر از صبر شما", "فعال سازی", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSendRegisterCode.Enabled = false;
                }
                else
                {
                    btnSendRegisterCode.Enabled = false;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void txtMobile_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);

        }

        private void txt11_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);

        }

        private void txt26_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);

        }

        private void txt28_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);

        }

        private void txt30_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);

        }

        private void txt32_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);

        }

        private void txt34_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);

        }

        private void txt36_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);

        }

        private void txt38_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);

        }

        private void txt2_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);

        }

        private void txt4_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);

        }

        private void txt6_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);

        }

        private void txt17_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);

        }

        private void txt19_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);

        }

        private void txt21_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);

        }

        private async void btnRegisterInternet_Click(object sender, EventArgs e)
        {
            Ping ping = new Ping();
            PingReply pingStatus = ping.Send("google.com");

            if (pingStatus.Status == IPStatus.Success)
            {
                string application = "Laundry",
                managename = txtManageName.Text,
                serial = txtSerial.Text,
                cammersialname = txtName.Text,
                state = "false",
                phone = txtMobile.Text,
                tel = txtTel.Text,
                email = txtEmail.Text,
                address = txtAdress.Text,
                Reagent = txtReagent.Text;

                Data_Importer Data = new Data_Importer();
                string data = await Data.GET("http://papiloo.ir/pyment/Papiloo/Insert.php", application, managename, serial, cammersialname, state, phone, tel, email, address, Reagent);
                //MessageBox.Show("ejra shod");
            }
            else
            {
                MessageBox.Show("اینترنت وصل نیست", "اینترنت", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //-------------------


        }

        private void txtWarningCreadit_Leave(object sender, EventArgs e)
        {
            try
            {
                using (var context = new kitchenEntities())
                {
                    var select = context.WhiteSms.FirstOrDefault();
                    select.R10 = txtWarningCreadit.Text;
                    context.SaveChanges();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("مشکل در هشدار اعتبار");
            }
        }

        private void txtWarningCreadit_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);

        }


        public void Save_WhiteSms(string text)
        {
            try
            {

                kitchenEntities context = new kitchenEntities();
                if (key == 1)
                {
                    var welcome = context.WhiteSms.Where(c => c.W1 != null || c.W1 != "").FirstOrDefault();
                    welcome.W1 = text;
                    context.SaveChanges();
                    return;
                }
                if (key == 2)
                {
                    var accept = context.WhiteSms.Where(c => c.S1 != null || c.S1 != "").FirstOrDefault();
                    accept.S1 = text;
                    context.SaveChanges();
                    return;
                }
                if (key == 3)
                {
                    var ready = context.WhiteSms.Where(c => c.R1 != null || c.R1 != "").FirstOrDefault();
                    ready.R1 = text;
                    context.SaveChanges();
                    return;
                }
                if (key == 4)
                {
                    var delivery = context.WhiteSms.Where(c => c.D1 != null || c.D1 != "").FirstOrDefault();
                    delivery.D1 = text;
                    context.SaveChanges();
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btnSaveWelcome_Click(object sender, EventArgs e)
        {
            key = 1;
            Save_WhiteSms(txtWelcome.Text);
            
        }

        private void btnSaveAccept_Click(object sender, EventArgs e)
        {
            key = 2;
            Save_WhiteSms(txtAccept.Text);
        }

        private void btnSaveReady_Click(object sender, EventArgs e)
        {
            key = 3;
            Save_WhiteSms(txtReady.Text);
        }

        private void btnSaveDelivery_Click(object sender, EventArgs e)
        {
            key = 4;
            Save_WhiteSms(txtDelivery.Text);
        }
    }
}
