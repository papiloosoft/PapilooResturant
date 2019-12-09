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
    public partial class FormManagePrice : Form
    {
        //string editMotorOil,editHidrolikOil;
        public FormManagePrice()
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
        private void btnSave_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            try
            {
                using (var context = new kitchenEntities())
                {
                    var name = context.ServicesPrice.Where(current => current.ServisKind == comGroup.Text && current.ServiceKala==txtKindKala.Text && current.ServiseName==txtServiceName.Text).ToList();
                    if (name.Count == 0)
                    {
                        ServicesPrice pri = new ServicesPrice();
                        pri.ServisKind = comGroup.Text;
                        pri.ServiseName = txtServiceName.Text;
                        pri.ServiceKala = txtKindKala.Text;
                        //if (txtServisPrice.Text != "")
                        pri.ServicePrice = Convert.ToInt64(txtServisPrice.Text);
                        // else
                        //pri.ServicePrice1 = 0;
                        context.SaveChanges();

                        context.ServicesPrice.Add(pri);
                        context.SaveChanges();
                        lblError.ForeColor = Color.Green;
                        lblError.Text = "اطلاعات خدمت ثبت شد";
                        Refresh_Price();

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

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveHidrolik_Click(object sender, EventArgs e)
        {
        }
        

        private void button1_Click(object sender, EventArgs e)
        {

        }
        

        private void btnUpdatePriceOilMotor_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            try
            {

                using (var context = new kitchenEntities())
                {
                    Int64 price = Convert.ToInt64(txtServisPrice.Text);
                    var service = context.ServicesPrice.Where(current => current.ServisKind == comGroup.Text && current.ServiceKala == txtKindKala.Text && current.ServiseName == txtServiceName.Text && current.ServicePrice ==price ).ToList();
                    if (service.Count == 0)
                    {
                        int x = Convert.ToInt16(dgShow.CurrentRow.Cells[4].Value.ToString());
                        var update = context.ServicesPrice.Where(current => current.Id == x).FirstOrDefault();
                        if (update != null)
                        {
                            update.ServisKind = comGroup.Text;
                            update.ServiceKala = txtKindKala.Text;
                            update.ServiseName = txtServiceName.Text;

                            if (txtServisPrice.Text != "")
                                update.ServicePrice = Convert.ToInt64(txtServisPrice.Text);
                            else
                                update.ServicePrice = 0;
                            context.SaveChanges();
                            context.Dispose();
                        }



                        lblError.ForeColor = Color.Green;
                        lblError.Text = "ویرایش با موفقبت اتجام شد";
                        Refresh_Price();
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

                MessageBox.Show(ex.Message);
            }
        }

        private void btnSearchHidrolikOil_Click(object sender, EventArgs e)
        {
        }
        
        private void btnSearchMotorOil_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            try
            {
                if (txtKindKala.Text == "" || txtServisPrice.Text == "")
                {
                    using (var context = new kitchenEntities())
                    {
                        var update = context.ServicesPrice.Where(current => current.ServiseName.Contains(txtKindKala.Text)).ToList();
                        if (update != null)
                        {
                            dgShow.DataSource = update;
                            //editMotorOil = txtKindKala.Text;
                        }
                        else
                        {
                            lblError.ForeColor = Color.Red;
                            lblError.Text = "هیچ موردی پیدا نشد";
                        }
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void btnUpdatePriceHidrolik_Click(object sender, EventArgs e)
        {

        }

        private void FormManagePrice_Load(object sender, EventArgs e)
        {

            Refresh_Price();
        }
        public void Refresh_Price()
        {
            using (var context = new kitchenEntities())
            {

                dgShow.DataSource = context.ServicesPrice.ToList();

                dgShow.Columns[0].HeaderText = "دسته";
                dgShow.Columns[1].HeaderText = "محصول";
                dgShow.Columns[2].HeaderText = "سرویس";
                dgShow.Columns[3].HeaderText = "قیمت";
                dgShow.Columns[4].HeaderText = "شماره";
                //dgShow.Columns[4].Visible = false;

                
            }
        }

        private void btnDeleteMotorOil_Click(object sender, EventArgs e)
        {
            lblError.Text = "";
            try
            {
                using (var context = new kitchenEntities())
                {
                    int x = Convert.ToInt16(dgShow.CurrentRow.Cells[4].Value.ToString());

                    ServicesPrice del = context.ServicesPrice.Where(current => current.Id == x).FirstOrDefault();
                    context.ServicesPrice.Remove(del);
                    context.SaveChanges();
                    lblError.ForeColor = Color.Green;
                    lblError.Text = "خدمت با موفقیت حذف شد";
                    context.Dispose();



                    Refresh_Price();
                    comGroup.Text = "";
                    txtServiceName.Text = "";
                    txtKindKala.Text = "";
                    txtServisPrice.Text = "";



                }
            }
            catch (Exception)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = "عملیات حذف با مشکل مواجه شد";
            }
        }

        private void dgShow_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            lblError.Text = "";
            try
            {
                if (dgShow.CurrentRow.Cells[0].Selected || dgShow.CurrentRow.Cells[1].Selected || dgShow.CurrentRow.Cells[2].Selected || dgShow.CurrentRow.Cells[3].Selected)
                {
                    comGroup.Text = dgShow.CurrentRow.Cells[0].Value.ToString();
                    txtKindKala.Text= dgShow.CurrentRow.Cells[1].Value.ToString();
                    txtServiceName.Text= dgShow.CurrentRow.Cells[2].Value.ToString();
                    txtServisPrice.Text= dgShow.CurrentRow.Cells[3].Value.ToString();
                }
                
            }
            catch (Exception)
            {
                lblError.ForeColor = Color.Red;
                lblError.Text = "مقداری وجود ندارد";
            }

            
        }

        private void btnDeleteHidrolikOil_Click(object sender, EventArgs e)
        {
        }

        private void txtPriceMotorOil_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender,e);
        }

        private void txtPriceHidrolikOil_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);
        }

        private void txtPriceFilterOil_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);
        }

        private void txtPriceFilterAir_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);
        }

        private void txtPriceFilterCondition_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);
        }

        private void txtPriceFilterBenzin_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);
        }

        private void txtPriceVaskazin_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);
        }

        private void txtPriceBatriWatear_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);
        }
        }
    }

