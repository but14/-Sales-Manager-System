namespace QLBH
{
    partial class fEditProduct
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
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtName = new TextBox();
            txtImageFile = new TextBox();
            rDescription = new RichTextBox();
            mQuantity = new MaskedTextBox();
            mPrice = new MaskedTextBox();
            mMarketPrice = new MaskedTextBox();
            ckStatus = new CheckBox();
            cbCategories = new ComboBox();
            btSave = new Button();
            btnClose = new Button();
            openFileDialog1 = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            pictureBox1 = new PictureBox();
            btBrowse = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 21);
            label1.Name = "label1";
            label1.Size = new Size(100, 20);
            label1.TabIndex = 1;
            label1.Text = "Tên sản phẩm";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 2;
            label2.Text = "Số lượng";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 151);
            label3.Name = "label3";
            label3.Size = new Size(85, 20);
            label3.TabIndex = 3;
            label3.Text = "Mô tả ngắn";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(344, 88);
            label4.Name = "label4";
            label4.Size = new Size(60, 20);
            label4.TabIndex = 4;
            label4.Text = "Giá bán";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(423, 154);
            label5.Name = "label5";
            label5.Size = new Size(87, 20);
            label5.TabIndex = 5;
            label5.Text = "Tập tin hình";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(626, 81);
            label6.Name = "label6";
            label6.Size = new Size(101, 20);
            label6.TabIndex = 6;
            label6.Text = "Gía thị trường";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(681, 27);
            label7.Name = "label7";
            label7.Size = new Size(37, 20);
            label7.TabIndex = 7;
            label7.Text = "Loại";
            // 
            // txtName
            // 
            txtName.Location = new Point(127, 21);
            txtName.Name = "txtName";
            txtName.Size = new Size(479, 27);
            txtName.TabIndex = 0;
            txtName.TextChanged += txtName_TextChanged;
            txtName.Validating += txtName_Validating;
            // 
            // txtImageFile
            // 
            txtImageFile.Location = new Point(529, 151);
            txtImageFile.Name = "txtImageFile";
            txtImageFile.Size = new Size(97, 27);
            txtImageFile.TabIndex = 7;
            txtImageFile.TextChanged += txtImageFile_TextChanged;
            txtImageFile.Validating += txtImageFile_Validating;
            // 
            // rDescription
            // 
            rDescription.Location = new Point(127, 151);
            rDescription.Name = "rDescription";
            rDescription.Size = new Size(290, 160);
            rDescription.TabIndex = 6;
            rDescription.Text = "";
            rDescription.Validating += rDescription_Validating;
            // 
            // mQuantity
            // 
            mQuantity.Location = new Point(127, 82);
            mQuantity.Name = "mQuantity";
            mQuantity.Size = new Size(132, 27);
            mQuantity.TabIndex = 3;
            mQuantity.TypeValidationCompleted += mQuantity_TypeValidationCompleted;
            mQuantity.Validating += mQuantity_Validating;
            // 
            // mPrice
            // 
            mPrice.Location = new Point(433, 82);
            mPrice.Name = "mPrice";
            mPrice.Size = new Size(125, 27);
            mPrice.TabIndex = 4;
            mPrice.TypeValidationCompleted += mPrice_TypeValidationCompleted;
            // 
            // mMarketPrice
            // 
            mMarketPrice.Location = new Point(769, 78);
            mMarketPrice.Name = "mMarketPrice";
            mMarketPrice.Size = new Size(125, 27);
            mMarketPrice.TabIndex = 5;
            mMarketPrice.MaskInputRejected += mMarketPrice_MaskInputRejected;
            mMarketPrice.TypeValidationCompleted += mMarketPrice_TypeValidationCompleted;
            // 
            // ckStatus
            // 
            ckStatus.AutoSize = true;
            ckStatus.CheckAlign = ContentAlignment.MiddleRight;
            ckStatus.Checked = true;
            ckStatus.CheckState = CheckState.Checked;
            ckStatus.ImageAlign = ContentAlignment.BottomCenter;
            ckStatus.Location = new Point(901, 23);
            ckStatus.Name = "ckStatus";
            ckStatus.Size = new Size(97, 24);
            ckStatus.TabIndex = 2;
            ckStatus.Text = "Trạng thái";
            ckStatus.TextAlign = ContentAlignment.MiddleRight;
            ckStatus.UseVisualStyleBackColor = true;
            // 
            // cbCategories
            // 
            cbCategories.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbCategories.FormattingEnabled = true;
            cbCategories.Location = new Point(743, 21);
            cbCategories.Name = "cbCategories";
            cbCategories.Size = new Size(151, 28);
            cbCategories.TabIndex = 1;
            cbCategories.Validating += cbCategories_Validating;
            // 
            // btSave
            // 
            btSave.Location = new Point(904, 154);
            btSave.Name = "btSave";
            btSave.Size = new Size(94, 29);
            btSave.TabIndex = 9;
            btSave.Text = "Lưu";
            btSave.UseVisualStyleBackColor = true;
            btSave.Click += btSave_Click;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(901, 200);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(94, 29);
            btnClose.TabIndex = 10;
            btnClose.Text = "Đóng";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(769, 154);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 157);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // btBrowse
            // 
            btBrowse.CausesValidation = false;
            btBrowse.Location = new Point(633, 151);
            btBrowse.Name = "btBrowse";
            btBrowse.Size = new Size(57, 29);
            btBrowse.TabIndex = 8;
            btBrowse.Text = ".....";
            btBrowse.UseVisualStyleBackColor = true;
            btBrowse.Click += btBrowse_Click;
            // 
            // fEditProduct
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            CausesValidation = false;
            ClientSize = new Size(1010, 450);
            ControlBox = false;
            Controls.Add(btBrowse);
            Controls.Add(pictureBox1);
            Controls.Add(btnClose);
            Controls.Add(btSave);
            Controls.Add(cbCategories);
            Controls.Add(ckStatus);
            Controls.Add(mMarketPrice);
            Controls.Add(mPrice);
            Controls.Add(mQuantity);
            Controls.Add(rDescription);
            Controls.Add(txtImageFile);
            Controls.Add(txtName);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "fEditProduct";
            Text = "Nhập thêm mới sản phẩm";
            WindowState = FormWindowState.Maximized;
            FormClosing += fEditProduct_FormClosing;
            Load += fEditProduct_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtName;
        private TextBox txtImageFile;
        private RichTextBox rDescription;
        private MaskedTextBox mQuantity;
        private MaskedTextBox mPrice;
        private MaskedTextBox mMarketPrice;
        private CheckBox ckStatus;
        private ComboBox cbCategories;
        private Button btSave;
        private Button btnClose;
        private OpenFileDialog openFileDialog1;
        private ToolTip toolTip1;
        private PictureBox pictureBox1;
        private Button btBrowse;
    }

        
    
}