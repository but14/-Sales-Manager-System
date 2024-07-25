namespace QLBH
{
    partial class fNewCustomer
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            txtName = new TextBox();
            txtAddress = new TextBox();
            txtPhone = new TextBox();
            txtEmail = new TextBox();
            label5 = new Label();
            ckGender = new CheckBox();
            ckStatus = new CheckBox();
            dateTimePicker1 = new DateTimePicker();
            btnSave = new Button();
            btnClose = new Button();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(63, 36);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 0;
            label1.Text = "Tên khách hàng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(63, 92);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 1;
            label2.Text = "Địa chỉ";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(68, 223);
            label3.Name = "label3";
            label3.Size = new Size(153, 20);
            label3.TabIndex = 2;
            label3.Text = "Ngày/tháng/năm sinh";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(63, 160);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 3;
            label4.Text = "Điện thoại";
            // 
            // txtName
            // 
            txtName.Location = new Point(180, 33);
            txtName.Name = "txtName";
            txtName.Size = new Size(362, 27);
            txtName.TabIndex = 0;
            txtName.Validating += txtName_Validating;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(180, 85);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(637, 27);
            txtAddress.TabIndex = 3;
            txtAddress.TextChanged += textBox2_TextChanged;
            txtAddress.Validating += txtAddress_Validating;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(180, 153);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 4;
            txtPhone.Validating += txtPhone_Validating;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(426, 153);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(391, 27);
            txtEmail.TabIndex = 5;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(374, 156);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 8;
            label5.Text = "Email";
            // 
            // ckGender
            // 
            ckGender.AutoSize = true;
            ckGender.CheckAlign = ContentAlignment.MiddleRight;
            ckGender.Checked = true;
            ckGender.CheckState = CheckState.Indeterminate;
            ckGender.Location = new Point(582, 35);
            ckGender.Name = "ckGender";
            ckGender.Size = new Size(87, 24);
            ckGender.TabIndex = 1;
            ckGender.Text = "Gioi tính";
            ckGender.TextAlign = ContentAlignment.MiddleRight;
            ckGender.ThreeState = true;
            ckGender.UseVisualStyleBackColor = true;
            ckGender.CheckedChanged += ckGender_CheckedChanged;
            // 
            // ckStatus
            // 
            ckStatus.AutoSize = true;
            ckStatus.CheckAlign = ContentAlignment.MiddleRight;
            ckStatus.Checked = true;
            ckStatus.CheckState = CheckState.Checked;
            ckStatus.Location = new Point(720, 34);
            ckStatus.Name = "ckStatus";
            ckStatus.Size = new Size(97, 24);
            ckStatus.TabIndex = 2;
            ckStatus.Text = "Trạng thái";
            ckStatus.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = " dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(239, 219);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(115, 27);
            dateTimePicker1.TabIndex = 6;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            dateTimePicker1.Validating += dateTimePicker1_Validating;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(426, 220);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 7;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnClose
            // 
            btnClose.CausesValidation = false;
            btnClose.Location = new Point(548, 219);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 8;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // fNewCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(841, 304);
            ControlBox = false;
            Controls.Add(btnClose);
            Controls.Add(btnSave);
            Controls.Add(dateTimePicker1);
            Controls.Add(ckStatus);
            Controls.Add(ckGender);
            Controls.Add(label5);
            Controls.Add(txtEmail);
            Controls.Add(txtPhone);
            Controls.Add(txtAddress);
            Controls.Add(txtName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fNewCustomer";
            Text = "Nhập thêm khách hàng mới";
            WindowState = FormWindowState.Maximized;
            Activated += fNewCustomer_Activated;
            FormClosing += fNewCustomer_FormClosing;
            Load += fNewCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox txtName;
        private TextBox txtAddress;
        private TextBox txtPhone;
        private TextBox txtEmail;
        private Label label5;
        private CheckBox ckGender;
        private CheckBox ckStatus;
        private DateTimePicker dateTimePicker1;
        private Button btnSave;
        private Button btnClose;
        private ToolTip toolTip1;
    }
}