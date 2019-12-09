using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PARSGREEN;
namespace Laundry
{
    public partial class FormSms : Form
    {
        public FormSms()
        {
            InitializeComponent();
        }

        private void btnMoney_Click(object sender, EventArgs e)
        {
            try
            {
                    lblMoney.Text = "";
                PARSGREEN.API.SMS.Profile.ProfileService p = new PARSGREEN.API.SMS.Profile.ProfileService();
                double creidet = p.GetCredit(txtSignature.Text);
                lblMoney.Text = creidet.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void Design_GrideView_User()
        {
            if (dgSearch.DataSource != null)
            {
                dgSearch.Columns[0].HeaderText = "اشتراک";
                dgSearch.Columns[1].HeaderText = "نام";
                dgSearch.Columns[2].Visible = false;
                //dgSearch.Columns[2].HeaderText = " تاریخ";
                //dgSearch.Columns[2].DefaultCellStyle.Format = "0000/00/00";
                //dgSearch.Columns[3].Visible = false;
                dgSearch.Columns[3].HeaderText = "شماره تماس";
                dgSearch.Columns[4].Visible = false;
                //dgSearch.Columns[4].HeaderText = "ایمیل";
                // dgSearch.Columns[5].Visible = false;
                dgSearch.Columns[5].HeaderText = "تاریخ تولد";
                dgSearch.Columns[5].DefaultCellStyle.Format = "0000/00/00";
                dgSearch.Columns[6].Visible = false;
                dgSearch.Columns[6].HeaderText = "آدرس";
                dgSearch.Columns[7].Visible = false;
                dgSearch.Columns[7].HeaderText = "کد پستی";
                dgSearch.Columns[8].Visible = false;
                dgSearch.Columns[8].HeaderText = "شماره ";


            }
        }
        private void Design_GrideView_Service()
        {

            dgSearch.Columns[0].HeaderText = "اشتراک";
            dgSearch.Columns[1].HeaderText = "نام";
            dgSearch.Columns[2].HeaderText = "تاریخ سرویس";
            dgSearch.Columns[2].DefaultCellStyle.Format = "0000/00/00";
            dgSearch.Columns[3].HeaderText = "شماره تماس";
            dgSearch.Columns[4].Visible = false;
            //dgSearch.Columns[4].HeaderText = "بیعانه";
            dgSearch.Columns[5].Visible = false;
            //dgSearch.Columns[5].HeaderText = "باقیمانده";
            dgSearch.Columns[6].Visible = false;
            //dgSearch.Columns[6].HeaderText = "تخفیف ";
            dgSearch.Columns[7].Visible = false;
            //dgSearch.Columns[7].HeaderText = " مبلغ کل";
            dgSearch.Columns[8].Visible = false;
            //dgSearch.Columns[8].HeaderText = "تصفیه";
            dgSearch.Columns[9].Visible = false;
            //dgSearch.Columns[9].HeaderText = "کد رهگیری";
            dgSearch.Columns[10].Visible = false;
            dgSearch.Columns[10].HeaderText = "تعداد";
            dgSearch.Columns[11].Visible = false;
            //dgSearch.Columns[11].HeaderText = "تاریخ آماده";
           // dgSearch.Columns[11].DefaultCellStyle.Format = "0000/00/00";
            dgSearch.Columns[12].Visible = false;
           // dgSearch.Columns[12].HeaderText = "تعداد پیامک آماده";
            dgSearch.Columns[13].Visible = false;
            //dgSearch.Columns[13].HeaderText = "توضیحات ";
            dgSearch.Columns[14].Visible = false;
            //dgSearch.Columns[14].HeaderText = "شماره ";
            //dgSearch.Width = 750;
            //dgSearch.Height = 370;
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
        private void btnCountMessage_Click(object sender, EventArgs e)
        {
            try
            {
                //if (txtSignature.Text == "")
                //{
                //    MessageBox.Show("امضا دیجیتال را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    txtSignature.Focus();
                //    return;
                //}
                lblCountMessagSend.Text = "";
                lblCountMessageRecevie.Text = "";
                //PARSGREEN.API_MsgServic.MsgService ms = new PARSGREEN.API_MsgService.MsgService();
                PARSGREEN.API.SMS.Message.MsgService ms = new PARSGREEN.API.SMS.Message.MsgService();
                int countRe = ms.GetMsgCount(txtSignature.Text, 1, false);
                int countSend = ms.GetMsgCount(txtSignature.Text, 2, false);
                lblCountMessagSend.Text = countSend.ToString();
                lblCountMessageRecevie.Text = countRe.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                int vaziyzt = 1;
                using (var context = new kitchenEntities())
                {
                    try
                    {
                        var x = context.Setting.FirstOrDefault();
                        if (x.GroupSms == "true")
                        {
                            vaziyzt = 1;
                        }
                        else
                        {
                            vaziyzt = 0;
                        }
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ابتدا باید مشخصات مدیر را در بخش تنظیمات ثبت کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                        return;
                        //MessageBox.Show(ex.Message);
                    }

                    if (txtSignature.Text == "" || txtSMSnumber.Text == "")
                    {
                        MessageBox.Show("امضا دیجیتال یا شماره پیامک اشتباه است", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtSignature.Focus();
                        return;
                    }
                    if (vaziyzt == 1)
                    {
                        lblSendMessage.Text = "";
                        lblDelivery.Text = "";
                        PARSGREEN.API.SMS.Send.SendSMS send = new PARSGREEN.API.SMS.Send.SendSMS();
                        int successCount = 0;
                        int restStatus;
                        string[] restr = null;
                        restStatus = send.SendGroupSMS(txtSignature.Text, txtSMSnumber.Text, new string[] { txtMobilesNumbers.Text }, txtMessageBody.Text, false, string.Empty, ref successCount, ref restr);
                        if (restStatus == 1)
                        {
                            MessageBox.Show("ارسال شد", "پیامک", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            lblSendMessage.Text = restStatus.ToString();
                            lblDelivery.Text = successCount.ToString();
                            return;
                        }
                        if (restStatus == -1)
                        {
                            MessageBox.Show("امضا دیجیتال یا شماره پیامک اشتباه است", "پیامک", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                            return;
                        }
                    }
                    else
                     MessageBox.Show("برای فعال سازی یه بخش تنظیمتات بروید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    //MessageBox.Show("تعداد پیام ها: " + restStatus.ToString() + "\r" + "تحویل داده شده اولیه: " + successCount);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSendMessage_Click(object sender, EventArgs e)
        {
            try
            {
                //if (txtSignature.Text == "")
                //{
                //    MessageBox.Show("امضا دیجیتال را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    txtSignature.Focus();
                //    return;
                //}
                //int rowinPage = 5;
                //int startRow = 1;
                //int location = 2;
                if (txtSignature.Text != "" || txtSignature.Text != null)
                {
                    //PARSGREEN.API_MsgService.MsgService message = new PARSGREEN.API_MsgService.MsgService();
                    PARSGREEN.API.SMS.Message.MsgService message = new PARSGREEN.API.SMS.Message.MsgService();
                    DataSet ds = message.GetMessagePageing(txtSignature.Text, 2, false, 10, 1);
                    DataTable tableMessage = ds.Tables[0];
                    //----
                    //dgView.Columns[0].Visible = false;
                    //dgView.Columns[1].HeaderText = "متن پیامک";
                    //dgView.Columns[2].Visible = false;
                    //dgView.Columns[3].HeaderText = "تاریخ ارسال یا دریافت";
                    //dgView.Columns[4].HeaderText = "فرستنده";
                    //dgView.Columns[5].HeaderText = "گیرنده";
                    //dgView.Columns[6].Visible = false;
                    ////dgView.Columns[7].HeaderText = "نوع پیامک";
                    //dgView.Columns[7].Visible = false;
                    //dgView.Columns[8].Visible = false;
                    //dgView.Columns[9].Visible = false;
                    //dgView.Columns[10].HeaderText = "قیمت";
                    //dgView.Columns[11].Visible = false;
                    //dgView.Columns[12].HeaderText = "تعداد ارسال ناموفق";
                    //dgView.Columns[13].HeaderText = "تعداد ارسال موفق";
                    dgView.DataSource = tableMessage;

                }
                else
                    MessageBox.Show(" امضاء دیجیتال نباید خالی باشد ");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnRecevieMessage_Click(object sender, EventArgs e)
        {
            try
            {
                //if (txtSignature.Text == "")
                //{
                //    MessageBox.Show("امضا دیجیتال را وارد کنید", "خطا", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //    txtSignature.Focus();
                //    return;
                //}
                //int rowinPage = 5;
                //int startRow = 1;
                //int location = 2;
                if (txtSignature.Text != "" || txtSignature.Text != null)
                {
                    
                    PARSGREEN.API.SMS.Message.MsgService message = new PARSGREEN.API.SMS.Message.MsgService();
                    DataSet ds = message.GetMessagePageing(txtSignature.Text, 1, chxIsRead.Checked, 10, 1);
                    DataTable tableMessage = ds.Tables[0];
                    dgView.DataSource = tableMessage;

                }
                else
                    MessageBox.Show(" امضاء دیجیتال نباید خالی باشد ");

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnSelectMobile_Click(object sender, EventArgs e)
        {
            try
            {
                txtMobilesNumbers.Text = "";
                int r = 0;
                int end=dgSearch.Rows.Count;
                
                while(r<end)
                {
                    string mobile;
                    mobile = dgSearch.Rows[r].Cells[23].Value.ToString();
                    if (mobile != "" && mobile !=null)
                    {

                        txtMobilesNumbers.Text += mobile + ".";
                        r++;
                    }
                    else
                    {
                        r++;
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


                
        }

        private void btnSearchNumber_Click(object sender, EventArgs e)
        {
            try
            {

                dgSearch.DataSource = null;
                using(var context=new kitchenEntities())
                {
                    
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnAllUser_Click(object sender, EventArgs e)
        {
            try
            {
                dgSearch.DataSource = null;
                using(var context=new kitchenEntities())
                {
                    var AllUser = context.User.Where(c => c.Phone != null).ToList();
                    dgSearch.DataSource = AllUser;

                    Design_GrideView_User();

                    context.Dispose();
                }
                
                
                //---
                txtMobilesNumbers.Text = "";
                int r = 0;
                int end = dgSearch.RowCount;

                while (r < end)
                {
                    string mobile;
                    mobile = dgSearch.Rows[r].Cells[3].Value.ToString();
                    if (mobile != "" && mobile != null && mobile.Length==11 && mobile !="0")
                    {

                        txtMobilesNumbers.Text += mobile + ".";
                        r++;
                    }
                    else
                    {
                        r++;
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void FormSms_Load(object sender, EventArgs e)
        {
            dtSearch.Today_Click(null, null);
            comRemeberBirthDay.SelectedIndex = 0;
            try
            {
                using (var context = new kitchenEntities())
                {

                    var set = context.Setting.FirstOrDefault();
                    if (set != null)
                    {
                        txtSignature.Text = set.Signature;
                        txtSMSnumber.Text = set.NumberSms;
                    }
                    else
                        MessageBox.Show("از بخش تنظیمات امضا و شماره پیامک را وارد کنید", "هشدار", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show( ex.Message);
            }
        }

        private void btnSearchBirthday_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new kitchenEntities())
                {
                    int date = Find_BirthDay(dtSearch.Text, int.Parse(comRemeberBirthDay.Text));
                    var tavalod = context.User.Where(c => c.BirthDayDate == date).ToList();
                    dgSearch.DataSource = tavalod;
                }
                Design_GrideView_User();
                //------ezafe kardane shomare
                txtMobilesNumbers.Text = "";
                int r = 0;
                int end = dgSearch.RowCount;

                while (r < end)
                {
                    string mobile;
                    mobile = dgSearch.Rows[r].Cells[3].Value.ToString();
                    if (mobile != "" && mobile != null && mobile.Length == 11 && mobile != "0")
                    {

                        txtMobilesNumbers.Text += mobile + ".";
                        r++;
                    }
                    else
                    {
                        r++;
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearchServic_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new kitchenEntities())
                {
                    int date = int.Parse(dtSearch.Text.Replace("/", ""));
                    var service = context.Service.Where(c => c.DateService == date).ToList();
                    dgSearch.DataSource = service;
                }
                Design_GrideView_Service();
                //------ezafe kardane shomare
                txtMobilesNumbers.Text = "";
                int r = 0;
                int end = dgSearch.RowCount;

                while (r < end)
                {
                    string mobile;
                    mobile = dgSearch.Rows[r].Cells[3].Value.ToString();
                    if (mobile != "" && mobile != null && mobile.Length == 11 && mobile != "0")
                    {

                        txtMobilesNumbers.Text += mobile + ".";
                        r++;
                    }
                    else
                    {
                        r++;
                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
