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
    public partial class fManageProduct : Form
    {
        private EFDbContext db;
        private long CategoryID;
        public fManageProduct()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void fManageProduct_Load(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                cbCategories.DisplayMember = "Name";
                cbCategories.ValueMember = "CategoryID";
                //sau 2 lệnh trên
                cbCategories.DataSource =
                db.Categories.OrderBy(c => c.Order)
                .Select(c => new { c.CategoryID, c.Name })
                .ToList();
                //cbCategories.Text = null;
                dataGridView1.Width = ClientSize.Width - 10;
            }
        }

        private void cbCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                CategoryID = Convert.ToInt64(cbCategories.SelectedValue);
                dataGridView1.DataSource = db.Products.Where(p =>
    p.CategoryID == CategoryID).Select(p => new
    {
        p.ProductID,
        p.Name,
        p.Quantity,
        p.Price,
        p.MarketPrice,
        p.Description,
        p.ImageFile,
        p.Status
    }).ToList();
                //lblNumOfProduct.Text = "Số sản phẩm: " + dataGridView1.Rows.Count;
            }

        }

        private void btFind_Click(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                if (ckCategory.Checked)
                    dataGridView1.DataSource = db.Products.Where(p =>
                   p.Name.Contains(txtName.Text) && (p.CategoryID == CategoryID ||
                   cbCategories.SelectedIndex < 0)).Select(p => new
                   {
                       p.ProductID,
                       p.Name,
                       p.Quantity,
                       p.Price,
                       p.MarketPrice,
                       p.Description,
                       p.ImageFile,
                       p.Status
                   }).ToList();
                else
                    dataGridView1.DataSource = db.Products.Where(p =>
p.Name.Contains(txtName.Text)).Select(p => new
{
    p.ProductID,
    p.Name,
    p.Quantity,
    p.Price,
    p.MarketPrice,
    p.Description,
    p.ImageFile,
    p.Status
}).ToList();
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Kiểm tra nếu nhấp vào tiêu đề cột hoặc hàng không hợp lệ
            if (e.RowIndex < 0 || e.ColumnIndex < 0)
                return;

            try
            {
                // Lấy giá trị từ ô chứa tên tệp hình ảnh
                var imageFileName = dataGridView1.Rows[e.RowIndex].Cells["ImageFile"].Value?.ToString();

                // Kiểm tra nếu giá trị không null hoặc rỗng
                if (!string.IsNullOrEmpty(imageFileName))
                {
                    // Kết hợp đường dẫn tệp hình ảnh
                    string imagePath = System.IO.Path.Combine(Utility.ImagePath, imageFileName);

                    // Kiểm tra xem tệp hình ảnh có tồn tại không
                    if (System.IO.File.Exists(imagePath))
                    {
                        // Nạp hình ảnh vào PictureBox
                        pictureBox1.ImageLocation = imagePath;
                    }
                    else
                    {
                        // Hiển thị thông báo nếu tệp hình ảnh không tồn tại
                        MessageBox.Show("Tệp hình ảnh không tồn tại: " + imagePath, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        pictureBox1.Image = null;
                    }
                }
                else
                {
                    // Xóa hình ảnh nếu giá trị là null hoặc rỗng
                    pictureBox1.Image = null;
                }
            }
            catch (Exception ex)
            {
                // Hiển thị thông báo lỗi hoặc xử lý lỗi theo cách của bạn
                MessageBox.Show("Đã xảy ra lỗi khi tải hình ảnh: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fNewProduct"))
                return;
            fNewProduct f = new fNewProduct();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void fManageProduct_Activated(object sender, EventArgs e)
        {
            cbCategories_SelectedIndexChanged(sender, e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long ProductID =
                   Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["ProductID"].Value);
                    using (var db = new EFDbContext())
                    {
                        Product product = db.Products.Single(c => c.ProductID ==
                       ProductID);
                        if (MessageBox.Show("Bạn muốn xóa sản phẩm " +
                       product.Name, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) ==
                       DialogResult.Yes)
                        {
                            db.Products.Remove(product);
                            db.SaveChanges();
                            fManageProduct_Activated(sender, e);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi, chưa xóa được? Error: " + ex.Message);
                }
            }
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Edit")
            {
                if (Utility.IsOpeningForm("fEditProduct"))
                    return;
                fEditProduct f = new fEditProduct(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["ProductID"].Value));
                f.MdiParent = this.MdiParent;
                f.Show();
            }

        }

    }
}
