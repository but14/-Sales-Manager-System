namespace QLBH
{
    partial class fMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip1 = new MenuStrip();
            categoryToolStripMenuItem = new ToolStripMenuItem();
            mangeToolStripMenuItem = new ToolStripMenuItem();
            newToolStripMenuItem = new ToolStripMenuItem();
            productToolStripMenuItem = new ToolStripMenuItem();
            manageProductToolStripMenuItem = new ToolStripMenuItem();
            newProductToolStripMenuItem = new ToolStripMenuItem();
            customerToolStripMenuItem = new ToolStripMenuItem();
            manageCustomerToolStripMenuItem = new ToolStripMenuItem();
            newCustomerToolStripMenuItem = new ToolStripMenuItem();
            orderToolStripMenuItem = new ToolStripMenuItem();
            manageOrderToolStripMenuItem = new ToolStripMenuItem();
            newOrderToolStripMenuItem = new ToolStripMenuItem();
            processOrderDetailsToolStripMenuItem = new ToolStripMenuItem();
            reportToolStripMenuItem = new ToolStripMenuItem(); // Khai báo reportToolStripMenuItem
            cbOrders = new ComboBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { categoryToolStripMenuItem, productToolStripMenuItem, customerToolStripMenuItem, orderToolStripMenuItem, reportToolStripMenuItem }); // Thêm reportToolStripMenuItem vào MenuStrip
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            menuStrip1.ItemClicked += menuStrip1_ItemClicked;
            // 
            // categoryToolStripMenuItem
            // 
            categoryToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mangeToolStripMenuItem, newToolStripMenuItem });
            categoryToolStripMenuItem.Name = "categoryToolStripMenuItem";
            categoryToolStripMenuItem.Size = new Size(83, 24);
            categoryToolStripMenuItem.Text = "Category";
            // 
            // mangeToolStripMenuItem
            // 
            mangeToolStripMenuItem.Name = "mangeToolStripMenuItem";
            mangeToolStripMenuItem.Size = new Size(198, 26);
            mangeToolStripMenuItem.Text = "MangeCategory";
            // 
            // newToolStripMenuItem
            // 
            newToolStripMenuItem.Name = "newToolStripMenuItem";
            newToolStripMenuItem.Size = new Size(198, 26);
            newToolStripMenuItem.Text = "NewCategory";
            newToolStripMenuItem.Click += newToolStripMenuItem_Click;
            // 
            // productToolStripMenuItem
            // 
            productToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageProductToolStripMenuItem, newProductToolStripMenuItem });
            productToolStripMenuItem.Name = "productToolStripMenuItem";
            productToolStripMenuItem.Size = new Size(74, 24);
            productToolStripMenuItem.Text = "Product";
            // 
            // manageProductToolStripMenuItem
            // 
            manageProductToolStripMenuItem.Name = "manageProductToolStripMenuItem";
            manageProductToolStripMenuItem.Size = new Size(197, 26);
            manageProductToolStripMenuItem.Text = "ManageProduct";
            manageProductToolStripMenuItem.Click += manageProductToolStripMenuItem_Click;
            // 
            // newProductToolStripMenuItem
            // 
            newProductToolStripMenuItem.Name = "newProductToolStripMenuItem";
            newProductToolStripMenuItem.Size = new Size(197, 26);
            newProductToolStripMenuItem.Text = "NewProduct";
            // 
            // customerToolStripMenuItem
            // 
            customerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageCustomerToolStripMenuItem, newCustomerToolStripMenuItem });
            customerToolStripMenuItem.Name = "customerToolStripMenuItem";
            customerToolStripMenuItem.Size = new Size(86, 24);
            customerToolStripMenuItem.Text = "Customer";
            // 
            // manageCustomerToolStripMenuItem
            // 
            manageCustomerToolStripMenuItem.Name = "manageCustomerToolStripMenuItem";
            manageCustomerToolStripMenuItem.Size = new Size(209, 26);
            manageCustomerToolStripMenuItem.Text = "ManageCustomer";
            manageCustomerToolStripMenuItem.Click += manageCustomerToolStripMenuItem_Click;
            // 
            // newCustomerToolStripMenuItem
            // 
            newCustomerToolStripMenuItem.Name = "newCustomerToolStripMenuItem";
            newCustomerToolStripMenuItem.Size = new Size(209, 26);
            newCustomerToolStripMenuItem.Text = "NewCustomer";
            // 
            // orderToolStripMenuItem
            // 
            orderToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { manageOrderToolStripMenuItem, newOrderToolStripMenuItem, processOrderDetailsToolStripMenuItem });
            orderToolStripMenuItem.Name = "orderToolStripMenuItem";
            orderToolStripMenuItem.Size = new Size(61, 24);
            orderToolStripMenuItem.Text = "Order";
            // 
            // manageOrderToolStripMenuItem
            // 
            manageOrderToolStripMenuItem.Name = "manageOrderToolStripMenuItem";
            manageOrderToolStripMenuItem.Size = new Size(225, 26);
            manageOrderToolStripMenuItem.Text = "ManageOrder";
            manageOrderToolStripMenuItem.Click += manageOrderToolStripMenuItem_Click;
            // 
            // newOrderToolStripMenuItem
            // 
            newOrderToolStripMenuItem.Name = "newOrderToolStripMenuItem";
            newOrderToolStripMenuItem.Size = new Size(225, 26);
            newOrderToolStripMenuItem.Text = "NewOrder";
            // 
            // processOrderDetailsToolStripMenuItem
            // 
            processOrderDetailsToolStripMenuItem.Name = "processOrderDetailsToolStripMenuItem";
            processOrderDetailsToolStripMenuItem.Size = new Size(225, 26);
            processOrderDetailsToolStripMenuItem.Text = "ProcessOrderDetails";
            processOrderDetailsToolStripMenuItem.Click += processOrderDetailsToolStripMenuItem_Click;
            // 
            // reportToolStripMenuItem
            // 
            reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            reportToolStripMenuItem.Size = new Size(66, 24);
            reportToolStripMenuItem.Text = "Report";
            // 
            // cbOrders
            // 
            cbOrders.FormattingEnabled = true;
            cbOrders.Location = new Point(649, 410);
            cbOrders.Name = "cbOrders";
            cbOrders.Size = new Size(151, 28);
            cbOrders.TabIndex = 2;
            // 
            // fMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cbOrders);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "fMain";
            Text = "Quản lý bán hàng";
            Load += Form1_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem categoryToolStripMenuItem;
        private ToolStripMenuItem mangeToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem productToolStripMenuItem;
        private ToolStripMenuItem manageProductToolStripMenuItem;
        private ToolStripMenuItem newProductToolStripMenuItem;
        private ToolStripMenuItem customerToolStripMenuItem;
        private ToolStripMenuItem manageCustomerToolStripMenuItem;
        private ToolStripMenuItem newCustomerToolStripMenuItem;
        private ToolStripMenuItem orderToolStripMenuItem;
        private ToolStripMenuItem manageOrderToolStripMenuItem;
        private ToolStripMenuItem newOrderToolStripMenuItem;
        private ToolStripMenuItem processOrderDetailsToolStripMenuItem;
        private ToolStripMenuItem reportToolStripMenuItem; // Khai báo reportToolStripMenuItem
        private ComboBox cbOrders;
    }
}
