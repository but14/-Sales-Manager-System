namespace QLBH
{
    public partial class fMain : Form
    {
        public fMain()
        {
            InitializeComponent();
        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void manageCustomerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageCustomer"))
                return;
            fManageCustomer f = new fManageCustomer();

            f.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            fLogin f = new fLogin();
            if (f.ShowDialog() == DialogResult.OK)
            {
                Text = "Quản lý Bán hàng. Chào " + Utility.employee.Name;
                if (Utility.employee.RoleID != 1)
                {
                    foreach (ToolStripMenuItem t in menuStrip1.Items)
                    {
                        foreach (ToolStripItem c in t.DropDownItems)
                        {
                            if (t != reportToolStripMenuItem)
                            {
                                if (c.Name.Contains("new") && Utility.employee.RoleID == 2)
                                    break;
                                c.Enabled = false; // hoặc c.Visible = false;
                            }
                        }
                    }
                }
            }

        }

        private void manageProductToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageProduct"))
                return;
            fManageProduct f = new fManageProduct();
            f.MdiParent = this;
            f.Show();
        }

        private void manageOrderToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fManageOrder"))
                return;
            fManageOrder f = new fManageOrder();
            f.MdiParent = this;
            f.Show();
        }

        private void processOrderDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Utility.IsOpeningForm("fProcessOrderDetails"))
                return;
            fProcessOrderDetails f = new fProcessOrderDetails();
            f.MdiParent = this;
            f.Show();


        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
