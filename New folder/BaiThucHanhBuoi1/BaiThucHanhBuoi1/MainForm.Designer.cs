﻿namespace BaiThucHanhBuoi1
{
    partial class MainForm
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
            this.txtTên = new System.Windows.Forms.TextBox();
            this.btnXửLý = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSaoChep = new System.Windows.Forms.TextBox();
            this.btnSaoChep = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nhập tên của bạn";
            // 
            // txtTên
            // 
            this.txtTên.Location = new System.Drawing.Point(160, 95);
            this.txtTên.Name = "txtTên";
            this.txtTên.Size = new System.Drawing.Size(207, 20);
            this.txtTên.TabIndex = 1;
            this.txtTên.TextChanged += new System.EventHandler(this.txtTên_TextChanged);
            // 
            // btnXửLý
            // 
            this.btnXửLý.Location = new System.Drawing.Point(213, 132);
            this.btnXửLý.Name = "btnXửLý";
            this.btnXửLý.Size = new System.Drawing.Size(75, 23);
            this.btnXửLý.TabIndex = 2;
            this.btnXửLý.Text = "Xử lý";
            this.btnXửLý.UseVisualStyleBackColor = true;
            this.btnXửLý.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 192);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tên bạn đã sao chép";
            // 
            // txtSaoChep
            // 
            this.txtSaoChep.Location = new System.Drawing.Point(160, 185);
            this.txtSaoChep.Name = "txtSaoChep";
            this.txtSaoChep.ReadOnly = true;
            this.txtSaoChep.Size = new System.Drawing.Size(207, 20);
            this.txtSaoChep.TabIndex = 4;
            // 
            // btnSaoChep
            // 
            this.btnSaoChep.Location = new System.Drawing.Point(213, 233);
            this.btnSaoChep.Name = "btnSaoChep";
            this.btnSaoChep.Size = new System.Drawing.Size(75, 23);
            this.btnSaoChep.TabIndex = 2;
            this.btnSaoChep.Text = "Sao chép";
            this.btnSaoChep.UseVisualStyleBackColor = true;
            this.btnSaoChep.Click += new System.EventHandler(this.btnSaoChép_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSaoChep);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnSaoChep);
            this.Controls.Add(this.btnXửLý);
            this.Controls.Add(this.txtTên);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Chương Trình Đầu Tiên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTên;
        private System.Windows.Forms.Button btnXửLý;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSaoChep;
        private System.Windows.Forms.Button btnSaoChep;
    }
}

