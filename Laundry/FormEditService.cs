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
    public partial class FormEditService : Form
    {
        public FormEditService()
        {
            InitializeComponent();
        }
        //**************
        //baraye inke faghat adad vared konad
        private void Enter_Number(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
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
        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                lblError.Text = "";
                if (txtPhone.TextLength > 11 || txtPhone.TextLength < 11)
                {
                    lblError.ForeColor = Color.Red;
                    lblError.Text = "شماره موبایل 11 عدد نیست";
                    return;
                }
                using (var context = new kitchenEntities())
                {
                    
                    var editService = context.Service.Where(c => c.CodeRahgiri == txtCodeRahgiri.Text).FirstOrDefault();

                    editService.Name = txtName.Text;
                    editService.DateService= int.Parse(txtDateService.Text.Replace("/", ""));
                    editService.Mobile = txtPhone.Text;
                    if (txtBeiane.Text != "")
                        editService.Bestankar = Int64.Parse(txtBeiane.Text.Replace(",", ""));
                    else
                        editService.Bestankar = 0;
                    if (txtTakhfif.Text != "")
                        editService.Takhfif = Int64.Parse(txtTakhfif.Text.Replace(",", ""));
                    else
                        editService.Takhfif = 0;
                    if (txtTotalSum.Text != "")
                        editService.SumServices = Int64.Parse(txtTotalSum.Text.Replace(",", ""));
                    else
                        editService.SumServices = 0;
                    if (chxTasfiye.Checked == true)
                        editService.Tasfiye = "0";
                    else
                        editService.Tasfiye = "1";
                    editService.NumberService = txtSomeService.Value.ToString();
                    editService.ReadyDate= Int64.Parse(txtReadyDate.Text.Replace("/", ""));
                    editService.SendReadySms = Int64.Parse(txtReadySms.Value.ToString());
                    editService.Description = txtDescription.Text;
                    if (txtPardakhti.Text != "")
                        editService.Pardakhti = Int64.Parse(txtPardakhti.Text.Replace(",", ""));
                    else
                        editService.Pardakhti = 0;
                    //************
                    context.SaveChanges();
                    lblError.ForeColor = Color.Green;
                    lblError.Text = "اطلاعات با ویرایش شد";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                lblError.Text = "";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);

        }

        private void txtDateService_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);

        }

        private void txtSomeService_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);

        }

        private void txtBeiane_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);

        }

        private void txtBaghimande_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);
        }

        private void txtTakhfif_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);

        }

        private void txtTotalSum_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);

        }

        private void txtReadyDate_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);

        }

        private void txtReadySms_KeyPress(object sender, KeyPressEventArgs e)
        {
            Enter_Number(sender, e);

        }

        private void FormEditService_Load(object sender, EventArgs e)
        {
            if (txtBeiane.Text == "0")
                txtBeiane.Text = "";
        }

        private void txtBeiane_TextChanged(object sender, EventArgs e)
        {
            txtBeiane.Text = Seragham(txtBeiane.Text);
            txtBeiane.Select(txtBeiane.TextLength, 0);
        }

        private void txtTakhfif_TextChanged(object sender, EventArgs e)
        {
            txtTakhfif.Text = Seragham(txtTakhfif.Text);
            txtTakhfif.Select(txtTakhfif.TextLength, 0);
        }

        private void txtBaghimande_TextChanged(object sender, EventArgs e)
        {
            txtPardakhti.Text = Seragham(txtPardakhti.Text);
            txtPardakhti.Select(txtPardakhti.TextLength, 0);
        }

        private void txtTotalSum_TextChanged(object sender, EventArgs e)
        {
            txtTotalSum.Text = Seragham(txtTotalSum.Text);
            txtTotalSum.Select(txtTotalSum.TextLength, 0);
        }

        private void label15_Click(object sender, EventArgs e)
        {

        }
    }
}
