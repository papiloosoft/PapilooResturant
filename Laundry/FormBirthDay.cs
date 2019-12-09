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
    public partial class FormBirthDay : Form
    {
        public FormBirthDay()
        {
            InitializeComponent();
        }
        private void Design_GrideView_BirthDay()
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
        private void label34_Click(object sender, EventArgs e)
        {

        }

        private void comRemeberBirthDay_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                using (var context = new kitchenEntities())
                {
                    int date = Find_BirthDay(dtBirthDay.Text, int.Parse(comRemeberBirthDay.Text));
                    var tavalod = context.User.Where(c => c.BirthDayDate == date).ToList();
                    dgSearch.DataSource = tavalod;
                }
                Design_GrideView_BirthDay();

                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public int Find_BirthDay(string date,int x)
        {
            date = date.Replace("/", "");
            int year = int.Parse(date.Substring(0, 4));
            int month = int.Parse(date.Substring(4, 2));
            int day = int.Parse(date.Substring(6, 2));
            //------
            for(int i=0;i<x;i++)
            {
                day++;
                if(month<7)
                {
                    if(day==32)
                    {
                        day = 1;
                        month++;
                    }
                }
                if (month >=7 )
                {
                    if (day==31 )
                    {
                        day=1;
                        month++;

                    }
                }
                if(month>=12 && day==30)
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
            string tarikh =y + m + d;
            //MessageBox.Show(tarikh);
            int tavalod = int.Parse(tarikh);
            return tavalod;



        }
        private void FormBirthDay_Load(object sender, EventArgs e)
        {
            dtBirthDay.Today_Click(null, null);
            comRemeberBirthDay.SelectedIndex = 0;

        }
    }
}
