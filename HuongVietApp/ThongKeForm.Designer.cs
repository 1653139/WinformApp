namespace HuongVietApp
{
    partial class ThongKeForm
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
            this.grid_thongke = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_LoaiThongKe = new System.Windows.Forms.ComboBox();
            this.cbo_KenhDatHang = new System.Windows.Forms.ComboBox();
            this.btn_Thongke = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbo_ChiNhanh = new System.Windows.Forms.ComboBox();
            this.cbo_Monan = new System.Windows.Forms.ComboBox();
            this.cbo_Loaimon = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.cbo_Loaikhach = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_thongke)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ngày thống kê:";
            // 
            // grid_thongke
            // 
            this.grid_thongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_thongke.Location = new System.Drawing.Point(108, 264);
            this.grid_thongke.Name = "grid_thongke";
            this.grid_thongke.RowTemplate.Height = 24;
            this.grid_thongke.Size = new System.Drawing.Size(807, 236);
            this.grid_thongke.TabIndex = 1;
            this.grid_thongke.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.thongke_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(650, 503);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tổng doanh thu:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(818, 503);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "doanhthuhere";
            // 
            // cbo_LoaiThongKe
            // 
            this.cbo_LoaiThongKe.FormattingEnabled = true;
            this.cbo_LoaiThongKe.Location = new System.Drawing.Point(165, 66);
            this.cbo_LoaiThongKe.Name = "cbo_LoaiThongKe";
            this.cbo_LoaiThongKe.Size = new System.Drawing.Size(482, 24);
            this.cbo_LoaiThongKe.TabIndex = 6;
            this.cbo_LoaiThongKe.SelectionChangeCommitted += new System.EventHandler(this.cbo_LoaiThongKe_SelectionChangeCommitted_1);
            // 
            // cbo_KenhDatHang
            // 
            this.cbo_KenhDatHang.FormattingEnabled = true;
            this.cbo_KenhDatHang.Location = new System.Drawing.Point(739, 66);
            this.cbo_KenhDatHang.Name = "cbo_KenhDatHang";
            this.cbo_KenhDatHang.Size = new System.Drawing.Size(203, 24);
            this.cbo_KenhDatHang.TabIndex = 7;
            // 
            // btn_Thongke
            // 
            this.btn_Thongke.Location = new System.Drawing.Point(747, 209);
            this.btn_Thongke.Name = "btn_Thongke";
            this.btn_Thongke.Size = new System.Drawing.Size(168, 38);
            this.btn_Thongke.TabIndex = 8;
            this.btn_Thongke.Text = "Thống kê";
            this.btn_Thongke.UseVisualStyleBackColor = true;
            this.btn_Thongke.Click += new System.EventHandler(this.btn_Thongke_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(165, 28);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 9;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(425, 28);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker2.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(373, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 17);
            this.label4.TabIndex = 11;
            this.label4.Text = "đến";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(665, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "Chi Nhánh: ";
            // 
            // cbo_ChiNhanh
            // 
            this.cbo_ChiNhanh.FormattingEnabled = true;
            this.cbo_ChiNhanh.Items.AddRange(new object[] {
            "Tất cả",
            "Cửa hàng 1 ",
            "Cửa hàng  2",
            "Cửa hàng  3 ",
            "Cửa hàng 4"});
            this.cbo_ChiNhanh.Location = new System.Drawing.Point(739, 26);
            this.cbo_ChiNhanh.Name = "cbo_ChiNhanh";
            this.cbo_ChiNhanh.Size = new System.Drawing.Size(203, 24);
            this.cbo_ChiNhanh.TabIndex = 14;
            // 
            // cbo_Monan
            // 
            this.cbo_Monan.FormattingEnabled = true;
            this.cbo_Monan.Location = new System.Drawing.Point(165, 147);
            this.cbo_Monan.Name = "cbo_Monan";
            this.cbo_Monan.Size = new System.Drawing.Size(121, 24);
            this.cbo_Monan.TabIndex = 15;
            // 
            // cbo_Loaimon
            // 
            this.cbo_Loaimon.FormattingEnabled = true;
            this.cbo_Loaimon.Location = new System.Drawing.Point(425, 147);
            this.cbo_Loaimon.Name = "cbo_Loaimon";
            this.cbo_Loaimon.Size = new System.Drawing.Size(121, 24);
            this.cbo_Loaimon.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 73);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "Loại thống kê";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(665, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Hình thức";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(45, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Món ăn";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(353, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 17);
            this.label9.TabIndex = 20;
            this.label9.Text = "Loại món";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(665, 150);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(62, 17);
            this.label10.TabIndex = 21;
            this.label10.Text = "Loại KH:";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // cbo_Loaikhach
            // 
            this.cbo_Loaikhach.FormattingEnabled = true;
            this.cbo_Loaikhach.Location = new System.Drawing.Point(739, 143);
            this.cbo_Loaikhach.Name = "cbo_Loaikhach";
            this.cbo_Loaikhach.Size = new System.Drawing.Size(203, 24);
            this.cbo_Loaikhach.TabIndex = 22;
            // 
            // ThongKeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(976, 599);
            this.Controls.Add(this.cbo_Loaikhach);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbo_Loaimon);
            this.Controls.Add(this.cbo_Monan);
            this.Controls.Add(this.cbo_ChiNhanh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.btn_Thongke);
            this.Controls.Add(this.cbo_KenhDatHang);
            this.Controls.Add(this.cbo_LoaiThongKe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grid_thongke);
            this.Controls.Add(this.label1);
            this.Name = "ThongKeForm";
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.Thongke_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid_thongke)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grid_thongke;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_LoaiThongKe;
        private System.Windows.Forms.ComboBox cbo_KenhDatHang;
        private System.Windows.Forms.Button btn_Thongke;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbo_ChiNhanh;
        private System.Windows.Forms.ComboBox cbo_Monan;
        private System.Windows.Forms.ComboBox cbo_Loaimon;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbo_Loaikhach;
    }
}

