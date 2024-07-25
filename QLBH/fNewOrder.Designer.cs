namespace QLBH
{
    partial class fNewOrder
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
            components = new System.ComponentModel.Container();
            txtReceiveAddress = new TextBox();
            mOrderTime = new MaskedTextBox();
            mReceiveTime = new MaskedTextBox();
            dtOrderDate = new DateTimePicker();
            dtReceiveDate = new DateTimePicker();
            cbCustomers = new ComboBox();
            cbProgresses = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            btSave = new Button();
            btClose = new Button();
            toolTip1 = new ToolTip(components);
            cbCustomDateTime = new CheckBox();
            cbEmployees = new ComboBox();
            SuspendLayout();
            // 
            // txtReceiveAddress
            // 
            txtReceiveAddress.Location = new Point(348, 59);
            txtReceiveAddress.Name = "txtReceiveAddress";
            txtReceiveAddress.Size = new Size(611, 27);
            txtReceiveAddress.TabIndex = 1;
            txtReceiveAddress.TextChanged += txtReceiveAddress_TextChanged;
            txtReceiveAddress.Validating += txtReceiveAddress_Validating;
            // 
            // mOrderTime
            // 
            mOrderTime.Location = new Point(469, 187);
            mOrderTime.Mask = "00:00:00";
            mOrderTime.Name = "mOrderTime";
            mOrderTime.Size = new Size(125, 27);
            mOrderTime.TabIndex = 5;
            mOrderTime.TypeValidationCompleted += mOrderTime_TypeValidationCompleted;
            // 
            // mReceiveTime
            // 
            mReceiveTime.Location = new Point(169, 185);
            mReceiveTime.Mask = "00:00:00 ";
            mReceiveTime.Name = "mReceiveTime";
            mReceiveTime.Size = new Size(125, 27);
            mReceiveTime.TabIndex = 3;
            mReceiveTime.TypeValidationCompleted += mReceiveTime_TypeValidationCompleted;
            // 
            // dtOrderDate
            // 
            dtOrderDate.CustomFormat = "dd/MM/yyyy";
            dtOrderDate.Format = DateTimePickerFormat.Short;
            dtOrderDate.Location = new Point(315, 185);
            dtOrderDate.Name = "dtOrderDate";
            dtOrderDate.Size = new Size(119, 27);
            dtOrderDate.TabIndex = 4;
            // 
            // dtReceiveDate
            // 
            dtReceiveDate.Format = DateTimePickerFormat.Short;
            dtReceiveDate.Location = new Point(23, 185);
            dtReceiveDate.Name = "dtReceiveDate";
            dtReceiveDate.Size = new Size(123, 27);
            dtReceiveDate.TabIndex = 2;
            // 
            // cbCustomers
            // 
            cbCustomers.FormattingEnabled = true;
            cbCustomers.Location = new Point(12, 59);
            cbCustomers.Name = "cbCustomers";
            cbCustomers.Size = new Size(320, 28);
            cbCustomers.TabIndex = 0;
            cbCustomers.SelectedIndexChanged += cbCustomers_SelectedIndexChanged;
            cbCustomers.Validating += cbCustomers_Validating;
            // 
            // cbProgresses
            // 
            cbProgresses.Enabled = false;
            cbProgresses.FormattingEnabled = true;
            cbProgresses.Location = new Point(635, 187);
            cbProgresses.Name = "cbProgresses";
            cbProgresses.Size = new Size(151, 28);
            cbProgresses.TabIndex = 6;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 36);
            label1.Name = "label1";
            label1.Size = new Size(86, 20);
            label1.TabIndex = 7;
            label1.Text = "Khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(337, 36);
            label2.Name = "label2";
            label2.Size = new Size(126, 20);
            label2.TabIndex = 8;
            label2.Text = "Địa chỉ giao hàng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(116, 138);
            label3.Name = "label3";
            label3.Size = new Size(90, 20);
            label3.TabIndex = 9;
            label3.Text = "GIAO HÀNG";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(400, 138);
            label4.Name = "label4";
            label4.Size = new Size(84, 20);
            label4.TabIndex = 10;
            label4.Text = "ĐẶT HÀNG";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(23, 158);
            label5.Name = "label5";
            label5.Size = new Size(123, 20);
            label5.TabIndex = 11;
            label5.Text = "Ngày/tháng/năm";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(169, 158);
            label6.Name = "label6";
            label6.Size = new Size(102, 20);
            label6.TabIndex = 12;
            label6.Text = "Giờ/phút/giây";
            label6.Click += label6_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(315, 158);
            label7.Name = "label7";
            label7.Size = new Size(123, 20);
            label7.TabIndex = 13;
            label7.Text = "Ngày/tháng/năm";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(469, 158);
            label8.Name = "label8";
            label8.Size = new Size(102, 20);
            label8.TabIndex = 14;
            label8.Text = "Giờ/phút/giây";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(635, 158);
            label9.Name = "label9";
            label9.Size = new Size(71, 20);
            label9.TabIndex = 15;
            label9.Text = "Tiến trình";
            // 
            // btSave
            // 
            btSave.Location = new Point(792, 187);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 6;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btClose
            // 
            btClose.Location = new Point(892, 187);
            btClose.Name = "btClose";
            btClose.Size = new Size(94, 29);
            btClose.TabIndex = 7;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // cbCustomDateTime
            // 
            cbCustomDateTime.AutoSize = true;
            cbCustomDateTime.Location = new Point(315, 231);
            cbCustomDateTime.Name = "cbCustomDateTime";
            cbCustomDateTime.Size = new Size(210, 24);
            cbCustomDateTime.TabIndex = 16;
            cbCustomDateTime.Text = "Tự nhập ngày giờ đặt hàng";
            cbCustomDateTime.UseVisualStyleBackColor = true;
            // 
            // cbEmployees
            // 
            cbEmployees.FormattingEnabled = true;
            cbEmployees.Location = new Point(561, 266);
            cbEmployees.Name = "cbEmployees";
            cbEmployees.Size = new Size(151, 28);
            cbEmployees.TabIndex = 17;
            // 
            // fNewOrder
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(989, 450);
            ControlBox = false;
            Controls.Add(cbEmployees);
            Controls.Add(cbCustomDateTime);
            Controls.Add(btClose);
            Controls.Add(btSave);
            Controls.Add(label9);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbProgresses);
            Controls.Add(cbCustomers);
            Controls.Add(dtReceiveDate);
            Controls.Add(dtOrderDate);
            Controls.Add(mReceiveTime);
            Controls.Add(mOrderTime);
            Controls.Add(txtReceiveAddress);
            Name = "fNewOrder";
            Text = "Nhập thêm đơn hàng mới";
            WindowState = FormWindowState.Maximized;
            Load += fNewOrder_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtReceiveAddress;
        private MaskedTextBox mOrderTime;
        private MaskedTextBox mReceiveTime;
        private DateTimePicker dtOrderDate;
        private DateTimePicker dtReceiveDate;
        private ComboBox cbCustomers;
        private ComboBox cbProgresses;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Button btSave;
        private Button btClose;
        private ToolTip toolTip1;
        private CheckBox cbCustomDateTime;
        private ComboBox cbEmployees;
    }
}