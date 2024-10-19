namespace GUI
{
    partial class SignUp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignUp));
            pictureBox1 = new PictureBox();
            lbl_signUp = new Label();
            lbl_facebook = new Label();
            lbl_Google = new Label();
            txt_nameAccount = new TextBox();
            txt_phoneNumber = new TextBox();
            txt_class = new TextBox();
            txt_fullName = new TextBox();
            txt_repeatAccount = new TextBox();
            txt_passAccount = new TextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(900, 518);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // lbl_signUp
            // 
            lbl_signUp.AutoSize = true;
            lbl_signUp.BackColor = Color.FromArgb(55, 147, 205);
            lbl_signUp.Cursor = Cursors.Hand;
            lbl_signUp.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_signUp.ForeColor = SystemColors.ButtonFace;
            lbl_signUp.Location = new Point(564, 324);
            lbl_signUp.Name = "lbl_signUp";
            lbl_signUp.Size = new Size(200, 31);
            lbl_signUp.TabIndex = 8;
            lbl_signUp.Text = "Hoàn tất đăng ký";
            lbl_signUp.Click += lbl_signUp_Click;
            lbl_signUp.MouseEnter += lbl_signUp_MouseEnter;
            lbl_signUp.MouseLeave += lbl_signUp_MouseLeave;
            // 
            // lbl_facebook
            // 
            lbl_facebook.AutoSize = true;
            lbl_facebook.BackColor = Color.FromArgb(27, 87, 176);
            lbl_facebook.Cursor = Cursors.Hand;
            lbl_facebook.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_facebook.ForeColor = SystemColors.ButtonHighlight;
            lbl_facebook.Location = new Point(531, 399);
            lbl_facebook.Name = "lbl_facebook";
            lbl_facebook.Size = new Size(85, 23);
            lbl_facebook.TabIndex = 9;
            lbl_facebook.Text = "Facebook";
            lbl_facebook.MouseEnter += lbl_facebook_MouseEnter;
            lbl_facebook.MouseLeave += lbl_facebook_MouseLeave;
            // 
            // lbl_Google
            // 
            lbl_Google.AutoSize = true;
            lbl_Google.BackColor = Color.FromArgb(255, 49, 49);
            lbl_Google.Cursor = Cursors.Hand;
            lbl_Google.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point);
            lbl_Google.ForeColor = SystemColors.ButtonHighlight;
            lbl_Google.Location = new Point(725, 399);
            lbl_Google.Name = "lbl_Google";
            lbl_Google.Size = new Size(67, 23);
            lbl_Google.TabIndex = 10;
            lbl_Google.Text = "Google";
            lbl_Google.MouseEnter += lbl_Google_MouseEnter;
            lbl_Google.MouseLeave += lbl_Google_MouseLeave;
            // 
            // txt_nameAccount
            // 
            txt_nameAccount.BackColor = SystemColors.Window;
            txt_nameAccount.BorderStyle = BorderStyle.FixedSingle;
            txt_nameAccount.ForeColor = Color.Gray;
            txt_nameAccount.Location = new Point(513, 70);
            txt_nameAccount.Name = "txt_nameAccount";
            txt_nameAccount.Size = new Size(305, 30);
            txt_nameAccount.TabIndex = 12;
            txt_nameAccount.Text = "Tên tài khoản";
            txt_nameAccount.Click += txt_nameAccount_Click;
            // 
            // txt_phoneNumber
            // 
            txt_phoneNumber.BorderStyle = BorderStyle.FixedSingle;
            txt_phoneNumber.ForeColor = Color.Gray;
            txt_phoneNumber.Location = new Point(513, 262);
            txt_phoneNumber.Name = "txt_phoneNumber";
            txt_phoneNumber.Size = new Size(305, 30);
            txt_phoneNumber.TabIndex = 13;
            txt_phoneNumber.Text = "Số điện thoại";
            txt_phoneNumber.Click += txt_phoneNumber_Click;
            // 
            // txt_class
            // 
            txt_class.BorderStyle = BorderStyle.FixedSingle;
            txt_class.ForeColor = Color.Gray;
            txt_class.Location = new Point(513, 226);
            txt_class.Name = "txt_class";
            txt_class.Size = new Size(305, 30);
            txt_class.TabIndex = 14;
            txt_class.Text = "Lớp hoặc chức vụ";
            txt_class.Click += txt_class_Click;
            // 
            // txt_fullName
            // 
            txt_fullName.BorderStyle = BorderStyle.FixedSingle;
            txt_fullName.ForeColor = Color.Gray;
            txt_fullName.Location = new Point(513, 190);
            txt_fullName.Name = "txt_fullName";
            txt_fullName.Size = new Size(305, 30);
            txt_fullName.TabIndex = 15;
            txt_fullName.Text = "Họ và tên";
            txt_fullName.Click += txt_fullName_Click;
            // 
            // txt_repeatAccount
            // 
            txt_repeatAccount.BorderStyle = BorderStyle.FixedSingle;
            txt_repeatAccount.ForeColor = Color.Gray;
            txt_repeatAccount.Location = new Point(513, 154);
            txt_repeatAccount.Name = "txt_repeatAccount";
            txt_repeatAccount.Size = new Size(305, 30);
            txt_repeatAccount.TabIndex = 16;
            txt_repeatAccount.Text = "Nhập lại mật khẩu";
            txt_repeatAccount.Click += txt_repeatAccount_Click;
            // 
            // txt_passAccount
            // 
            txt_passAccount.BorderStyle = BorderStyle.FixedSingle;
            txt_passAccount.ForeColor = Color.Gray;
            txt_passAccount.Location = new Point(513, 118);
            txt_passAccount.Name = "txt_passAccount";
            txt_passAccount.Size = new Size(305, 30);
            txt_passAccount.TabIndex = 17;
            txt_passAccount.Text = "Mật khẩu";
            txt_passAccount.Click += txt_passAccount_Click;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(9F, 23F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(900, 518);
            Controls.Add(txt_passAccount);
            Controls.Add(txt_repeatAccount);
            Controls.Add(txt_fullName);
            Controls.Add(txt_class);
            Controls.Add(txt_phoneNumber);
            Controls.Add(txt_nameAccount);
            Controls.Add(lbl_Google);
            Controls.Add(lbl_facebook);
            Controls.Add(lbl_signUp);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "SignUp";
            Text = "SignUp";
            FormClosing += SignUp_FormClosing;
            Load += SignUp_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label lbl_signUp;
        private Label lbl_facebook;
        private Label lbl_Google;
        private TextBox txt_nameAccount;
        private TextBox txt_phoneNumber;
        private TextBox txt_class;
        private TextBox txt_fullName;
        private TextBox txt_repeatAccount;
        private TextBox txt_passAccount;
    }
}