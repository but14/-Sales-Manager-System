using QLBH.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLBH
{
    public partial class fNewOrder : Form
    {
        private Order order;
        public fNewOrder()
        {
            InitializeComponent();
            InitializeControls();
        }
        private void InitializeControls()
        {
            cbCustomDateTime.CheckedChanged += cbCustomDateTime_CheckedChanged;
            dtOrderDate.Enabled = false; // Mặc định là tắt
            mOrderTime.Enabled = false;

        }
        // Xử lý sự kiện CheckedChanged của CheckBox
        private void cbCustomDateTime_CheckedChanged(object sender, EventArgs e)
        {
            dtOrderDate.Enabled = cbCustomDateTime.Checked;
            mOrderTime.Enabled = cbCustomDateTime.Checked;
        }


        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void fNewOrder_Load(object sender, EventArgs e)
        {
            mOrderTime.ValidatingType = typeof(DateTime);
            mReceiveTime.ValidatingType = typeof(DateTime);
            cbCustomers.DisplayMember = "Name";
            cbCustomers.ValueMember = "CustomerID";
            using (var db = new EFDbContext())
            {
                cbCustomers.DataSource = db.Customers.Select(c => new
                {
                    c.CustomerID,
                    c.Name
                }).ToList();
                cbEmployees.DisplayMember = "Name";
                cbEmployees.ValueMember = "EmployeeID";
                cbEmployees.DataSource = db.Employees.Select(emp => new
                {
                    emp.EmployeeID,
                    emp.Name
                }).ToList();
            }
            // Thiết lập dữ liệu cho cbEmployees
            cbCustomers.Text = null;
            cbCustomers.Text = null;
            mOrderTime.Text = DateTime.Now.TimeOfDay.ToString();
            mReceiveTime.Text = DateTime.Now.TimeOfDay.ToString();
            mOrderTime.ValidatingType = typeof(DateTime);
            mReceiveTime.ValidatingType = typeof(DateTime);

        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();

        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtReceiveAddress.Text))
            {
                toolTip1.Show("Hãy nhập địa chỉ nhận hàng?", txtReceiveAddress, 0, 0,
               1000);
                txtReceiveAddress.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(mOrderTime.Text))
            {
                toolTip1.Show("Hãy nhập giờ:phút:giây đặt hàng?", mOrderTime, 0, 0,
               1000);
                mOrderTime.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(mReceiveTime.Text))
            {
                toolTip1.Show("Hãy nhập giờ:phút:giây nhận hàng?", mReceiveTime,
               0, 0, 1000);
                mReceiveTime.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbCustomers.Text))
            {
                toolTip1.Show("Hãy nhập khách hàng?", cbCustomers, 0, 0, 1000);
                cbCustomers.Focus();
                return;
            }
            if (Convert.ToDateTime(dtOrderDate.Value.ToShortDateString() + " " +
                Convert.ToDateTime(mOrderTime.Text).TimeOfDay) >
                Convert.ToDateTime(dtReceiveDate.Value.ToShortDateString() + " " +
                Convert.ToDateTime(mReceiveTime.Text).TimeOfDay))
            {
                toolTip1.Show("Thời điểm đặt hàng phải <= Thời điểm nhận hàng?",
               mReceiveTime, 0, 0, 1000);
                mReceiveTime.Focus();
                return;
            }


            try
            {
                order = new Order();
                order.ReceiveAddress = txtReceiveAddress.Text;

                if (cbCustomDateTime.Checked)
                {
                    order.OrderDate = DateTime.Now.Date;
                    order.OrderTime = DateTime.Now.TimeOfDay;
                }
                else
                {
                    order.OrderDate = dtOrderDate.Value.Date;
                    order.OrderTime = Convert.ToDateTime(mOrderTime.Text).TimeOfDay;
                }

                order.ReceiveDate = dtReceiveDate.Value.Date;
                order.ReceiveTime = Convert.ToDateTime(mReceiveTime.Text).TimeOfDay;
                order.ProgressID = 1;
                order.CustomerID = (int)Convert.ToInt64(cbCustomers.SelectedValue);
                order.EmployeeID = Convert.ToInt64(cbEmployees.SelectedValue);

                using (var db = new EFDbContext())
                {
                    db.Orders.Add(order);
                    db.SaveChanges();
                }

                // Reset lại các điều khiển sau khi lưu thành công
                txtReceiveAddress.Text = null;
                mReceiveTime.Text = DateTime.Now.TimeOfDay.ToString();
                mOrderTime.Text = DateTime.Now.TimeOfDay.ToString();
                cbCustomers.SelectedIndex = -1;
                cbEmployees.SelectedIndex = -1;


                toolTip1.Show("Lưu thành công.", btSave, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại. Error: " + ex.Message, btSave, 0, 0, 1000);
            }
        }

        private void cbCustomers_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbCustomers_Validating(object sender, CancelEventArgs e)
        {

        }

        private void txtReceiveAddress_TextChanged(object sender, EventArgs e)
        {



        }

        private void txtReceiveAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtReceiveAddress.Text))
            {
                toolTip1.Show("Hãy nhập địa chỉ khách hàng?", txtReceiveAddress, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtReceiveAddress.Text.Length > 250)
            {
                toolTip1.Show("Địa chỉ khách hàng - tối đa 250 ký tự?",
               txtReceiveAddress, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void mOrderTime_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                toolTip1.Show("Dữ liệu sai kiểu Time?", mOrderTime, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void mReceiveTime_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                toolTip1.Show("Dữ liệu sai kiểu Time?", mReceiveTime, 0, 0, 1000);
                e.Cancel = true;
            }

        }
    }
}
