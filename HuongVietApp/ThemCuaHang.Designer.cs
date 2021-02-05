namespace HuongVietApp
{
    partial class ThemCuaHang
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
            this.cbo_quan = new System.Windows.Forms.ComboBox();
            this.cbo_thanhpho = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_tenchinhanh = new System.Windows.Forms.TextBox();
            this.btn_themchinhanh = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cbo_quan
            // 
            this.cbo_quan.FormattingEnabled = true;
            this.cbo_quan.Location = new System.Drawing.Point(359, 245);
            this.cbo_quan.Name = "cbo_quan";
            this.cbo_quan.Size = new System.Drawing.Size(259, 24);
            this.cbo_quan.TabIndex = 9;
            // 
            // cbo_thanhpho
            // 
            this.cbo_thanhpho.FormattingEnabled = true;
            this.cbo_thanhpho.Location = new System.Drawing.Point(359, 182);
            this.cbo_thanhpho.Name = "cbo_thanhpho";
            this.cbo_thanhpho.Size = new System.Drawing.Size(259, 24);
            this.cbo_thanhpho.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(182, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Chọn Quận:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Chọn Thành phố:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(182, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 17);
            this.label1.TabIndex = 10;
            this.label1.Text = "Tên Chi nhánh:";
            // 
            // txt_tenchinhanh
            // 
            this.txt_tenchinhanh.Location = new System.Drawing.Point(359, 126);
            this.txt_tenchinhanh.Name = "txt_tenchinhanh";
            this.txt_tenchinhanh.Size = new System.Drawing.Size(259, 22);
            this.txt_tenchinhanh.TabIndex = 11;
            // 
            // btn_themchinhanh
            // 
            this.btn_themchinhanh.Location = new System.Drawing.Point(477, 309);
            this.btn_themchinhanh.Name = "btn_themchinhanh";
            this.btn_themchinhanh.Size = new System.Drawing.Size(141, 43);
            this.btn_themchinhanh.TabIndex = 12;
            this.btn_themchinhanh.Text = "Thêm Chi Nhánh";
            this.btn_themchinhanh.UseVisualStyleBackColor = true;
            this.btn_themchinhanh.Click += new System.EventHandler(this.btn_themchinhanh_Click);
            // 
            // ThemCuaHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_themchinhanh);
            this.Controls.Add(this.txt_tenchinhanh);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbo_quan);
            this.Controls.Add(this.cbo_thanhpho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "ThemCuaHang";
            this.Text = "ThemCuaHang";
            this.Load += new System.EventHandler(this.ThemCuaHang_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbo_quan;
        private System.Windows.Forms.ComboBox cbo_thanhpho;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_tenchinhanh;
        private System.Windows.Forms.Button btn_themchinhanh;
    }
}