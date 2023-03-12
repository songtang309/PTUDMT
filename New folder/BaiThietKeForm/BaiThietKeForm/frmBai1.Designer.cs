namespace BaiThietKeForm
{
    partial class frmBai1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBai1));
            this.gbChonMau = new System.Windows.Forms.GroupBox();
            this.rbTrang = new System.Windows.Forms.RadioButton();
            this.rbXanh = new System.Windows.Forms.RadioButton();
            this.rbDo = new System.Windows.Forms.RadioButton();
            this.lbgiatri = new System.Windows.Forms.Label();
            this.lbSoLuong = new System.Windows.Forms.Label();
            this.txtSoLuong = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.btnTinhTien = new System.Windows.Forms.Button();
            this.lbSoTien = new System.Windows.Forms.Label();
            this.lbDonGia = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.GiaTri = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.gbChonMau.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // gbChonMau
            // 
            this.gbChonMau.Controls.Add(this.rbTrang);
            this.gbChonMau.Controls.Add(this.rbXanh);
            this.gbChonMau.Controls.Add(this.rbDo);
            this.gbChonMau.Location = new System.Drawing.Point(326, 28);
            this.gbChonMau.Name = "gbChonMau";
            this.gbChonMau.Size = new System.Drawing.Size(157, 137);
            this.gbChonMau.TabIndex = 0;
            this.gbChonMau.TabStop = false;
            this.gbChonMau.Text = "Chọn màu xe";
            this.gbChonMau.Enter += new System.EventHandler(this.gbChonMau_Enter);
            // 
            // rbTrang
            // 
            this.rbTrang.AutoSize = true;
            this.rbTrang.Location = new System.Drawing.Point(15, 78);
            this.rbTrang.Name = "rbTrang";
            this.rbTrang.Size = new System.Drawing.Size(73, 17);
            this.rbTrang.TabIndex = 0;
            this.rbTrang.TabStop = true;
            this.rbTrang.Text = "Màu trắng";
            this.rbTrang.UseVisualStyleBackColor = true;
            this.rbTrang.CheckedChanged += new System.EventHandler(this.rbTrang_CheckedChanged);
            // 
            // rbXanh
            // 
            this.rbXanh.AutoSize = true;
            this.rbXanh.Location = new System.Drawing.Point(15, 32);
            this.rbXanh.Name = "rbXanh";
            this.rbXanh.Size = new System.Drawing.Size(72, 17);
            this.rbXanh.TabIndex = 0;
            this.rbXanh.TabStop = true;
            this.rbXanh.Text = "Màu xanh";
            this.rbXanh.UseVisualStyleBackColor = true;
            this.rbXanh.CheckedChanged += new System.EventHandler(this.rbXanh_CheckedChanged);
            // 
            // rbDo
            // 
            this.rbDo.AutoSize = true;
            this.rbDo.Location = new System.Drawing.Point(15, 55);
            this.rbDo.Name = "rbDo";
            this.rbDo.Size = new System.Drawing.Size(62, 17);
            this.rbDo.TabIndex = 0;
            this.rbDo.TabStop = true;
            this.rbDo.Text = "Màu đỏ";
            this.rbDo.UseVisualStyleBackColor = true;
            this.rbDo.CheckedChanged += new System.EventHandler(this.rbDo_CheckedChanged);
            // 
            // lbgiatri
            // 
            this.lbgiatri.AutoSize = true;
            this.lbgiatri.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lbgiatri.Location = new System.Drawing.Point(495, 195);
            this.lbgiatri.Name = "lbgiatri";
            this.lbgiatri.Size = new System.Drawing.Size(13, 13);
            this.lbgiatri.TabIndex = 1;
            this.lbgiatri.Text = "$";
            this.lbgiatri.Click += new System.EventHandler(this.lbDonGia_Click);
            // 
            // lbSoLuong
            // 
            this.lbSoLuong.AutoSize = true;
            this.lbSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSoLuong.Location = new System.Drawing.Point(329, 232);
            this.lbSoLuong.Name = "lbSoLuong";
            this.lbSoLuong.Size = new System.Drawing.Size(61, 16);
            this.lbSoLuong.TabIndex = 1;
            this.lbSoLuong.Text = "Số lượng";
            this.lbSoLuong.Click += new System.EventHandler(this.lbSoLuong_Click);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Location = new System.Drawing.Point(389, 228);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Size = new System.Drawing.Size(58, 22);
            this.txtSoLuong.TabIndex = 2;
            this.txtSoLuong.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(389, 192);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(94, 22);
            this.txtDonGia.TabIndex = 2;
            this.txtDonGia.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnTinhTien
            // 
            this.btnTinhTien.Location = new System.Drawing.Point(389, 256);
            this.btnTinhTien.Name = "btnTinhTien";
            this.btnTinhTien.Size = new System.Drawing.Size(70, 28);
            this.btnTinhTien.TabIndex = 3;
            this.btnTinhTien.Text = "Tính tiền";
            this.btnTinhTien.UseVisualStyleBackColor = true;
            this.btnTinhTien.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbSoTien
            // 
            this.lbSoTien.AutoSize = true;
            this.lbSoTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbSoTien.Location = new System.Drawing.Point(394, 297);
            this.lbSoTien.Name = "lbSoTien";
            this.lbSoTien.Size = new System.Drawing.Size(20, 22);
            this.lbSoTien.TabIndex = 1;
            this.lbSoTien.Text = "0";
            this.lbSoTien.Click += new System.EventHandler(this.lbDonGia_Click);
            // 
            // lbDonGia
            // 
            this.lbDonGia.AutoSize = true;
            this.lbDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbDonGia.Location = new System.Drawing.Point(329, 192);
            this.lbDonGia.Name = "lbDonGia";
            this.lbDonGia.Size = new System.Drawing.Size(54, 16);
            this.lbDonGia.TabIndex = 1;
            this.lbDonGia.Text = "Đơn giá";
            this.lbDonGia.Click += new System.EventHandler(this.lbDonGia_Click);
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.lbTongTien.Location = new System.Drawing.Point(180, 297);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(181, 22);
            this.lbTongTien.TabIndex = 1;
            this.lbTongTien.Text = "Tổng tiền thanh toán:";
            this.lbTongTien.Click += new System.EventHandler(this.lbDonGia_Click);
            // 
            // GiaTri
            // 
            this.GiaTri.AutoSize = true;
            this.GiaTri.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.GiaTri.Location = new System.Drawing.Point(506, 297);
            this.GiaTri.Name = "GiaTri";
            this.GiaTri.Size = new System.Drawing.Size(20, 22);
            this.GiaTri.TabIndex = 1;
            this.GiaTri.Text = "$";
            this.GiaTri.Click += new System.EventHandler(this.lbDonGia_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(73, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(203, 158);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmBai1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 359);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnTinhTien);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.lbSoLuong);
            this.Controls.Add(this.GiaTri);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.lbSoTien);
            this.Controls.Add(this.lbDonGia);
            this.Controls.Add(this.lbgiatri);
            this.Controls.Add(this.gbChonMau);
            this.Name = "frmBai1";
            this.Text = "ftmBai1";
            this.gbChonMau.ResumeLayout(false);
            this.gbChonMau.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbChonMau;
        private System.Windows.Forms.RadioButton rbTrang;
        private System.Windows.Forms.RadioButton rbXanh;
        private System.Windows.Forms.RadioButton rbDo;
        private System.Windows.Forms.Label lbgiatri;
        private System.Windows.Forms.Label lbSoLuong;
        private System.Windows.Forms.TextBox txtSoLuong;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.Button btnTinhTien;
        private System.Windows.Forms.Label lbSoTien;
        private System.Windows.Forms.Label lbDonGia;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label GiaTri;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}