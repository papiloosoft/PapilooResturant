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
        public void Welcome_white_Sms()
        {
            string darsad = "";
            string t1 = txt10.Text;
            //if (txt11.Text == "")
            //    txt11.Text = "0";
            //int x = int.Parse(txt11.Text);
            //for (int i = 0; i < x; i++)
            //    darsad = darsad + "%";
            if (chx9.Checked)
                darsad = "%% ";

            string t2 = darsad;
            string t3 = txt12.Text;
            string t4 = txt13.Text;
            string t5 = txt14.Text;
            string t6 = txt15.Text;
            string compelete = "";
            compelete = t1 + t2 + t3 + t4 + t5 + t6 + "%%";
            if (chxDate2.Checked == true)
                compelete = compelete + " تاریخ " + "%%";
            //compelete =compelete + "." + "%%%%%%%%%%";
            compelete = compelete + txtWel16.Text;
            txtTotall2.Text = compelete;
            lblTotall2.Text = txtTotall2.TextLength.ToString();
        }
        //*************
        public void Ready_white_Sms()
        {
            //string temp = "";
            //if (txt2.Text == "")
            //    txt2.Text = "0";
            //int y = int.Parse(txt2.Text);
            //for (int i = 0; i < y; i++)
            //    temp = temp + "%";
            //------
            string temp = "";
            if (chx6.Checked)
                temp = "%% ";
            //-----
            //string s1 = temp;

            //-------------
            //string temp2 = "";
            //if (txt4.Text == "")
            //    txt4.Text = "0";
            //int z = int.Parse(txt4.Text);
            //for (int i = 0; i < z; i++)
            //    temp2 = temp2 + "%";

            //string s2 = temp2;

            string temp2 = "";
            if (chx7.Checked)
                temp2 = "%%";
            //-------------
            //string temp3 = "";
            //if (txt6.Text == "")
            //    txt6.Text = "0";
            //int q = int.Parse(txt6.Text);
            //for (int i = 0; i < q; i++)
            //    temp3 = temp3 + "%";

            //string s3 = temp3;

            string temp3 = "";
            if (chx8.Checked)
                temp3 = "%%";

            //-------------

            //-------------
            string t1 = txt1.Text;
            string t2 = temp;
            string t3 = txt3.Text;
            string t4 = temp2;
            string t5 = txt5.Text;
            string t6 = temp3;
            string t7 = txt7.Text;
            string t8 = txt8.Text;
            string t9 = txt9.Text;
            
            string compelete;
            compelete = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9;
            if (chxDate1.Checked == true)
                compelete = compelete + " تاریخ " + "%%";
            string t11 = txtReadyt10.Text;
            compelete = compelete + t11;
            //compelete = compelete + "." + "%%%%%%%%%%";
            txtTotall1.Text = compelete;
            lblTotall1.Text = txtTotall1.TextLength.ToString();
        }
        //*************
        public void Delivery_white_Sms()
        {
            //string temp = "";
            //if (txt17.Text == "")
            //    txt17.Text = "0";
            //int y = int.Parse(txt17.Text);
            //for (int i = 0; i < y; i++)
            //    temp = temp + "%";

            //string s1 = temp;

            string temp = "";
            if (chx10.Checked)
                temp = "%% ";
            //-------------
            //string temp2 = "";
            //if (txt19.Text == "")
            //    txt19.Text = "0";
            //int z = int.Parse(txt19.Text);
            //for (int i = 0; i < z; i++)
            //    temp2 = temp2 + "%";

            //string s2 = temp2;

            string temp2 = "";
            if (chx11.Checked)
                temp2 = "%%";
            //-------------
            //string temp3 = "";
            //if (txt21.Text == "")
            //    txt21.Text = "0";
            //int q = int.Parse(txt21.Text);
            //for (int i = 0; i < q; i++)
            //    temp3 = temp3 + "%";

            //string s3 = temp3;

            string temp3 = "";
            if (chx12.Checked)
                temp3 = "%%";
            //-------------
            string t1 = txt16.Text;
            string t2 = temp;
            string t3 = txt18.Text;
            string t4 = temp2;
            string t5 = txt20.Text;
            string t6 = temp3;
            string t7 = txt22.Text;
            string t8 = txt23.Text;
            string t9 = txt24.Text;
            string compelete;
            compelete = t1 + t2 + t3 + t4 + t5 + t6 + t7 + t8 + t9;
            if (chxDate3.Checked == true)
                compelete = compelete + " تاریخ " + "%%";
            //compelete = compelete + "." + "%%%%%%%%%%";
            compelete = compelete + txtDel25.Text;
            txtTotall3.Text = compelete;
            lblTotall3.Text = txtTotall1.TextLength.ToString();
        }
        //*************
        public void Order_white_Sms()
        {
            //int i = 0;
            string t1 = txt25.Text;
            string temp = "";

            if (chx13.Checked)
                temp = " %% ";
            //---------
            string temp2 = "";
            if (chx1.Checked)
                temp2 = " %% ";

            //---------

            string temp7 = "";
            string t7 = txt37.Text;

            //for (i = 0; i < int.Parse(txt38.Text); i++)
            //    temp7 = temp7 + "%";

            if (chx14.Checked)
                temp7 = "%% ";
            //---------
            string t8 = txt39.Text;
            //---------
            string t9 = txt40.Text;
            //---------
            string t10 = txt41.Text;
            //-------
            string compelete = t1 + temp + t7 + temp2 + t8 + temp7 + t9 + t10;
            if (chxDate4.Checked == true)
                compelete = compelete + " تاریخ " + "%%";
            //compelete = compelete +"."+ "%%%%%%%%%%";
            compelete = compelete + txt42.Text;
            txtTotall4.Text = compelete;
            lblTotall4.Text = txtTotall4.TextLength.ToString();
            
        }
        //**************
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
                    txtSerial.Text = IDGenerator.GetCPUId()+"/"+ser.CountOpen+ser.Date;
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
                        if (setting.InviteClubeSms == "true")
                            chxInviteCluoeSms.Checked = true;
                        if (setting.InviteClubeSms == "false")
                            chxInviteCluoeSms.Checked = false;
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

                        set.InviteClubeSms = "true";
                        chxInviteCluoeSms.Checked = true;

                        context.Setting.Add(set);
                        context.SaveChanges();
                    }
                }
                //----------
                //************ white sms welcome
                //Welcome_white_Sms();
                using (var context = new kitchenEntities())
                {
                    var smsWlecome = context.WhiteSms.Where(c =>c.W1 !=null && c.W1 !="").FirstOrDefault();
                    txtWarningCreadit.Text = smsWlecome.R10;
                    //************
                    txt10.Text = smsWlecome.W1;
                    txt12.Text = smsWlecome.W3;
                    txt13.Text = txtName.Text;
                    txt14.Text = smsWlecome.W5;
                    txt15.Text = smsWlecome.W6;
                    txtWel16.Text = smsWlecome.W9;
                    string date = "";
                    if (smsWlecome.W8 != "")
                    {
                        date = " تاریخ " + "%%";
                        chxDate2.Checked = true;
                    }
                    string w2 = "";
                    if(smsWlecome.W2 !="")
                    {
                        w2 = smsWlecome.W2;
                        chx9.Checked = true;
                    }
                    txtTotall2.Text = txt10.Text + w2 + txt12.Text + txt13.Text + txt14.Text + txt15.Text + date + txtWel16.Text;
                }
                lbl10.Text = txt10.TextLength.ToString();
                lbl12.Text = txt12.TextLength.ToString();
                //txt13.Text = txtName.Text;
                lbl13.Text = txt13.TextLength.ToString();
                lbl14.Text = txt14.TextLength.ToString();
                lbl15.Text = txt15.TextLength.ToString();
                //**************
                //**************white sms Ready
                //Ready_white_Sms();
                using (var context = new kitchenEntities())
                {
                    var smsWlecome = context.WhiteSms.Where(c => c.R1 != null && c.R1 != "").FirstOrDefault();
                    txt1.Text = smsWlecome.R1;
                    txt3.Text = smsWlecome.R3;
                    txt5.Text = smsWlecome.R5;
                    txt7.Text = smsWlecome.R7;
                    txt8.Text = smsWlecome.R8;
                    txt9.Text = txtName.Text;
                    txtReadyt10.Text = smsWlecome.R11;
                    string date = "";
                    if (smsWlecome.R10 != "")
                    {
                        date = " تاریخ " + "%%";
                        chxDate1.Checked = true;
                    }
                    //-----
                    string R2 = "";
                    if (smsWlecome.R2 != "")
                    {
                        R2 = smsWlecome.R2;
                        chx6.Checked = true;
                    }
                    //-----
                    string R4 = "";
                    if (smsWlecome.R4 != "")
                    {
                        R4 = smsWlecome.R4;
                        chx7.Checked = true;
                    }
                    //-----
                    string R6 = "";
                    if (smsWlecome.R6 != "")
                    {
                        R6 = smsWlecome.R6;
                        chx8.Checked = true;
                    }
                    txtTotall1.Text = txt1.Text + R2 + txt3.Text + R4 + txt5.Text + R6 + txt7.Text + txt8.Text + txt9.Text + date + txtReadyt10.Text;
                }
                    //-------------
                lbl1.Text = txt1.TextLength.ToString();
                lbl3.Text = txt3.TextLength.ToString();
                lbl5.Text = txt5.TextLength.ToString();
                lbl7.Text = txt7.TextLength.ToString();
                lbl8.Text = txt8.TextLength.ToString();
                //txt9.Text = txtName.Text;
                lbl9.Text = txt9.TextLength.ToString();
                label27.Text = txtReadyt10.TextLength.ToString();

                //****************deliveri white sms
                using (var context = new kitchenEntities())
                {
                    var smsWlecome = context.WhiteSms.Where(c => c.D1 != null && c.D1 != "").FirstOrDefault();
                    txt16.Text = smsWlecome.D1;
                    txt18.Text = smsWlecome.D3;
                    txt20.Text = smsWlecome.D5;
                    txt22.Text = smsWlecome.D7;
                    txt23.Text = smsWlecome.D8;
                    txt24.Text = txtName.Text;
                    txtDel25.Text = smsWlecome.D11;
                    string date = "";
                    if (smsWlecome.D10 != "")
                    {
                        date = " تاریخ " + "%%";
                        chxDate3.Checked = true;
                    }
                    //-----
                    string D2 = "";
                    if (smsWlecome.D2 != "")
                    {
                        D2 = smsWlecome.D2;
                        chx10.Checked = true;
                    }
                    //-----
                    string D4 = "";
                    if (smsWlecome.D4 != "")
                    {
                        D4 = smsWlecome.D4;
                        chx11.Checked = true;
                    }
                    //-----
                    string D6 = "";
                    if (smsWlecome.D6 != "")
                    {
                        D6 = smsWlecome.D6;
                        chx12.Checked = true;
                    }
                    txtTotall3.Text = txt16.Text + D2 + txt18.Text + D4 + txt20.Text + D6 + txt22.Text + txt23.Text + txt24.Text + date + txtDel25.Text;
                }
                lbl16.Text = txt16.TextLength.ToString();
                lbl18.Text = txt18.TextLength.ToString();
                lbl20.Text = txt20.TextLength.ToString();
                lbl22.Text = txt22.TextLength.ToString();
                lbl23.Text = txt23.TextLength.ToString();
                //txt24.Text = txtName.Text;
                lbl24.Text = txt24.TextLength.ToString();
                label28.Text = txtDel25.TextLength.ToString();
                //---------------
                //*************order white sms
                //Order_white_Sms();

                using (var context = new kitchenEntities())
                {
                    var smsWlecome = context.WhiteSms.Where(c => c.S1 != null && c.S1 != "").FirstOrDefault();
                    txt25.Text = smsWlecome.S1;
                    txt37.Text = smsWlecome.S3;
                    txt39.Text = smsWlecome.S8;
                    txt40.Text = smsWlecome.S10;
                    txt41.Text = txtName.Text;
                    txt42.Text = smsWlecome.S13;
                    string date = "";
                    if (smsWlecome.S12 != "")
                    {
                        date = " تاریخ " + "%%";
                        chxDate4.Checked = true;
                    }
                    //-----
                    string S2 = "";
                    if (smsWlecome.S2 != "")
                    {
                        S2 = smsWlecome.S2;
                        chx13.Checked = true;
                    }
                    //-----
                    string S3 = "";
                    if (smsWlecome.S3 != "")
                    {
                        S3 = smsWlecome.S3;
                        chx1.Checked = true;
                    }
                    //-----
                    string S9 = "";
                    if (smsWlecome.S9 != "")
                    {
                        S9 = smsWlecome.S9;
                        chx14.Checked = true;
                    }
                    string S7 = "";
                    if (smsWlecome.S7 != "")
                    {
                        S7 = smsWlecome.S7;
                        chx1.Checked = true;
                    }
                    txtTotall4.Text = txt25.Text + S2 + txt37.Text + S7 + txt39.Text + S9 + txt40.Text + txt41.Text + date + txt42.Text;
                    //txtTotall4.Text = txt25.Text + S2 + S3+S7 + S8 + txt39.Text + txt40.Text + txt41.Text + date + txt42.Text;
                }
                lbl25.Text = txt25.TextLength.ToString();
                lbl37.Text = txt37.TextLength.ToString();
                lbl39.Text = txt39.TextLength.ToString();
                lbl40.Text = txt40.TextLength.ToString();
                txt41.Text = txtName.Text;
                lbl41.Text = txt41.TextLength.ToString();
                label25.Text = txt42.Text.Length.ToString();
                lblTotall4.Text = txtTotall4.TextLength.ToString();


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
            if (checkMobile==false)
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

        private void lblSomeCom2_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void txt1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNameLaundry_TextChanged(object sender, EventArgs e)
        {
            lbl13.Text = txt13.TextLength.ToString();
            //--------
            Welcome_white_Sms();

        }

        private void txt4_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt5_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt6_TextChanged(object sender, EventArgs e)
        {


        }

        private void txtTotall_TextChanged(object sender, EventArgs e)
        {
            lblTotall2.Text = txtTotall2.TextLength.ToString();
        }

        private void txt10_TextChanged(object sender, EventArgs e)
        {
            lbl10.Text = txt10.TextLength.ToString();
            //----------
            Welcome_white_Sms();
        }

        private void txt11_TextChanged(object sender, EventArgs e)
        {
            Welcome_white_Sms();
            //----------

        }

        private void txt12_TextChanged(object sender, EventArgs e)
        {
            lbl12.Text = txt12.TextLength.ToString();
            //--------
            Welcome_white_Sms();
        }

        private void txt13_TextChanged(object sender, EventArgs e)
        {
            lbl13.Text = txt13.TextLength.ToString();
            //--------
            Welcome_white_Sms();
        }

        private void txt14_TextChanged(object sender, EventArgs e)
        {
            lbl14.Text = txt14.TextLength.ToString();
            //--------
            Welcome_white_Sms();
        }

        private void txt15_TextChanged(object sender, EventArgs e)
        {
            lbl15.Text = txt15.TextLength.ToString();
            //---------
            Welcome_white_Sms();
        }

        private void txtTotall2_TextChanged(object sender, EventArgs e)
        {
            lblTotall2.Text = txt12.TextLength.ToString();
            //--------
            Welcome_white_Sms();
        }

        private void txt1_TextChanged_1(object sender, EventArgs e)
        {
            lbl1.Text = txt1.TextLength.ToString();
            //------------
            Ready_white_Sms();
        }

        private void txt2_TextChanged_1(object sender, EventArgs e)
        {
            Ready_white_Sms();
        }

        private void txt3_TextChanged(object sender, EventArgs e)
        {
            lbl3.Text = txt3.TextLength.ToString();
            //------------
            Ready_white_Sms();
        }

        private void txt4_TextChanged_1(object sender, EventArgs e)
        {
            lbl1.Text = txt1.TextLength.ToString();
            //------------
            Ready_white_Sms();
        }

        private void txt5_TextChanged_1(object sender, EventArgs e)
        {
            lbl5.Text = txt5.TextLength.ToString();
            //------------
            Ready_white_Sms();
        }

        private void txt6_TextChanged_1(object sender, EventArgs e)
        {
            Ready_white_Sms();
        }

        private void txt7_TextChanged(object sender, EventArgs e)
        {
            lbl7.Text = txt7.TextLength.ToString();
            //------------
            Ready_white_Sms();
        }

        private void txt8_TextChanged(object sender, EventArgs e)
        {
            lbl8.Text = txt8.TextLength.ToString();
            //------------
            Ready_white_Sms();
        }

        private void txt9_TextChanged(object sender, EventArgs e)
        {
            lbl9.Text = txt9.TextLength.ToString();
            //------------
            Ready_white_Sms();
        }
        private void txtTotall1_TextChanged(object sender, EventArgs e)
        {
            lblTotall1.Text = txtTotall1.TextLength.ToString();
        }

        private void chxDate2_CheckedChanged(object sender, EventArgs e)
        {
            Welcome_white_Sms();
        }

        private void chxDate1_CheckedChanged(object sender, EventArgs e)
        {
            Ready_white_Sms();
        }

        private void txt16_TextChanged(object sender, EventArgs e)
        {
            lbl16.Text = txt16.TextLength.ToString();
            //--------
            Delivery_white_Sms();
        }

        private void txt17_TextChanged(object sender, EventArgs e)
        {
            Delivery_white_Sms();
        }

        private void txt18_TextChanged(object sender, EventArgs e)
        {
            lbl18.Text = txt18.TextLength.ToString();
            //--------
            Delivery_white_Sms();
        }

        private void txt19_TextChanged(object sender, EventArgs e)
        {
            Delivery_white_Sms();
        }

        private void txt20_TextChanged(object sender, EventArgs e)
        {
            lbl20.Text = txt20.TextLength.ToString();
            //--------
            Delivery_white_Sms();
        }

        private void txt21_TextChanged(object sender, EventArgs e)
        {
            Delivery_white_Sms();
        }

        private void txt22_TextChanged(object sender, EventArgs e)
        {
            lbl22.Text = txt22.TextLength.ToString();
            //--------
            Delivery_white_Sms();
        }

        private void txt23_TextChanged(object sender, EventArgs e)
        {
            lbl23.Text = txt23.TextLength.ToString();
            //--------
            Delivery_white_Sms();
        }

        private void txt24_TextChanged(object sender, EventArgs e)
        {
            lbl24.Text = txt24.TextLength.ToString();
            //--------
            Delivery_white_Sms();
        }

        private void chxDate3_CheckedChanged(object sender, EventArgs e)
        {
            Delivery_white_Sms();
        }

        private void txtTotall3_TextChanged(object sender, EventArgs e)
        {
            lblTotall3.Text = txtTotall3.TextLength.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            lbl37.Text = txt37.TextLength.ToString();
            Order_white_Sms();

        }

        private void tabOrderWhiteSms_Click(object sender, EventArgs e)
        {

        }

        private void chx1_CheckedChanged(object sender, EventArgs e)
        {
            Order_white_Sms();
        }

        private void txt27_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txt25_TextChanged(object sender, EventArgs e)
        {
            lbl25.Text = txt25.TextLength.ToString();
            Order_white_Sms();

        }

        private void txt26_TextChanged(object sender, EventArgs e)
        {
            Order_white_Sms();

        }

        private void txt28_TextChanged(object sender, EventArgs e)
        {
            Order_white_Sms();

        }

        private void txt29_TextChanged(object sender, EventArgs e)
        {


        }

        private void txt30_TextChanged(object sender, EventArgs e)
        {
            Order_white_Sms();

        }

        private void chx2_CheckedChanged(object sender, EventArgs e)
        {
            Order_white_Sms();

        }

        private void chx3_CheckedChanged(object sender, EventArgs e)
        {
            Order_white_Sms();

        }

        private void txt31_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void txt32_TextChanged(object sender, EventArgs e)
        {
            Order_white_Sms();

        }

        private void chx4_TextChanged(object sender, EventArgs e)
        {
            Order_white_Sms();

        }

        private void txt33_TextChanged(object sender, EventArgs e)
        {
           

        }

        private void txt34_TextChanged(object sender, EventArgs e)
        {
            Order_white_Sms();

        }

        private void chx5_TextChanged(object sender, EventArgs e)
        {
            Order_white_Sms();

        }

        private void txt36_TextChanged(object sender, EventArgs e)
        {
            Order_white_Sms();

        }

        private void txt38_TextChanged(object sender, EventArgs e)
        {
            Order_white_Sms();

        }

        private void txt39_TextChanged(object sender, EventArgs e)
        {
            lbl39.Text = txt39.TextLength.ToString();
            Order_white_Sms();

        }

        private void txt40_TextChanged(object sender, EventArgs e)
        {
            lbl40.Text = txt40.TextLength.ToString();
            Order_white_Sms();

        }

        private void txt41_TextChanged(object sender, EventArgs e)
        {
            lbl41.Text = txt41.TextLength.ToString();
            Order_white_Sms();

        }

        private void chxDate4_TextChanged(object sender, EventArgs e)
        {
            Order_white_Sms();

        }

        private void txtTotall4_TextChanged(object sender, EventArgs e)
        {
            lblTotall4.Text = txtTotall4.TextLength.ToString();
            //Order_white_Sms();

        }

        private void chx3_TextChanged(object sender, EventArgs e)
        {
            lblTotall4.Text = txtTotall4.TextLength.ToString();
            Order_white_Sms();

        }

        private void chx4_CheckedChanged(object sender, EventArgs e)
        {
            Order_white_Sms();

        }

        private void chx5_CheckedChanged(object sender, EventArgs e)
        {
            Order_white_Sms();

        }

        private void chxDate4_CheckedChanged(object sender, EventArgs e)
        {
            Order_white_Sms();

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

        private void btnSaveEdit2_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new kitchenEntities())
                {
                    var exist = context.WhiteSms.Where(c => c.W1 != null && c.W1 != "").FirstOrDefault();
                    if (exist != null)
                    {
                        string darsad = "";
                        string t1 = txt10.Text;
                        //if (txt11.Text == "")
                        //    txt11.Text = "0";
                        //int x = int.Parse(txt11.Text);
                        //for (int i = 0; i < x; i++)
                        //    darsad = darsad + "%";

                        if (chx9.Checked)
                            darsad = "%%";

                        string t2 = darsad;
                        string t3 = txt12.Text;
                        string t4 = txt13.Text;
                        string t5 = txt14.Text;
                        string t6 = txt15.Text;
                        string t7 = "%%"+".";
                        string compelete = "";
                        if (chxDate2.Checked == true)
                            compelete = compelete + " تاریخ " + "%%";
                        else
                            exist.W8 = "";
                        //compelete = compelete + "." + "%%%%%%%%%%";
                        //------
                        exist.W1 = t1;
                        exist.W2 = t2;
                        exist.W3 = t3;
                        exist.W4 = t4;
                        exist.W5 = t5;
                        exist.W6 = t6;
                        exist.W7 = t7;
                        exist.W8 = compelete;
                        exist.W9 = txtWel16.Text;

                    }
                    else
                    {
                        WhiteSms st = new WhiteSms();
                        string darsad = "";
                        string t1 = txt10.Text;
                        if (txt11.Text == "")
                            txt11.Text = "0";
                        int x = int.Parse(txt11.Text);
                        for (int i = 0; i < x; i++)
                            darsad = darsad + "%";

                        string t2 = darsad;
                        string t3 = txt12.Text;
                        string t4 = txt13.Text;
                        string t5 = txt14.Text;
                        string t6 = txt15.Text;
                        string t7= "%%%%%";
                        string compelete = "";
                        compelete = compelete + " تاریخ " + "%%";
                        //compelete = compelete + "." + "%%%%%%%%%%";
                        //-----
                        st.W1 = t1;
                        st.W2 = t2;
                        st.W3 = t3;
                        st.W4 = t4;
                        st.W5 = t5;
                        st.W6 = t6;
                        st.W7 = t7;
                        st.W8 = compelete;
                        st.W9 = txtWel16.Text;
                        context.WhiteSms.Add(st);
                        
                    }
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveEdit4_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new kitchenEntities())
                {
                    var exist = context.WhiteSms.Where(c => c.S1 != null && c.S1 != "").FirstOrDefault();
                    if (exist != null)
                    {
                        //int i = 0;
                        string t1 = txt25.Text;
                        string temp = "";

                        if (chx13.Checked)
                            temp = " %% ";
                        //---------
                        string temp2 = "";
                        if (chx1.Checked)
                            temp2 = " %% ";

                        //---------

                        
                        string t7 = txt37.Text;

                        //for (i = 0; i < int.Parse(txt38.Text); i++)
                        //    temp7 = temp7 + "%";
                        string temp7 = "";
                        if (chx14.Checked)
                            temp7 = "%% ";
                        //---------
                        string t8 = txt39.Text;
                        //---------
                        string t9 = txt40.Text;
                        //---------
                        string t10 = txt41.Text;
                        //-------
                        string compelete = t1 + temp + t7 + temp2 + t8 + temp7 + t9 + t10;
                        string Date = "";
                        if (chxDate4.Checked == true)
                        {
                             Date = " تاریخ " + "%%";
                            compelete=compelete + Date;
                        }
                        compelete = compelete + txt42.Text;
                        //-------
                        //string compelete = t1 + temp + t2 + temp2 + t3 + temp3 + t4 + temp4 + t5 +
                        //    temp5 + t6 + temp6 + t7 + temp7 + t8 + t9 + t10;

                        //compelete = compelete +"."+ "%%%%%%%%%%";
                        exist.S1 = t1;
                        exist.S2 = temp;
                        exist.S3 = t7;
                        
                        exist.S7 = temp2;
                        exist.S8 = t8;
                        exist.S9 = temp7;
                        exist.S10 = t9;
                        exist.S11 = t10;
                        exist.S12 = Date;
                        exist.S13 = txt42.Text;
                        txtTotall4.Text = compelete;
                        lblTotall4.Text = txtTotall4.TextLength.ToString();
                    }
                    else
                    {
                        WhiteSms st = new WhiteSms();
                        //int i = 0;
                        string t1 = txt25.Text;
                        string temp = "";

                        if (chx13.Checked)
                            temp = " %% ";
                        //---------
                        string temp2 = "";
                        if (chx1.Checked)
                            temp2 = " %% ";

                        //---------

                        string temp7 = "";
                        string t7 = txt37.Text;

                        //for (i = 0; i < int.Parse(txt38.Text); i++)
                        //    temp7 = temp7 + "%";

                        if (chx14.Checked)
                            temp7 = "%% ";
                        //---------
                        string t8 = txt39.Text;
                        //---------
                        string t9 = txt40.Text;
                        //---------
                        string t10 = txt41.Text;
                        //-------
                        string compelete = t1 + temp + t7 + temp2 + t8 + temp7 + t9 + t10;
                        string Date = "";
                        if (chxDate4.Checked == true)
                        {
                            Date = " تاریخ " + "%%";
                            compelete = compelete + Date;
                        }
                        //-------
                        //string compelete = t1 + temp + t2 + temp2 + t3 + temp3 + t4 + temp4 + t5 +
                        //    temp5 + t6 + temp6 + t7 + temp7 + t8 + t9 + t10;

                        //compelete = compelete +"."+ "%%%%%%%%%%";
                        st.S1 = t1;
                        st.S2 = temp;
                        st.S3 = t7;

                        st.S7 = temp2;
                        st.S8 = t8;
                        st.S9 = temp7;
                        st.S10 = t9;
                        st.S11 = t10;
                        st.S12 = Date;
                        st.S13 = txt42.Text;
                        context.WhiteSms.Add(st);
                        txtTotall4.Text = compelete;
                        lblTotall4.Text = txtTotall4.TextLength.ToString();
                    }
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveEdit1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new kitchenEntities())
                {
                    var exist = context.WhiteSms.Where(c => c.R1 != null && c.R1 != "").FirstOrDefault();
                    if (exist != null)
                    {
                        //string temp = "";
                        //if (txt2.Text == "")
                        //    txt2.Text = "0";
                        //int y = int.Parse(txt2.Text);
                        //for (int i = 0; i < y; i++)
                        //    temp = temp + "%";
                        //------
                        string temp = "";
                        if (chx6.Checked)
                             temp = "%%";
                        //-----
                        //string s1 = temp;

                        //-------------
                        //string temp2 = "";
                        //if (txt4.Text == "")
                        //    txt4.Text = "0";
                        //int z = int.Parse(txt4.Text);
                        //for (int i = 0; i < z; i++)
                        //    temp2 = temp2 + "%";

                        //string s2 = temp2;

                        string temp2 = "";
                        if (chx7.Checked)
                            temp2 = "%%";
                        //-------------
                        //string temp3 = "";
                        //if (txt6.Text == "")
                        //    txt6.Text = "0";
                        //int q = int.Parse(txt6.Text);
                        //for (int i = 0; i < q; i++)
                        //    temp3 = temp3 + "%";

                        //string s3 = temp3;

                        string temp3 = "";
                        if (chx8.Checked)
                            temp3 = "%%";

                        //-------------
                        string t1 = txt1.Text;
                        string t2 = temp;
                        string t3 = txt3.Text;
                        string t4 = temp2;
                        string t5 = txt5.Text;
                        string t6 = temp3;
                        string t7 = txt7.Text;
                        string t8 = txt8.Text;
                        string t9 = txt9.Text;
                        string t11 = txtReadyt10.Text;
                        string Date="";
                        if (chxDate1.Checked == true)
                            Date = " تاریخ " + "%%";
                        //compelete = compelete + "." + "%%%%%%%%%%";
                        exist.R1 = t1;
                        exist.R2 = t2;
                        exist.R3 = t3;
                        exist.R4 = t4;
                        exist.R5 = t5;
                        exist.R6 = t6;
                        exist.R7 = t7;
                        exist.R8 = t8;
                        exist.R9 = t9;
                        exist.R10 = Date;
                        exist.R11 = t11;
                    }
                    else
                    {
                        WhiteSms st = new WhiteSms();
                        //string temp = "";
                        //if (txt2.Text == "")
                        //    txt2.Text = "0";
                        //int y = int.Parse(txt2.Text);
                        //for (int i = 0; i < y; i++)
                        //    temp = temp + "%";

                        //string s1 = temp;

                        string temp = "";
                        if (chx6.Checked)
                            temp = "%%";

                        //-------------
                        //string temp2 = "";
                        //if (txt4.Text == "")
                        //    txt4.Text = "0";
                        //int z = int.Parse(txt4.Text);
                        //for (int i = 0; i < z; i++)
                        //    temp2 = temp2 + "%";

                        //string s2 = temp2;

                        string temp2 = "";
                        if (chx7.Checked)
                            temp2 = "%%";

                        //-------------
                        //string temp3 = "";
                        //if (txt6.Text == "")
                        //    txt6.Text = "0";
                        //int q = int.Parse(txt6.Text);
                        //for (int i = 0; i < q; i++)
                        //    temp3 = temp3 + "%";

                        //string s3 = temp3;

                        string temp3 = "";
                        if (chx8.Checked)
                            temp3 = "%%";

                        //-------------
                        string t1 = txt1.Text;
                        string t2 = temp;
                        string t3 = txt3.Text;
                        string t4 = temp2;
                        string t5 = txt5.Text;
                        string t6 = temp3;
                        string t7 = txt7.Text;
                        string t8 = txt8.Text;
                        string t9 = txt9.Text;
                        string t11 = txtReadyt10.Text;
                        string date = "";
                        if (chxDate1.Checked == true)
                            date =" تاریخ " + "%%";
                        //compelete = compelete + "." + "%%%%%%%%%%";

                        st.R1 = t1;
                        st.R2 = t2;
                        st.R3 = t3;
                        st.R4 = t4;
                        st.R5 = t5;
                        st.R6 = t6;
                        st.R7 = t7;
                        st.R8 = t8;
                        st.R9 = t9;
                        st.R10 = date;
                        st.R11 = t11;
                        context.WhiteSms.Add(st);

                    }
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveEdit3_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new kitchenEntities())
                {
                    var exist = context.WhiteSms.Where(c => c.D1 != null && c.D1 != "").FirstOrDefault();
                    if (exist != null)
                    {
                        //string temp = "";
                        //if (txt17.Text == "")
                        //    txt17.Text = "0";
                        //int y = int.Parse(txt17.Text);
                        //for (int i = 0; i < y; i++)
                        //    temp = temp + "%";

                        //string s1 = temp;

                        string temp = "";
                        if (chx10.Checked)
                            temp = "%%";
                        //-------------
                        //string temp2 = "";
                        //if (txt19.Text == "")
                        //    txt19.Text = "0";
                        //int z = int.Parse(txt19.Text);
                        //for (int i = 0; i < z; i++)
                        //    temp2 = temp2 + "%";

                        //string s2 = temp2;

                        string temp2 = "";
                        if (chx11.Checked)
                            temp2 = "%%";
                        //-------------
                        //string temp3 = "";
                        //if (txt21.Text == "")
                        //    txt21.Text = "0";
                        //int q = int.Parse(txt21.Text);
                        //for (int i = 0; i < q; i++)
                        //    temp3 = temp3 + "%";

                        //string s3 = temp3;

                        string temp3 = "";
                        if (chx12.Checked)
                            temp3 = "%%";
                        //-------------
                        string t1 = txt16.Text;
                        string t2 = temp;
                        string t3 = txt18.Text;
                        string t4 = temp2;
                        string t5 = txt20.Text;
                        string t6 = temp3;
                        string t7 = txt22.Text;
                        string t8 = txt23.Text;
                        string t9 = txt24.Text;
                        string date = "";
                        string t11 = txtDel25.Text;
                        if (chxDate3.Checked == true)
                            date = " تاریخ " + "%%";
                        //compelete = compelete + "." + "%%%%%%%%%%";
                        exist.D1 = t1;
                        exist.D2 = t2;
                        exist.D3 = t3;
                        exist.D4 = t4;
                        exist.D5 = t5;
                        exist.D6 = t6;
                        exist.D7 = t7;
                        exist.D8 = t8;
                        exist.D9 = t9;
                        exist.D10 = date;
                        exist.D11 = t11;

                    }
                    else
                    {
                        WhiteSms st = new WhiteSms();
                        //string temp = "";
                        //if (txt17.Text == "")
                        //    txt17.Text = "0";
                        //int y = int.Parse(txt17.Text);
                        //for (int i = 0; i < y; i++)
                        //    temp = temp + "%";

                        //string s1 = temp;


                        string temp = "";
                        if (chx10.Checked)
                            temp = "%%";
                        //-------------
                        //string temp2 = "";
                        //if (txt19.Text == "")
                        //    txt19.Text = "0";
                        //int z = int.Parse(txt19.Text);
                        //for (int i = 0; i < z; i++)
                        //    temp2 = temp2 + "%";

                        //string s2 = temp2;


                        string temp2 = "";
                        if (chx11.Checked)
                            temp2 = "%%";
                        //-------------
                        //string temp3 = "";
                        //if (txt21.Text == "")
                        //    txt21.Text = "0";
                        //int q = int.Parse(txt21.Text);
                        //for (int i = 0; i < q; i++)
                        //    temp3 = temp3 + "%";

                        //string s3 = temp3;

                        string temp3 = "";
                        if (chx12.Checked)
                            temp3 = "%%";

                        //-------------
                        string t1 = txt16.Text;
                        string t2 = temp;
                        string t3 = txt18.Text;
                        string t4 = temp2;
                        string t5 = txt20.Text;
                        string t6 = temp3;
                        string t7 = txt22.Text;
                        string t8 = txt23.Text;
                        string t9 = txt24.Text;
                        string t11 = txtDel25.Text;
                        string date = "";
                        if (chxDate3.Checked == true)
                            date = " تاریخ " + "%%";
                        //compelete = compelete + "." + "%%%%%%%%%%";
                        st.D1 = t1;
                        st.D2 = t2;
                        st.D3 = t3;
                        st.D4 = t4;
                        st.D5 = t5;
                        st.D6 = t6;
                        st.D7 = t7;
                        st.D8 = t8;
                        st.D9 = t9;
                        st.D10 = date;
                        st.D11 = t11;
                        context.WhiteSms.Add(st);

                    }
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void chx6_CheckedChanged(object sender, EventArgs e)
        {
            Ready_white_Sms();
        }

        private void chx7_CheckedChanged(object sender, EventArgs e)
        {
            Ready_white_Sms();
        }

        private void chx8_CheckedChanged(object sender, EventArgs e)
        {
            Ready_white_Sms();
        }

        private void chx9_CheckedChanged(object sender, EventArgs e)
        {
            Welcome_white_Sms();
        }

        private void chx10_CheckedChanged(object sender, EventArgs e)
        {
            Delivery_white_Sms();
        }

        private void chx11_CheckedChanged(object sender, EventArgs e)
        {
            Delivery_white_Sms();
        }

        private void chx12_CheckedChanged(object sender, EventArgs e)
        {
            Delivery_white_Sms();
        }

        private void chx13_CheckedChanged(object sender, EventArgs e)
        {
            Order_white_Sms();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Order_white_Sms();
        }


        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private async void btnRegisterInternet_Click(object sender, EventArgs e)
        {
            Ping ping = new Ping();
            PingReply pingStatus = ping.Send("google.com");

            if (pingStatus.Status == IPStatus.Success)
            {
                //MessageBox.Show("Connected");
            }
            else
            {
                MessageBox.Show("اینترنت وصل نیست", "اینترنت", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //-------------------
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
            MessageBox.Show("ejra shod");

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

        private void lbl20_Click(object sender, EventArgs e)
        {

        }

        private void tabDeliveryWhiteSms_Click(object sender, EventArgs e)
        {

        }

        private void txtWel16_TextChanged(object sender, EventArgs e)
        {
            label23.Text = txtWel16.TextLength.ToString();
            Welcome_white_Sms();
            
        }

        private void txt42_TextChanged(object sender, EventArgs e)
        {
            label25.Text = txt42.TextLength.ToString();
            Order_white_Sms();
        }

        private void txtReadyt10_TextChanged(object sender, EventArgs e)
        {
            label27.Text = txtReadyt10.TextLength.ToString();
            Ready_white_Sms();
        }

        private void txtDel25_TextChanged(object sender, EventArgs e)
        {
            label28.Text = txtDel25.TextLength.ToString();
            Delivery_white_Sms();
        }
    }
}
