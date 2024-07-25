using QLBH.Models;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace QLBH
{
    public partial class fEditCustomer : Form
    {
        EFDbContext db = new EFDbContext();
        Customer customer;
        long CustomerID;

        public fEditCustomer(long CustomerID)
        {
            InitializeComponent();
            this.CustomerID = CustomerID;

        }

        private void fEditCustomer_Load(object sender, EventArgs e)
        {
            customer = db.Customers.SingleOrDefault(p => p.CustomerID == CustomerID);
            if (customer != null)
            {
                Text += " - Mã KH " + customer.CustomerID.ToString();
                txtName.Text = customer.Name;
                txtAddress.Text = customer.Address;
                txtPhone.Text = customer.Phone;
                txtEmail.Text = customer.Email;
                dateTimePicker1.Value = customer.BirthDay;
                ckGender.CheckState = customer.Gender == null ? CheckState.Indeterminate : (customer.Gender == true ? CheckState.Checked : CheckState.Unchecked);
                ckStatus.Checked = customer.Status;
            }
            else
            {
                MessageBox.Show("Không tìm thấy khách hàng có mã tương ứng.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                // Đóng form hoặc thực hiện hành động phù hợp khi không tìm thấy khách hàng
                this.Close(); // Đóng form
            }
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
                if (customer != null)
                {
                    customer.Name = txtName.Text;
                    customer.Address = txtAddress.Text;
                    customer.Phone = txtPhone.Text;
                    customer.Email = txtEmail.Text;
                    customer.BirthDay = dateTimePicker1.Value.Date;
                    customer.Gender = ckGender.CheckState == CheckState.Indeterminate ? (bool?)null : ckGender.Checked;
                    customer.Status = ckStatus.Checked;
                    db.SaveChanges();
                    toolTip1.Show("Lưu thành công.", btnSave, 0, 0, 1000);
                }
                else
                {
                    MessageBox.Show("Không thể lưu thông tin vì không có khách hàng được tìm thấy.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btnSave, 0, 0, 1000);
            }
            txtName.Focus();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void fEditCustomer_Activated(object sender, EventArgs e)
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

        private void fNewCustomer_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}

