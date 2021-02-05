namespace HuongVietApp
{
    partial class DangNhapNV
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
            this.btn_Dangnhap = new System.Windows.Forms.Button();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_Chinhanh = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // btn_Dangnhap
            // 
            this.btn_Dangnhap.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_Dangnhap.Location = new System.Drawing.Point(455, 317);
            this.btn_Dangnhap.Name = "btn_Dangnhap";
            this.btn_Dangnhap.Size = new System.Drawing.Size(120, 23);
            this.btn_Dangnhap.TabIndex = 10;
            this.btn_Dangnhap.Text = "Đăng Nhập";
            this.btn_Dangnhap.UseVisualStyleBackColor = false;
            this.btn_Dangnhap.Click += new System.EventHandler(this.btn_Dangnhap_Click);
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(366, 195);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(209, 22);
            this.txt_matkhau.TabIndex = 9;
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(366, 141);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(209, 22);
            this.txt_email.TabIndex = 8;
            this.txt_email.TextChanged += new System.EventHandler(this.txt_email_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(225, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Mật khẩu";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 146);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Email";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(225, 238);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Chọn chi nhánh";
            // 
            // cbo_Chinhanh
            // 
            this.cbo_Chinhanh.FormattingEnabled = true;
            this.cbo_Chinhanh.Location = new System.Drawing.Point(366, 238);
            this.cbo_Chinhanh.Name = "cbo_Chinhanh";
            this.cbo_Chinhanh.Size = new System.Drawing.Size(209, 24);
            this.cbo_Chinhanh.TabIndex = 13;
            // 
            // DangNhapNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cbo_Chinhanh);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_Dangnhap);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DangNhapNV";
            this.Text = "DangNhapNV";
            this.Load += new System.EventHandler(this.DangNhapNV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_Dangnhap;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_Chinhanh;
    }
}