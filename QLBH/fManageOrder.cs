using Microsoft.EntityFrameworkCore;
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
    public partial class fManageOrder : Form
    {
        public fManageOrder()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long OrderID = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["OrderID"].Value);
                    using (var db = new EFDbContext())
                    {
                        Order order = db.Orders.Single(c => c.OrderID == OrderID);
                        if (MessageBox.Show("Bạn muốn xóa đơn hàng " + order.OrderID, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            
                                db.Orders.Remove(order);
                                db.SaveChanges();
                                fManageOrder_Activated(sender, e);
                            }
                        }
                    }
                          catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }
            // Kiểm tra nếu cột được nhấp là cột "Edit"
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                // Kiểm tra nếu form fEditOrder đang mở
                if (Utility.IsOpeningForm("fEditOrder"))
                    return;

                // Lấy OrderID từ DataGridView
                long orderID;
                if (!long.TryParse(dataGridView1.Rows[e.RowIndex].Cells["OrderID"].Value.ToString(), out orderID))
                {
                    MessageBox.Show("OrderID không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Kiểm tra nếu đơn hàng tồn tại
                using (var db = new EFDbContext())
                {
                    var order = db.Orders.Include(o => o.Customer).SingleOrDefault(o => o.OrderID == orderID);
                    if (order == null)
                    {
                        MessageBox.Show("Không tìm thấy đơn hàng với OrderID: " + orderID, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                // Mở form fEditOrder
                fEditOrder f = new fEditOrder(orderID);
                f.MdiParent = this.MdiParent;
                f.Show();
            }


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void fManageOrder_Load(object sender, EventArgs e)
        {
            for (int i = DateTime.Now.Year + 1; i >= 2015; i--)
                cbYear.Items.Add(i);
            dataGridView1.Width = ClientSize.Width - 10;
        }

        private void cbMonth_SelectedIndexChanged(object sender, EventArgs e)
        {
            int year = string.IsNullOrWhiteSpace(cbYear.Text) ? DateTime.Now.Year : Convert.ToInt32(cbYear.Text);
            byte month = Convert.ToByte(string.IsNullOrWhiteSpace(cbMonth.Text) ?
           DateTime.Now.Month : (cbMonth.Text == "Tất cả" ? 0 : cbMonth.Text));
            using (var db = new EFDbContext())
            {
                if (month == 0)
                    dataGridView1.DataSource = db.Orders.Where(o => o.OrderDate.Year ==
                   year).Select(o => new
                   {
                       o.OrderID,
                       o.OrderDate,
                       o.OrderTime,
                       o.ReceiveDate,
                       o.ReceiveTime,
                       o.ReceiveAddress,
                       o.ProgressID,
                       ProgressName =
                   o.Progress.Name,
                       o.CustomerID,
                       o.EmployeeID
                   }).ToList();
                else
                    dataGridView1.DataSource = db.Orders.Where(o => o.OrderDate.Year == year
                   && o.OrderDate.Month == month).Select(o => new
                   {
                       o.OrderID,
                       o.OrderDate,
                       o.OrderTime,
                       o.ReceiveDate,
                       o.ReceiveTime,
                       o.ReceiveAddress,
                       o.ProgressID,
                       ProgressName = o.Progress.Name,
                       o.CustomerID,
                       o.EmployeeID
                   }).ToList();
            }
            //lblNumOfOrder.Text = "Số đơn hàng: " + dataGridView1.Rows.Count;
        }

        private void cbYear_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbMonth_SelectedIndexChanged(sender, e);
        }

        private void btFind_Click(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                DateTime OrderDate = dateTimePicker1.Value.Date;
                dataGridView1.DataSource = db.Orders.Where(o => o.OrderDate == OrderDate ||
               OrderDate == null).Select(o => new
               {
                   o.OrderID,
                   o.OrderDate,
                   o.OrderTime,
                   o.ReceiveDate,
                   o.ReceiveTime,
                   o.ReceiveAddress,
                   o.ProgressID,
                   ProgressName =
               o.Progress.Name,
                   o.CustomerID,
                   o.EmployeeID
               }).ToList();
            }

        }

        private void btNew_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fNewOrder"))
                return;
            fNewOrder f = new fNewOrder();
            f.MdiParent = this.MdiParent;
            f.Show();

        }

        private void fManageOrder_Activated(object sender, EventArgs e)
        {
            cbMonth_SelectedIndexChanged(sender, e);
        }
    }
}
