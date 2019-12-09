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
    public partial class FormSearch : Form
    {
        StiReport Report = new StiReport();
        SaveFileDialog _save;
        public FormSearch()
        {
            InitializeComponent();
        }
        private void Design_GrideView_Report_Service()
        {
            if (dgSearch.DataSource != null)
            {
                

                dgSearch.Columns[0].Name = "Ready";
                dgSearch.Columns[0].DataPropertyName = "Ready";
                dgSearch.Columns[0].HeaderText = "آماده";
                //dgSearch.Columns[0].
                dgSearch.Columns[0].Visible = false;
                //------
                dgSearch.Columns[1].Name = "Eshterak";
                dgSearch.Columns[1].DataPropertyName = "Eshterak";
                dgSearch.Columns[1].HeaderText = "اشتراک";
                //------
                dgSearch.Columns[2].Name = "Date";
                dgSearch.Columns[2].DataPropertyName = "Date";
                dgSearch.Columns[2].HeaderText = "تاریخ سرویس";
                dgSearch.Columns[2].DefaultCellStyle.Format = "0000/00/00";
                //-------
                dgSearch.Columns[3].Name = "Kind";
                dgSearch.Columns[3].DataPropertyName = "Kind";
                dgSearch.Columns[3].HeaderText = "دسته";
                //-------
                dgSearch.Columns[4].Name = "Kala";
                dgSearch.Columns[4].DataPropertyName = "Kala";
                dgSearch.Columns[4].HeaderText = "محصول";
                //-------
                dgSearch.Columns[5].Name = "Service";
                dgSearch.Columns[5].DataPropertyName = "Service";
                dgSearch.Columns[5].HeaderText = "سرویس";
                ///------
                dgSearch.Columns[6].Name = "Some";
                dgSearch.Columns[6].DataPropertyName = "Some";
                dgSearch.Columns[6].HeaderText = "مقدار ";
                //-------
                dgSearch.Columns[7].Name = "Price";
                dgSearch.Columns[7].DataPropertyName = "Price";
                dgSearch.Columns[7].HeaderText = " مبلغ ";
                ///------
                dgSearch.Columns[8].Name = "CodeRahgiri";
                dgSearch.Columns[8].DataPropertyName = "CodeRahgiri";

                dgSearch.Columns[8].HeaderText = "کدرهگیری";
                ///------
                dgSearch.Columns[9].Name = "NumberServise";
                dgSearch.Columns[9].DataPropertyName = "NumberServise";
                dgSearch.Columns[9].HeaderText = " تعداد";
                ///------
                dgSearch.Columns[10].Name = "Id";
                dgSearch.Columns[10].DataPropertyName = "Id";
                dgSearch.Columns[10].HeaderText = "شماره";
                dgSearch.Columns[10].Visible = false;
                ///------
            }



        }
        private void Design_GrideView_User()
        {
            dgSearch.Columns[0].HeaderText = "اشتراک";
            dgSearch.Columns[1].HeaderText = "نام";
            //dgSearch.Columns[2].Visible = false;
            dgSearch.Columns[2].HeaderText = " تاریخ";
            dgSearch.Columns[2].DefaultCellStyle.Format = "0000/00/00";
            //dgSearch.Columns[3].Visible = false;
            dgSearch.Columns[3].HeaderText = "شماره تماس";
            //dgSearch.Columns[4].Visible = false;
            dgSearch.Columns[4].HeaderText = "ایمیل";
            // dgSearch.Columns[5].Visible = false;
            dgSearch.Columns[5].HeaderText = "تاریخ تولد";
            dgSearch.Columns[5].DefaultCellStyle.Format = "0000/00/00";
            //dgSearch.Columns[6].Visible = false;
            dgSearch.Columns[6].HeaderText = "آدرس";
            dgSearch.Columns[7].HeaderText = "کد پستی";
            dgSearch.Columns[8].Visible = false;
            dgSearch.Columns[8].HeaderText = "شماره ";

        }
        private void Design_GrideView_Service()
        {
            dgSearch.Columns[0].HeaderText = "اشتراک";
            dgSearch.Columns[1].HeaderText = "نام";
            dgSearch.Columns[2].HeaderText = "تاریخ سرویس";
            dgSearch.Columns[2].DefaultCellStyle.Format = "0000/00/00";
            dgSearch.Columns[3].HeaderText = "شماره تماس";
            dgSearch.Columns[4].HeaderText = "بیعانه";
            dgSearch.Columns[5].HeaderText = "پرداختی";
            dgSearch.Columns[6].HeaderText = "تخفیف ";
            dgSearch.Columns[7].HeaderText = " مبلغ کل";
            dgSearch.Columns[8].Visible = false;
            dgSearch.Columns[8].HeaderText = "تصفیه";
            dgSearch.Columns[9].HeaderText = "کد رهگیری";
            dgSearch.Columns[10].HeaderText = "تعداد";
            dgSearch.Columns[11].HeaderText = "تاریخ آماده";
            dgSearch.Columns[11].DefaultCellStyle.Format = "0000/00/00";
            dgSearch.Columns[12].HeaderText = "تعداد پیامک آماده";
            dgSearch.Columns[13].HeaderText = "توضیحات ";
            dgSearch.Columns[14].HeaderText = "شماره ";
            dgSearch.Columns[14].Visible = false;
            //dgSearch.Width = 750;
            //dgSearch.Height = 370;
        }
        public string OutPout_Name()
        {
            string NameFile="";
            if (comSearch.SelectedIndex == 0 || comSearch.SelectedIndex == 2 || comSearch.SelectedIndex == 3 || comSearch.SelectedIndex == 5)
            {
                NameFile = "\\RptUser.mrt";
                
            }
            if (comSearch.SelectedIndex == 1)
            {
                NameFile="\\RptExportService.mrt";
            }
            if(comSearch.SelectedIndex==4)
            {
                NameFile = "\\RptReportService.mrt";
            }
                return NameFile;
        }

        public string OutPout_Data()
        {
            string Data = "";
            if (comSearch.SelectedIndex == 0 || comSearch.SelectedIndex == 2 || comSearch.SelectedIndex == 3 || comSearch.SelectedIndex == 5)
            {
               
                Data = "rptUser";
            }
            if (comSearch.SelectedIndex == 1)
            {
                Data = "rptService";
            }
            if(comSearch.SelectedIndex==4)
            {
                Data = "rptReportService";
            }
            return Data;
        }

        #region Search With Eshterak
        private void Search_Eshterak()
        {
            try
            {
                using (var context = new kitchenEntities())
                {
                    dgSearch.DataSource = null;
                    var find = context.User.Where(c => c.Eshterak.Contains(txtSearch.Text)).ToList();
                    dgSearch.DataSource = find;
                    //-----------------
                    Design_GrideView_User();
                    //-----------------

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        #endregion

        #region Search With Date Services
        private void Search_DateServise()
        {
            try
            {
                using (var context = new kitchenEntities())
                {
                    int dtsearch = int.Parse(dtSearch.Text.Replace("/", ""));
                    var find = context.Service.Where(current => current.DateService == dtsearch).ToList();
                    dgSearch.DataSource = find;
                    //--------------------

                    Design_GrideView_Service();
                    //--------------------

                    dgSearch.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        #endregion

        #region Search With Phone
        private void Search_Phone()
        {
            try
            {
                using (var context = new kitchenEntities())
                {
                    var find = context.User.Where(current => current.Phone.Contains(txtSearch.Text)).ToList();
                    dgSearch.DataSource = find;
                    //-----------------
                    Design_GrideView_User();
                    //-----------------

                    dgSearch.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        #endregion


        #region Search With Date Enter
        private void Search_Enter_Date()
        {
            try
            {
                using (var context = new kitchenEntities())
                {
                    int dtsearch = int.Parse(dtSearch.Text.Replace("/", ""));
                    var find = context.User.Where(current => current.Date == dtsearch).ToList();
                    dgSearch.DataSource = find;
                    //-----------------
                    Design_GrideView_User();
                    //-----------------
                    //dgSearch.Width = 750;
                    //dgSearch.Height = 370;
                    //dgSearch.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        #endregion

        #region Search Code Rahgiri
        private void Search_Code_Rahgiri()
        {
            //try
            //{
            //    using (var context = new LundryEntities2())
            //    {
            //        dgSearch.DataSource = null;
            //        var user = context.ReportServices.Where(c => c.CodeRahgiri == txtSearch.Text).ToList();
            //        if (user != null)
            //        {
            //            dgSearch.DataSource = user;
            //            Design_GrideView_Report_Service();
            //            for (int i = 0; i < user.Count; i++)
            //            {
            //                if (dgSearch.Rows[i].Cells[0].Value == null)
            //                    dgSearch.Rows[i].Cells[11].Value = true;
            //                else if (dgSearch.Rows[i].Cells[0].Value.ToString() == "0")
            //                    dgSearch.Rows[i].Cells[11].Value = true;
            //                else if (dgSearch.Rows[i].Cells[0].Value.ToString() == "1")
            //                    dgSearch.Rows[i].Cells[11].Value = false;


            //            }

            //        }
            //    }

            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("سفارش انتخاب شده کد رهگیری ندارد.کدرهگیری جستجو \n " + ex.Message);
            //}

            try
            {
                using (var context = new kitchenEntities())
                {
                    dgSearch.DataSource = null;
                    var find = context.ReportService.Where(current => current.CodeRahgiri == txtSearch.Text).ToList();
                    dgSearch.DataSource = find;
                    //-----------------
                    Design_GrideView_Report_Service();
                    //-----------------

                    dgSearch.Show();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }




        }


        #endregion
        #region Search With Name
        private void Search_Name()
        {
            try
            {
                using (var context = new kitchenEntities())
                {
                    var find = context.User.Where(c => c.Name.Contains(txtSearch.Text)).ToList();
                    dgSearch.DataSource = find;
                    //-----------------
                    Design_GrideView_User();
                    //-----------------

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        #region Search With compelete Name
        private void Search_Compelete_Name()
        {
            try
            {
                using (var context = new kitchenEntities())
                {
                    var find = context.User.Where(c => c.Name.StartsWith(txtSearch.Text)).ToList();
                    dgSearch.DataSource = find;
                    //-----------------
                    Design_GrideView_User();
                    //-----------------

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
        #endregion
        #endregion
        private void FormSearch_Load(object sender, EventArgs e)
        {
            dtSearch.Today_Click(null, null);
            comSearch.SelectedIndex = 0;
            dtSearch.Visible = true;

            //*****************

            //lblError.Location = new System.Drawing.Point(456, 430);
            //-----

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            if (comSearch.SelectedIndex == 0) //search bar asase shomare eshterak
            {
                Search_Eshterak();
                return;
            }
            //***********************
            if (comSearch.SelectedIndex == 1) //search bar asase shomare Tarikh Servis
            {
                Search_DateServise();
                return;
            }
            //***********************
            if (comSearch.SelectedIndex == 2) //search bar asase shomare pelak
            {
                Search_Phone();
                return;
            }
            //***********************
            if (comSearch.SelectedIndex == 3) //search bar asase khodro
            {
                Search_Enter_Date();
                return;
            }
            //***********************
            if (comSearch.SelectedIndex == 5) //search ba Name
            {
                Search_Compelete_Name();
                return;
            }
            //***********************
            if (comSearch.SelectedIndex == 4)//serach ba kode rahgiri
            {
                Search_Code_Rahgiri();
                return;
            }

            }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comSearch_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            if (comSearch.SelectedIndex == 0)
            {
                txtSearch.Visible = true;
                dtSearch.Visible = false;
            }
            if (comSearch.SelectedIndex == 1)
            {
                txtSearch.Visible = false;
                dtSearch.Visible = true;
                //dtSearch.Location = new System.Drawing.Point(231, 18);

            }
            if (comSearch.SelectedIndex == 2)
            {
                txtSearch.Visible = true;
                dtSearch.Visible = false;
            }
            if (comSearch.SelectedIndex == 3)
            {
                txtSearch.Visible = false;
                dtSearch.Visible = true;
                //dtSearch.Location = new System.Drawing.Point(231, 18);
            }
            if (comSearch.SelectedIndex == 4)
            {
                txtSearch.Visible = true;
                dtSearch.Visible = false;
                //dtSearch.Location = new System.Drawing.Point(231, 18);
            }
            if (comSearch.SelectedIndex == 5)
            {
                txtSearch.Visible = true;
                dtSearch.Visible = false;
            }

        }

        private void comSearch_TabIndexChanged(object sender, EventArgs e)
        {

        }



        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            switch (comSearch.SelectedIndex)
            {
                case 0:
                    dgSearch.DataSource = null;                                
                    Search_Eshterak();
                    return;
                case 1:
                    return;
                case 2:
                    Search_Phone();
                    return;
                case 3:
                    return;
                case 4:
                    dgSearch.DataSource = null;
                    Search_Code_Rahgiri();
                    return;
                case 5:
                    Search_Name();
                    return;
            }
            //if (comSearch.SelectedIndex == 0)
            //{
            //    Search_Eshterak();
            //    return;
            //}
            //if (comSearch.SelectedIndex == 2)
            //{
            //    Search_Phone();
            //    return;
            //}
            //if (comSearch.SelectedIndex == 4)
            //{
            //    Search_Code_Rahgiri();
            //    return;
            //}
            //if (comSearch.SelectedIndex == 5)
            //{
            //    Search_Name();
            //    return;
            //}
        }

        private void dgSearch_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dtSearch_TextChanged(object sender, EventArgs e)
        {
            if (comSearch.SelectedIndex == 1)
            {
                Search_DateServise();
                return;
            }
            if (comSearch.SelectedIndex == 3)
            {
                Search_Enter_Date();
                return;
            }
        }

        private void dgSearch_CellEnter(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgSearch_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {

                if (comSearch.SelectedIndex == 0 || comSearch.SelectedIndex == 2 || comSearch.SelectedIndex == 3 || comSearch.SelectedIndex == 5)
                {
                    FormEditUser frmEditUser = new FormEditUser();
                    frmEditUser.txtEshterak.Text = dgSearch.CurrentRow.Cells[0].Value.ToString();
                    //---------------------
                    frmEditUser.txtName.Text = dgSearch.CurrentRow.Cells[1].Value.ToString();
                    //---------------------
                    frmEditUser.txtEnter.Text = dgSearch.CurrentRow.Cells[2].Value.ToString();
                    //---------------------
                    frmEditUser.txtPhone.Text = dgSearch.CurrentRow.Cells[3].Value.ToString();
                    //---------------------
                    frmEditUser.txtEmail.Text = dgSearch.CurrentRow.Cells[4].Value.ToString();
                    //---------------------
                    frmEditUser.txtBirthDay.Text = dgSearch.CurrentRow.Cells[5].Value.ToString();
                    //---------------------
                    frmEditUser.txtAddress.Text = dgSearch.CurrentRow.Cells[6].Value.ToString();
                    //---------------------
                    frmEditUser.txtPostiCode.Text = dgSearch.CurrentRow.Cells[7].Value.ToString();
                    //---------------------
                    frmEditUser.Show();
                    return;
                }


                if (comSearch.SelectedIndex == 1)
                {

                    FormEditService frmEditSer = new FormEditService();

                    frmEditSer.txtEshterak.Text = dgSearch.CurrentRow.Cells[0].Value.ToString();
                    //-----------
                    frmEditSer.txtName.Text = dgSearch.CurrentRow.Cells[1].Value.ToString();
                    //-----------
                    frmEditSer.txtDateService.Text = dgSearch.CurrentRow.Cells[2].Value.ToString();
                    //-----------
                    frmEditSer.txtPhone.Text = dgSearch.CurrentRow.Cells[3].Value.ToString();
                    //-----------
                    frmEditSer.txtBeiane.Text = dgSearch.CurrentRow.Cells[4].Value.ToString();
                    //-----------
                    frmEditSer.txtPardakhti.Text = dgSearch.CurrentRow.Cells[5].Value.ToString();
                    //-----------
                    frmEditSer.txtTakhfif.Text = dgSearch.CurrentRow.Cells[6].Value.ToString();
                    //-----------
                    frmEditSer.txtTotalSum.Text = dgSearch.CurrentRow.Cells[7].Value.ToString();
                    //-----------
                    if ((dgSearch.CurrentRow.Cells[8].Value).ToString() == "0")
                        frmEditSer.chxTasfiye.Checked = true;
                    else
                        frmEditSer.chxTasfiye.Checked = false;
                    //-----------
                    frmEditSer.txtCodeRahgiri.Text = dgSearch.CurrentRow.Cells[9].Value.ToString();
                    //-----------
                    frmEditSer.txtSomeService.Text = dgSearch.CurrentRow.Cells[10].Value.ToString();
                    //-----------
                    frmEditSer.txtReadyDate.Text = dgSearch.CurrentRow.Cells[11].Value.ToString();
                    //-----------
                    frmEditSer.txtReadySms.Text = dgSearch.CurrentRow.Cells[12].Value.ToString();
                    //-----------
                    frmEditSer.txtDescription.Text = dgSearch.CurrentRow.Cells[13].Value.ToString();
                    //-----------

                    frmEditSer.Show();
                    return;
                }

            }

            
            catch (Exception ex)
            { 
            MessageBox.Show(ex.Message); }

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }


        private void btnPdfExport_Click(object sender, EventArgs e)
        {
            Report.Load(Application.StartupPath + OutPout_Name());
            Report.RegBusinessObject(OutPout_Data(), dgSearch.DataSource);
            Report.Render(false);

            _save = new SaveFileDialog();
            _save.Filter = "PDF File (.pdf)|*.pdf";
            if (_save.ShowDialog() == DialogResult.OK)
                Report.ExportDocument(StiExportFormat.Pdf, _save.FileName);
        }

        private void btnWordExport_Click(object sender, EventArgs e)
        {
            Report.Load(Application.StartupPath + OutPout_Name());
            Report.RegBusinessObject(OutPout_Data(), dgSearch.DataSource);
            Report.Render(false);
            _save = new SaveFileDialog();
            _save.Filter = "Word File (.docx)|*.docx";
            if (_save.ShowDialog() == DialogResult.OK)
                Report.ExportDocument(StiExportFormat.Word2007, _save.FileName);
        }

        private void btnExcelExport_Click(object sender, EventArgs e)
        {
            Report.Load(Application.StartupPath + OutPout_Name());
            Report.RegBusinessObject(OutPout_Data(), dgSearch.DataSource);
            Report.Render(false);
            _save = new SaveFileDialog();
            _save.Filter = "Excel File (.xlsx)|*.xlsx";
            if (_save.ShowDialog() == DialogResult.OK)
                Report.ExportDocument(StiExportFormat.Excel2007, _save.FileName);
        }
    }
}
