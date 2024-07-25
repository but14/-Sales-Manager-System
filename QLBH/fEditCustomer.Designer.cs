namespace QLBH
{
    partial class fEditCustomer
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
            btnClose = new Button();
            btnSave = new Button();
            dateTimePicker1 = new DateTimePicker();
            ckStatus = new CheckBox();
            ckGender = new CheckBox();
            label5 = new Label();
            txtEmail = new TextBox();
            txtPhone = new TextBox();
            txtAddress = new TextBox();
            txtName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            toolTip1 = new ToolTip(components);
            SuspendLayout();
            // 
            // btnClose
            // 
            btnClose.Location = new Point(508, 303);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 21;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(386, 304);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 20;
            btnSave.Text = "Lưu";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CustomFormat = " dd/MM/yyyy";
            dateTimePicker1.Format = DateTimePickerFormat.Custom;
            dateTimePicker1.Location = new Point(199, 303);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(115, 27);
            dateTimePicker1.TabIndex = 19;
            // 
            // ckStatus
            // 
            ckStatus.AutoSize = true;
            ckStatus.CheckAlign = ContentAlignment.MiddleRight;
            ckStatus.Checked = true;
            ckStatus.CheckState = CheckState.Checked;
            ckStatus.Location = new Point(680, 118);
            ckStatus.Name = "ckStatus";
            ckStatus.Size = new Size(97, 24);
            ckStatus.TabIndex = 13;
            ckStatus.Text = "Trạng thái";
            ckStatus.UseVisualStyleBackColor = true;
            // 
            // ckGender
            // 
            ckGender.AutoSize = true;
            ckGender.CheckAlign = ContentAlignment.MiddleRight;
            ckGender.Checked = true;
            ckGender.CheckState = CheckState.Indeterminate;
            ckGender.Location = new Point(542, 119);
            ckGender.Name = "ckGender";
            ckGender.Size = new Size(87, 24);
            ckGender.TabIndex = 11;
            ckGender.Text = "Gioi tính";
            ckGender.TextAlign = ContentAlignment.MiddleRight;
            ckGender.ThreeState = true;
            ckGender.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(334, 240);
            label5.Name = "label5";
            label5.Size = new Size(46, 20);
            label5.TabIndex = 22;
            label5.Text = "Email";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(386, 237);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(391, 27);
            txtEmail.TabIndex = 18;
            txtEmail.Validating += txtEmail_Validating;
            // 
            // txtPhone
            // 
            txtPhone.Location = new Point(140, 237);
            txtPhone.Name = "txtPhone";
            txtPhone.Size = new Size(125, 27);
            txtPhone.TabIndex = 17;
            txtPhone.Validating += txtPhone_Validating;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(140, 169);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(637, 27);
            txtAddress.TabIndex = 15;
            txtAddress.Validating += txtAddress_Validating;
            // 
            // txtName
            // 
            txtName.Location = new Point(140, 117);
            txtName.Name = "txtName";
            txtName.Size = new Size(362, 27);
            txtName.TabIndex = 9;
            txtName.TextChanged += txtName_TextChanged;
            txtName.Validating += txtName_Validating;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 244);
            label4.Name = "label4";
            label4.Size = new Size(78, 20);
            label4.TabIndex = 16;
            label4.Text = "Điện thoại";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 307);
            label3.Name = "label3";
            label3.Size = new Size(153, 20);
            label3.TabIndex = 14;
            label3.Text = "Ngày/tháng/năm sinh";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 176);
            label2.Name = "label2";
            label2.Size = new Size(55, 20);
            label2.TabIndex = 12;
            label2.Text = "Địa chỉ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(23, 120);
            label1.Name = "label1";
            label1.Size = new Size(111, 20);
            label1.TabIndex = 10;
            label1.Text = "Tên khách hàng";
            // 
            // fEditCustomer
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1010, 450);
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
            Name = "fEditCustomer";
            Text = "Sửa khách hàng";
            WindowState = FormWindowState.Maximized;
            Activated += fEditCustomer_Activated;
            Load += fEditCustomer_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnClose;
        private Button btnSave;
        private DateTimePicker dateTimePicker1;
        private CheckBox ckStatus;
        private CheckBox ckGender;
        private Label label5;
        private TextBox txtEmail;
        private TextBox txtPhone;
        private TextBox txtAddress;
        private TextBox txtName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ToolTip toolTip1;
    }
}