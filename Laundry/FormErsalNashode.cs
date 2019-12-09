using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laundry
{
    public partial class FormErsalNashode : Form
    {
        kitchenEntities context = new kitchenEntities();
        public FormErsalNashode()
        {
            InitializeComponent();
        }
        public void Refresh_dgSearch()
        {
            try
            {
                dgSearch.DataSource = null;
                dgSearch.Rows.Clear();
                dgSearch.Columns.Clear();
                    var ersalNashode = context.ErsalNashode.ToList();
                    dgSearch.DataSource = ersalNashode;
                
                dgSearch.Columns[0].Name = "Name";
                dgSearch.Columns[0].DataPropertyName = "Name";
                dgSearch.Columns[0].HeaderText = "نام";
                //dgSearch.Columns[0].Visible = false;
                dgSearch.Columns[0].Width = 150;
                //------
                dgSearch.Columns[1].Name = "Phone";
                dgSearch.Columns[1].DataPropertyName = "Phone";
                dgSearch.Columns[1].HeaderText = "شماره تماس";
                //------
                dgSearch.Columns[2].Name = "Message";
                dgSearch.Columns[2].DataPropertyName = "Message";
                dgSearch.Columns[2].HeaderText = "متن پیامک";
                dgSearch.Columns[2].Width = 300;
                //-------
                dgSearch.Columns[3].Name = "Date";
                dgSearch.Columns[3].DataPropertyName = "Date";
                dgSearch.Columns[3].HeaderText = "تاریخ ارسال";
                dgSearch.Columns[3].DefaultCellStyle.Format = "0000/00/00";
                //-------
                dgSearch.Columns[4].Name = "Time";
                dgSearch.Columns[4].DataPropertyName = "Time";
                dgSearch.Columns[4].HeaderText = "زمان ارسال";
                //-------
                dgSearch.Columns[5].Name = "CodeRahgiri";
                dgSearch.Columns[5].DataPropertyName = "CodeRahgiri";
                dgSearch.Columns[5].HeaderText = "کد رهگیری";
                //-------
                dgSearch.Columns[6].Name = "Id";
                dgSearch.Columns[6].DataPropertyName = "Id";
                dgSearch.Columns[6].HeaderText = "شماره";
                dgSearch.Columns[6].Visible = false;
                ///------
                var btnSend = new DataGridViewButtonColumn();
                
                btnSend.Text = "ارسال";
                btnSend.Name = "btnErsal";
                btnSend.HeaderText = "";
                btnSend.DataPropertyName = "Ersal";
                btnSend.Width = 75;
                btnSend.UseColumnTextForButtonValue = true;
                this.dgSearch.Columns.Add(btnSend);
                //-------
                var btnDelete = new DataGridViewButtonColumn();
                
                btnDelete.Text = "حذف";
                btnDelete.Name = "btDelete";
                btnDelete.HeaderText = "";
                btnDelete.DataPropertyName = "Delete";
                btnDelete.Width = 75;
                btnDelete.UseColumnTextForButtonValue = true;
                this.dgSearch.Columns.Add(btnDelete);
                //-------

                //btnDelete.Name = "btnDelete";
                //btnDelete.HeaderText = "حذف";
                //btnDelete.DataPropertyName = "Delete";
                //btnDelete.Width = 50;
                //dgSearch.Columns[0].HeaderText = "نام";
                //dgSearch.Columns[1].HeaderText = "شماره تماس";
                //dgSearch.Columns[2].Width = 300;
                //dgSearch.Columns[2].HeaderText = "متن پیام";
                //dgSearch.Columns[3].HeaderText = "تاریخ ارسال";
                //dgSearch.Columns[3].DefaultCellStyle.Format = "0000/00/00";
                //dgSearch.Columns[4].HeaderText = "کد رهگیری";
                //dgSearch.Columns[5].HeaderText = "شماره";
                //dgSearch.Columns[5].Visible = false;
                //DataGridViewButtonColumn btnSend = new DataGridViewButtonColumn();
                //dgSearch.Columns.Add(btnSend);
                //btnSend.Text = "ارسال";
                //btnSend.Name = "btnErsal";
                //btnSend.HeaderText = "ارسال";
                //btnSend.DataPropertyName = "Ersal";
                //btnSend.Width = 50;
                //DataGridViewButtonColumn btnDelete = new DataGridViewButtonColumn();
                //dgSearch.Columns.Add(btnDelete);
                //btnDelete.Text = "حذف";

                //btnDelete.Name = "btnDelete";
                //btnDelete.HeaderText = "حذف";
                //btnDelete.DataPropertyName = "Delete";
                //btnDelete.Width = 50;


            }
            catch (Exception ex)
            {

                MessageBox.Show("ارسال نشده" + "\n" + ex.Message);
            }
        }
        private void FormErsalNashode_Load(object sender, EventArgs e)
        {
            Refresh_dgSearch();
            
        }

        private void dgSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex == 7)
                {
                    try
                    {
                        //***********baraye check kardane ertebat
                        //HttpWebRequest reqCheack = (HttpWebRequest)WebRequest.Create("http://login.parsgreen.com/UrlService/sendSMS.ashx?from=");
                        //System.Net.WebResponse respCheack = reqCheack.GetResponse();
                        //***********
                        //Ping ping = new Ping();
                        //PingReply pingStatus = ping.Send("google.com");
                        var sign = context.Setting.FirstOrDefault();
                        if (sign.Signature == null || sign.Signature == "" || sign.NumberSms == null || sign.NumberSms == "")
                        {
                            MessageBox.Show("از قسمت تنظیمات امضا دیجیتال و شماره پیامک را ثبت کنید", "امضا دیجیتال ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }
                        //if (pingStatus.Status == IPStatus.Success)
                        //{
                            
                            string pattern = "http://login.parsgreen.com/UrlService/sendSMS.ashx?from=" + sign.NumberSms + "&to=" + dgSearch.CurrentRow.Cells[1].Value.ToString() + "&text=" + dgSearch.CurrentRow.Cells[2].Value.ToString() + "&signature=" + sign.Signature;

                            //MessageBox.Show(pattern);
                            System.IO.Stream st = null;
                            System.IO.StreamReader sr = null;

                            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(pattern);
                            Encoding encode = System.Text.Encoding.UTF8;

                            System.Net.WebResponse resp = req.GetResponse();

                            st = resp.GetResponseStream();
                            sr = new System.IO.StreamReader(st, Encoding.UTF8);
                            string result = sr.ReadToEnd().Substring(12, 1);
                            if (result == "0")
                            {
                                string id = dgSearch.CurrentRow.Cells[6].Value.ToString();
                                var del = context.ErsalNashode.Where(c => c.Id.ToString() == id).FirstOrDefault();
                                context.ErsalNashode.Remove(del);
                                context.SaveChanges();
                                Refresh_dgSearch();
                            }
                            sr.Close();
                            resp.Close();
                        //}
                    }
                    catch(Exception)
                    {

                        MessageBox.Show("اینترنت وصل نیست", "اینترنت", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }
                    
                }
                if (e.ColumnIndex==8)
                {
                    string id = dgSearch.CurrentRow.Cells[6].Value.ToString();
                    var del = context.ErsalNashode.Where(c => c.Id.ToString() == id).FirstOrDefault();
                    context.ErsalNashode.Remove(del);
                    context.SaveChanges();
                    Refresh_dgSearch();

                    return;
                }
            }
            catch (Exception)
            {
                //MessageBox.Show("اینترنت وصل نیست 2"+"\n"+ex.Message, "اینترنت", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                //MessageBox.Show("ارسال نشده2" + "\n" + ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string id = dgSearch.CurrentRow.Cells[5].Value.ToString();
            var del = context.ErsalNashode.Where(c => c.Id.ToString() == id).FirstOrDefault();
            context.ErsalNashode.Remove(del);
            context.SaveChanges();
            Refresh_dgSearch();
        }

        private void toolSendAll_Click(object sender, EventArgs e)
        {
            try
            {

                    try
                    {
                        //Ping ping = new Ping();
                        //PingReply pingStatus = ping.Send("google.com");
                    var sign = context.Setting.FirstOrDefault();
                    if (sign.Signature == null || sign.Signature == "" || sign.NumberSms == null || sign.NumberSms == "")
                    {

                        MessageBox.Show("از قسمت تنظیمات امضا دیجیتال و شماره پیامک را ثبت کنید","امضا دیجیتال ",MessageBoxButtons.OK,MessageBoxIcon.Warning);

                        return;
                    }
                    //***********baraye check kardane ertebat
                    HttpWebRequest reqCheack = (HttpWebRequest)WebRequest.Create("http://login.parsgreen.com/UrlService/sendSMS.ashx?from=");
                    System.Net.WebResponse respCheack = reqCheack.GetResponse();
                    //***********
                    //if (resp2 == encode2.)
                    //{
                    for (int i=0;i<dgSearch.RowCount;i++)
                        {
                            
                            string pattern = "http://login.parsgreen.com/UrlService/sendSMS.ashx?from=" + sign.NumberSms + "&to=" + dgSearch.CurrentRow.Cells[1].Value.ToString() + "&text=" + dgSearch.CurrentRow.Cells[2].Value.ToString() + "&signature=" + sign.Signature;

                            //MessageBox.Show(pattern);
                            System.IO.Stream st = null;
                            System.IO.StreamReader sr = null;

                            HttpWebRequest req = (HttpWebRequest)WebRequest.Create(pattern);
                            Encoding encode = System.Text.Encoding.UTF8;

                            System.Net.WebResponse resp = req.GetResponse();

                            st = resp.GetResponseStream();
                            sr = new System.IO.StreamReader(st, Encoding.UTF8);
                            string result = sr.ReadToEnd().Substring(12, 1);
                            if (result == "0")
                            {
                                string id = dgSearch.CurrentRow.Cells[6].Value.ToString();
                                var del = context.ErsalNashode.Where(c => c.Id.ToString() == id).FirstOrDefault();
                                context.ErsalNashode.Remove(del);
                                context.SaveChanges();
                                Refresh_dgSearch();
                            }
                            sr.Close();
                            resp.Close();
                        }
                    //}
                    }
                    catch (Exception)
                    {
                        MessageBox.Show("اینترنت وصل نیست", "اینترنت", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

            }
            catch (Exception)
            {
                //MessageBox.Show("اینترنت وصل نیست 2" + "\n" + ex.Message, "اینترنت", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //MessageBox.Show("ارسال نشده2" + "\n" + ex.Message);
            }
        }

        private void toolDeleteAll_Click(object sender, EventArgs e)
        {
            try
            {
                var del = context.ErsalNashode.ToList();
                    context.ErsalNashode.RemoveRange(del);
                    context.SaveChanges();
                    Refresh_dgSearch();

                    return;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("مشکل در حذف همه" + "\n" + ex.Message, "حذف همه", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                //MessageBox.Show("ارسال نشده2" + "\n" + ex.Message);
            }
        }
    }
}
