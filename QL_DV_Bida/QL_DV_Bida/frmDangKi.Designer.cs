namespace QL_DV_Bida
{
    partial class frmDangKi
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
            pictureBox1 = new PictureBox();
            txttaikhoan = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txtmatkhau = new TextBox();
            label3 = new Label();
            txtxacnhanmatkhau = new TextBox();
            label4 = new Label();
            txtemail = new TextBox();
            btndangky = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Screenshot_2024_04_12_230341;
            pictureBox1.Location = new Point(132, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 172);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // txttaikhoan
            // 
            txttaikhoan.Location = new Point(265, 214);
            txttaikhoan.Name = "txttaikhoan";
            txttaikhoan.Size = new Size(188, 27);
            txttaikhoan.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(73, 218);
            label1.Name = "label1";
            label1.Size = new Size(125, 23);
            label1.TabIndex = 5;
            label1.Text = "Tên Tài Khoản:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(73, 268);
            label2.Name = "label2";
            label2.Size = new Size(92, 23);
            label2.TabIndex = 7;
            label2.Text = "Mật Khẩu:";
            // 
            // txtmatkhau
            // 
            txtmatkhau.Location = new Point(265, 264);
            txtmatkhau.Name = "txtmatkhau";
            txtmatkhau.Size = new Size(188, 27);
            txtmatkhau.TabIndex = 6;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(73, 319);
            label3.Name = "label3";
            label3.Size = new Size(172, 23);
            label3.TabIndex = 9;
            label3.Text = "Xác Nhận Mật Khẩu:";
            // 
            // txtxacnhanmatkhau
            // 
            txtxacnhanmatkhau.Location = new Point(265, 315);
            txtxacnhanmatkhau.Name = "txtxacnhanmatkhau";
            txtxacnhanmatkhau.Size = new Size(188, 27);
            txtxacnhanmatkhau.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(73, 367);
            label4.Name = "label4";
            label4.Size = new Size(59, 23);
            label4.TabIndex = 11;
            label4.Text = "Email:";
            // 
            // txtemail
            // 
            txtemail.Location = new Point(265, 363);
            txtemail.Name = "txtemail";
            txtemail.Size = new Size(188, 27);
            txtemail.TabIndex = 10;
            // 
            // btndangky
            // 
            btndangky.BackColor = SystemColors.ActiveBorder;
            btndangky.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btndangky.Location = new Point(159, 438);
            btndangky.Name = "btndangky";
            btndangky.Size = new Size(150, 41);
            btndangky.TabIndex = 12;
            btndangky.Text = "Đăng ký";
            btndangky.UseVisualStyleBackColor = false;
            btndangky.Click += btndangky_Click;
            // 
            // frmDangKi
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(532, 693);
            Controls.Add(btndangky);
            Controls.Add(label4);
            Controls.Add(txtemail);
            Controls.Add(label3);
            Controls.Add(txtxacnhanmatkhau);
            Controls.Add(label2);
            Controls.Add(txtmatkhau);
            Controls.Add(label1);
            Controls.Add(txttaikhoan);
            Controls.Add(pictureBox1);
            Name = "frmDangKi";
            Text = "Đăng ký";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox txttaikhoan;
        private Label label1;
        private Label label2;
        private TextBox txtmatkhau;
        private Label label3;
        private TextBox txtxacnhanmatkhau;
        private Label label4;
        private TextBox txtemail;
        private Button btndangky;
    }
}
