using Stimulsoft.Report;
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
    public partial class FormReports : Form
    {
        StiReport Report = new StiReport();
        SaveFileDialog _save;
        public FormReports()
        {
            InitializeComponent();
        }
        private void Enter_Number(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }
        private void Design_GrideView_Service()
        {
            if (dgSearch.DataSource != null)
            {
                dgSearch.Columns[0].Name = "Eshterak";
                dgSearch.Columns[0].DataPropertyName = "Eshterak";
                dgSearch.Columns[0].HeaderText = "اشتراک";
                //------
                dgSearch.Columns[1].Name = "Name";
                dgSearch.Columns[1].DataPropertyName = "Name";
                dgSearch.Columns[1].HeaderText = "نام";
                //------
                dgSearch.Columns[2].Name = "DateService";
                dgSearch.Columns[2].DataPropertyName = "DateService";
                dgSearch.Columns[2].HeaderText = "تاریخ سرویس";
                dgSearch.Columns[2].DefaultCellStyle.Format = "0000/00/00";
                //-------
                dgSearch.Columns[3].Name = "Mobile";
                dgSearch.Columns[3].DataPropertyName = "Mobile";
                dgSearch.Columns[3].HeaderText = "شماره تماس";
                //-------
                dgSearch.Columns[4].Name = "Bestankar";
                dgSearch.Columns[4].DataPropertyName = "Bestankar";
                dgSearch.Columns[4].HeaderText = "بیعانه";
                //-------
                dgSearch.Columns[5].Name = "Pardakhti";
                dgSearch.Columns[5].DataPropertyName = "Pardakhti";
                dgSearch.Columns[5].HeaderText = "پرداختی";
                ///------
                dgSearch.Columns[6].Name = "Takhfif";
                dgSearch.Columns[6].DataPropertyName = "Takhfif";
                dgSearch.Columns[6].HeaderText = "تخفیف ";
                //-------
                dgSearch.Columns[7].Name = "SumServices";
                dgSearch.Columns[7].DataPropertyName = "SumServices";
                dgSearch.Columns[7].HeaderText = " مبلغ کل";
                ///------
                dgSearch.Columns[8].Name = "Tasfiye";
                dgSearch.Columns[8].DataPropertyName = "Tasfiye";
                dgSearch.Columns[8].Visible = false;
                dgSearch.Columns[8].HeaderText = "تصفیه";
                ///------
                dgSearch.Columns[9].Name = "CodeRahgiri";
                dgSearch.Columns[9].DataPropertyName = "CodeRahgiri";
                dgSearch.Columns[9].HeaderText = "کد رهگیری";
                ///------
                dgSearch.Columns[10].Name = "NumberService";
                dgSearch.Columns[10].DataPropertyName = "NumberService";
                dgSearch.Columns[10].HeaderText = "تعداد";
                ///------
                dgSearch.Columns[11].Name = "ReadyDate";
                dgSearch.Columns[11].DataPropertyName = "ReadyDate";
                dgSearch.Columns[11].HeaderText = "تاریخ آماده";
                dgSearch.Columns[11].DefaultCellStyle.Format = "0000/00/00";
                ///------
                dgSearch.Columns[12].Name = "SendReadySms";
                dgSearch.Columns[12].DataPropertyName = "SendReadySms";
                dgSearch.Columns[12].HeaderText = "تعداد پیامک آماده";
                ///------
                dgSearch.Columns[13].Name = "Description";
                dgSearch.Columns[13].DataPropertyName = "Description";
                dgSearch.Columns[13].HeaderText = "توضیحات ";
                ///------
                dgSearch.Columns[14].Name = "IdService";
                dgSearch.Columns[14].DataPropertyName = "IdService";
                dgSearch.Columns[14].HeaderText = "شماره ";
                dgSearch.Columns[14].Visible = false;

            }
        }
        //********
        //jame kole Karkard
        public double Jame_Kole_Karkard()
        {
            double sum = 0;
            for (int i = 0; i < dgSearch.RowCount; i++)
            {

                if(dgSearch.Rows[i].Cells[7].Value.ToString()!="0" || dgSearch.Rows[i].Cells[7].Value.ToString()!=null)
                sum = sum + Convert.ToInt64(dgSearch.Rows[i].Cells[7].Value.ToString());
            }
            return sum;
        }
        //********
        //jame kole daryafti
        public double Jame_Kole_Daryafti()
        {
            long bestankar = 0, pardakhti = 0, sum = 0, sumPardakhti = 0,sumBestankar=0;

            for (int i = 0; i < dgSearch.RowCount; i++)
            {
                pardakhti = 0; 
                pardakhti = Int64.Parse(dgSearch.Rows[i].Cells[5].Value.ToString());
                sumPardakhti = sumPardakhti + pardakhti;

            }
            //------
            for (int i = 0; i < dgSearch.RowCount; i++)
            {
                bestankar = 0;
                bestankar = Int64.Parse(dgSearch.Rows[i].Cells[4].Value.ToString());
                sumBestankar = sumBestankar + bestankar;

            }
            sum = sumBestankar + sumPardakhti;
            return sum;
        }
        //**********
        //jame kole daryafti
        public double Jame_Kole_Mande()
        {
            long bestankar = 0, takhfif = 0, pardakhti = 0, sumService = 0, sum = 0;

            for (int i = 0; i < dgSearch.RowCount; i++)
            {
                pardakhti = 0; bestankar = 0; takhfif = 0; sumService = 0;
                takhfif = Int64.Parse(dgSearch.Rows[i].Cells[6].Value.ToString());
                bestankar = Int64.Parse(dgSearch.Rows[i].Cells[4].Value.ToString());
                pardakhti = Int64.Parse(dgSearch.Rows[i].Cells[5].Value.ToString());
                sumService = Int64.Parse(dgSearch.Rows[i].Cells[7].Value.ToString());
                sum = sum + (sumService - (pardakhti + bestankar + takhfif));

            }
            return sum;
        }
        //**************
        //jame kole takhfif
        public double Jame_Kole_Takhfif()
        {
            double sum = 0;
            for (int i = 0; i < dgSearch.RowCount; i++)
            {

                if (dgSearch.Rows[i].Cells[6].Value.ToString() != "0" || dgSearch.Rows[i].Cells[6].Value.ToString() != null)
                    sum = sum + Convert.ToInt64(dgSearch.Rows[i].Cells[6].Value.ToString());
            }
            return sum;
        }
        //********
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
        private void FormReports_Load(object sender, EventArgs e)
        {
            //------
            using (var context = new kitchenEntities())
            {
                var select = context.Service.ToList();
                string[] eshterak = new string[select.Count];
                for (int i = 0; i < select.Count; i++)
                {
                    eshterak[i] = select[i].Eshterak.ToString();
                }
                AutoCompleteStringCollection suggestEshterak = new AutoCompleteStringCollection();
                txtEshterak.AutoCompleteCustomSource = suggestEshterak;
                suggestEshterak.AddRange(eshterak);
                //-------
                string[] phone = new string[select.Count];
                for (int i = 0; i < select.Count; i++)
                {
                    phone[i] = select[i].Mobile.ToString();
                }
                AutoCompleteStringCollection suggestPhone = new AutoCompleteStringCollection();
                txtPhone.AutoCompleteCustomSource = suggestPhone;
                suggestPhone.AddRange(phone);
            }
            //-----------
            dtStart.Today_Click(null, null);
            dtEnd.Today_Click(null, null);
            //------


        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            try
            {
                int startDate = int.Parse(dtStart.Text.Replace("/", ""));
                int endDate = int.Parse(dtEnd.Text.Replace("/", ""));
                using (var context = new kitchenEntities())
                {
                    var findDate = context.Service.Where(c => c.DateService >= startDate && c.DateService <= endDate).ToList();
                    dgSearch.DataSource = findDate;
                    

                }
                Design_GrideView_Service();
                lblTotalPrice.Text = Jame_Kole_Karkard().ToString();
                lblTotalResive.Text = Jame_Kole_Daryafti().ToString();
                lblTotalMande.Text = Jame_Kole_Mande().ToString();
                lblTotallTakhfif.Text = Jame_Kole_Takhfif().ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("بعضی از مقادیر وارد نشده \n" + ex.Message);
            }
        }

        private void btnReportUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEshterak.Text == "")
                    txtEshterak.Focus();
                using (var context = new kitchenEntities())
                {
                    var find = context.Service.Where(c => c.Eshterak == txtEshterak.Text).ToList();

                    dgSearch.DataSource = find;
                    
                }
                Design_GrideView_Service();
                lblTotalPrice.Text = Jame_Kole_Karkard().ToString();
                lblTotalResive.Text = Jame_Kole_Daryafti().ToString();
                lblTotalMande.Text = Jame_Kole_Mande().ToString();
                lblTotallTakhfif.Text = Jame_Kole_Takhfif().ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("بعضی از مقادیر وارد نشده \n" + ex.Message);
            }
        }

        private void txtEshterak_TextChanged(object sender, EventArgs e)
        {
            try
            {

                using (var context = new kitchenEntities())
                {
                    var find = context.Service.Where(c => c.Eshterak == txtEshterak.Text).ToList();
                    
                    dgSearch.DataSource = find;
                }
                Design_GrideView_Service();
                lblTotalPrice.Text = Jame_Kole_Karkard().ToString();
                lblTotalResive.Text = Jame_Kole_Daryafti().ToString();
                lblTotalMande.Text = Jame_Kole_Mande().ToString();
                lblTotallTakhfif.Text = Jame_Kole_Takhfif().ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("بعضی از مقادیر وارد نشده \n" + ex.Message);
            }
        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            try
            {
                
                using (var context = new kitchenEntities())
                {
                    var user = context.Service.Where(c => c.Mobile == txtPhone.Text).ToList();
                    dgSearch.DataSource = user;
                }
                Design_GrideView_Service();
                lblTotalPrice.Text = Jame_Kole_Karkard().ToString();
                lblTotalResive.Text = Jame_Kole_Daryafti().ToString();
                lblTotalMande.Text = Jame_Kole_Mande().ToString();
                lblTotallTakhfif.Text = Jame_Kole_Takhfif().ToString();
            }
            catch (Exception ex)
            {

                MessageBox.Show("بعضی از مقادیر وارد نشده \n" + ex.Message);
            }
        }
        private void dgSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                string select = dgSearch.CurrentRow.Cells[9].Value.ToString();
                FormReportServices frmReportServices = new FormReportServices();
                frmReportServices.label1.Text = select;
                //Design_GrideView_Service();
                frmReportServices.Show();
            }
            catch (Exception ex)
            {

                MessageBox.Show("سفارش انتخاب شده کد رهگیری ندارد \n " + ex.Message);
            }
        }

        private void lblTotalPrice_TextChanged(object sender, EventArgs e)
        {
            lblTotalPrice.Text = Seragham(lblTotalPrice.Text);
            //lblTotalPrice.Select(lblTotalPrice., 0);
        }

        private void lblTotalResive_TextChanged(object sender, EventArgs e)
        {
            lblTotalResive.Text = Seragham(lblTotalResive.Text);

        }

        private void lblTotalMande_TextChanged(object sender, EventArgs e)
        {
            lblTotalMande.Text = Seragham(lblTotalMande.Text);

        }

        private void lblTotallTakhfif_TextChanged(object sender, EventArgs e)
        {
            lblTotallTakhfif.Text = Seragham(lblTotallTakhfif.Text);
        }

        private void btnPdfExport_Click(object sender, EventArgs e)
        {
            Report.Load(Application.StartupPath + "\\RptExportService.mrt");
            Report.RegBusinessObject("rptService", dgSearch.DataSource);
            Report.Render(false);

            _save = new SaveFileDialog();
            _save.Filter = "PDF File (.pdf)|*.pdf";
            if (_save.ShowDialog() == DialogResult.OK)
                Report.ExportDocument(StiExportFormat.Pdf, _save.FileName);
        }

        private void btnWordExport_Click(object sender, EventArgs e)
        {
            Report.Load(Application.StartupPath + "\\RptExportService.mrt");
            Report.RegBusinessObject("rptService", dgSearch.DataSource);
            Report.Render(false);
            _save = new SaveFileDialog();
            _save.Filter = "Word File (.docx)|*.docx";
            if (_save.ShowDialog() == DialogResult.OK)
                Report.ExportDocument(StiExportFormat.Word2007, _save.FileName);
        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            Report.Load(Application.StartupPath + "\\RptExportService.mrt");
            Report.RegBusinessObject("rptService", dgSearch.DataSource);
            Report.Render(false);
            _save = new SaveFileDialog();
            _save.Filter = "Excel File (.xlsx)|*.xlsx";
            if (_save.ShowDialog() == DialogResult.OK)
                Report.ExportDocument(StiExportFormat.Excel2007, _save.FileName);
        }

        private void txtEshterak_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);
        }
    }
}
