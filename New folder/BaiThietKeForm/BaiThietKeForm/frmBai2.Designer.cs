namespace BaiThietKeForm
{
    partial class frmBai2
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnChonHang = new System.Windows.Forms.Button();
            this.list1 = new System.Windows.Forms.ListBox();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnBoHang = new System.Windows.Forms.Button();
            this.lblTongTien = new System.Windows.Forms.Label();
            this.list2 = new System.Windows.Forms.ListBox();
            this.lblDaMua = new System.Windows.Forms.Label();
            this.lblSoTien = new System.Windows.Forms.Label();
            this.lblGiaTri = new System.Windows.Forms.Label();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnChonHang);
            this.panel1.Controls.Add(this.list1);
            this.panel1.Controls.Add(this.lblDanhSach);
            this.panel1.Location = new System.Drawing.Point(38, 32);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(325, 290);
            this.panel1.TabIndex = 0;
            // 
            // btnChonHang
            // 
            this.btnChonHang.Location = new System.Drawing.Point(225, 108);
            this.btnChonHang.Name = "btnChonHang";
            this.btnChonHang.Size = new System.Drawing.Size(97, 23);
            this.btnChonHang.TabIndex = 3;
            this.btnChonHang.Text = "Chọn hàng >";
            this.btnChonHang.UseVisualStyleBackColor = true;
            this.btnChonHang.Click += new System.EventHandler(this.btnChonHang_Click);
            // 
            // list1
            // 
            this.list1.FormattingEnabled = true;
            this.list1.Items.AddRange(new object[] {
            "Chuột",
            "Bàn phím",
            "Máy in",
            "USB Kingmax"});
            this.list1.Location = new System.Drawing.Point(23, 67);
            this.list1.Name = "list1";
            this.list1.Size = new System.Drawing.Size(160, 95);
            this.list1.TabIndex = 2;
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.Location = new System.Drawing.Point(88, 32);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(107, 13);
            this.lblDanhSach.TabIndex = 1;
            this.lblDanhSach.Text = "Danh sách hàng hóa";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnTinhTien);
            this.panel2.Controls.Add(this.btnBoHang);
            this.panel2.Controls.Add(this.lblDaMua);
            this.panel2.Controls.Add(this.lblGiaTri);
            this.panel2.Controls.Add(this.lblSoTien);
            this.panel2.Controls.Add(this.lblTongTien);
            this.panel2.Controls.Add(this.list2);
            this.panel2.Location = new System.Drawing.Point(429, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(325, 290);
            this.panel2.TabIndex = 0;
            // 
            // btnBoHang
            // 
            this.btnBoHang.Location = new System.Drawing.Point(3, 107);
            this.btnBoHang.Name = "btnBoHang";
            this.btnBoHang.Size = new System.Drawing.Size(97, 23);
            this.btnBoHang.TabIndex = 3;
            this.btnBoHang.Text = "< Bỏ hàng";
            this.btnBoHang.UseVisualStyleBackColor = true;
            this.btnBoHang.Click += new System.EventHandler(this.btnBoHang_Click);
            // 
            // lblTongTien
            // 
            this.lblTongTien.AutoSize = true;
            this.lblTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Location = new System.Drawing.Point(3, 243);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(148, 16);
            this.lblTongTien.TabIndex = 1;
            this.lblTongTien.Text = "Tổng tiền thanh toán";
            this.lblTongTien.Click += new System.EventHandler(this.label1_Click);
            // 
            // list2
            // 
            this.list2.FormattingEnabled = true;
            this.list2.Location = new System.Drawing.Point(151, 66);
            this.list2.Name = "list2";
            this.list2.Size = new System.Drawing.Size(160, 95);
            this.list2.TabIndex = 2;
            // 
            // lblDaMua
            // 
            this.lblDaMua.AutoSize = true;
            this.lblDaMua.Location = new System.Drawing.Point(54, 32);
            this.lblDaMua.Name = "lblDaMua";
            this.lblDaMua.Size = new System.Drawing.Size(162, 13);
            this.lblDaMua.TabIndex = 1;
            this.lblDaMua.Text = "Các mặt hàng mà khách đã mua";
            this.lblDaMua.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblSoTien
            // 
            this.lblSoTien.AutoSize = true;
            this.lblSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoTien.Location = new System.Drawing.Point(157, 243);
            this.lblSoTien.Name = "lblSoTien";
            this.lblSoTien.Size = new System.Drawing.Size(12, 16);
            this.lblSoTien.TabIndex = 1;
            this.lblSoTien.Text = ".";
            this.lblSoTien.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblGiaTri
            // 
            this.lblGiaTri.AutoSize = true;
            this.lblGiaTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaTri.Location = new System.Drawing.Point(276, 243);
            this.lblGiaTri.Name = "lblGiaTri";
            this.lblGiaTri.Size = new System.Drawing.Size(43, 16);
            this.lblGiaTri.TabIndex = 1;
            this.lblGiaTri.Text = "đồng";
            this.lblGiaTri.Click += new System.EventHandler(this.label1_Click);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(151, 194);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(97, 23);
            this.btnTinhTien.TabIndex = 3;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.btnTinhTien_Click);
            // 
            // frmBai2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmBai2";
            this.Text = "Bán hàng";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnChonHang;
        private System.Windows.Forms.ListBox list1;
        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnBoHang;
        private System.Windows.Forms.Label lblTongTien;
        private System.Windows.Forms.ListBox list2;
        private System.Windows.Forms.Label lblDaMua;
        private System.Windows.Forms.Label lblGiaTri;
        private System.Windows.Forms.Label lblSoTien;
        private System.Windows.Forms.Button btnTinhTien;
    }
}