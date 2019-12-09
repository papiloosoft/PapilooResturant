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
    public partial class FormEditSmallReport : Form
    {
        public FormEditSmallReport()
        {
            InitializeComponent();
        }
        private void Design_GrideView_Report_Service()
        {
            kitchenEntities context = new kitchenEntities();
            dgSearch.DataSource = null;
            dgSearch.Rows.Clear();
            dgSearch.Columns.Clear();
            var user = context.ReportService.Where(c => c.CodeRahgiri == label1.Text).ToList();
            dgSearch.DataSource = user;
            DataGridViewCheckBoxColumn chk = new DataGridViewCheckBoxColumn();
            dgSearch.Columns.Add(chk);
            //dgSearch.Columns[0].DefaultCellStyle = chk;
            chk.HeaderText = "آماده بودن";
            chk.Name = "Ready";
            //chk.DisplayIndex = 0;
            //dgSearch.Columns[0].Visible = false;
            //dgSearch.Columns[0].HeaderText = "آماده بودن";
            //dgSearch.Columns[0].DefaultCellStyle = data
            dgSearch.Columns[0].Visible = false;
            dgSearch.Columns[1].HeaderText = "اشتراک";
            dgSearch.Columns[2].HeaderText = "تاریخ";
            dgSearch.Columns[2].DefaultCellStyle.Format = "0000/00/00";
            //dgSearch.Columns[3].Visible = false;
            dgSearch.Columns[3].HeaderText = "دسته";
            //dgSearch.Columns[4].Visible = false;
            dgSearch.Columns[4].HeaderText = "محصول";
            //dgSearch.Columns[5].Visible = false;
            dgSearch.Columns[5].HeaderText = "سرویس";
            //dgSearch.Columns[6].Visible = false;
            dgSearch.Columns[6].HeaderText = "تعداد";
            //dgSearch.Columns[7].Visible = false;
            dgSearch.Columns[7].HeaderText = "مبلغ";
            dgSearch.Columns[8].HeaderText = "کد رهگیری";
            dgSearch.Columns[9].Visible = false;
            dgSearch.Columns[9].HeaderText = " شماره";
            dgSearch.Columns[10].Visible = false;
            dgSearch.Columns[10].HeaderText = "تعداد مراجعه";
            dgSearch.Columns[11].DisplayIndex = 0;

            var btnDeleteRow = new DataGridViewButtonColumn();
            btnDeleteRow.Name = "btnDeleteRow";
            btnDeleteRow.Text = "حذف";
            btnDeleteRow.UseColumnTextForButtonValue = true;
            btnDeleteRow.HeaderText = "";
            btnDeleteRow.Width = 75;
            this.dgSearch.Columns.Add(btnDeleteRow);



        }
        private void FormEditSmallReport_Load(object sender, EventArgs e)
        {
            try
            {
                using (var context = new kitchenEntities())
                {

                    var user = context.ReportService.Where(c => c.CodeRahgiri == label1.Text).ToList();

                    dgSearch.DataSource = user;
                    Design_GrideView_Report_Service();
                    for (int i = 0; i < user.Count; i++)
                    {
                        if (dgSearch.Rows[i].Cells[0].Value == null)
                            dgSearch.Rows[i].Cells[11].Value = true;
                        else if (dgSearch.Rows[i].Cells[0].Value.ToString() == "0")
                            dgSearch.Rows[i].Cells[11].Value = true;
                        else if (dgSearch.Rows[i].Cells[0].Value.ToString() == "1")
                            dgSearch.Rows[i].Cells[11].Value = false;


                    }

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("سفارش انتخاب شده کد رهگیری ندارد.ریزگزارش \n " + ex.Message);
            }
        }

        private void dgSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                if (e.ColumnIndex == 11)
                {
                    int selectId = int.Parse(dgSearch.CurrentRow.Cells[10].Value.ToString());
                    using (var context = new kitchenEntities())
                    {
                        var select = context.ReportService.Where(c => c.Id == selectId).FirstOrDefault();
                        if (select.Ready == "1")
                        {
                            select.Ready = "0";
                            context.SaveChanges();
                            dgSearch.CurrentCell.Value = true;
                            return;
                        }
                        if (select.Ready == "0")
                        {
                            select.Ready = "1";
                            context.SaveChanges();
                            dgSearch.CurrentCell.Value = false;
                            return;
                        }
                    }
                }
                if (e.ColumnIndex == 12)
                {
                    int selectId =int.Parse( dgSearch.CurrentRow.Cells[10].Value.ToString());
                    using (var context = new kitchenEntities())
                    {
                        var del = context.ReportService.Where(c => c.Id == selectId).FirstOrDefault();
                        context.ReportService.Remove(del);
                        context.SaveChanges();
                        var user = context.ReportService.Where(c => c.CodeRahgiri == label1.Text).ToList();

                        dgSearch.DataSource = user;
                        Design_GrideView_Report_Service();
                        //-----mohasebe mojadade hazine service bad az hazfe 1 khedmat
                        var editPrice = context.Service.Where(c => c.CodeRahgiri == label1.Text).FirstOrDefault();
                        long sum = 0;

                        if (dgSearch.RowCount > 0)
                        {
                            for (int i = 0; i < dgSearch.RowCount; i++)
                            {
                                sum = sum + long.Parse(dgSearch.Rows[i].Cells[7].Value.ToString());
                            }
                            editPrice.SumServices = sum;
                            context.SaveChanges();
                            return;
                        }
                        if(dgSearch.RowCount==0)//hame khedmatha hazf shavad in khedmat az list serviceha hazf shsvad
                        {
                            context.Service.Remove(editPrice);
                            context.SaveChanges();
                        }
                    }

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("عوض کردن وضعیت آماده ویرایش" + "\n" + ex.Message);
            }
        }
    }
}
