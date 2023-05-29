namespace Lab07
{
    partial class Form1
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
            this.lblCoTatCa = new System.Windows.Forms.Label();
            this.dgvFoodList = new System.Windows.Forms.DataGridView();
            this.lblMonAn = new System.Windows.Forms.Label();
            this.lblQuanity = new System.Windows.Forms.Label();
            this.lblCatName = new System.Windows.Forms.Label();
            this.cbbCategory = new System.Windows.Forms.ComboBox();
            this.lblChonMonAn = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).BeginInit();
            this.SuspendLayout();
            // 
            // lblCoTatCa
            // 
            this.lblCoTatCa.AutoSize = true;
            this.lblCoTatCa.Location = new System.Drawing.Point(32, 425);
            this.lblCoTatCa.Name = "lblCoTatCa";
            this.lblCoTatCa.Size = new System.Drawing.Size(59, 16);
            this.lblCoTatCa.TabIndex = 2;
            this.lblCoTatCa.Text = "Có tất cả";
            this.lblCoTatCa.Click += new System.EventHandler(this.label1_Click);
            // 
            // dgvFoodList
            // 
            this.dgvFoodList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFoodList.Location = new System.Drawing.Point(0, 63);
            this.dgvFoodList.MultiSelect = false;
            this.dgvFoodList.Name = "dgvFoodList";
            this.dgvFoodList.RowHeadersWidth = 51;
            this.dgvFoodList.RowTemplate.Height = 24;
            this.dgvFoodList.Size = new System.Drawing.Size(798, 342);
            this.dgvFoodList.TabIndex = 3;
            // 
            // lblMonAn
            // 
            this.lblMonAn.AutoSize = true;
            this.lblMonAn.Location = new System.Drawing.Point(203, 425);
            this.lblMonAn.Name = "lblMonAn";
            this.lblMonAn.Size = new System.Drawing.Size(122, 16);
            this.lblMonAn.TabIndex = 2;
            this.lblMonAn.Text = "món ăn thuộc nhóm";
            this.lblMonAn.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblQuanity
            // 
            this.lblQuanity.AutoSize = true;
            this.lblQuanity.Location = new System.Drawing.Point(144, 425);
            this.lblQuanity.Name = "lblQuanity";
            this.lblQuanity.Size = new System.Drawing.Size(16, 16);
            this.lblQuanity.TabIndex = 2;
            this.lblQuanity.Text = "...";
            this.lblQuanity.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblCatName
            // 
            this.lblCatName.AutoSize = true;
            this.lblCatName.Location = new System.Drawing.Point(359, 425);
            this.lblCatName.Name = "lblCatName";
            this.lblCatName.Size = new System.Drawing.Size(16, 16);
            this.lblCatName.TabIndex = 2;
            this.lblCatName.Text = "...";
            this.lblCatName.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbbCategory
            // 
            this.cbbCategory.FormattingEnabled = true;
            this.cbbCategory.Location = new System.Drawing.Point(268, 22);
            this.cbbCategory.Name = "cbbCategory";
            this.cbbCategory.Size = new System.Drawing.Size(249, 24);
            this.cbbCategory.TabIndex = 4;
            this.cbbCategory.SelectedIndexChanged += new System.EventHandler(this.cbbCategory_SelectedIndexChanged);
            // 
            // lblChonMonAn
            // 
            this.lblChonMonAn.AutoSize = true;
            this.lblChonMonAn.Location = new System.Drawing.Point(116, 25);
            this.lblChonMonAn.Name = "lblChonMonAn";
            this.lblChonMonAn.Size = new System.Drawing.Size(124, 16);
            this.lblChonMonAn.TabIndex = 2;
            this.lblChonMonAn.Text = "Chọn nhóm món ăn:";
            this.lblChonMonAn.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 464);
            this.Controls.Add(this.cbbCategory);
            this.Controls.Add(this.dgvFoodList);
            this.Controls.Add(this.lblChonMonAn);
            this.Controls.Add(this.lblMonAn);
            this.Controls.Add(this.lblCatName);
            this.Controls.Add(this.lblQuanity);
            this.Controls.Add(this.lblCoTatCa);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFoodList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCoTatCa;
        private System.Windows.Forms.DataGridView dgvFoodList;
        private System.Windows.Forms.Label lblMonAn;
        private System.Windows.Forms.Label lblQuanity;
        private System.Windows.Forms.Label lblCatName;
        private System.Windows.Forms.ComboBox cbbCategory;
        private System.Windows.Forms.Label lblChonMonAn;
    }
}

