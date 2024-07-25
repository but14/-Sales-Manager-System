using Microsoft.EntityFrameworkCore;
using QLBH.Models;
using System;
using System.Linq;
using System.Windows.Forms;

namespace QLBH
{
    public partial class fProcessOrderDetails : Form
    {
        private EFDbContext db = new EFDbContext();
        private long? OrderID;
        public fProcessOrderDetails()
        {
            InitializeComponent();
        }
        public fProcessOrderDetails(long? OrderID)
        {
            InitializeComponent();
            this.OrderID = OrderID;
        }

        private void fProcessOrderDetails_Load(object sender, EventArgs e)
        {
            cbProducts.DisplayMember = "Name";
            cbProducts.ValueMember = "ProductID";
            cbProducts.DataSource = db.Products.Select(p => new { p.ProductID, p.Name }).ToList();
            cbProducts.Text = null;
            cbOrders.DataSource = db.Orders.Select(o => o.OrderID).ToList();
            cbOrders.Text = null;
            mQuantity.ValidatingType = typeof(Int32);
        }

        private void cbOrders_SelectionChangeCommitted(object sender, EventArgs e)
        {
            OrderID = Convert.ToInt64(cbOrders.SelectedValue);
            Order order = db.Orders.Include(o => o.Customer).SingleOrDefault(o => o.OrderID == OrderID);
            if (order == null) return;

            Text = "Xử lý chi tiết đơn hàng " + order.OrderID.ToString();
            txtReceiveAddress.Text = order.ReceiveAddress;
            dtOrderDate.Text = order.OrderDate.ToShortDateString();
            dtReceiveDate.Text = order.ReceiveDate.ToString();
            mOrderTime.Text = order.OrderTime.ToString();
            mReceiveTime.Text = order.ReceiveTime.ToString();
            cbProgresses.Text = order.ProgressID.ToString();
            cbCustomers.Text = order.Customer.Name;
            cbProducts.Text = null;
            mQuantity.Text = null;
            loadOrderDetails();

            dataGridView1.Columns["ProductID"].ReadOnly = true;
            dataGridView1.Columns["OrderID"].ReadOnly = true;
            dataGridView1.Columns["Name"].ReadOnly = true;
        }

        private void loadOrderDetails()
        {
            var details = db.OrderDetails
                .Where(d => d.OrderID == OrderID)
                .Select(d => new { d.OrderID, d.ProductID, d.Product.Name, d.Quantity, d.Price })
                .ToList();

            List<OrderDetailsAndProduct> list = new List<OrderDetailsAndProduct>();
            foreach (var d in details)
            {
                OrderDetailsAndProduct detail = new OrderDetailsAndProduct
                {
                    ProductID = d.ProductID,
                    OrderID = d.OrderID,
                    Quantity = d.Quantity,
                    Price = d.Price,
                    Name = d.Name
                };
                list.Add(detail);
            }

            dataGridView1.DataSource = list;
            cbOrders.Focus();
        }

        private void cbProducts_SelectedIndexChanged(object sender, EventArgs e)
        {
            long ProductID = Convert.ToInt32(cbProducts.SelectedValue);
            mPrice.Text = db.Products.Where(p => p.ProductID == ProductID).Select(p => p.Price).SingleOrDefault().ToString();
            mQuantity.Focus();
        }

        private void btAddOrderDetail_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(cbProducts.Text))
            {
                toolTip1.Show("Hãy nhập sản phẩm?", cbProducts, 0, 0, 1000);
                cbProducts.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(mQuantity.Text))
            {
                toolTip1.Show("Hãy nhập số lượng?", mQuantity, 0, 0, 1000);
                mQuantity.Focus();
                return;
            }
            try
            {
                OrderDetail orderdetail = new OrderDetail
                {
                    OrderID = (long)OrderID,
                    ProductID = Convert.ToInt64(cbProducts.SelectedValue),
                    Quantity = Convert.ToInt32(mQuantity.Text),
                    Price = Convert.ToDecimal(mPrice.Text)
                };
                db.OrderDetails.Add(orderdetail);
                db.SaveChanges();
                cbProducts.Text = null;
                mQuantity.Text = null;
                loadOrderDetails();
                toolTip1.Show("Thêm thành công.", btAddOrderDetail, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btAddOrderDetail, 0, 0, 1000);
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            OrderDetail orderdetail;
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                try
                {
                    orderdetail = new OrderDetail
                    {
                        OrderID = (long)OrderID,
                        ProductID = Convert.ToInt64(dataGridView1.Rows[i].Cells["ProductID"].Value),
                        Quantity = Convert.ToInt32(dataGridView1.Rows[i].Cells["Quantity"].Value),
                        Price = Convert.ToDecimal(dataGridView1.Rows[i].Cells["Price"].Value)
                    };
                    db.SaveChanges();
                }
                catch (Exception ex)
                {
                    toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, 0, 0, 1000);
                    return;
                }
            }
            loadOrderDetails();
            toolTip1.Show("Lưu thành công.", btSave, 0, 0, 1000);
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            OrderDetail orderdetail;
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long ProductID = Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["ProductID"].Value);
                    orderdetail = db.OrderDetails.Single(o => o.ProductID == ProductID && o.OrderID == OrderID);
                    if (MessageBox.Show("Bạn muốn xóa " + ProductID, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        db.OrderDetails.Remove(orderdetail);
                        db.SaveChanges();
                        loadOrderDetails();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }
        }

        private void dataGridView1_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Quantity")
            {
                if (String.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText = "Hãy nhập số lượng?";
                    e.Cancel = true;
                    return;
                }
                else
                {
                    try
                    {
                        if (Convert.ToInt32(e.FormattedValue) < 0)
                        {
                            dataGridView1.Rows[e.RowIndex].ErrorText = "Số lượng phải >= 0?";
                            e.Cancel = true;
                        }
                        else
                        {
                            dataGridView1.Rows[e.RowIndex].ErrorText = "";
                        }
                    }
                    catch
                    {
                        dataGridView1.Rows[e.RowIndex].ErrorText = "Dữ liệu sai kiểu số nguyên?";
                        e.Cancel = true;
                        return;
                    }
                }
                dataGridView1.Rows[e.RowIndex].Cells["Amount"].Selected = true;
                dataGridView1.Rows[e.RowIndex].Cells["Amount"].Selected = false;
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Price")
            {
                if (String.IsNullOrEmpty(e.FormattedValue.ToString()))
                {
                    dataGridView1.Rows[e.RowIndex].ErrorText = "Hãy nhập giá bán?";
                    e.Cancel = true;
                    return;
                }
                else
                {
                    try
                    {
                        if (Convert.ToDecimal(e.FormattedValue) < 0)
                        {
                            dataGridView1.Rows[e.RowIndex].ErrorText = "Giá bán phải >= 0?";
                            e.Cancel = true;
                            return;
                        }
                        else
                        {
                            dataGridView1.Rows[e.RowIndex].ErrorText = "";
                        }
                    }
                    catch
                    {
                        dataGridView1.Rows[e.RowIndex].ErrorText = "Dữ liệu sai kiểu số thực?";
                        e.Cancel = true;
                        return;
                    }
                }
                dataGridView1.Rows[e.RowIndex].Cells["Amount"].Selected = true;
                dataGridView1.Rows[e.RowIndex].Cells["Amount"].Selected = false;
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].ErrorText = String.Empty;
        }

        private void btCancel_Click(object sender, EventArgs e)
        {

        }
        private void fProcessOrderDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }
    }
}
