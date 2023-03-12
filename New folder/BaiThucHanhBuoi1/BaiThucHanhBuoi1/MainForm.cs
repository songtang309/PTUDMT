using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaiThucHanhBuoi1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

            //Click đôi vào nút chương trình sẽ tự dộng tạo hàm sự kiện này
        private void btnOK_Click(object sender, EventArgs e)
        {
            var tenDaNhap = txtTên.Text;

            MessageBox.Show($"Xin chào bạn {tenDaNhap}. Rất vui được gặp bạn", "Thông điệp chào mừng"); 

        }

        private void btnSaoChép_Click(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTên.Text;
        }

        private void txtTên_TextChanged(object sender, EventArgs e)
        {
            txtSaoChep.Text = txtTên.Text;
        }
    }
}
