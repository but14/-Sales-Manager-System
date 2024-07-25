namespace QLBH
{
    partial class fManageOrder
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbMonth = new ComboBox();
            cbYear = new ComboBox();
            btNew = new Button();
            btFind = new Button();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            OrderID = new DataGridViewTextBoxColumn();
            OrderDate = new DataGridViewTextBoxColumn();
            OrderTime = new DataGridViewTextBoxColumn();
            ReceiveDate = new DataGridViewTextBoxColumn();
            ReceiveTime = new DataGridViewTextBoxColumn();
            ReceiveAddress = new DataGridViewTextBoxColumn();
            ProgressID = new DataGridViewTextBoxColumn();
            CustomerID = new DataGridViewTextBoxColumn();
            EmployeeID = new DataGridViewTextBoxColumn();
            Edit = new DataGridViewButtonColumn();
            Delete = new DataGridViewButtonColumn();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // cbMonth
            // 
            cbMonth.FormattingEnabled = true;
            cbMonth.Items.AddRange(new object[] { "Tất cả", "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12" });
            cbMonth.Location = new Point(527, 71);
            cbMonth.Name = "cbMonth";
            cbMonth.Size = new Size(67, 28);
            cbMonth.TabIndex = 1;
            cbMonth.SelectedIndexChanged += cbMonth_SelectedIndexChanged;
            // 
            // cbYear
            // 
            cbYear.FormattingEnabled = true;
            cbYear.Location = new Point(377, 72);
            cbYear.Name = "cbYear";
            cbYear.Size = new Size(72, 28);
            cbYear.TabIndex = 0;
            cbYear.SelectedIndexChanged += cbYear_SelectedIndexChanged;
            // 
            // btNew
            // 
            btNew.Location = new Point(43, 65);
            btNew.Name = "btNew";
            btNew.Size = new Size(99, 35);
            btNew.TabIndex = 4;
            btNew.Text = "Nhập mới";
            btNew.UseVisualStyleBackColor = true;
            btNew.Click += btNew_Click;
            // 
            // btFind
            // 
            btFind.Location = new Point(898, 72);
            btFind.Name = "btFind";
            btFind.Size = new Size(70, 29);
            btFind.TabIndex = 3;
            btFind.Text = "Tìm";
            btFind.UseVisualStyleBackColor = true;
            btFind.Click += btFind_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(748, 72);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(125, 27);
            dateTimePicker1.TabIndex = 2;
            dateTimePicker1.Value = new DateTime(2024, 5, 21, 3, 13, 28, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { OrderID, OrderDate, OrderTime, ReceiveDate, ReceiveTime, ReceiveAddress, ProgressID, CustomerID, EmployeeID, Edit, Delete });
            dataGridView1.Location = new Point(43, 141);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(882, 188);
            dataGridView1.TabIndex = 5;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // OrderID
            // 
            OrderID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            OrderID.DataPropertyName = "OrderID";
            OrderID.HeaderText = "OrderID";
            OrderID.MinimumWidth = 6;
            OrderID.Name = "OrderID";
            OrderID.Width = 91;
            // 
            // OrderDate
            // 
            OrderDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            OrderDate.DataPropertyName = "OrderDate";
            OrderDate.HeaderText = "OrderDate";
            OrderDate.MinimumWidth = 6;
            OrderDate.Name = "OrderDate";
            OrderDate.Width = 108;
            // 
            // OrderTime
            // 
            OrderTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            OrderTime.DataPropertyName = "OrderTime";
            OrderTime.HeaderText = "OrderTime";
            OrderTime.MinimumWidth = 6;
            OrderTime.Name = "OrderTime";
            OrderTime.Width = 109;
            // 
            // ReceiveDate
            // 
            ReceiveDate.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ReceiveDate.DataPropertyName = "ReceiveDate";
            ReceiveDate.HeaderText = "ReceiveDate";
            ReceiveDate.MinimumWidth = 6;
            ReceiveDate.Name = "ReceiveDate";
            ReceiveDate.Width = 121;
            // 
            // ReceiveTime
            // 
            ReceiveTime.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ReceiveTime.DataPropertyName = "ReceiveTime";
            ReceiveTime.HeaderText = "ReceiveTime";
            ReceiveTime.MinimumWidth = 6;
            ReceiveTime.Name = "ReceiveTime";
            ReceiveTime.Width = 122;
            // 
            // ReceiveAddress
            // 
            ReceiveAddress.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ReceiveAddress.DataPropertyName = "ReceiveAddress";
            ReceiveAddress.HeaderText = "ReceiveAddress";
            ReceiveAddress.MinimumWidth = 6;
            ReceiveAddress.Name = "ReceiveAddress";
            ReceiveAddress.Width = 142;
            // 
            // ProgressID
            // 
            ProgressID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            ProgressID.DataPropertyName = "ProgressID";
            ProgressID.HeaderText = "ProgressID";
            ProgressID.MinimumWidth = 6;
            ProgressID.Name = "ProgressID";
            ProgressID.Width = 109;
            // 
            // CustomerID
            // 
            CustomerID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            CustomerID.DataPropertyName = "CustomerID";
            CustomerID.HeaderText = "CustomerID";
            CustomerID.MinimumWidth = 6;
            CustomerID.Name = "CustomerID";
            CustomerID.Width = 116;
            // 
            // EmployeeID
            // 
            EmployeeID.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            EmployeeID.DataPropertyName = "EmployeeID";
            EmployeeID.HeaderText = "EmployeeID";
            EmployeeID.MinimumWidth = 6;
            EmployeeID.Name = "EmployeeID";
            EmployeeID.Width = 119;
            // 
            // Edit
            // 
            Edit.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Edit.HeaderText = "Edit";
            Edit.MinimumWidth = 6;
            Edit.Name = "Edit";
            Edit.UseColumnTextForButtonValue = true;
            Edit.Width = 41;
            // 
            // Delete
            // 
            Delete.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            Delete.HeaderText = "Delete";
            Delete.MinimumWidth = 6;
            Delete.Name = "Delete";
            Delete.UseColumnTextForButtonValue = true;
            Delete.Width = 59;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(148, 75);
            label1.Name = "label1";
            label1.Size = new Size(128, 20);
            label1.TabIndex = 6;
            label1.Text = "Số lượng hóa đơn";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(330, 75);
            label2.Name = "label2";
            label2.Size = new Size(41, 20);
            label2.TabIndex = 7;
            label2.Text = "Năm";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(471, 75);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 8;
            label3.Text = "Tháng";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(621, 77);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 9;
            label4.Text = "Ngày đặt hàng";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.FromArgb(0, 192, 0);
            label5.Location = new Point(307, 19);
            label5.Name = "label5";
            label5.Size = new Size(246, 31);
            label5.TabIndex = 10;
            label5.Text = "QUẢN LÝ ĐƠN HÀNG";
            // 
            // fManageOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1040, 450);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(dateTimePicker1);
            Controls.Add(btFind);
            Controls.Add(btNew);
            Controls.Add(cbYear);
            Controls.Add(cbMonth);
            Name = "fManageOrder";
            Text = "Quản lý Đơn hàng";
            WindowState = FormWindowState.Maximized;
            Activated += fManageOrder_Activated;
            Load += fManageOrder_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbMonth;
        private ComboBox cbYear;
        private Button btNew;
        private Button btFind;
        private DateTimePicker dateTimePicker1;
        private DataGridView dataGridView1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridViewTextBoxColumn OrderID;
        private DataGridViewTextBoxColumn OrderDate;
        private DataGridViewTextBoxColumn OrderTime;
        private DataGridViewTextBoxColumn ReceiveDate;
        private DataGridViewTextBoxColumn ReceiveTime;
        private DataGridViewTextBoxColumn ReceiveAddress;
        private DataGridViewTextBoxColumn ProgressID;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn EmployeeID;
        private DataGridViewButtonColumn Edit;
        private DataGridViewButtonColumn Delete;
    }
}