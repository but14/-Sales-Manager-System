namespace QLBH
{
    partial class fProcessOrderDetails
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            cbCustomers = new ComboBox();
            txtReceiveAddress = new TextBox();
            cbProgresses = new ComboBox();
            cbOrders = new ComboBox();
            dtOrderDate = new DateTimePicker();
            dtReceiveDate = new DateTimePicker();
            mOrderTime = new MaskedTextBox();
            mReceiveTime = new MaskedTextBox();
            cbProducts = new ComboBox();
            mQuantity = new MaskedTextBox();
            mPrice = new MaskedTextBox();
            btAddOrderDetail = new Button();
            btCancel = new Button();
            dataGridView1 = new DataGridView();
            Delete = new DataGridViewButtonColumn();
            btSave = new Button();
            btClose = new Button();
            toolTip1 = new ToolTip(components);
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // cbCustomers
            // 
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(20, 35);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(200, 28);
            cbCustomers.TabIndex = 0;
            // 
            // txtReceiveAddress
            // 
            txtReceiveAddress.Location = new Point(240, 35);
            txtReceiveAddress.Name = "txtReceiveAddress";
            txtReceiveAddress.Size = new Size(400, 27);
            txtReceiveAddress.TabIndex = 1;
            // 
            // cbProgresses
            // 
            cbProgresses.FormattingEnabled = true;
            cbProgresses.Location = new Point(20, 95);
            cbProgresses.Name = "cbProgresses";
            cbProgresses.Size = new Size(200, 28);
            cbProgresses.TabIndex = 2;
            // 
            // cbOrders
            // 
            cbOrders.FormattingEnabled = true;
            cbOrders.Location = new Point(240, 95);
            cbOrders.Name = "cbOrders";
            cbOrders.Size = new Size(200, 28);
            cbOrders.TabIndex = 3;
            cbOrders.SelectionChangeCommitted += cbOrders_SelectionChangeCommitted;
            // 
            // dtOrderDate
            // 
            dtOrderDate.Location = new Point(10, 30);
            dtOrderDate.Name = "dtOrderDate";
            dtOrderDate.Size = new Size(150, 27);
            dtOrderDate.TabIndex = 4;
            // 
            // dtReceiveDate
            // 
            dtReceiveDate.Location = new Point(10, 30);
            dtReceiveDate.Name = "dtReceiveDate";
            dtReceiveDate.Size = new Size(150, 27);
            dtReceiveDate.TabIndex = 5;
            // 
            // mOrderTime
            // 
            mOrderTime.Location = new Point(10, 70);
            mOrderTime.Mask = "00:00";
            mOrderTime.Name = "mOrderTime";
            mOrderTime.Size = new Size(150, 27);
            mOrderTime.TabIndex = 6;
            mOrderTime.ValidatingType = typeof(DateTime);
            // 
            // mReceiveTime
            // 
            mReceiveTime.Location = new Point(10, 70);
            mReceiveTime.Mask = "00:00";
            mReceiveTime.Name = "mReceiveTime";
            mReceiveTime.Size = new Size(150, 27);
            mReceiveTime.TabIndex = 7;
            mReceiveTime.ValidatingType = typeof(DateTime);
            // 
            // cbProducts
            // 
            cbProducts.FormattingEnabled = true;
            cbProducts.Location = new Point(20, 155);
            cbProducts.Name = "cbProducts";
            cbProducts.Size = new Size(200, 28);
            cbProducts.TabIndex = 8;
            cbProducts.SelectedIndexChanged += cbProducts_SelectedIndexChanged;
            // 
            // mQuantity
            // 
            mQuantity.Location = new Point(240, 155);
            mQuantity.Name = "mQuantity";
            mQuantity.Size = new Size(100, 27);
            mQuantity.TabIndex = 9;
            // 
            // mPrice
            // 
            mPrice.Enabled = false;
            mPrice.Location = new Point(360, 155);
            mPrice.Name = "mPrice";
            mPrice.Size = new Size(100, 27);
            mPrice.TabIndex = 10;
            // 
            // btAddOrderDetail
            // 
            btAddOrderDetail.Location = new Point(480, 155);
            btAddOrderDetail.Name = "btAddOrderDetail";
            btAddOrderDetail.Size = new Size(75, 23);
            btAddOrderDetail.TabIndex = 11;
            btAddOrderDetail.Text = "Thêm";
            btAddOrderDetail.UseVisualStyleBackColor = true;
            btAddOrderDetail.Click += btAddOrderDetail_Click;
            // 
            // btCancel
            // 
            btCancel.Location = new Point(570, 155);
            btCancel.Name = "btCancel";
            btCancel.Size = new Size(75, 23);
            btCancel.TabIndex = 12;
            btCancel.Text = "Hủy";
            btCancel.UseVisualStyleBackColor = true;
            btCancel.Click += btCancel_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Delete });
            dataGridView1.Location = new Point(20, 190);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 24;
            dataGridView1.Size = new Size(750, 300);
            dataGridView1.TabIndex = 13;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.CellValidating += dataGridView1_CellValidating;
            // 
            // Delete
            // 
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.Text = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 125;
            // 
            // btSave
            // 
            btSave.Location = new Point(660, 500);
            btSave.Name = "btSave";
            btSave.Size = new Size(75, 23);
            btSave.TabIndex = 14;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btClose
            // 
            btClose.Location = new Point(750, 500);
            btClose.Name = "btClose";
            btClose.Size = new Size(75, 23);
            btClose.TabIndex = 15;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 15);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 16;
            label1.Text = "Khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(240, 15);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 17;
            label2.Text = "Địa chỉ giao hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 75);
            label3.Name = "label3";
            label3.Size = new Size(71, 20);
            label3.TabIndex = 18;
            label3.Text = "Tiến trình";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(240, 75);
            label4.Name = "label4";
            label4.Size = new Size(110, 20);
            label4.TabIndex = 19;
            label4.Text = "Chọn đơn hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(20, 135);
            label5.Name = "label5";
            label5.Size = new Size(111, 20);
            label5.TabIndex = 22;
            label5.Text = "Chọn sản phẩm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(240, 135);
            label6.Name = "label6";
            label6.Size = new Size(69, 20);
            label6.TabIndex = 23;
            label6.Text = "Số lượng";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(360, 135);
            label7.Name = "label7";
            label7.Size = new Size(62, 20);
            label7.TabIndex = 24;
            label7.Text = "Đơn giá";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(dtOrderDate);
            groupBox1.Controls.Add(mOrderTime);
            groupBox1.Location = new Point(460, 60);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(170, 100);
            groupBox1.TabIndex = 20;
            groupBox1.TabStop = false;
            groupBox1.Text = "ĐẶT HÀNG";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(dtReceiveDate);
            groupBox2.Controls.Add(mReceiveTime);
            groupBox2.Location = new Point(640, 60);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(170, 100);
            groupBox2.TabIndex = 21;
            groupBox2.TabStop = false;
            groupBox2.Text = "GIAO HÀNG";
            // 
            // fProcessOrderDetails
            // 
            ClientSize = new Size(982, 540);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(dataGridView1);
            Controls.Add(btCancel);
            Controls.Add(btAddOrderDetail);
            Controls.Add(mPrice);
            Controls.Add(mQuantity);
            Controls.Add(cbProducts);
            Controls.Add(cbOrders);
            Controls.Add(cbProgresses);
            Controls.Add(txtReceiveAddress);
            Controls.Add(cbCustomers);
            Name = "fProcessOrderDetails";
            Text = "Xử lý chi tiết đơn hàng";
            Load += fProcessOrderDetails_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.ComboBox cbCustomers;
        private System.Windows.Forms.TextBox txtReceiveAddress;
        private System.Windows.Forms.ComboBox cbProgresses;
        private System.Windows.Forms.ComboBox cbOrders;
        private System.Windows.Forms.DateTimePicker dtOrderDate;
        private System.Windows.Forms.DateTimePicker dtReceiveDate;
        private System.Windows.Forms.MaskedTextBox mOrderTime;
        private System.Windows.Forms.MaskedTextBox mReceiveTime;
        private System.Windows.Forms.ComboBox cbProducts;
        private System.Windows.Forms.MaskedTextBox mQuantity;
        private System.Windows.Forms.MaskedTextBox mPrice;
        private System.Windows.Forms.Button btAddOrderDetail;
        private System.Windows.Forms.Button btCancel;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Button btSave;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}
