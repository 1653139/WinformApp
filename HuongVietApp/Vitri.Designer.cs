namespace HuongVietApp
{
    partial class Vitri
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
            this.label3 = new System.Windows.Forms.Label();
            this.cbo_thanhpho = new System.Windows.Forms.ComboBox();
            this.cbo_quan = new System.Windows.Forms.ComboBox();
            this.btn_tieptuc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bạn đang ở đâu?:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(104, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chọn Thành phố:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Chọn Quận:";
            // 
            // cbo_thanhpho
            // 
            this.cbo_thanhpho.FormattingEnabled = true;
            this.cbo_thanhpho.Location = new System.Drawing.Point(281, 94);
            this.cbo_thanhpho.Name = "cbo_thanhpho";
            this.cbo_thanhpho.Size = new System.Drawing.Size(259, 24);
            this.cbo_thanhpho.TabIndex = 4;
            // 
            // cbo_quan
            // 
            this.cbo_quan.FormattingEnabled = true;
            this.cbo_quan.Location = new System.Drawing.Point(281, 157);
            this.cbo_quan.Name = "cbo_quan";
            this.cbo_quan.Size = new System.Drawing.Size(259, 24);
            this.cbo_quan.TabIndex = 5;
            // 
            // btn_tieptuc
            // 
            this.btn_tieptuc.Location = new System.Drawing.Point(399, 318);
            this.btn_tieptuc.Name = "btn_tieptuc";
            this.btn_tieptuc.Size = new System.Drawing.Size(141, 41);
            this.btn_tieptuc.TabIndex = 7;
            this.btn_tieptuc.Text = "Tiếp tục";
            this.btn_tieptuc.UseVisualStyleBackColor = true;
            this.btn_tieptuc.Click += new System.EventHandler(this.btn_tieptuc_Click);
            // 
            // Vitri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_tieptuc);
            this.Controls.Add(this.cbo_quan);
            this.Controls.Add(this.cbo_thanhpho);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Vitri";
            this.Text = "Vitri";
            this.Load += new System.EventHandler(this.Vitri_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbo_thanhpho;
        private System.Windows.Forms.ComboBox cbo_quan;
        private System.Windows.Forms.Button btn_tieptuc;
    }
}