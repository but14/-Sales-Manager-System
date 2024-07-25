using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using QLBH.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
namespace QLBH
{
    public partial class fNewCustomer : Form
    {
        Customer customer;
        public fNewCustomer()
        {
            InitializeComponent();
            txtName.MaxLength = 100;
            txtPhone.MaxLength = 10;
            txtAddress.MaxLength = 250;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void ckGender_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên khách hàng?", txtName, 0, 0, 1000);
                txtName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                toolTip1.Show("Hãy nhập địa chỉ khách hàng?", txtAddress, 0, 0, 1000);
                txtAddress.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(txtPhone.Text))
            {
                toolTip1.Show("Hãy nhập địa chỉ khách hàng?", txtPhone, 0, 0, 1000);
                txtPhone.Focus();
                return;
            }

            try
            {
                // Tạo khách hàng mới
                customer = new Customer
                {
                    Name = txtName.Text,
                    Phone = txtPhone.Text,
                    Address = txtAddress.Text,
                    // Thiết lập các thuộc tính khác
                };

                // Kiểm tra nếu đã nhập email
                if (!string.IsNullOrEmpty(txtEmail.Text))
                {
                    customer.Email = txtEmail.Text;
                }

                // Kiểm tra nếu đã chọn ngày sinh
                if (dateTimePicker1.Value != null)
                {
                    customer.BirthDay = dateTimePicker1.Value.Date;
                }

                // Kiểm tra giới tính
                customer.Gender = ckGender.CheckState == CheckState.Indeterminate ? (bool?)null : ckGender.Checked;

                // Thiết lập trạng thái
                customer.Status = ckStatus.Checked;

                using (var db = new EFDbContext())
                {
                    db.Customers.Add(customer); // Thêm khách hàng vào bối cảnh mô hình
                    db.SaveChanges(); // Lưu các thay đổi vào cơ sở dữ liệu
                }

                // Xóa trống và thiết lập lại các điều khiển
                txtName.Text = null;
                txtAddress.Text = null;
                txtPhone.Text = null;
                txtEmail.Text = null;
                // dateTimePicker1.Text = null; // Không tác dụng
                ckGender.CheckState = CheckState.Indeterminate;
                ckStatus.Checked = true;
                toolTip1.Show("Lưu thành công!", btnSave, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại. Lỗi: " + ex.Message, btnSave, 0, 0, 1000);
            }

            txtName.Focus();
        }

        private void fNewCustomer_Load(object sender, EventArgs e)
        {

        }

        private void fNewCustomer_Activated(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {

            }

        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên khách hàng?", txtName, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtName.Text.Length > 100)
            {
                toolTip1.Show("Tên khách hàng <= 100 ký tự?", txtName, 0, 0, 1000);
                e.Cancel = true;
            }

        }

        private void txtAddress_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtAddress.Text))
            {
                toolTip1.Show("Hãy nhập địa chỉ?", txtAddress, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtAddress.Text.Length > 250)
            {
                toolTip1.Show("Địa chỉ <= 250 ký tự?", txtAddress, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void txtPhone_Validating(object sender, CancelEventArgs e)
        {
            if (Regex.IsMatch(txtPhone.Text, @"\d{10}") && txtPhone.Text.Length == 10)
                return;
            toolTip1.Show("Không đúng dạng số điện thoại?", txtPhone, 0, 0, 1000);
            e.Cancel = true;
        }

        private void dateTimePicker1_Validating(object sender, CancelEventArgs e)
        {
            if (dateTimePicker1.Value.Date > DateTime.Now.Date)
            {
                toolTip1.Show("Ngày/tháng/năm <= hiện tại?", dateTimePicker1, 0, 0, 1000);
                e.Cancel = true;
            }

        }

        private void fNewCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void txtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
                return; //Có thể không cần nhập dữ liệu cho cột có thể null
            if (!Regex.IsMatch(txtEmail.Text, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$"))
            {
                toolTip1.Show("Không đúng dạng địa chỉ email?", txtEmail, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (txtEmail.Text.Length > 100)
            {
                toolTip1.Show("Địa chỉ email <= 100 ký tự?", txtEmail, 0, 0, 1000);
                e.Cancel = true;
            }

        }
    }
}
