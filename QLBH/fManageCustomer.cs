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
    public partial class fManageCustomer : Form
    {
        public fManageCustomer()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void fManageCustomer_Activated(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            using (var db = new EFDbContext())
            {
                dataGridView1.DataSource = db.Customers.ToList();
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Delete")
            {
                try
                {
                    long CustomerID = Convert.ToInt64(dataGridView1
                    .Rows[e.RowIndex].Cells["CustomerID"].Value);
                    using (var db = new EFDbContext())
                    {
                        Customer customer = db.Customers.Single(c => c.CustomerID == CustomerID);
                        if (MessageBox.Show("Bạn muốn xóa khách hàng " + customer.Name, "Xóa", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                        {
                            db.Customers.Remove(customer);
                            db.SaveChanges();
                            fManageCustomer_Activated(sender, e);
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
                if (Utility.IsOpeningForm("fEditCustomer"))
                    return;

                fEditCustomer f = new fEditCustomer(Convert.ToInt64(dataGridView1.Rows[e.RowIndex].Cells["CustomerID"].Value));
                f.MdiParent = this.MdiParent;
                f.Show();

            }

        }

        private void fManageCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btFind_Click(object sender, EventArgs e)
        {
            using (var db = new EFDbContext())
            {
                dataGridView1.DataSource =
                db.Customers
                .Where(c => c.Name.Contains(txtName.Text)).ToList();
            }
        }

        private void btNew_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fNewCustomer"))
                return;
            fNewCustomer f = new fNewCustomer();
            f.MdiParent = this.MdiParent;
            f.Show();
        }

        private void fManageCustomer_Click(object sender, EventArgs e)
        {

        }

    
    }
}
