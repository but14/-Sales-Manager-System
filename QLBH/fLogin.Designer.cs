namespace QLBH
{
    partial class fLogin
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
            lblMessage = new Label();
            txtUser = new TextBox();
            txtPassword = new TextBox();
            btLogin = new Button();
            btClose = new Button();
            liForget = new LinkLabel();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Location = new Point(16, 14);
            lblMessage.Margin = new Padding(4, 0, 4, 0);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(76, 20);
            lblMessage.TabIndex = 0;
            lblMessage.Text = "Chào bạn!";
            // 
            // txtUser
            // 
            txtUser.Location = new Point(107, 62);
            txtUser.Margin = new Padding(4, 5, 4, 5);
            txtUser.Name = "txtUser";
            txtUser.Size = new Size(239, 27);
            txtUser.TabIndex = 1;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(107, 123);
            txtPassword.Margin = new Padding(4, 5, 4, 5);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(239, 27);
            txtPassword.TabIndex = 2;
            // 
            // btLogin
            // 
            btLogin.Location = new Point(107, 185);
            btLogin.Margin = new Padding(4, 5, 4, 5);
            btLogin.Name = "btLogin";
            btLogin.Size = new Size(100, 35);
            btLogin.TabIndex = 3;
            btLogin.Text = "Đăng nhập";
            btLogin.UseVisualStyleBackColor = true;
            btLogin.Click += btLogin_Click;
            // 
            // btClose
            // 
            btClose.Location = new Point(247, 185);
            btClose.Margin = new Padding(4, 5, 4, 5);
            btClose.Name = "btClose";
            btClose.Size = new Size(100, 35);
            btClose.TabIndex = 4;
            btClose.Text = "Đóng";
            btClose.UseVisualStyleBackColor = true;
            btClose.Click += btClose_Click;
            // 
            // liForget
            // 
            liForget.AutoSize = true;
            liForget.Location = new Point(107, 162);
            liForget.Margin = new Padding(4, 0, 4, 0);
            liForget.Name = "liForget";
            liForget.Size = new Size(109, 20);
            liForget.TabIndex = 5;
            liForget.TabStop = true;
            liForget.Text = "Quên mật khẩu";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(16, 66);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(89, 20);
            label1.TabIndex = 6;
            label1.Text = "Người dùng";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(16, 128);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 7;
            label2.Text = "Mật khẩu";
            // 
            // fLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(379, 248);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(liForget);
            Controls.Add(btClose);
            Controls.Add(btLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtUser);
            Controls.Add(lblMessage);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(4, 5, 4, 5);
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "fLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Đăng nhập";
            Load += fLogin_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label lblMessage;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btLogin;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.LinkLabel liForget;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
