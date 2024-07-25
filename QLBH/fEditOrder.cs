using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;
using QLBH.Models;

namespace QLBH
{
    public partial class fEditOrder : Form
    {
        private Order order;
        private long OrderID;
        private EFDbContext db = new EFDbContext();
        public fEditOrder(long OrderID)
        {
            InitializeComponent();
            this.OrderID = OrderID;

        }

        private void fEditOrder_Load(object sender, EventArgs e)
        {
            try
            {
                order = db.Orders.Include(o => o.Customer).SingleOrDefault(o => o.OrderID == OrderID);

                if (order == null)
                {
                    MessageBox.Show("Đơn hàng không tồn tại.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    this.Close();
                    return;
                }

                Text = "SỬA ĐƠN HÀNG " + order.OrderID.ToString();
                txtReceiveAddress.Text = order.ReceiveAddress;
                dtOrderDate.Text = order.OrderDate.ToShortDateString();
                dtReceiveDate.Text = order.ReceiveDate.ToString();
                mOrderTime.Text = order.OrderTime.ToString();
                mReceiveTime.Text = order.ReceiveTime.ToString();
                // Hiển thị tên khách hàng trong Label
                lblCustomerName.Text = "Tên khách hàng:";
                lblCustomerValue.Text = order.Customer.Name;

                cbProgresses.DisplayMember = "Name";
                cbProgresses.ValueMember = "ProgressID";
                cbProgresses.DataSource = db.Progresses.ToList();
                cbProgresses.SelectedValue = order.ProgressID;

                cbCustomers.DisplayMember = "Name";
                cbCustomers.ValueMember = "CustomerID";
                cbCustomers.DataSource = db.Customers.Select(c => new
                {
                    c.CustomerID,
                    c.Name
                }).ToList();
                cbCustomers.SelectedValue = order.CustomerID;
                cbCustomers.Enabled = false; // Ban đầu không cho phép chỉnh sửa

                // Thêm sự kiện cho CheckBox để cho phép chỉnh sửa dữ liệu
                chkAllowEdit.CheckedChanged += (s, ev) =>
                {
                    cbCustomers.Enabled = chkAllowEdit.Checked;
                };

                cbEmployees.DisplayMember = "Name";
                cbEmployees.ValueMember = "EmployeeID";
                cbEmployees.DataSource = db.Employees.Select(e => new
                {
                    e.EmployeeID,
                    e.Name
                }).ToList();
                cbEmployees.SelectedValue = order.EmployeeID;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu đơn hàng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void fEditOrder_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
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
                // Tìm đối tượng đơn hàng cần sửa từ cơ sở dữ liệu
                order = db.Orders.Include(o => o.Customer).Single(o => o.OrderID == OrderID);

                // Cập nhật thông tin từ các điều khiển
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
                order.ProgressID = Convert.ToInt32(cbProgresses.SelectedValue);
                order.CustomerID = (int)Convert.ToInt64(cbCustomers.SelectedValue);
                order.EmployeeID = Convert.ToInt64(cbEmployees.SelectedValue);

                // Lưu thay đổi vào cơ sở dữ liệu
                db.SaveChanges();

                // Hiển thị thông báo thành công và đóng form
                toolTip1.Show("Lưu thành công.", btSave, 0, 0, 1000);
                
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại. Error: " + ex.Message, btSave, 0, 0, 1000);
                MessageBox.Show("Lưu thất bại. Error: " + ex.Message + "\n" + ex.StackTrace);
            }
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
