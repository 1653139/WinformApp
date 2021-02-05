namespace HuongVietApp
{
    partial class ThemLoaiMon
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
            this.txt_tenloaimon = new System.Windows.Forms.TextBox();
            this.btn_themloaimon = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_tenloaimon
            // 
            this.txt_tenloaimon.Location = new System.Drawing.Point(293, 169);
            this.txt_tenloaimon.Name = "txt_tenloaimon";
            this.txt_tenloaimon.Size = new System.Drawing.Size(284, 22);
            this.txt_tenloaimon.TabIndex = 0;
            // 
            // btn_themloaimon
            // 
            this.btn_themloaimon.Location = new System.Drawing.Point(444, 250);
            this.btn_themloaimon.Name = "btn_themloaimon";
            this.btn_themloaimon.Size = new System.Drawing.Size(133, 35);
            this.btn_themloaimon.TabIndex = 1;
            this.btn_themloaimon.Text = "Thêm Loại Món";
            this.btn_themloaimon.UseVisualStyleBackColor = true;
            this.btn_themloaimon.Click += new System.EventHandler(this.btn_themloaimon_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(177, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên loại món";
            // 
            // ThemLoaiMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_themloaimon);
            this.Controls.Add(this.txt_tenloaimon);
            this.Name = "ThemLoaiMon";
            this.Text = "ThemLoaiMon";
            this.Load += new System.EventHandler(this.ThemLoaiMon_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_tenloaimon;
        private System.Windows.Forms.Button btn_themloaimon;
        private System.Windows.Forms.Label label1;
    }
}