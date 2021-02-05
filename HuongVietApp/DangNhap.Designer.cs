namespace HuongVietApp
{
    partial class DangNhap
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_matkhau = new System.Windows.Forms.TextBox();
            this.btn_Dangnhap = new System.Windows.Forms.Button();
            this.btn_datmon = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Email";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 164);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mật khẩu";
            // 
            // txt_email
            // 
            this.txt_email.Location = new System.Drawing.Point(197, 110);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(209, 22);
            this.txt_email.TabIndex = 2;
            // 
            // txt_matkhau
            // 
            this.txt_matkhau.Location = new System.Drawing.Point(197, 164);
            this.txt_matkhau.Name = "txt_matkhau";
            this.txt_matkhau.Size = new System.Drawing.Size(209, 22);
            this.txt_matkhau.TabIndex = 3;
            // 
            // btn_Dangnhap
            // 
            this.btn_Dangnhap.BackColor = System.Drawing.Color.Aquamarine;
            this.btn_Dangnhap.Location = new System.Drawing.Point(59, 256);
            this.btn_Dangnhap.Name = "btn_Dangnhap";
            this.btn_Dangnhap.Size = new System.Drawing.Size(120, 23);
            this.btn_Dangnhap.TabIndex = 4;
            this.btn_Dangnhap.Text = "Đăng Nhập";
            this.btn_Dangnhap.UseVisualStyleBackColor = false;
            this.btn_Dangnhap.Click += new System.EventHandler(this.btn_Dangnhap_Click);
            // 
            // btn_datmon
            // 
            this.btn_datmon.Location = new System.Drawing.Point(268, 256);
            this.btn_datmon.Name = "btn_datmon";
            this.btn_datmon.Size = new System.Drawing.Size(138, 23);
            this.btn_datmon.TabIndex = 5;
            this.btn_datmon.Text = "Đặt món ngay";
            this.btn_datmon.UseVisualStyleBackColor = true;
            this.btn_datmon.Click += new System.EventHandler(this.btn_datmon_Click);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 362);
            this.Controls.Add(this.btn_datmon);
            this.Controls.Add(this.btn_Dangnhap);
            this.Controls.Add(this.txt_matkhau);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_matkhau;
        private System.Windows.Forms.Button btn_Dangnhap;
        private System.Windows.Forms.Button btn_datmon;
    }
}