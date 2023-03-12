namespace ThucHanhLyThuyetSo2
{
    partial class ListBox
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
            this.lbDanhSach = new System.Windows.Forms.ListBox();
            this.lbDanhSachChon = new System.Windows.Forms.ListBox();
            this.btnChon = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.lblDanhSach = new System.Windows.Forms.Label();
            this.lblDanhSachChon = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbDanhSach
            // 
            this.lbDanhSach.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbDanhSach.FormattingEnabled = true;
            this.lbDanhSach.ItemHeight = 16;
            this.lbDanhSach.Items.AddRange(new object[] {
            "Phạm Vũ Ngọc Hà",
            "Hoàng Văn Hùng",
            "Lê Thị Vân",
            "Nguyễn Thị Thu",
            "Lê Văn Quốc",
            "Lê Văn Phước",
            "Trương Văn Dũng"});
            this.lbDanhSach.Location = new System.Drawing.Point(22, 81);
            this.lbDanhSach.MultiColumn = true;
            this.lbDanhSach.Name = "lbDanhSach";
            this.lbDanhSach.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.lbDanhSach.Size = new System.Drawing.Size(210, 196);
            this.lbDanhSach.TabIndex = 0;
            this.lbDanhSach.SelectedIndexChanged += new System.EventHandler(this.lbDanhSach_SelectedIndexChanged);
            // 
            // lbDanhSachChon
            // 
            this.lbDanhSachChon.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbDanhSachChon.FormattingEnabled = true;
            this.lbDanhSachChon.ItemHeight = 16;
            this.lbDanhSachChon.Location = new System.Drawing.Point(326, 81);
            this.lbDanhSachChon.MultiColumn = true;
            this.lbDanhSachChon.Name = "lbDanhSachChon";
            this.lbDanhSachChon.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lbDanhSachChon.Size = new System.Drawing.Size(210, 196);
            this.lbDanhSachChon.TabIndex = 0;
            // 
            // btnChon
            // 
            this.btnChon.Location = new System.Drawing.Point(252, 146);
            this.btnChon.Name = "btnChon";
            this.btnChon.Size = new System.Drawing.Size(68, 28);
            this.btnChon.TabIndex = 1;
            this.btnChon.Text = "Chọn";
            this.btnChon.UseVisualStyleBackColor = true;
            this.btnChon.Click += new System.EventHandler(this.btnChon_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(252, 216);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(68, 28);
            this.btnXoa.TabIndex = 1;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // lblDanhSach
            // 
            this.lblDanhSach.AutoSize = true;
            this.lblDanhSach.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDanhSach.Location = new System.Drawing.Point(19, 53);
            this.lblDanhSach.Name = "lblDanhSach";
            this.lblDanhSach.Size = new System.Drawing.Size(148, 16);
            this.lblDanhSach.TabIndex = 2;
            this.lblDanhSach.Text = "Danh sách sinh viên lớp";
            // 
            // lblDanhSachChon
            // 
            this.lblDanhSachChon.AutoSize = true;
            this.lblDanhSachChon.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblDanhSachChon.Location = new System.Drawing.Point(323, 53);
            this.lblDanhSachChon.Name = "lblDanhSachChon";
            this.lblDanhSachChon.Size = new System.Drawing.Size(180, 16);
            this.lblDanhSachChon.TabIndex = 2;
            this.lblDanhSachChon.Text = "Danh sách sinh viên tham gia";
            // 
            // ListBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblDanhSachChon);
            this.Controls.Add(this.lblDanhSach);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnChon);
            this.Controls.Add(this.lbDanhSachChon);
            this.Controls.Add(this.lbDanhSach);
            this.Name = "ListBox";
            this.Text = "ListBox";
            this.Load += new System.EventHandler(this.frmListBox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbDanhSach;
        private System.Windows.Forms.ListBox lbDanhSachChon;
        private System.Windows.Forms.Button btnChon;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Label lblDanhSach;
        private System.Windows.Forms.Label lblDanhSachChon;
    }
}