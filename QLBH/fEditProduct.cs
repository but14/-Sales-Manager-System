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
    public partial class fEditProduct : Form
    {
        private Product product;
        private long? ProductID;
        private EFDbContext db = new EFDbContext();
        public fEditProduct(long ProductID)
        {
            InitializeComponent();
            this.ProductID = ProductID;
            btnClose.CausesValidation = false;
        }

        private void fEditProduct_Load(object sender, EventArgs e)
        {
            product = db.Products.Include(p => p.Category).Single(p => p.ProductID == ProductID);
            Text = "SỬA ĐỔI SẢN PHẨM " + product.ProductID.ToString();
            txtName.Text = product.Name;
            mQuantity.Text = product.Quantity.ToString();
            mPrice.Text = product.Price.ToString();
            mMarketPrice.Text = product.MarketPrice.ToString();
            ckStatus.Checked = product.Status;
            rDescription.Text = product.Description;
            txtImageFile.Text =
           string.IsNullOrWhiteSpace(product.ImageFile) ? null : Utility.ImagePath
           + product.ImageFile;
            pictureBox1.ImageLocation = txtImageFile.Text; //Hiển thị hình
                                                           //Nạp dữ liệu cho ComboBox
            cbCategories.DisplayMember = "Name";
            cbCategories.ValueMember = "CategoryID";
            cbCategories.DataSource = db.Categories.Select(c => new
            {
                c.CategoryID,
                c.Name
            }).ToList();
            cbCategories.Text = product.Category.Name;
        }

        private void btnClose_Click(object sender, EventArgs e)

        {
            // Bỏ focus khỏi control hiện tại
            this.ActiveControl = null;
            Close();
        }

        private void btBrowse_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "All file|*.*|Bitmap File | *.bmp; *.dib | JPEG | *.jpg; *.jpe; *.jpeg; *.jfif | GIF | *.gif | TIFF | *.tif; *.tiff | PNG | *.png | ICO | *.ico";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                txtImageFile.Text = openFileDialog1.FileName;
                pictureBox1.ImageLocation = openFileDialog1.FileName;
            }
        }

        private void fEditProduct_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = false;
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên sản phẩm?", txtName, 0, 0, 1000);
                txtName.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(cbCategories.Text))
            {
                toolTip1.Show("Hãy nhập loại sản phẩm?", cbCategories, 0, 0, 1000);
                cbCategories.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(mQuantity.Text))
            {
                toolTip1.Show("Hãy nhập số lượng?", mQuantity, 0, 0, 1000);
                mQuantity.Focus();
                return;
            }
            if (string.IsNullOrWhiteSpace(mPrice.Text))
            {
                toolTip1.Show("Hãy nhập giá bán?", mPrice, 0, 0, 1000);
                mPrice.Focus();
                return;
            }
            try
            {
                using (var db = new EFDbContext())
                {
                    if (ProductID.HasValue) // Nếu có ProductID, tìm sản phẩm hiện tại trong csdl
                    {
                        product = db.Products.Find(ProductID.Value);
                        if (product == null)
                        {
                            toolTip1.Show("Không tìm thấy sản phẩm.", btSave, 0, 0, 1000);
                            return;
                        }
                    }
                    else
                    {
                        product = new Product(); // Tạo một thể hiện cho sản phẩm mới
                        db.Products.Add(product); // Thêm sản phẩm vào bối cảnh
                    }

                    product.Name = txtName.Text;
                    product.Quantity = Convert.ToInt32(mQuantity.Text);
                    product.Price = Convert.ToDecimal(mPrice.Text);
                    product.MarketPrice = string.IsNullOrWhiteSpace(mMarketPrice.Text) ? (decimal?)null : Convert.ToDecimal(mMarketPrice.Text);
                    product.Description = rDescription.Text;
                    product.Status = ckStatus.Checked;
                    product.CategoryID = Convert.ToInt64(cbCategories.SelectedValue);

                    db.SaveChanges(); // Lưu các thay đổi vào csdl

                    // Lưu hình vào thư mục hình và tên tập tin hình vào csdl
                    if (!string.IsNullOrWhiteSpace(txtImageFile.Text))
                    {
                        string ext = txtImageFile.Text.Substring(txtImageFile.Text.LastIndexOf("."));
                        product.ImageFile = product.ProductID + ext;
                        pictureBox1.Image.Save(Utility.ImagePath + product.ProductID + ext);
                        db.SaveChanges(); // Lưu các thay đổi vào csdl
                    }
                }

                // Xóa trống và thiết lập lại các điều khiển
                txtName.Text = null;
                mQuantity.Text = null;
                mPrice.Text = null;
                mMarketPrice.Text = null;
                rDescription.Text = null;
                ckStatus.Checked = true;
                txtImageFile.Text = null;
                pictureBox1.ImageLocation = null;
                toolTip1.Show("Lưu thành công.", btSave, 0, 0, 1000);
            }
            catch (Exception ex)
            {
                toolTip1.Show("Lưu thất bại? Error: " + ex.Message, btSave, 0, 0, 1000);
            }
            txtName.Focus();

        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            {
                toolTip1.Show("Hãy nhập tên sản phẩm?", txtName, 0, 0, 1000);
                e.Cancel = true; //Phải nhập dữ liệu cho cột not null
            }
            else if (txtName.Text.Length > 200)
            {
                toolTip1.Show("Tên sản phẩm - tối đa 200 ký tự?", txtName, 0, 0,
               1000);
                e.Cancel = true;
            }
        }

        private void mQuantity_Validating(object sender, CancelEventArgs e)
        {

        }

        private void mQuantity_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {

            if (!e.IsValidInput) //Nếu nhập sai kiểu
            {
                toolTip1.Show("Dữ liệu sai kiểu số nguyên?", mQuantity, 0, 0, 1000);
                e.Cancel = true;
            }
            else if ((UInt64)e.ReturnValue < 0) //Nếu giá trị âm
            {
                toolTip1.Show("Số lượng phải >= 0?", mQuantity, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void mPrice_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                toolTip1.Show("Dữ liệu sai kiểu số thực?", mPrice, 0, 0, 1000);
                e.Cancel = true;
            }
            else if ((decimal)e.ReturnValue < 0)
            {
                toolTip1.Show("Giá phải >= 0?", mPrice, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void mMarketPrice_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void mMarketPrice_TypeValidationCompleted(object sender, TypeValidationEventArgs e)
        {
            if (!e.IsValidInput)
            {
                toolTip1.Show("Dữ liệu sai kiểu số thực?", mPrice, 0, 0, 1000);
                e.Cancel = true;
            }
            else if ((decimal)e.ReturnValue < 0)
            {
                toolTip1.Show("Giá phải >= 0?", mPrice, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void cbCategories_Validating(object sender, CancelEventArgs e)
        {
            if (cbCategories.FindStringExact(cbCategories.Text) < 0) //Nếu sai tênloại
            {
                toolTip1.Show("Nhập sai loại sản phẩm?", cbCategories, 0, 0, 1000);
                e.Cancel = true;
            }
        }

        private void txtImageFile_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtImageFile_Validating(object sender, CancelEventArgs e)
        {
            pictureBox1.Image = null;
            if (string.IsNullOrWhiteSpace(txtImageFile.Text))
                return; // Không cần nhập dữ liệu cho cột có thể null

            if (txtImageFile.Text.Length > 200)
            {
                toolTip1.Show("Tên tập tin - tối đa 200 ký tự?", txtImageFile, 0, 0, 1000);
                e.Cancel = true;
            }
            else if (!File.Exists(txtImageFile.Text))
            {
                toolTip1.Show("Tên tập tin sai hoặc Tập tin không tồn tại?", txtImageFile, 0, 0, 1000);
                e.Cancel = true;
            }
            else
            {
                pictureBox1.ImageLocation = txtImageFile.Text;
            }
        }

        private void rDescription_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(rDescription.Text))
            {
                toolTip1.Show("Hãy nhập miêu tả?", rDescription, 0, 0, 1000);
                e.Cancel = true; // Phải nhập dữ liệu cho cột not null
            }
            else if (rDescription.Text.Length > 200)
            {
                toolTip1.Show("Miêu tả - tối đa 200 ký tự?", rDescription, 0, 0, 1000);
                e.Cancel = true;
            }
        }
    }
}
