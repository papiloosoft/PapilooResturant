using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Stimulsoft.Report;
using Stimulsoft.Report.Components;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using POS_PC;
using BPersianCalender;

namespace Laundry
{
    public partial class FormServices : Form
    {
        //long sumServices=0;
        public FormServices()
        {
            InitializeComponent();

        }

        //public void test()
        //{
        //    Globals.POSPC_CommunicationType = "tcp/ip";
        //    Globals.POSPC_TCPCOMMU_SocketPortNumebr ="1024";
        //    Globals.POSPC_TCPCOMMU_SocketRecTimeout = 180000;
        //    Transaction txn = new Transaction();
        //    POS_PC.Transaction.return_codes ret_code = Transaction.return_codes.ERR_POS_PC_OTHER;
        //    do
        //    {

        //    }
        //}
        
        public string Get_Return_Message_Sms(int state)
        {
            string message = "";
            if (state == 1)
            {
                message = "ارسال نشد";
                return message;   
            }
            //-----
            if (state == -1)
            {
                message = "امضا دیجیتال معتبر تیست";
                return message;
            }
            //-----
            if (state == 0)
            {
                message = "ارسال شد";
                return message;
            }
            //-----
            if (state == 2)
            {
                message = "  پیامک معتبر نیست";
                return message;
            }
            //-----
            if (state == 3)
            {
                message = "شماره موبایلی وارد نشده";
                return message;
            }
            //-----
            if (state == 4)
            {
                message = "فیلتر می باشد";
                return message;
            }
            //-----
            if (state == 5)
            {
                message = "اپراتور قطع است";
                return message;
            }
            //-----
            if (state == 6)
            {
                message = "ارسال مجاز نیست";
                return message;
            }
            //-----
            if (state == 7)
            {
                message = "حساب کاریری شما فعال نیست";
                return message;
            }
            //-----
            if (state == 8)
            {
                message = "اعتبار کافی موجود تیست";
                return message;
            }
            //-----
            if (state == 9)
            {
                message = "محدودیت در تعداد درخواست";
                return message;
            }
            //-----
            if (state == 10)
            {
                message = "محدودیت ارسال روزانه";
                return message;
            }
            //-----
            if (state == 11)
            {
                message = "شماره پیامک معتبر نیست";
                return message;
            }
            //-----
            if (state == 12)
            {
                message = "خطا";
                return message;
            }
            //-----
            if (state == 13)
            {
                message = "حساب کاربری منقضی شده";
                return message;
            }
            //-----
            if (state == 14)
            {
                message = "باید به پنل لاگین کنید";
                return message;
            }
            //-----
            if (state == -64)
            {
                message = "اعتبار مالی کافی نیست";
                return message;
            }


            return message;
        }
        public void Some_Paye()
        {
            try
            {
                //----------beiane
                if (txtBeiane.Text == "")
                    txtBeiane.Text = "0";

                double beiane;
                if (txtBeiane.Text != "")
                    beiane = int.Parse(txtBeiane.Text.Replace(",", ""));
                else
                    beiane = 0;
                if (txtPay.Text == "")
                    txtPay.Text = "0";
                //----------takhfif
                if (txtDarsadTakhfif.Text == "")
                    txtDarsadTakhfif.Text = "0";
                //---
                if (txtSumTakhfif.Text == "")
                    txtSumTakhfif.Text = "0";
                //-----------mande
                if (txtMande.Text == "")
                    txtMande.Text = "0";


                double darsad;
                if (txtDarsadTakhfif.Text != "")
                    darsad = int.Parse(txtDarsadTakhfif.Text);
                else
                    darsad = 0;

                    if (darsad > 100)
                        txtDarsadTakhfif.Text = "100";
                    if (darsad < 0)
                        txtDarsadTakhfif.Text = "0";
                
                double totalSome = double.Parse(txtSumServices.Text.Replace(",", ""));
                double sum = double.Parse(txtPay.Text.Replace(",", ""));
                double takhfif=0;
                if (darsad != 0)
                {
                     takhfif = totalSome * darsad;
                    takhfif = takhfif / 100;
                    txtSumTakhfif.Text = takhfif.ToString();
                }
                else
                {
                    takhfif = double.Parse(txtSumTakhfif.Text);
                }
                double mande = double.Parse(txtMande.Text.Replace(",", ""));

                //----------

                txtPay.Text = (((totalSome - beiane) - takhfif) + mande).ToString();

            }
            catch (Exception)
            {
                //lblError.Text = "مشکل در حساب ";
                lblError.Text = "";

            }
        }
        //**************
        //joda kardane 3ragham 3ragham
        public string Seragham(string input)
        {
            if (input != string.Empty)
            {
                input = Convert.ToInt64(input.Replace(",", "")).ToString("#,0");

            }
            return input;
        }
        //**************
        private void Enter_Number(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        public int Find_BirthDay(string date, int x)
        {
            date = date.Replace("/", "");
            int year = int.Parse(date.Substring(0, 4));
            int month = int.Parse(date.Substring(4, 2));
            int day = int.Parse(date.Substring(6, 2));
            //------
            for (int i = 0; i < x; i++)
            {
                day++;
                if (month < 7)
                {
                    if (day == 32)
                    {
                        day = 1;
                        month++;
                    }
                }
                if (month >= 7)
                {
                    if (day == 31)
                    {
                        day = 1;
                        month++;

                    }
                }
                if (month >= 12 && day == 30)
                {
                    day = 1;
                    month = 1;
                    year++;
                }

            }
            ///-------------
            string d = day.ToString();
            string m = month.ToString();
            string y = year.ToString();
            if (d.Length == 1)
                d = "0" + d;
            if (m.Length == 1)
                m = "0" + m;
            //--------------
            string tarikh = y + m + d;
            //MessageBox.Show(tarikh);
            int tavalod = int.Parse(tarikh);
            return tavalod;



        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {

                using (var context = new kitchenEntities())
                {
                    var repeatRahgiri = context.Service.Where(c => c.CodeRahgiri == lblCodeRahgiri.Text).FirstOrDefault();
                    if(repeatRahgiri!= null)
                    {
                        lblError.Text = "این کد رهگیری قبلا ثبت شده";
                        DialogResult result=MessageBox.Show("موارد ارسال نشده را میخواهید؟", "ارسال نشده", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if(result==DialogResult.Yes)
                        {
                            FormErsalNashode frmErsalNashode = new FormErsalNashode();
                            frmErsalNashode.Show();
                        }
                        return;
                    }
                    bool isService = context.User.Where(check => check.Eshterak == txtEshterak.Text).Any();
                    if (isService)
                    {
                        if (dgShow.Rows.Count > 0)
                        {
                            Service service = new Service();
                            service.Eshterak = txtEshterak.Text;
                            service.Name = txtName.Text;
                            service.DateService = int.Parse(dtNewService.Text.Replace("/",""));
                            service.Mobile = txtPhone.Text;
                            Int64 beiane=0;
                            if (txtBeiane.Text != "")
                                beiane= Int64.Parse(txtBeiane.Text.Replace(",", ""));
                            else
                                beiane = 0;
                            service.Bestankar = beiane;

                            //---
                            Int64 takhfif;
                            if (txtSumTakhfif.Text != "")
                                takhfif = Int64.Parse(txtSumTakhfif.Text.Replace(",", ""));
                            else
                                takhfif = 0;
                            //string sumTakhfif = ((totalSum * takhfif) / 100).ToString();
                            //service.Takhfif = Int64.Parse(txtSumTakhfif.Text.Replace(",",""));
                            service.Takhfif = takhfif;

                            Int64 totalSum;
                            if (txtSumServices.Text != "")
                                totalSum = Int64.Parse(txtSumServices.Text.Replace(",", ""));
                            else
                                totalSum = 0;
                            if (totalSum < 0)
                            {
                                string x=totalSum.ToString().Remove(0, 1);
                                totalSum = Int64.Parse(x);
                            }
                            //---
                            //totalSum = totalSum - takhfif;
                            //txtsumAfterTakhfif.Text = totalSum.ToString();
                            //service.SumServices = (totalSum-(takhfif + beiane));
                            service.SumServices = totalSum;
                            if (txtBeiane.Text == "")
                                txtBeiane.Text = "0";
                            if ((Int64.Parse(txtSumServices.Text.Replace(",", "")) - Int64.Parse(txtBeiane.Text.Replace(",", ""))) == 0)
                                service.Tasfiye = "0";
                            else
                                service.Tasfiye = "1";
                            service.CodeRahgiri = lblCodeRahgiri.Text;
                            Int32 countServices = Convert.ToInt32(lblSomeService.Text);
                            countServices++;
                            service.NumberService = countServices.ToString();
                            if (txtPay.Text == "")
                                txtPay.Text = "0";
                            service.Pardakhti = Convert.ToInt64(txtPay.Text.Replace(",", ""));

                            service.ReadyDate = 0;
                            service.SendReadySms = 0;
                            service.Description = txtDescription.Text;


                            context.Service.Add(service);
                        }
                        else
                        {
                            lblError.Text = "سفارشی ثبت نشده است";
                            return;
                        }
                        //******************
                        //******************
                        if (lblCodeRahgiri.Text != "")
                        {
                            for (int i = 0; i < dgShow.Rows.Count; i++)
                            {
                                ReportService repServ = new ReportService();
                                repServ.Eshterak = txtEshterak.Text;
                                repServ.Date = int.Parse(dtNewService.Text.Replace("/",""));
                                repServ.Kind = dgShow.Rows[i].Cells[0].Value.ToString();
                                repServ.Kala = dgShow.Rows[i].Cells[1].Value.ToString();
                                repServ.Service = dgShow.Rows[i].Cells[2].Value.ToString();
                                repServ.Some = dgShow.Rows[i].Cells[3].Value.ToString();
                                repServ.Price = dgShow.Rows[i].Cells[5].Value.ToString();
                                repServ.CodeRahgiri = dgShow.Rows[i].Cells[6].Value.ToString();
                                repServ.NumberServise = lblSomeService.Text;
                                repServ.Ready = "1";
                                context.ReportService.Add(repServ);
                            }
                            context.SaveChanges();
                            lblError.ForeColor = Color.Green;
                            lblError.Text = "اطلاعات با موفقیت ثیت شد";
                        }
                    }
                    else
                    {
                        lblError.ForeColor = Color.Red;
                        lblError.Text = "کاربری بااین شماره اشتراک وجود ندارد";

                        txtEshterak.Focus();
                        return;
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("مشکل در ثبت نهایی" + "\n" + ex.Message);
            }

            //********* ersal sms
            try
            {
                int vaziyzt = 1;

                try
                {
                    kitchenEntities context = new kitchenEntities();
                    var x = context.Setting.FirstOrDefault();
                    if (x.AcceptSms == "true")
                    {
                        vaziyzt = 1;
                    }
                    else
                    {
                        vaziyzt = 0;
                    }


                    if (vaziyzt == 1)
                    {
                        if (txtPhone.TextLength > 11 || txtPhone.TextLength < 11 || txtPhone.Text.StartsWith("09")==false)
                        {
                            lblError.ForeColor = Color.Red;
                            lblError.Text = "شماره موبایل اشتباه است";
                            //txtPhone.Text = "0";
                            txtPhone.Focus();
                            return;
                        }
                        var sign = context.Setting.FirstOrDefault();
                        if (sign.Signature == null || sign.Signature == "" || sign.NumberSms == null || sign.NumberSms == "")
                        {
                            lblError.ForeColor = Color.Red;
                            lblError.Text = "از قسمت تنظیمات امضا دیجیتال و شماره پیامک را ثبت کنید";
                            lblError.ForeColor = Color.Black;
                            return;
                        }
                        //Ping ping = new Ping();
                        //PingReply pingStatus = ping.Send("login.parsgreen.com");

                        //if (pingStatus.Status == IPStatus.Success)
                        //{
                        //***********baraye check kardane ertebat
                        //HttpWebRequest reqCheack = (HttpWebRequest)WebRequest.Create("http://login.parsgreen.com/UrlService/sendSMS.ashx?from=");
                        //System.Net.WebResponse respCheack = reqCheack.GetResponse();
                        //***********
                        string message = "";
                            for (int i = 0; i < dgShow.RowCount; i++)
                            {
                                message += dgShow.Rows[i].Cells[1].Value.ToString() + dgShow.Rows[i].Cells[3].Value.ToString() + "،";
                            }
                            var sms = context.WhiteSms.Where(c => c.S1 != null && c.S1 != "").FirstOrDefault();
                            var setName = context.Setting.Where(c => c.CommercialName != "" || c.CommercialName != null).FirstOrDefault();
                            if (setName == null)
                            {
                                MessageBox.Show("از بخش تنظیمات پیامک نام تجاری را ثبت کنید", "تنظیمات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                            string message2 = "";

                        if (string.IsNullOrEmpty(sms.S12))
                        {
                            message2 = sms.S1 + txtName.Text.Replace(" ", ".") + sms.S3 + message.Replace(" ", ".") + sms.S8 + lblCodeRahgiri.Text + sms.S10 + setName.CommercialName + sms.S13;
                        }
                        else
                            message2 = sms.S1 + txtName.Text.Replace(" ", ".") + sms.S3 + message.Replace(" ", ".") + sms.S8 + lblCodeRahgiri.Text + sms.S10 + setName.CommercialName + dtNewService.Text + sms.S13;

                            //MessageBox.Show("name " + message2.Length.ToString());

                            //--------
                            //PARSGREEN.API.SMS.Send.SendSMS info = new PARSGREEN.API.SMS.Send.SendSMS();
                            //int part = 0;
                            //bool uniCode = true;
                            //double doIt=info.MessageInfo(sign.Signature, message2, ref part, ref uniCode);


                                //*********
                                if (message2.Length > 132)
                                {
                                    message = dgShow.Rows.Count.ToString();
                                    if (string.IsNullOrEmpty(sms.S12))
                                    {
                                        message2 = sms.S1 + txtName.Text.Replace(" ", ".") + sms.S3 + message.Replace(" ", ".") + sms.S8 + lblCodeRahgiri.Text + sms.S10 + setName.CommercialName + sms.S13;
                                    }
                                    else
                                        message2 = sms.S1 + txtName.Text.Replace(" ", ".") + sms.S3 + message.Replace(" ", ".") + sms.S8 + lblCodeRahgiri.Text + sms.S10 + setName.CommercialName + dtNewService.Text + sms.S13;

                                    //MessageBox.Show("sefaresh " + message2.Length.ToString());
                                    lblError.Text = "فرمت خیلی فشرده پیامک";

                                }

                            
                            //System.Web.HttpUtility.HtmlDecode(text);
                            //MessageBox.Show(message2);
                            //return;
                            string pattern = "http://login.parsgreen.com/UrlService/sendSMS.ashx?from=" + sign.NumberSms + "&to=" + txtPhone.Text + "&text=" + message2 + "&signature=" + sign.Signature;
                            
                            //MessageBox.Show(pattern);
                            System.IO.Stream st = null;
                            System.IO.StreamReader sr = null;

                            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(pattern);
                            Encoding encode = System.Text.Encoding.UTF8;
                        //MessageBox.Show(message2.Length.ToString());
                            System.Net.WebResponse resp = req.GetResponse();

                            st = resp.GetResponseStream();
                            sr = new System.IO.StreamReader(st, Encoding.UTF8);
                            string result = sr.ReadToEnd().Substring(12, 1);
                            //MessageBox.Show(sr.ReadToEnd()); //Get_Return_Message_Sms(int.Parse(result);
                            lblError.Text = Get_Return_Message_Sms(int.Parse(result));
                            sr.Close();
                            resp.Close();
                            //---------
                            PARSGREEN.API.SMS.Profile.ProfileService p = new PARSGREEN.API.SMS.Profile.ProfileService();
                            double creidet = p.GetCredit(sign.Signature);

                            var check = context.WhiteSms.FirstOrDefault();
                            double warning = double.Parse(check.R10);
                            if (creidet < warning)
                                MessageBox.Show("اعتبار پنل پیامک کمتر از" + warning + " ریال است", "پنل پیامک", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        //-------
                        //restStatus = send.SendGroupSMS(sig.Signature, sig.NumberSms, new string[] { txtPhone.Text }, message, false, string.Empty, ref successCount, ref restr);
                        //lblError.Text = Get_Return_Message_Sms(restStatus);
                        if (result == "0")
                        {
                            MessageBox.Show(message2, "پیام ارسال شده");
                            return;
                        }
                            //else
                            //{
                            //    ErsalNashode En = new ErsalNashode();
                            //    En.Name = txtName.Text;
                            //    En.Phone = txtPhone.Text;
                            //    En.Message = message2;
                            //    En.Date = int.Parse(dtNewService.Text.Replace("/", ""));
                            //    En.Time = DateTime.Now.ToLongTimeString();
                            //    En.CodeRahgiri = lblCodeRahgiri.Text;
                            //    context.ErsalNashodes.Add(En);
                            //    context.SaveChanges();
                            //    MessageBox.Show("اینترنت وصل نیست،در موارد ارسال نشده ذخیره شد", " وصل نیست اینترنت", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            //}
                        //}//
                    }


                    //ersal sms paziresh

                }
                catch (Exception)
                {

                    kitchenEntities context = new kitchenEntities();
                    var sms = context.WhiteSms.Where(c => c.S1 != null && c.S1 != "").FirstOrDefault();
                    var sign = context.Setting.FirstOrDefault();
                    var setName = context.Setting.Where(c => c.CommercialName != "" || c.CommercialName != null).FirstOrDefault();
                    if (setName == null)
                    {
                        MessageBox.Show("از بخش تنظیمات پیامک نام تجاری را ثبت کنید", "تنظیمات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    //*****
                    try
                    {


                        string msg = "";
                        if (string.IsNullOrEmpty(sms.S12))
                        {
                            msg = sms.S1 + txtName.Text.Replace(" ",".") + sms.S3 + dgShow.Rows.Count.ToString() + sms.S8 + lblCodeRahgiri.Text + sms.S10 + setName.CommercialName + sms.S13;
                        }
                        else
                            msg = sms.S1 + txtName.Text.Replace(" ", ".") + sms.S3 + dgShow.Rows.Count.ToString() + sms.S8 + lblCodeRahgiri.Text + sms.S10 + setName.CommercialName + dtNewService.Text + sms.S13;
                        //---------
                        string pattern = "http://login.parsgreen.com/UrlService/sendSMS.ashx?from=" + sign.NumberSms + "&to=" + txtPhone.Text + "&text=" + msg + "&signature=" + sign.Signature;

                        //MessageBox.Show(pattern);
                        System.IO.Stream st = null;
                        System.IO.StreamReader sr = null;

                        HttpWebRequest req = (HttpWebRequest)WebRequest.Create(pattern);
                        Encoding encode = System.Text.Encoding.UTF8;
                        //MessageBox.Show(message2.Length.ToString());
                        System.Net.WebResponse resp = req.GetResponse();

                        st = resp.GetResponseStream();
                        sr = new System.IO.StreamReader(st, Encoding.UTF8);
                        string result = sr.ReadToEnd().Substring(12, 1);
                        //MessageBox.Show(sr.ReadToEnd()); //Get_Return_Message_Sms(int.Parse(result);
                        lblError.Text = Get_Return_Message_Sms(int.Parse(result));
                        sr.Close();
                        resp.Close();
                        //---------
                        PARSGREEN.API.SMS.Profile.ProfileService p = new PARSGREEN.API.SMS.Profile.ProfileService();
                        double creidet = p.GetCredit(sign.Signature);

                        var check = context.WhiteSms.FirstOrDefault();
                        double warning = double.Parse(check.R10);
                        if (creidet < warning)
                            MessageBox.Show("اعتبار پنل پیامک کمتر از" + warning + " ریال است", "پنل پیامک", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        //-------
                        //restStatus = send.SendGroupSMS(sig.Signature, sig.NumberSms, new string[] { txtPhone.Text }, message, false, string.Empty, ref successCount, ref restr);
                        //lblError.Text = Get_Return_Message_Sms(restStatus);
                        if (result == "0")
                        {
                            MessageBox.Show(msg, "پیام ارسال شده");
                            return;
                        }




                    }
                    catch (Exception)
                    {


                    }
                    //*****

                    string message = "";
                    for (int i = 0; i < dgShow.RowCount; i++)
                    {
                        message += dgShow.Rows[i].Cells[1].Value.ToString() + dgShow.Rows[i].Cells[3].Value.ToString() + "،";
                    }

                    string message2 = "";
                    if (string.IsNullOrEmpty(sms.S12))
                    {
                        message2 = sms.S1 + txtName.Text.Replace(" ", ".") + sms.S3 + message.Replace(" ", ".") + sms.S8 + lblCodeRahgiri.Text + sms.S10 + setName.CommercialName + sms.S13;
                    }
                    else
                        message2 = sms.S1 + txtName.Text.Replace(" ", ".") + sms.S3 + message.Replace(" ", ".") + sms.S8 + lblCodeRahgiri.Text + sms.S10 + setName.CommercialName + dtNewService.Text + sms.S13;

                    //MessageBox.Show("name " + message2.Length.ToString());

                    //--------
                    //PARSGREEN.API.SMS.Send.SendSMS info = new PARSGREEN.API.SMS.Send.SendSMS();
                    //int part = 0;
                    //bool uniCode = true;
                    //double doIt=info.MessageInfo(sign.Signature, message2, ref part, ref uniCode);

                        //*********
                        if (message2.Length > 132)
                        {
                            message = dgShow.Rows.Count.ToString();
                            if (string.IsNullOrEmpty(sms.S12))
                            {
                                message2 = sms.S1 + txtName.Text.Replace(" ", ".") + sms.S3 + message.Replace(" ", ".") + sms.S8 + lblCodeRahgiri.Text + sms.S10 + setName.CommercialName + sms.S13;
                            }
                            else
                                message2 = sms.S1 + txtName.Text.Replace(" ", ".") + sms.S3 + message.Replace(" ", ".") + sms.S8 + lblCodeRahgiri.Text + sms.S10 + setName.CommercialName + dtNewService.Text + sms.S13;

                            //MessageBox.Show("sefaresh " + message2.Length.ToString());
                            lblError.Text = "فرمت خیلی فشرده پیامک";

                        }

                    

                    ErsalNashode En = new ErsalNashode();
                    En.Name = txtName.Text;
                    En.Phone = txtPhone.Text;
                    En.Message = message2;
                    En.Date = int.Parse(dtNewService.Text.Replace("/", ""));
                    En.Time = DateTime.Now.ToLongTimeString();
                    En.CodeRahgiri = lblCodeRahgiri.Text;
                    context.ErsalNashode.Add(En);
                    context.SaveChanges();
                    MessageBox.Show("اینترنت وصل نیست،در موارد ارسال نشده ذخیره شد", " وصل نیست اینترنت", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                //***************
                //**************

                txtEshterak.Text = "";
                txtSumServices.Text = "";
                txtSumTakhfif.Text = "";
                txtPay.Text = "";
                txtPhone.Text = "";
                txtName.Text = "";
                txtMande.Text = "";
                txtBeiane.Text = "";
                txtDarsadTakhfif.Text = "";
                //**************
                //***************

            }
            catch (Exception ex)
            {

                MessageBox.Show("مشکل در ثبت نهایی پیامک " + "\n" + ex.Message);
            }

        }
        int run;
        private void FormServices_Load(object sender, EventArgs e)
        {
            //int run = 0;
            try
            {
                using (var context = new kitchenEntities())
                {
                    //*******Auto Fill Eshterak - Name - Phone
                    if (chxNewCustomer.Checked == false)
                    {
                        var select = context.User.ToList();
                        //------

                        string[] eshterak = new string[select.Count];
                        for (int i = 0; i < select.Count; i++)
                        {
                            eshterak[i] = select[i].Eshterak.ToString();
                        }
                        //txtEshterak.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        AutoCompleteStringCollection suggest = new AutoCompleteStringCollection();
                        txtEshterak.AutoCompleteCustomSource = suggest;
                        suggest.AddRange(eshterak);
                        //-----------
                        string[] Name = new string[select.Count];
                        for (int i = 0; i < select.Count; i++)
                        {
                            Name[i] = select[i].Name.ToString();
                        }
                        //txtName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        AutoCompleteStringCollection suggestName = new AutoCompleteStringCollection();
                        txtName.AutoCompleteCustomSource = suggestName;
                        suggestName.AddRange(Name);
                        //-------
                        string[] Phone = new string[select.Count];
                        for (int i = 0; i < select.Count; i++)
                        {
                            Phone[i] = select[i].Phone.ToString();
                        }
                        AutoCompleteStringCollection suggestPhone = new AutoCompleteStringCollection();
                        txtPhone.AutoCompleteCustomSource = suggestPhone;
                        suggestPhone.AddRange(Phone);
                    }
                    var selectCodeRahgiri = context.Service.ToList();
                    string[] CodeRahgiri = new string[selectCodeRahgiri.Count];
                    for (int i = 0; i < selectCodeRahgiri.Count; i++)
                    {
                        CodeRahgiri[i] = selectCodeRahgiri[i].CodeRahgiri.ToString();
                    }
                    //txtEshterak.AutoCompleteSource = AutoCompleteSource.CustomSource;
                    AutoCompleteStringCollection suggestCodeRahgiri = new AutoCompleteStringCollection();
                    txtCodeRahgiri.AutoCompleteCustomSource = suggestCodeRahgiri;
                    suggestCodeRahgiri.AddRange(CodeRahgiri);
                    //-----------

                    //******
                    
                    dtNewService.Today_Click(null, null);
                    
                    if (txtPrice.Text == "")
                        btnAddService.Enabled = true;

                    dtNewService.Today_Click(null, null);


                    var kindServ = context.KindService.ToList();
                    comServiceKind.DataSource = kindServ;
                    comServiceKind.DisplayMember = "Name";
                    //----------
                    var kindKala = context.KindKala.Where(c => c.NameService == comServiceKind.Text).ToList();
                    comKindKala.DataSource = kindKala;
                    comKindKala.DisplayMember = "Name";
                    //---------
                    var nameServ = context.NameService.ToList();
                    comServiceName.DataSource = nameServ;
                    comServiceName.DisplayMember = "Name";
                    //---------
                    //var selectService = context.NameService.Where(c => c.Name == comServiceName.Text).FirstOrDefault();
                    lblCategory.Text = comServiceKind.Text;


                    var service = context.ServicesPrice.Where(c => c.ServisKind == comServiceKind.Text && c.ServiseName == comServiceName.Text && c.ServiceKala == comKindKala.Text).FirstOrDefault();
                    if (service != null)
                    {
                        if (service.ServicePrice.Value.ToString() == "")
                            txtPrice.Text = "0";
                        else
                            txtPrice.Text = service.ServicePrice.Value.ToString();

                    }
                    else
                    {
                        lblError.Text = "این خدمت تعریف نشده است";
                        //MessageBox.Show("این خدمت تعریف نشده است.از قسمت مدیریت قیمت استفاده کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("1 " + ex.Message);

            }
            //-------------------
            //if (string.IsNullOrEmpty(txtPriceMotorOil.Text) || txtPriceMotorOil.Text == "0")
            //    txtSomeMotorOil.Text = "0";
            //else
            //    txtSomeMotorOil.Text = "1";
            //----------
            //if (string.IsNullOrEmpty(txtSomeHidrolikOil.Text) || txtSomeHidrolikOil.Text == "0")
            //    txtSomeHidrolikOil.Text = "0";
            //else
            //    txtSomeHidrolikOil.Text = "1";
            //-------
            //if (comServiceKind.Visible != false)
            //{
            //    dtNewService.Today_Click(null, null);

            //    //comPriceMotorOil.Enabled = false;
            //    //comPriceHidrolikOil.Enabled = false;
            //    comServiceName.Enabled = false;
            //    comServicePrice.Enabled = false;
            //    //****************
            //    comServicePrice.Text = "0";
            //    //comPriceHidrolikOil.Text = "0";
            //    txtSomeVaskazin.Text = "0";
            //    txtSomeBatriWatear.Text = "0";
            //    //****************
            //    int month;

            //    System.Globalization.PersianCalendar pc = new PersianCalendar();
            //    //txtNextService.Text = string.Format("mm", pc.GetMonthsInYear().ToString());
            //    month = pc.GetMonth(DateTime.Today);
            //    month += 06;
            //    //-----mahaye tak raghami tabdil be 2 raghami mishe
            //    string m = pc.GetMonth(pc.AddMonths(DateTime.Now, 06)).ToString();
            //    if (int.Parse(m) < 10)
            //        m = "0" + m;
            //    //------
            //    //-----roozaye tak raghami tabdil be 2 raghami mishe
            //    string d = pc.GetDayOfMonth(DateTime.Now).ToString();
            //    if (int.Parse(d) < 10)
            //        d = "0" + d;
            //    //------
            //    if (month > 12)
            //    {
            //        dtNextService.Text = pc.GetYear(pc.AddYears(DateTime.Today, 1)).ToString() +
            //       "/" + m +
            //        "/" + d;
            //    }
            //    else
            //    {
            //        dtNextService.Text = pc.GetYear(pc.AddDays(DateTime.Now, 0)).ToString() +
            //        "/" + pc.GetMonth(pc.AddMonths(DateTime.Now, 6)).ToString() +
            //        "/" + d;
            //    }
            //}


        }


        private void txtEshterak_TextChanged(object sender, EventArgs e)
        {
            try
            {
                using (var context = new kitchenEntities())
                {
                    var somServ = context.Service.Where(serv => serv.Eshterak == txtEshterak.Text).ToList();
                    lblSomeService.Text = somServ.Count.ToString();
                    //txtNumberService.Text = (somServ.Count + 1).ToString();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private class servrvice
        {
            public string Name { get; set; }
            public string DateService { get; set; }
            public string Eshterak { get; set; }
            public string NumberService { get; set; }
            public string SumPrice { get; set; }
            public string khedmat { get; set; }
            public string Some { get; set; }
            public string Price { get; set; }
            public string Rahgiri { get; set; }
            public string serv { get; set; }


        }
        private void btnPrint_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            try
            {
                if (txtEshterak.Text == "")
                {
                    lblError.ForeColor = Color.Red;
                    lblError.Text = "شماره اشتراک خالی است";
                }
                if(dgShow.Rows.Count==0)
                {
                    lblError.Text="هیچ خدمتی ثبت نشده";
                    return;
                }
                string nameshop;
                using (var context = new kitchenEntities())
                {
                    var Name = context.Setting.Where(current => current.CommercialName !=null).FirstOrDefault();
                    nameshop = Name.CommercialName;

                    List<servrvice> list = new List<servrvice>();
                    for (int i = 0; i < dgShow.Rows.Count; i++)
                    {
                        servrvice serv = new servrvice
                        {
                            Name = txtName.Text,
                            DateService = dtNewService.Text,
                            Eshterak = txtEshterak.Text,
                            NumberService = lblSomeService.Text,
                            Rahgiri = lblCodeRahgiri.Text,
                            khedmat = dgShow.Rows[i].Cells[1].Value.ToString(),
                            Some = dgShow.Rows[i].Cells[3].Value.ToString(),
                            Price = dgShow.Rows[i].Cells[5].Value.ToString(),
                            //-----
                            SumPrice = txtSumServices.Text,
                            serv= dgShow.Rows[i].Cells[2].Value.ToString(),

                        };

                        list.Add(serv);
                    }
                    StiReport report = new StiReport();
                    report.Load(Application.StartupPath + "\\RptService.mrt");

                    report.RegBusinessObject("Service", list);

                    (report.GetComponentByName("DataService_Name") as StiText).Enabled = txtName.Enabled;
                    (report.GetComponentByName("DataService_Eshterak") as StiText).Enabled = txtEshterak.Enabled;
                    (report.GetComponentByName("DataService_DateService") as StiText).Enabled = dtNewService.Enabled;
                 
                        (report.GetComponentByName("DataService_Some") as StiText).Enabled = dgShow.Enabled;
                        (report.GetComponentByName("DataService_Price") as StiText).Enabled = dgShow.Enabled;
                        (report.GetComponentByName("DataService_khedmat") as StiText).Enabled = dgShow.Enabled;

                    (report.GetComponentByName("DataService_SumPrice") as StiText).Enabled = txtSumServices.Enabled;
                    (report.GetComponentByName("Text7") as StiText).Text = nameshop;
                    (report.GetComponentByName("Text10") as StiText).Text = txtSumTakhfif.Text;
                    (report.GetComponentByName("Text12") as StiText).Text = txtPay.Text;
                    (report.GetComponentByName("Text14") as StiText).Text = txtBeiane.Text;


                    report.Print();

                    //report.Show();
                    
                }


            }
            catch (Exception ex)
            {
                 MessageBox.Show(ex.Message);
                //lblError.ForeColor = Color.Red;
                //lblError.Text = "کاربری بااین شماره اشتراک وجود ندارد,خطا";
                //txtEshterak.Focus();
            }
        }


        private void txtPriceFilterBenzin_TextChanged(object sender, EventArgs e)
        {

        }

        private void chxBenzin_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnServiceUpdate_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            try
            {
                using (var context = new kitchenEntities())
                {

                    var service = context.Service.Where(current => current.Eshterak == txtEshterak.Text).FirstOrDefault();

                    service.DateService = int.Parse(dtNewService.Text.Replace("/", ""));
                    service.SumServices = Convert.ToInt64(txtSumServices.Text);

                    context.SaveChanges();
                }
                lblError.ForeColor = Color.Green;
                lblError.Text = "ویرایش با موفقبت اتجام شد";

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtPriceMotorOil_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtpriceHidrolikOil_TextChanged(object sender, EventArgs e)
        {

        }
        //************
        // code rahgiri sade
        private string Build_CodeRahgiri()
        {
            Int64 code = 0;
            string code2 = "";
            try
            {
                using (var context = new kitchenEntities())
                {
                    var getCode = context.Setting.FirstOrDefault();
                    if (getCode.EndCreateCodeRahgiri != null)
                        code = Convert.ToInt64(getCode.EndCreateCodeRahgiri);
                    else
                        code = 0;

                    code++;
                    getCode.EndCreateCodeRahgiri = code;
                    context.SaveChanges();
                }

                code2 = code.ToString();
                //MessageBox.Show(code2);
                return code2;
            }
            catch (Exception ex)
            {

                MessageBox.Show("مشکل در کد رهگیری"+"\n"+ex.Message);
            }
            return code2;
        }
        //----------
        //dorost kardane adade randome gheire tekrari
        private string GreateUniqueNumbericID()
        {

            byte[] bytes = Guid.NewGuid().ToByteArray();

            string code = BitConverter.ToInt32(bytes, 0).ToString();
            string code2 = code.Substring(0, 1);
            //hazf kardane "-" az avale adad
            if (code2.IndexOf('-') == 0)
                code = code.Remove(0, 1);
            //dorost kardane adad 6 raghami va kamtar
            if (code.Length > 7)
                code = code.Substring(0, 6);
            return code;

        }
        //-------------

        private void txtEshterak_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);
        }

        private void txtCarKm_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);
        }

        private void txtNextServiceKm_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);
        }

        private void txtNumberService_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);
        }

        private void txtSomeMotorOil_TextChanged(object sender, EventArgs e)
        {
            if (numSome.Text == "0")
            {
                txtPrice.Enabled = false;
                btnSave.Enabled = false;
            }
            else
            {
                txtPrice.Enabled = true;
                btnSave.Enabled = true;
                if (txtPrice.Text == "")
                    txtPrice.Text = "0";
                Int64 totalPrice = Convert.ToInt32(txtPrice.Text) * Convert.ToInt32(numSome.Text);

            }

        }

        private void comServiceKind_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new kitchenEntities())
                {
                    string serviceKind = comServiceKind.SelectedItem.ToString();
                    string serviceName = comServiceName.SelectedItem.ToString();
                    string kindKala = comKindKala.SelectedItem.ToString();

                    var service = context.ServicesPrice.Where(c => c.ServisKind == serviceKind && c.ServiseName == serviceName && c.ServiceKala == kindKala).FirstOrDefault();
                    if (service != null)
                        txtPrice.Text = service.ServicePrice.Value.ToString();
                    else
                        MessageBox.Show("این خدمت تعریف نشده است.از قسمت مدیریت قیمت استفاده کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            lblError.Text = "";
            try
            {
                if (txtPrice.Text == "")
                {
                    lblError.ForeColor = Color.Red;
                    lblError.Text = "قیمت خالی است";
                    return;

                }
                if (lblCodeRahgiri.Text == "")
                    lblCodeRahgiri.Text = Build_CodeRahgiri();
                double totalPrice = Convert.ToDouble(txtPrice.Text) * Convert.ToDouble(numSome.Text);
                dgShow.Rows.Add(comServiceKind.Text, comKindKala.Text, comServiceName.Text, numSome.Text, txtPrice.Text, totalPrice.ToString(), lblCodeRahgiri.Text,"",lblCategory.Text);

                numSome.Text = "1";
                double sum = 0;
                for (int i = 0; i < dgShow.RowCount; i++)
                {

                    sum = sum + Convert.ToInt64(dgShow.Rows[i].Cells[5].Value.ToString());
                }
                txtSumServices.Text = sum.ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("مشکل در ثبت سفارش در لیست" + "\n" + ex.Message);
            }
        }

        private void btnAddKindService_Click(object sender, EventArgs e)
        {
            txtAddKindService.Text = "";
            txtAddKindService.Visible = true;
            txtAddKindService.Focus();
        }

        private void btnAddKindKala_Click(object sender, EventArgs e)
        {
            txtAddKindkala.Text = "";
            txtAddKindkala.Visible = true;
            txtAddKindkala.Focus();
        }

        private void btnAddNameService_Click(object sender, EventArgs e)
        {
            txtAddNameService.Text = "";
            txtAddNameService.Visible = true;
            txtAddNameService.Focus();
        }

        private void txtAddKindService_DoubleClick(object sender, EventArgs e)
        {
            //comServiceKind.Items.Add(txtAddKindService.Text);

            using (var context = new kitchenEntities())
            {
                KindService k = new KindService();
                k.Name = txtAddKindService.Text;
                context.KindService.Add(k);
                context.SaveChanges();
                //------
                var kindServ = context.KindService.ToList();
                comServiceKind.DataSource = kindServ;
                comServiceKind.DisplayMember = "Name";

                txtAddKindService.Visible = false;
            }
        }

        private void txtAddKindkala_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            using (var context = new kitchenEntities())
            {
                KindKala kk = new KindKala();
                kk.Name = txtAddKindkala.Text;
                context.KindKala.Add(kk);
                context.SaveChanges();

                //------
                var kindKala = context.KindKala.ToList();
                comKindKala.DataSource = kindKala;
                comKindKala.DisplayMember = "Name";

                txtAddKindkala.Visible = false;
            }
        }

        private void txtAddNameService_DoubleClick(object sender, EventArgs e)
        {
            using (var context = new kitchenEntities())
            {
                NameService kkk = new NameService();
                kkk.Name = txtAddNameService.Text;
                context.NameService.Add(kkk);
                context.SaveChanges();

                //------
                var nameServ = context.NameService.ToList();
                comServiceName.DataSource = nameServ;
                comServiceName.DisplayMember = "Name";

                txtAddNameService.Visible = false;
            }
        }

        private void comServiceKind_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = "";
                run++;
                if (run < 3)
                {

                    return;
                }
                else
                {
                    using (var context = new kitchenEntities())
                    {
                        var service = context.ServicesPrice.Where(c => c.ServisKind == comServiceKind.Text && c.ServiseName == comServiceName.Text && c.ServiceKala == comKindKala.Text).FirstOrDefault();
                        if (service != null)
                        {
                            btnAddService.Enabled = false;
                            
                                if (service.ServicePrice.Value.ToString() == "")
                                    txtPrice.Text = "0";
                                else
                                    txtPrice.Text = service.ServicePrice.Value.ToString();

                            
                            //----------
                            var kindKala = context.KindKala.Where(c => c.NameService == comServiceKind.Text).ToList();
                            comKindKala.DataSource = kindKala;
                            comKindKala.DisplayMember = "NameService";
                        }
                        else
                        {
                            btnAddService.Enabled = true;
                            lblError.Text = "این خدمت تعریف نشده است.از قسمت مدیریت قیمت استفاده کنید";
                            //MessageBox.Show("این خدمت تعریف نشده است.از قسمت مدیریت قیمت استفاده کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void comKindKala_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = "";
                run++;
                if (run < 5)
                {

                    return;
                }
                else
                {
                    using (var context = new kitchenEntities())
                    {
                        
                        var service = context.ServicesPrice.Where(c => c.ServisKind == comServiceKind.Text && c.ServiseName == comServiceName.Text && c.ServiceKala == comKindKala.Text).FirstOrDefault();
                        if (service != null)
                        {
                            btnAddService.Enabled = false;
                            txtPrice.Text = service.ServicePrice.Value.ToString();
                        }
                        else
                        {
                            btnAddService.Enabled = true;

                            lblError.Text = "این خدمت تعریف نشده است.از قسمت مدیریت قیمت استفاده کنید";
                            //MessageBox.Show("این خدمت تعریف نشده است.از قسمت مدیریت قیمت استفاده کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void comServiceName_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = "";
                run++;
                if (run < 7)
                {

                    return;
                }
                else
                {
                    using (var context = new kitchenEntities())
                    {
                        var service = context.ServicesPrice.Where(c => c.ServisKind == comServiceKind.Text && c.ServiseName == comServiceName.Text && c.ServiceKala == comKindKala.Text).FirstOrDefault();
                        if (service != null)
                        {
                            btnAddService.Enabled = false;
                            txtPrice.Text = service.ServicePrice.Value.ToString();
                        }
                        else
                        {
                            btnAddService.Enabled = true;

                            lblError.Text = "این خدمت تعریف نشده است.از قسمت مدیریت قیمت استفاده کنید";
                            //MessageBox.Show("این خدمت تعریف نشده است.از قسمت مدیریت قیمت استفاده کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                        var selectService = context.NameService.Where(c => c.Name == comServiceName.Text).FirstOrDefault();
                        lblCategory.Text = selectService.Category;

                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            kitchenEntities context = new kitchenEntities();
            string message = "";
            try
            {
                lblError.Text = "";
                if (txtPhone.TextLength > 11 || txtPhone.TextLength < 11 || txtPhone.Text.StartsWith("09") == false)
                {
                    lblError.ForeColor = Color.Red;
                    lblError.Text = "شماره موبایل اشتباه است";
                    //txtPhone.Text = "0";
                    txtPhone.Focus();
                    return;
                }
                else
                    lblError.Text = "";

                if (txtEshterak.Text == "")
                {
                    MessageBox.Show("شماره اشتراک خالی است", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (txtName.Text == "")
                {
                    lblError.Text = "نام را وارد کنید";
                    return;
                }
                if (txtPhone.Text == "")
                {
                    lblError.Text = "شماره تماس را وارد کنید";
                    return;
                }

                bool isContact = context.User.Where(check => check.Eshterak == txtEshterak.Text).Any();
                if (isContact)
                {
                    //MessageBox.Show("کاربری بااین شماره اشتراک وجود دارد", "اشتراک", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    lblError.ForeColor = Color.Red;
                    lblError.Text = "کاربری بااین شماره اشتراک وجود دارد";
                    txtEshterak.Focus();
                    return;
                }
                else
                {

                    User user = new User();
                    user.Name = txtName.Text;
                    user.Phone = txtPhone.Text;
                    user.Eshterak = txtEshterak.Text;
                    user.Date = int.Parse(dtNewService.Text.Replace("/", ""));
                    user.Email = txtEmail.Text;
                    user.Address = txtAddress.Text;
                    user.PostiCode = txtPostiCode.Text;
                    if (dtBirthDay.Text == "")
                        user.BirthDayDate = 0;
                    else
                        user.BirthDayDate = int.Parse(dtBirthDay.Text.Replace("/", ""));
                    //************

                    context.User.Add(user);
                    context.SaveChanges();
                    lblError.ForeColor = Color.Green;
                    lblError.Text = "اطلاعات با موفقیت ثبت شد";
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show("مشکل در ثبت مشتری" + "\n" + ex.Message);
            }
            //********** Sms Part
            try
            {
                int vaziyzt = 1;
                var x = context.Setting.FirstOrDefault();
                if (x.WelcomeSms == "true")
                {
                    vaziyzt = 1;
                }
                else
                {
                    vaziyzt = 0;
                }
                if (vaziyzt == 0)
                    return;

                var sms = context.WhiteSms.Where(c => c.W1 != null || c.W1 != "").FirstOrDefault();
                //|| c.CommercialName != null
                var setName = context.Setting.Where(c => c.CommercialName != "").FirstOrDefault();
                if (setName == null)
                {
                    MessageBox.Show("برای ارسال پیامک ابتدااز بخش تنظیمات پیامک نام تجاری را ثبت کنید", "تنظیمات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                if (string.IsNullOrEmpty(sms.W8))
                   message = sms.W1 + txtName.Text.Replace(" ",".") + sms.W3 + setName.CommercialName + sms.W5 + sms.W6 + txtEshterak.Text + sms.W9;
                else
                    message = sms.W1 + txtName.Text.Replace(" ",".") + sms.W3 + setName.CommercialName + sms.W5 + sms.W6 + txtEshterak.Text + " " + dtNewService.Text + sms.W9;

                //MessageBox.Show(message);
                //return;



                var sign = context.Setting.FirstOrDefault();
                if (sign.Signature == null || sign.Signature == "" || sign.NumberSms == null || sign.NumberSms == "")
                {
                    //lblError.ForeColor = Color.Red;
                    lblError.Text = "از قسمت تنظیمات امضا دیجیتال و شماره پیامک را ثبت کنید";
                    lblError.ForeColor = Color.Black;
                    return;
                }
                if (txtPhone.TextLength > 11 || txtPhone.TextLength < 11 || txtPhone.Text.StartsWith("09") == false)
                {
                    lblError.ForeColor = Color.Red;
                    lblError.Text = "شماره موبایل اشتباه است";
                    //txtPhone.Text = "0";
                    txtPhone.Focus();
                    return;
                }
                if (vaziyzt == 1)
                {
                    try
                    {
                        //Ping ping = new Ping();
                        //PingReply pingStatus = ping.Send("google.com");

                        //if (pingStatus.Status == IPStatus.Success)
                        //{
                        //***********baraye check kardane ertebat
                        //HttpWebRequest reqCheack = (HttpWebRequest)WebRequest.Create("http://login.parsgreen.com/UrlService/sendSMS.ashx?from=");
                        //System.Net.WebResponse respCheack = reqCheack.GetResponse();
                        //***********

                        string value = "";
                            PARSGREEN.API.SMS.Send.SendSMS send = new PARSGREEN.API.SMS.Send.SendSMS();
                            int result = send.Send(sign.Signature, txtPhone.Text, message, ref value);
                            if (result == 1)
                                MessageBox.Show(message);
                            ////System.Web.HttpUtility.HtmlDecode(text);

                            //string pattern = "http://login.parsgreen.com/UrlService/sendSMS.ashx?from=" + sign.NumberSms + "&to=" + txtPhone.Text + "&text=" + message + "&signature=" + sign.Signature;

                            ////MessageBox.Show(pattern);
                            //System.IO.Stream st = null;
                            //System.IO.StreamReader sr = null;

                            //HttpWebRequest req = (HttpWebRequest)WebRequest.Create(pattern);
                            //Encoding encode = System.Text.Encoding.UTF8;

                            //System.Net.WebResponse resp = req.GetResponse();

                            //st = resp.GetResponseStream();
                            //sr = new System.IO.StreamReader(st, Encoding.UTF8);
                            //string result = sr.ReadToEnd().Substring(12, 1);
                            //if (result == "0")
                            //    MessageBox.Show(message);
                            ////MessageBox.Show(sr.ReadToEnd()); //Get_Return_Message_Sms(int.Parse(result);
                            //lblError.Text = Get_Return_Message_Sms(int.Parse(result));
                            //sr.Close();
                            //resp.Close();
                            PARSGREEN.API.SMS.Profile.ProfileService p = new PARSGREEN.API.SMS.Profile.ProfileService();
                            double creidet = p.GetCredit(sign.Signature);
                            var check = context.WhiteSms.FirstOrDefault();
                            double warning = double.Parse(check.R10);
                            if (creidet < warning)
                                MessageBox.Show("اعتبار پنل پیامک کمتر از"+ warning+" ریال است", "پنل پیامک", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            if (result != 1)
                            {
                                ErsalNashode En = new ErsalNashode();
                                En.Name = txtName.Text;
                                En.Phone = txtPhone.Text;
                                En.Message = message;
                                En.Date = int.Parse(dtNewService.Text.Replace("/", ""));
                                En.Time = DateTime.Now.ToLongTimeString();
                                En.CodeRahgiri = lblCodeRahgiri.Text;
                                context.ErsalNashode.Add(En);
                                context.SaveChanges();
                                //MessageBox.Show("اینترنت وصل نیست", "اینترنت", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                MessageBox.Show("اینترنت وصل نیست،در موارد ارسال نشده ذخیره شد", " وصل نیست اینترنت", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                        //}
                    }
                    catch (Exception)
                    {
                        ErsalNashode En = new ErsalNashode();
                        En.Name = txtName.Text;
                        En.Phone = txtPhone.Text;
                        En.Message = message;
                        En.Date = int.Parse(dtNewService.Text.Replace("/", ""));
                        En.Time = DateTime.Now.ToLongTimeString();
                        En.CodeRahgiri = lblCodeRahgiri.Text;                        
                        context.ErsalNashode.Add(En);
                        context.SaveChanges();
                        //MessageBox.Show("اینترنت وصل نیست", "اینترنت", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        MessageBox.Show("اینترنت وصل نیست،در موارد ارسال نشده ذخیره شد", " وصل نیست اینترنت", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("مشکل در ارسال پیامک خوش آمدگویی" + "\n" + ex.Message);
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = "";
                using (var context = new kitchenEntities())
                {
                    var countService = context.Service.Where(c => c.Mobile == txtPhone.Text).ToList();
                    lblSomeService.Text = countService.Count.ToString();
                    //txtNumberService.Text = (countService.Count + 1).ToString();

                    bool isService = context.User.Where(check => check.Phone == txtPhone.Text).Any();
                    if (isService)
                    {
                        var mobile = context.User.Where(serv => serv.Phone == txtPhone.Text).FirstOrDefault();
                        txtName.Text = mobile.Name;
                        txtEshterak.Text = mobile.Eshterak;
                        txtEmail.Text = mobile.Email;
                    }
                    else
                    {
                        //txtName.Text = "";
                        //txtPhone.Text = "";
                        //lblError.ForeColor = Color.Red;
                        //lblError.Text = "کاربری بااین شماره موبایل وجود ندارد";
                        //txtEshterak.Focus();
                    }
                }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            int vaziyat = 1;
            try
            {
                if (txtCodeRahgiri.Text == "")
                {
                    lblError.ForeColor = Color.Red;
                    lblError.Text = "کد رهگیری را وارد کنید";
                    return;
                }
                using (var context = new kitchenEntities())
                {

                    var x = context.Setting.FirstOrDefault();
                    if (x.ReadySms == "true")
                    {
                        vaziyat = 1;
                    }
                    else
                    {
                        vaziyat = 0;
                    }
                    //------
                    var select = context.ReportService.Where(c => c.CodeRahgiri == txtCodeRahgiri.Text).ToList();
                    for (int i = 0; i < select.Count;i++)
                    {
                        select[i].Ready = "0";

                    }
                    context.SaveChanges();
                    //------
                }
            }
            catch (Exception)
            {
                lblError.Text = "ابتدا باید مشخصات مدیر را در بخش تنظیمات ثبت کنید";
                return;
                //MessageBox.Show(ex.Message);
            }

            if (vaziyat == 1)
            {
                try
                {
                    if (txtPhone.TextLength > 11 || txtPhone.TextLength < 11 || txtPhone.Text.StartsWith("09") == false)
                    {
                        lblError.ForeColor = Color.Red;
                        lblError.Text = "شماره موبایل اشتباه است";
                        //txtPhone.Text = "0";
                        txtPhone.Focus();
                        return;
                    }
                    //Ping ping = new Ping();
                    //PingReply pingStatus = ping.Send("google.com");

                    //if (pingStatus.Status == IPStatus.Success)
                    //{

                    //-----ersal sms

                    //***********baraye check kardane ertebat
                    //HttpWebRequest reqCheack = (HttpWebRequest)WebRequest.Create("http://login.parsgreen.com/UrlService/sendSMS.ashx?from=");
                    //System.Net.WebResponse respCheack = reqCheack.GetResponse();
                    //***********
                    using (var context = new kitchenEntities())
                        {


                            var x = context.ReportService.Where(c => c.CodeRahgiri == txtCodeRahgiri.Text).FirstOrDefault();

                            if (x == null)
                            {
                                lblError.ForeColor = Color.Red;
                                lblError.Text = "شماره رهگیری اشتباه است";
                                return;
                            }
                            var selectphone = context.User.Where(c => c.Eshterak == x.Eshterak).FirstOrDefault();
                            string phone = selectphone.Phone;
                            string eshterak = selectphone.Eshterak;
                            string name = selectphone.Name;

                            var sign = context.Setting.FirstOrDefault();
                            if (sign.Signature == null || sign.Signature == "" || sign.NumberSms == null || sign.NumberSms == "")
                            {
                                lblError.ForeColor = Color.Red;
                                lblError.Text = "از قسمت تنظیمات امضا دیجیتال و شماره پیامک را ثبت کنید";
                                lblError.ForeColor = Color.Black;
                                return;
                            }

                            var sms = context.WhiteSms.Where(c => c.R1 != null && c.R1 != "").FirstOrDefault();
                            var setName = context.Setting.Where(c => c.CommercialName != "" || c.CommercialName != null).FirstOrDefault();
                            if (setName == null)
                            {
                                MessageBox.Show("از بخش تنظیمات پیامک نام تجاری را ثبت کنید", "تنظیمات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                                return;
                            }
                            string message = "";
                            if (string.IsNullOrEmpty(sms.R10))
                                 message = sms.R1 + txtName.Text.Replace(" ", ".") + sms.R3 + eshterak + sms.R5 + txtCodeRahgiri.Text + sms.R7 + sms.R8 + setName.CommercialName + sms.R11;
                            else
                                message = sms.R1 + txtName.Text.Replace(" ", ".") + sms.R3 + eshterak + sms.R5 + txtCodeRahgiri.Text + sms.R7 + sms.R8 + setName.CommercialName + dtNewService.Text + sms.R11;

                            //MessageBox.Show(message);
                            //return;
                            //--------
                            //System.Web.HttpUtility.HtmlDecode(text);

                            string pattern = "http://login.parsgreen.com/UrlService/sendSMS.ashx?from=" + sign.NumberSms + "&to=" + phone + "&text=" + message + "&signature=" + sign.Signature;

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
                            lblError.Text = Get_Return_Message_Sms(int.Parse(result));
                            sr.Close();
                            resp.Close();
                            //-------
                            PARSGREEN.API.SMS.Profile.ProfileService p = new PARSGREEN.API.SMS.Profile.ProfileService();
                            double creidet = p.GetCredit(sign.Signature);
                            var check = context.WhiteSms.FirstOrDefault();
                            double warning = double.Parse(check.R10);
                            if (creidet < warning)
                                MessageBox.Show("اعتبار پنل پیامک کمتر از" + warning + " ریال است", "پنل پیامک", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            //-------
                            //restStatus = send.SendGroupSMS(sig.Signature, sig.NumberSms, new string[] { txtPhone.Text }, message, false, string.Empty, ref successCount, ref restr);
                            //lblError.Text = Get_Return_Message_Sms(restStatus);
                            if (result == "0")
                            {
                                MessageBox.Show(message);
                                var sendSms = context.Service.Where(c => c.CodeRahgiri == txtCodeRahgiri.Text).FirstOrDefault();
                                if (sendSms.ReadyDate == null)
                                    sendSms.ReadyDate = int.Parse(dtNewService.Text.Replace("/", ""));
                                sendSms.SendReadySms++;
                                context.SaveChanges();
                            }
                            else
                            {
                                var sendSms = context.Service.Where(c => c.CodeRahgiri == txtCodeRahgiri.Text).FirstOrDefault();
                                if (sendSms.ReadyDate == null || sendSms.ReadyDate == 0)
                                    sendSms.ReadyDate = int.Parse(dtNewService.Text.Replace("/", ""));
                                //-----
                                ErsalNashode En = new ErsalNashode();
                                En.Name = selectphone.Name;
                                En.Phone = selectphone.Phone;
                                En.Message = message;
                                En.Date = int.Parse(dtNewService.Text.Replace("/", ""));
                                En.Time = DateTime.Now.ToLongTimeString();
                                En.CodeRahgiri = txtCodeRahgiri.Text;
                                context.ErsalNashode.Add(En);
                                context.SaveChanges();
                                MessageBox.Show("اینترنت وصل نیست،در موارد ارسال نشده ذخیره شد", " وصل نیست اینترنت", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            }
                        }
                    //}
                    //else
                    //{
                    //    MessageBox.Show("اینترنت وصل نیست", "اینترنت", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    //}
                }
                catch (Exception )
                {
                    try
                    {
                        kitchenEntities context = new kitchenEntities();
                        var sendSms = context.Service.Where(c => c.CodeRahgiri == txtCodeRahgiri.Text).FirstOrDefault();
                        if (sendSms.ReadyDate == null || sendSms.ReadyDate == 0)
                            sendSms.ReadyDate = int.Parse(dtNewService.Text.Replace("/", ""));
                        var sms = context.WhiteSms.Where(c => c.R1 != null && c.R1 != "").FirstOrDefault();
                        var setName = context.Setting.Where(c => c.CommercialName != "" || c.CommercialName != null).FirstOrDefault();
                        var serv = context.Service.Where(c => c.CodeRahgiri == txtCodeRahgiri.Text).FirstOrDefault();

                        //-----
                        string message = sms.R1 + serv.Name.Replace(" ",".") + sms.R3 + serv.Eshterak + sms.R5 + txtCodeRahgiri.Text + sms.R7 + sms.R8 + setName.CommercialName + sms.R10;

                        ErsalNashode En = new ErsalNashode();
                        En.Name = serv.Name;
                        En.Phone = serv.Mobile;
                        En.Message = message;
                        En.Date = int.Parse(dtNewService.Text.Replace("/", ""));
                        En.Time = DateTime.Now.ToLongTimeString();
                        En.CodeRahgiri = txtCodeRahgiri.Text;
                        context.ErsalNashode.Add(En);
                        context.SaveChanges();
                        //MessageBox.Show("اینترنت وصل نیست" + "\n" + ex.Message, "اینترنت", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        MessageBox.Show("اینترنت وصل نیست،در موارد ارسال نشده ذخیره شد", " وصل نیست اینترنت", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("1");
                    }
                }
            }
            else
            {
                try
                {
                    using (var context = new kitchenEntities())
                    {
                        var sendSms = context.Service.Where(c => c.CodeRahgiri == txtCodeRahgiri.Text).FirstOrDefault();
                        if (sendSms.ReadyDate ==null || sendSms.ReadyDate == null)
                            sendSms.ReadyDate = int.Parse(dtNewService.Text.Replace("/",""));
                        context.SaveChanges();
                        lblError.Text = "اطلاعات ثبت شد.پیامک ارسال نشد،به بخش تنظیمتات بروید";
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show("2" + "\n" + ex.Message);
                }
            }
        }

        private void FormServices_MouseClick(object sender, MouseEventArgs e)
        {
            txtAddKindService.Visible = false;
            txtAddKindkala.Visible = false;
            txtAddNameService.Visible = false;
        }

        private void btnDelKindService_Click(object sender, EventArgs e)
        {
            try
            {
                if (comServiceKind.Items.Count == 0)
                    return;
                using (var context = new kitchenEntities())
                {
                    lblError.Text = "";
                    var del = context.KindService.Where(c => c.Name == comServiceKind.Text).FirstOrDefault();
                    context.KindService.Remove(del);
                    context.SaveChanges();
                    lblError.ForeColor = Color.Green;
                    lblError.Text = "حذف شد";
                    var kindServ = context.KindService.ToList();
                    comServiceKind.DataSource = kindServ;
                    comServiceKind.DisplayMember = "Name";
                }
            }
            catch (Exception ex)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = ex.Message;
            }
        }

        private void panel2_MouseClick(object sender, MouseEventArgs e)
        {
            txtAddKindService.Visible = false;
            txtAddKindkala.Visible = false;
            txtAddNameService.Visible = false;
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            txtAddKindService.Visible = false;
            txtAddKindkala.Visible = false;
            txtAddNameService.Visible = false;
        }

        private void dgShow_MouseClick(object sender, MouseEventArgs e)
        {
            txtAddKindService.Visible = false;
            txtAddKindkala.Visible = false;
            txtAddNameService.Visible = false;
        }

        private void btnDelKindKala_Click(object sender, EventArgs e)
        {
            try
            {
                if (comKindKala.Items.Count == 0)
                    return;
                lblError.Text = "";
                using (var context = new kitchenEntities())
                {
                    var del = context.KindKala.Where(c => c.Name == comKindKala.Text).FirstOrDefault();
                    context.KindKala.Remove(del);
                    context.SaveChanges();
                    lblError.ForeColor = Color.Green;
                    lblError.Text = "حذف شد";
                    var kindkala = context.KindKala.ToList();
                    comKindKala.DataSource = kindkala;
                    comKindKala.DisplayMember = "Name";
                }
            }
            catch (Exception ex)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = ex.Message;
            }
        }

        private void btnDelNameService_Click(object sender, EventArgs e)
        {
            try
            {
                if (comServiceName.Items.Count == 0)
                    return;
                lblError.Text = "";
                using (var context = new kitchenEntities())
                {
                    var del = context.NameService.Where(c => c.Name == comServiceName.Text).FirstOrDefault();
                    context.NameService.Remove(del);
                    context.SaveChanges();
                    lblError.ForeColor = Color.Green;
                    lblError.Text = "حذف شد";
                    var nameService = context.NameService.ToList();
                    comServiceName.DataSource = nameService;
                    comServiceName.DisplayMember = "Name";
                }
            }
            catch (Exception ex)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = ex.Message;
            }
        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            try
            {
                using (var context = new kitchenEntities())
                {
                    var name = context.ServicesPrice.Where(current => current.ServisKind == comServiceKind.Text && current.ServiceKala == comKindKala.Text && current.ServiseName == comServiceName.Text).ToList();
                    if (name.Count == 0)
                    {
                        ServicesPrice pri = new ServicesPrice();
                        pri.ServisKind = comServiceKind.Text;
                        pri.ServiseName = comServiceName.Text;
                        pri.ServiceKala = comKindKala.Text;
                        //if (txtServisPrice.Text != "")
                        pri.ServicePrice = Convert.ToInt64(txtPrice.Text.Replace(",", ""));
                        // else
                        //pri.ServicePrice1 = 0;
                        context.SaveChanges();

                        context.ServicesPrice.Add(pri);
                        context.SaveChanges();
                        lblError.ForeColor = Color.Green;
                        lblError.Text = "اطلاعات خدمت ثبت شد";
                        btnAddService.Enabled = false;
                    }
                    else
                    {
                        lblError.ForeColor = Color.Red;
                        lblError.Text = " خدمت با این مقادیر وجود دارد";
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("مشکل در اضافه کردن" + "\n" + ex.Message);
            }
        }

        private void txtAddKindkala_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Enter)
            {
                using (var context = new kitchenEntities())
                {
                    KindKala kk = new KindKala();
                    kk.Name = txtAddKindkala.Text;
                    kk.NameService = comServiceKind.Text;

                    context.KindKala.Add(kk);
                    context.SaveChanges();

                    //------
                    var kindKala = context.KindKala.Where(c => c.NameService == comServiceKind.Text).ToList();
                    comKindKala.DataSource = kindKala;
                    comKindKala.DisplayMember = "Name";


                    txtAddKindkala.Visible = false;
                }
            }

        }

        private void txtAddKindService_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData==Keys.Enter)
            {
                using (var context = new kitchenEntities())
                {
                    KindService k = new KindService();
                    k.Name = txtAddKindService.Text;
                    context.KindService.Add(k);
                    context.SaveChanges();
                    //------
                    var kindServ = context.KindService.ToList();
                    comServiceKind.DataSource = kindServ;
                    comServiceKind.DisplayMember = "Name";

                    txtAddKindService.Visible = false;
                }
            }
        }

        private void txtAddNameService_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData==Keys.Enter)
            {
                using (var context = new kitchenEntities())
                {
                    NameService kkk = new NameService();
                    kkk.Name = txtAddNameService.Text;
                    context.NameService.Add(kkk);
                    context.SaveChanges();

                    //------
                    var nameServ = context.NameService.ToList();
                    comServiceName.DataSource = nameServ;
                    comServiceName.DisplayMember = "Name";

                    txtAddNameService.Visible = false;
                }
            }
        }

        private void dgShow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex==7 )
            {
                dgShow.Rows.Remove(dgShow.CurrentRow);
                //-----
                Int64 sum = 0;
                for (int i = 0; i < dgShow.RowCount; i++)
                {

                    sum = sum + Convert.ToInt64(dgShow.Rows[i].Cells[5].Value.ToString());
                }
                txtSumServices.Text = sum.ToString();
            }
        }

        private void comServiceKind_SelectedIndexChanged_2(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = "";
                run++;
                if (run < 3)
                {

                    return;
                }
                else
                {

                    using (var context = new kitchenEntities())
                    {
                        var kindKala = context.KindKala.Where(c => c.NameService == comServiceKind.Text).ToList();
                        comKindKala.DataSource = kindKala;
                        comKindKala.DisplayMember = "Name";
                        //-----
                        var service = context.ServicesPrice.Where(c => c.ServisKind == comServiceKind.Text && c.ServiseName == comServiceName.Text && c.ServiceKala == comKindKala.Text).FirstOrDefault();
                        if (service != null)
                        {
                            btnAddService.Enabled = false;
                            if (service.ServicePrice.Value.ToString() == "")
                                txtPrice.Text = "0";
                            else
                                txtPrice.Text = service.ServicePrice.Value.ToString();
                        }
                        else
                        {
                            btnAddService.Enabled = true;

                            lblError.Text = "این خدمت تعریف نشده است.از قسمت مدیریت قیمت استفاده کنید";
                            //MessageBox.Show("این خدمت تعریف نشده است.از قسمت مدیریت قیمت استفاده کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            lblError.Text = "";
            int vaziyat = 1;
            try
            {
                using (var context = new kitchenEntities())
                {
                    var x = context.Setting.FirstOrDefault();
                    if (x.DeliverySms == "true")
                    {
                        vaziyat = 1;
                    }
                    else
                    {
                        vaziyat = 0;
                    }
                }
            }
            catch (Exception)
            {
                lblError.Text = "ابتدا باید مشخصات مدیر را در بخش تنظیمات ثبت کنید";
                return;
                // MessageBox.Show(ex.Message);
            }
            try
            {
                kitchenEntities context = new kitchenEntities();
                var serv = context.Service.Where(c => c.CodeRahgiri == txtCodeRahgiri.Text).FirstOrDefault();
                var sms = context.WhiteSms.Where(c => c.D1 != null && c.D1 != "").FirstOrDefault();
                var x = context.ReportService.Where(c => c.CodeRahgiri == txtCodeRahgiri.Text).FirstOrDefault();
                var setName = context.Setting.Where(c => c.CommercialName != "" || c.CommercialName != null).FirstOrDefault();
                string message = "";
                if (string.IsNullOrEmpty(sms.D10))
                    message = sms.D1 + serv.Name.Replace(" ", ".") + sms.D3 + serv.Eshterak + sms.D5 + txtCodeRahgiri.Text + sms.D7 + sms.D8 + setName.CommercialName + sms.D11;
                else
                    message = sms.D1 + serv.Name.Replace(" ", ".") + sms.D3 + serv.Eshterak + sms.D5 + txtCodeRahgiri.Text + sms.D7 + sms.D8 + setName.CommercialName + dtNewService.Text + sms.D11;

                //-----ersal sms
                if (vaziyat == 1)
                {
                    if (txtCodeRahgiri.Text == "")
                    {
                        lblError.ForeColor = Color.Red;
                        lblError.Text = "کد رهگیری را وارد کنید";
                        return;
                    }

                    if (setName == null)
                    {
                        MessageBox.Show("از بخش تنظیمات نام تجاری را ثبت کنید", "تنظیمات", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    //Ping ping = new Ping();
                    //PingReply pingStatus = ping.Send("google.com");
                    //if (pingStatus.Status != IPStatus.Success)
                    //{


                    //}
                    //else
                    //{
                    //******
                    if (txtPhone.TextLength > 11 || txtPhone.TextLength < 11 || txtPhone.Text.StartsWith("09") == false)
                    {
                        lblError.ForeColor = Color.Red;
                        lblError.Text = "شماره موبایل اشتباه است";
                        //txtPhone.Text = "0";
                        txtPhone.Focus();
                        return;
                    }

                    //-----ersal sms

                    //***********baraye check kardane ertebat
                    //HttpWebRequest reqCheack = (HttpWebRequest)WebRequest.Create("http://login.parsgreen.com/UrlService/sendSMS.ashx?from=");
                    //System.Net.WebResponse respCheack = reqCheack.GetResponse();
                    //***********
                    if (x == null)
                        {
                            lblError.ForeColor = Color.Red;
                            lblError.Text = "شماره رهگیری اشتباه است";
                            return;
                        }
                        var selectphone = context.User.Where(c => c.Eshterak == x.Eshterak).FirstOrDefault();
                        txtPhone.Text = selectphone.Phone;
                        var sign = context.Setting.FirstOrDefault();
                        if (sign.Signature == null || sign.Signature == "" || sign.NumberSms == null || sign.NumberSms == "")
                        {
                            lblError.ForeColor = Color.Red;
                            lblError.Text = "از قسمت تنظیمات امضا دیجیتال و شماره پیامک را ثبت کنید";
                            lblError.ForeColor = Color.Black;
                            return;
                        }
                        //--------
                        //System.Web.HttpUtility.HtmlDecode(text);
                        //MessageBox.Show(message);
                        //return;
                        string pattern = "http://login.parsgreen.com/UrlService/sendSMS.ashx?from=" + sign.NumberSms + "&to=" + txtPhone.Text + "&text=" + message + "&signature=" + sign.Signature;

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
                        lblError.Text = Get_Return_Message_Sms(int.Parse(result));
                        sr.Close();
                        resp.Close();
                        //-------
                        PARSGREEN.API.SMS.Profile.ProfileService p = new PARSGREEN.API.SMS.Profile.ProfileService();
                        double creidet = p.GetCredit(sign.Signature);
                        var check = context.WhiteSms.FirstOrDefault();
                        double warning = double.Parse(check.R10);
                        if (creidet < warning)
                            MessageBox.Show("اعتبار پنل پیامک کمتر از" + warning + " ریال است", "پنل پیامک", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        //-------

                        if (result == "0")
                        {
                            MessageBox.Show(message);
                        }
                        //********
                        //baraye tasfiye boodan ya naboodan
                        var tasfiye = context.Service.Where(c => c.CodeRahgiri == txtCodeRahgiri.Text).FirstOrDefault();
                        if (chxTasfiye.Checked == true)
                        {
                            tasfiye.Tasfiye = "0";
                            //tasfiye.Baghimande = 0;
                        }
                        else
                            tasfiye.Tasfiye = "1";
                        context.SaveChanges();

                        //******
                        return;
                    //}

                }
                else
                {
                    try
                    {
                            var tasfiye = context.Service.Where(c => c.CodeRahgiri == txtCodeRahgiri.Text).FirstOrDefault();
                            if (chxTasfiye.Checked == true)
                            {
                                tasfiye.Tasfiye = "0";
                                //tasfiye.Baghimande = 0;
                                //tasfiye.Baghimande = 0;
                            }
                            context.SaveChanges();
                            lblError.Text = "اطلاعات ثبت شد.پیامک غیرفعال است";
                        
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("4 مشکل در ثبت تصفیه" + "\n" + ex.Message);
                    }
                }

            }
            catch (Exception)
            {
                try
                {
                    kitchenEntities context = new kitchenEntities();
                    var serv = context.Service.Where(c => c.CodeRahgiri == txtCodeRahgiri.Text).FirstOrDefault();
                    var sms = context.WhiteSms.Where(c => c.D1 != null && c.D1 != "").FirstOrDefault();
                    var x = context.ReportService.Where(c => c.CodeRahgiri == txtCodeRahgiri.Text).FirstOrDefault();
                    var setName = context.Setting.Where(c => c.CommercialName != "" || c.CommercialName != null).FirstOrDefault();
                    string message = sms.D1 + serv.Name.Replace(" ", ".") + sms.D3 + serv.Eshterak + sms.D5 + txtCodeRahgiri.Text + sms.D7 + sms.D8 + setName.CommercialName + dtNewService.Text;

                    ErsalNashode En = new ErsalNashode();
                    En.Name = serv.Name;
                    En.Phone = serv.Mobile;
                    En.Message = message;
                    En.Date = int.Parse(dtNewService.Text.Replace("/", ""));
                    En.Time = DateTime.Now.ToLongTimeString();
                    En.CodeRahgiri = txtCodeRahgiri.Text;
                    
                    context.ErsalNashode.Add(En);
                    //********
                    //baraye tasfiye boodan ya naboodan
                    var tasfiye = context.Service.Where(c => c.CodeRahgiri == txtCodeRahgiri.Text).FirstOrDefault();
                    if (chxTasfiye.Checked == true)
                    {
                        tasfiye.Tasfiye = "0";
                        //tasfiye.Baghimande = 0;
                    }
                    else
                        tasfiye.Tasfiye = "1";
                    context.SaveChanges();
                    //------
                    MessageBox.Show("اینترنت وصل نیست،در موارد ارسال نشده ذخیره شد", " وصل نیست اینترنت", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                catch (Exception )
                {
                    lblError.Text = "";

                }

                

            }
        
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = "";
                if (txtCodeRahgiri.Text == "")
                {
                    lblError.ForeColor = Color.Red;
                    lblError.Text = "کد رهگیری را وارد کنید";
                    return;
                }
                using (var context = new kitchenEntities())
                {
                    var x = context.Service.Where(c => c.CodeRahgiri == txtCodeRahgiri.Text).FirstOrDefault();
                    if (x == null)
                    {
                        lblError.ForeColor = Color.Red;
                        lblError.Text = "شماره رهگیری اشتباه است";
                        return;
                    }
                    else
                    {
                        lblError.Text = x.SumServices.ToString();
                        long sumService = long.Parse(lblError.Text);
                        lblError.Text = x.Bestankar.ToString();
                        long bestankar= long.Parse(lblError.Text);
                        lblError.Text = x.Takhfif.ToString();
                        long takhfif = long.Parse(lblError.Text);

                        lblError.Text = x.Pardakhti.ToString();
                        long pardkhti = long.Parse(lblError.Text);

                        long baghimande = (sumService - (pardkhti+takhfif+bestankar));
                        
                        string message = "مبلغ بیعانه: " + bestankar + "\n"+ "تخفیف: " + takhfif + "\n" + "مبلغ کل: " + sumService + "\n" + "پرداختی: " + pardkhti + "\n" + "مانده: " + baghimande;
                        MessageBox.Show(message, "گزارش", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                }
            catch (Exception )
            {

                lblCodeRahgiri.Text = "";
            }
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }


        private void txtPostiCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);

        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            txtPrice.Text = Seragham(txtPrice.Text);
            txtPrice.Select(txtPrice.TextLength, 0);
        }

        private void txtBeiane_TextChanged_1(object sender, EventArgs e)
        {

            lblError.Text = "";
            try
            {
                ////----------beiane
                //if (txtBeiane.Text == "")
                //    txtBeiane.Text = "0";

                //double beiane;
                //if (txtBeiane.Text != "")
                //    beiane = int.Parse(txtBeiane.Text.Replace(",", ""));
                //else
                //    beiane = 0;
                //if (txtPay.Text == "")
                //    txtPay.Text = "0";
                ////----------takhfif
                //if (txtDarsadTakhfif.Text == "")
                //    txtDarsadTakhfif.Text = "0";
                ////-----------mande
                //if (txtMande.Text == "0")
                //    txtMande.Text = "0";

                //double darsad;
                //if (txtDarsadTakhfif.Text != "")
                //    darsad = int.Parse(txtDarsadTakhfif.Text);
                //else
                //    darsad = 0;
                //if (darsad > 100)
                //    txtDarsadTakhfif.Text = "100";
                //if (darsad < 0)
                //    txtDarsadTakhfif.Text = "0";
                //double totalSome = double.Parse(txtSumServices.Text.Replace(",", ""));
                //double sum = double.Parse(txtPay.Text.Replace(",", ""));

                //double takhfif = totalSome * darsad;
                //takhfif = takhfif / 100;
                //txtSumTakhfif.Text = takhfif.ToString();

                //double mande = double.Parse(txtMande.Text.Replace(",", ""));

                ////----------

                //txtPay.Text = (((totalSome - beiane) - takhfif) + mande).ToString();
                //------
                //Some_Paye();
                txtBeiane.Text = Seragham(txtBeiane.Text);
                txtBeiane.Select(txtBeiane.TextLength, 0);

            }
            catch (Exception)
            {
                lblError.Text = "مشکل در حساب تخفیف";
            }
        }

        private void txtSumTakhfif_TextChanged_1(object sender, EventArgs e)
        {
            try
            {
                //Some_Paye();
                txtSumTakhfif.Text = Seragham(txtSumTakhfif.Text);
                txtSumTakhfif.Select(txtSumTakhfif.TextLength, 0);
            }
            catch (Exception)
            {
                lblError.Text = "مشکل در حساب تخفیف";
            }


            
        }

        private void txtSumServices_TextChanged_1(object sender, EventArgs e)
        {
            txtSumServices.Text = Seragham(txtSumServices.Text);
            txtSumServices.Select(txtSumServices.TextLength, 0);
            Some_Paye();
        }

        private void txtBeiane_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);
        }

        private void txtSumServices_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);
        }

        private void txtPrice_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);
        }

        private void txtDarsadTakhfif_TextChanged_1(object sender, EventArgs e)
        {

            lblError.Text = "";
            try
            {
                //if (txtSumTakhfif.Text == "")
                //    txtSumTakhfif.Text = "0";
                ////----------beiane
                //if (txtBeiane.Text == "")
                //    txtBeiane.Text = "0";

                //double beiane;
                //if (txtBeiane.Text != "")
                //    beiane = int.Parse(txtBeiane.Text.Replace(",", ""));
                //else
                //    beiane = 0;
                //if (txtPay.Text == "")
                //    txtPay.Text = "0";
                ////----------takhfif
                //if (txtDarsadTakhfif.Text == "")
                //    txtDarsadTakhfif.Text = "0";
                ////-----------mande
                //if (txtMande.Text == "0")
                //    txtMande.Text = "0";
                //double darsad;
                //if (txtDarsadTakhfif.Text != "")
                //    darsad = int.Parse(txtDarsadTakhfif.Text);
                //else
                //    darsad = 0;
                //if (darsad > 100)
                //    txtDarsadTakhfif.Text = "100";
                //if (darsad < 0)
                //    txtDarsadTakhfif.Text = "0";
                //double totalSome = double.Parse(txtSumServices.Text.Replace(",", ""));
                //double sum = double.Parse(txtPay.Text.Replace(",", ""));

                //double takhfif = totalSome * darsad;
                //takhfif = takhfif / 100;
                //txtSumTakhfif.Text = takhfif.ToString();

                //double mande = double.Parse(txtMande.Text.Replace(",", ""));
                ////----------

                //txtPay.Text = (((totalSome - beiane) - takhfif)+mande).ToString();
                ////------
                //Some_Paye();
                txtBeiane.Text = Seragham(txtBeiane.Text);
                txtBeiane.Select(txtBeiane.TextLength, 0);
                
            }
            catch (Exception)
            {
                lblError.Text = "مشکل در حساب تخفیف";
            }
        }

        private void txtDarsadTakhfif_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);
        }

        private void txtEshterak_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);

        }

        private void txtEshterak_TextChanged_2(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = "";
                lblEndRahgiri.Text = "";
                //-----

                dgShow.Rows.Clear();
                txtSumServices.Text = "";
                txtEmail.Text = "";
                lblCodeRahgiri.Text = "";
                lblError.Text = "";
                txtBeiane.Text = "";
                txtPay.Text = "";
                txtDarsadTakhfif.Text = "0";
                txtSumTakhfif.Text = "0";
                txtMande.Text = "0";
                lblTotalPrice.Text = "";

                //-----
                if (chxNewCustomer.Checked == false)
                {
                    using (var context = new kitchenEntities())
                    {
                        var countService = context.Service.Where(c => c.Eshterak == txtEshterak.Text).ToList();
                        lblSomeService.Text = countService.Count.ToString();

                        var mobile = context.User.Where(serv => serv.Eshterak == txtEshterak.Text).FirstOrDefault();
                        if (mobile == null)
                        {
                            txtName.Text = "";
                            txtPhone.Text = "";
                            txtAddress.Text = "";
                            txtEmail.Text = "";
                            txtPostiCode.Text = "";
                            dtBirthDay.Text = "";
                            dtBirthDay.Enabled = true;
                            return;
                        }
                        else
                        {
                            txtName.Text = mobile.Name;
                            txtPhone.Text = mobile.Phone;
                            txtAddress.Text = mobile.Address;
                            txtEmail.Text = mobile.Email;
                            txtPostiCode.Text = mobile.PostiCode;
                            //BPersianCalenderTextBox cal = new BPersianCalenderTextBox();
                            string date = mobile.BirthDayDate.ToString();
                            //dtBirthDay.Shamsi = mobile.BirthDayDate.ToString();
                            if (date.Length>5)
                            {
                                date = date.Insert(4, "/");
                                date = date.Insert(7, "/");
                                dtBirthDay.Text = date;
                            }
                            dtBirthDay.Enabled = false;
                            
                            //dtBirthDay.Text = mobile.BirthDayDate.ToString();
                        }

                        //------akharin code rahgiri in shomare eshterak
                        var find = context.Service.Where(c => c.Eshterak == txtEshterak.Text).ToList();
                        if (find != null)
                        {
                            var end = find.LastOrDefault();
                            lblEndRahgiri.Text = end.CodeRahgiri;
                        }
                        ///-----

                        var price = context.Service.Where(c => c.Eshterak == txtEshterak.Text).ToList();
                        //------mohasebe jame baghimande
                        long bestankar = 0, takhfif = 0, pardakhti = 0, sumService = 0, sum = 0,totalSum=0;


                        for (int i = 0; i < price.Count; i++)
                        {
                            pardakhti = 0; bestankar = 0; takhfif = 0; sumService = 0;
                            takhfif = Int64.Parse(takhfif + price[i].Takhfif.Value.ToString());
                            bestankar = price[i].Bestankar.Value;
                            pardakhti = price[i].Pardakhti.Value;
                            sumService = price[i].SumServices.Value;
                            totalSum = totalSum + sumService;//kole mablaghe khadamat
                            sum = sum + (sumService - (pardakhti + bestankar + takhfif));
                        }
                        lblTotalPrice.Text = Seragham(totalSum.ToString());
                        if (sum < 0)
                        {
                            txtBeiane.Text = sum.ToString().Remove(0, 1);

                            txtMande.Text = "0";
                            return;
                        }
                        if (sum > 0)
                        {
                            txtBeiane.Text = "0";
                            txtMande.Text = sum.ToString();
                            return;
                        }
                        if (sum == 0)
                        {
                            txtBeiane.Text = "0";
                            txtMande.Text = "0";
                        }


                        //------
                    }
                }
            }
            catch (Exception)
            {

                lblError.Text = "";
            }
        }

        private void sumAfterTakhfif_TextChanged(object sender, EventArgs e)
        {
            //somePaye();
            //txtsumAfterTakhfif.Text = Seragham(txtsumAfterTakhfif.Text);
            //txtsumAfterTakhfif.Select(txtsumAfterTakhfif.TextLength, 0);
        }

        private void txtsumAfterTakhfif_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);

        }

        private void btnSearchCodeRahgiri_Click(object sender, EventArgs e)
        {
            try
            {

                using (var context = new kitchenEntities())
                {
                    //string select = dgSearch.CurrentRow.Cells[9].Value.ToString();
                    //var user = context.ReportServices.Where(c => c.CodeRahgiri == txtCodeRahgiri.Text).ToList();

                    FormReportServices frmReportServices = new FormReportServices();
                    frmReportServices.label1.Text = txtCodeRahgiri.Text;
                    //frmReportServices.dgSearch.DataSource = user;
                    //frmReportServices.MdiParent = this;
                    frmReportServices.Show();
                }
                //Design_GrideView_Service();
            }
            catch (Exception ex)
            {

                MessageBox.Show("سفارش انتخاب شده کد رهگیری ندارد \n " + ex.Message);
            }
        }

        private void txtPay_TextChanged(object sender, EventArgs e)
        {
            try
            {
                //Some_Paye();
                if (txtPay.Text == "")
                txtPay.Text = "0";
                txtPay.Text = Seragham(txtPay.Text);
                txtPay.Select(txtPay.TextLength, 0);

            }
            catch (Exception)
            {
                lblError.Text = "مشکل در حساب تخفیف";
            }

        }

        private void txtEshterak_Leave(object sender, EventArgs e)
        {
            try
            {
                using (var context = new kitchenEntities())
                {
                    int tavalod = Find_BirthDay(dtNewService.Text, 1);
                    var Userbirthday = context.User.Where(c => c.Eshterak == txtEshterak.Text).First();
                    if (Userbirthday.BirthDayDate == tavalod)
                    {
                        MessageBox.Show(" فردا تولد " + Userbirthday.Name + " است ");
                    }
                }
            }
            catch (Exception)
            {

                lblError.Text = "";
            }
        }

        private void txtMande_TextChanged(object sender, EventArgs e)
        {
            txtMande.Text = Seragham(txtMande.Text);
            txtMande.Select(txtMande.TextLength, 0);
        }

        private void txtMande_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);
        }

        private void txtPay_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);
        }

        private void txtBeiane_Leave(object sender, EventArgs e)
        {
            Some_Paye();
        }

        private void txtDarsadTakhfif_Leave(object sender, EventArgs e)
        {
            Some_Paye();
        }

        private void txtMande_Leave(object sender, EventArgs e)
        {
            Some_Paye();
        }

        private void txtSumTakhfif_Leave(object sender, EventArgs e)
        {
            Some_Paye();
        }

        private void btnErsalNashode_Click(object sender, EventArgs e)
        {
            FormErsalNashode frmErsalNashode = new FormErsalNashode();
            frmErsalNashode.Show();

        }

        private void txtPhone_TextChanged_1(object sender, EventArgs e)
        {
            lblError.Text = "";
            kitchenEntities context = new kitchenEntities();
            var select = context.User.Where(serv => serv.Phone == txtPhone.Text).FirstOrDefault();
            if (chxNewCustomer.Checked == false)
            {

                if (select != null)
                {
                    txtEshterak.Text = select.Eshterak;
                    txtName.Text = select.Name;
                }
            }
            else
            {
                if (txtPhone.TextLength == 11)
                {
                    txtEshterak.Text = txtPhone.Text.Substring(7, 4);
                    txtName.Text = "";
                    txtName.Focus();
                    var check = context.User.Where(c => c.Eshterak == txtEshterak.Text).FirstOrDefault();
                    if (check != null)
                    {
                        lblError.Text = "این شماره اشتراک وجود دارد";
                        txtName.Text = check.Name;
                        txtPhone.Focus();
                    }
                }
            }
        }

        private void txtPhone_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);
        }

        private void btnEditSmallReport_Click(object sender, EventArgs e)
        {
            FormEditSmallReport frmSmallReport = new FormEditSmallReport();
            frmSmallReport.label1.Text = txtCodeRahgiri.Text;
            frmSmallReport.Show();
        }


        private void btnPay_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            try
            {
                if (txtCodeRahgiri.Text == "")
                    return;


                kitchenEntities context = new kitchenEntities();
                var selectRahgiri = context.Service.Where(c => c.CodeRahgiri == txtCodeRahgiri.Text).FirstOrDefault();
                if (selectRahgiri == null)
                {
                    lblError.Text = "کد رهگیری اشتباه است";
                    return;
                }
                else
                {
                    //selectRahgiri.Bestankar = Int64.Parse(txtBeiane.Text.Replace(",", ""));
                    //selectRahgiri.Takhfif = Int64.Parse(txtSumTakhfif.Text.Replace(",", ""));
                    //selectRahgiri.SumServices = Int64.Parse(txtSumServices.Text.Replace(",", ""));
                    var beforePay = selectRahgiri.Pardakhti;
                    selectRahgiri.Pardakhti = Convert.ToInt64(txtPay.Text.Replace(",", "")) + beforePay;
                    context.SaveChanges();
                    lblError.Text = "ثبت شد";
                }
            }
            catch (Exception)
            {

                lblError.Text="خطا در پرداخت";
            }
        }


        private void comCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (chxNewCustomer.Checked == false)
            {
                kitchenEntities context = new kitchenEntities();
                var select = context.User.Where(serv => serv.Name == txtName.Text).FirstOrDefault();
                if (select != null)
                {
                    txtEshterak.Text = select.Eshterak;
                    txtPhone.Text = select.Phone;
                }
            }
        }

        private void txtCodeRahgiri_TextChanged_1(object sender, EventArgs e)
        {
            lblError.Text = "";
            txtBeiane.Text = "0";
            txtSumTakhfif.Text = "0";
            txtDarsadTakhfif.Text = "0";
            txtSumServices.Text = "0";
            txtPay.Text = "0";
            txtMande.Text = "0";
            try
            {
                if (txtCodeRahgiri.Text == "")
                    return;

                kitchenEntities context = new kitchenEntities();
                var selectRahgiri = context.Service.Where(c => c.CodeRahgiri == txtCodeRahgiri.Text).FirstOrDefault();
                if (selectRahgiri == null)
                {
                    //lblError.Text = "کد رهگیری اشتباه است";
                    return;
                }
                else
                {
                    txtName.Text = selectRahgiri.Name;
                    txtEshterak.Text = selectRahgiri.Eshterak;
                    txtPhone.Text = selectRahgiri.Mobile;
                    //txtBeiane.Text = selectRahgiri.Bestankar.ToString();
                    string beiane = selectRahgiri.Bestankar.ToString();
                    //txtSumTakhfif.Text = selectRahgiri.Takhfif.ToString();
                    string takhfif = selectRahgiri.Takhfif.ToString();
                    //txtSumServices.Text = selectRahgiri.SumServices.ToString();
                    string sumService = selectRahgiri.SumServices.ToString();
                    string Pay = selectRahgiri.Pardakhti.ToString();
                    int b = int.Parse(beiane), t = int.Parse(takhfif), s = int.Parse(sumService), p = int.Parse(Pay);
                    Int64 cal = s - (b + t + p);
                    //txtPay.Text = cal.ToString();
                    if (cal < 0)
                        txtBeiane.Text = cal.ToString().Remove(0, 1);
                    if (cal >= 0)
                        txtMande.Text = cal.ToString();

                }
            }
            catch (Exception)
            {

                lblError.Text = "خطا در پرداخت";
            }
        }

        private void chxNewCustomer_CheckedChanged(object sender, EventArgs e)
        {
            if (chxNewCustomer.Checked == false)
            {
                using (var context = new kitchenEntities())
                {
                    //*******Auto Fill Eshterak - Name - Phone
                    if (chxNewCustomer.Checked == false)
                    {
                        var select = context.User.ToList();
                        //------

                        string[] eshterak = new string[select.Count];
                        for (int i = 0; i < select.Count; i++)
                        {
                            eshterak[i] = select[i].Eshterak.ToString();
                        }
                        //txtEshterak.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        AutoCompleteStringCollection suggest = new AutoCompleteStringCollection();
                        txtEshterak.AutoCompleteCustomSource = suggest;
                        suggest.AddRange(eshterak);
                        //-----------
                        string[] Name = new string[select.Count];
                        for (int i = 0; i < select.Count; i++)
                        {
                            Name[i] = select[i].Name.ToString();
                        }
                        //txtName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                        AutoCompleteStringCollection suggestName = new AutoCompleteStringCollection();
                        txtName.AutoCompleteCustomSource = suggestName;
                        suggestName.AddRange(Name);
                        //-------
                        string[] Phone = new string[select.Count];
                        for (int i = 0; i < select.Count; i++)
                        {
                            Phone[i] = select[i].Phone.ToString();
                        }
                        AutoCompleteStringCollection suggestPhone = new AutoCompleteStringCollection();
                        txtPhone.AutoCompleteCustomSource = suggestPhone;
                        suggestPhone.AddRange(Phone);
                    }
                }
            }
            else
            {
                
                txtEshterak.AutoCompleteCustomSource = null;
                txtName.AutoCompleteCustomSource = null;
                txtPhone.AutoCompleteCustomSource = null;
                txtName.Text = "";
                txtPhone.Text = "";
                txtEshterak.Text = "";
                txtPhone.Focus();
                dtBirthDay.Enabled = true;
            }
        }

        private void txtEshterak_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            using (var context = new kitchenEntities())
            {
                var editUser = context.User.Where(c => c.Eshterak == txtEshterak.Text).FirstOrDefault();
                if (editUser != null)
                {
                    FormEditUser frmEditUser = new FormEditUser();
                    frmEditUser.txtEshterak.Text = editUser.Eshterak;
                    //---------------------
                    frmEditUser.txtName.Text = editUser.Name;
                    //---------------------
                    if (editUser.Date == 0)
                        frmEditUser.txtEnter.Text = "";
                    else
                        frmEditUser.txtEnter.Text = editUser.Date.ToString();
                    //---------------------
                    frmEditUser.txtPhone.Text = editUser.Phone;
                    //---------------------
                    frmEditUser.txtEmail.Text = editUser.Email;
                    //---------------------
                    if (editUser.BirthDayDate == 0)
                        frmEditUser.txtBirthDay.Text = "";
                    else
                        frmEditUser.txtBirthDay.Text = editUser.BirthDayDate.ToString();
                    //---------------------
                    frmEditUser.txtAddress.Text = editUser.Address;
                    //---------------------
                    frmEditUser.txtPostiCode.Text = editUser.PostiCode;
                    //---------------------
                    frmEditUser.phoneNumber = editUser.Phone;
                    frmEditUser.Show();
                }
            }
        }

        private void txtName_DoubleClick(object sender, EventArgs e)
        {
            using (var context = new kitchenEntities())
            {
                var editUser = context.User.Where(c => c.Name == txtName.Text).FirstOrDefault();
                if (editUser != null)
                {
                    FormEditUser frmEditUser = new FormEditUser();
                    frmEditUser.txtEshterak.Text = editUser.Eshterak;
                    //---------------------
                    frmEditUser.txtName.Text = editUser.Name;
                    //---------------------
                    frmEditUser.txtEnter.Text = editUser.Date.ToString();
                    //---------------------
                    frmEditUser.txtPhone.Text = editUser.Phone;
                    //---------------------
                    frmEditUser.txtEmail.Text = editUser.Email;
                    //---------------------
                    frmEditUser.txtBirthDay.Text = editUser.BirthDayDate.ToString();
                    //---------------------
                    frmEditUser.txtAddress.Text = editUser.Address;
                    //---------------------
                    frmEditUser.txtPostiCode.Text = editUser.PostiCode;
                    //---------------------
                    frmEditUser.Show();
                }
            }
        }

        private void txtPhone_DoubleClick(object sender, EventArgs e)
        {
            using (var context = new kitchenEntities())
            {
                var editUser = context.User.Where(c => c.Phone == txtPhone.Text).FirstOrDefault();
                if (editUser != null)
                {
                    FormEditUser frmEditUser = new FormEditUser();
                    frmEditUser.txtEshterak.Text = editUser.Eshterak;
                    //---------------------
                    frmEditUser.txtName.Text = editUser.Name;
                    //---------------------
                    frmEditUser.txtEnter.Text = editUser.Date.ToString();
                    //---------------------
                    frmEditUser.txtPhone.Text = editUser.Phone;
                    //---------------------
                    frmEditUser.txtEmail.Text = editUser.Email;
                    //---------------------
                    frmEditUser.txtBirthDay.Text = editUser.BirthDayDate.ToString();
                    //---------------------
                    frmEditUser.txtAddress.Text = editUser.Address;
                    //---------------------
                    frmEditUser.txtPostiCode.Text = editUser.PostiCode;
                    //---------------------
                    frmEditUser.Show();
                }
            }
        }

        private void txtCodeRahgiri_DoubleClick(object sender, EventArgs e)
        {
            using (var context = new kitchenEntities())
            {
                var editService = context.Service.Where(c => c.CodeRahgiri == txtCodeRahgiri.Text).FirstOrDefault();
                if (editService != null)
                {
                    FormEditService frmEditSer = new FormEditService();

                    frmEditSer.txtEshterak.Text = editService.Eshterak;
                    //-----------
                    frmEditSer.txtName.Text = editService.Name;
                    //-----------
                    frmEditSer.txtDateService.Text = editService.DateService.ToString();
                    //-----------
                    frmEditSer.txtPhone.Text = editService.Mobile;
                    //-----------
                    frmEditSer.txtBeiane.Text = editService.Bestankar.ToString();
                    //-----------
                    frmEditSer.txtPardakhti.Text = editService.Pardakhti.ToString();
                    //-----------
                    frmEditSer.txtTakhfif.Text = editService.Takhfif.ToString();
                    //-----------
                    frmEditSer.txtTotalSum.Text = editService.SumServices.ToString();
                    //-----------
                    frmEditSer.txtCodeRahgiri.Text = editService.CodeRahgiri;
                    //-----------
                    frmEditSer.txtSomeService.Text = editService.NumberService;
                    //-----------
                    frmEditSer.txtReadyDate.Text = editService.ReadyDate.ToString();
                    //-----------
                    frmEditSer.txtReadySms.Text = editService.SendReadySms.ToString();
                    //-----------
                    frmEditSer.txtDescription.Text = editService.Description;
                    //-----------

                    frmEditSer.Show();
                }
            }
        }
    }
}