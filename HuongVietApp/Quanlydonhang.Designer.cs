namespace HuongVietApp
{
    partial class Nhân_viên
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
            this.grid_donhang = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_trangthai = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lb_tencuahang = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grid_donhang)).BeginInit();
            this.SuspendLayout();
            // 
            // grid_donhang
            // 
            this.grid_donhang.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_donhang.Location = new System.Drawing.Point(16, 123);
            this.grid_donhang.Margin = new System.Windows.Forms.Padding(4);
            this.grid_donhang.Name = "grid_donhang";
            this.grid_donhang.Size = new System.Drawing.Size(975, 185);
            this.grid_donhang.TabIndex = 6;
            this.grid_donhang.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_donhang_CellClick);
            this.grid_donhang.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(39, 356);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Trạng thái :";
            // 
            // txt_trangthai
            // 
            this.txt_trangthai.Location = new System.Drawing.Point(224, 351);
            this.txt_trangthai.Margin = new System.Windows.Forms.Padding(4);
            this.txt_trangthai.Name = "txt_trangthai";
            this.txt_trangthai.Size = new System.Drawing.Size(132, 22);
            this.txt_trangthai.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(762, 370);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(202, 73);
            this.button1.TabIndex = 13;
            this.button1.Text = "Cập nhật trạng thái";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(21, 43);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 17);
            this.label8.TabIndex = 14;
            this.label8.Text = "Cửa hàng";
            // 
            // lb_tencuahang
            // 
            this.lb_tencuahang.AutoSize = true;
            this.lb_tencuahang.Location = new System.Drawing.Point(106, 43);
            this.lb_tencuahang.Name = "lb_tencuahang";
            this.lb_tencuahang.Size = new System.Drawing.Size(46, 17);
            this.lb_tencuahang.TabIndex = 15;
            this.lb_tencuahang.Text = "label1";
            // 
            // Nhân_viên
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 468);
            this.Controls.Add(this.lb_tencuahang);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txt_trangthai);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.grid_donhang);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Nhân_viên";
            this.Text = "Nhân_viên";
            this.Load += new System.EventHandler(this.Nhân_viên_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.grid_donhang)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView grid_donhang;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_trangthai;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lb_tencuahang;
    }
}