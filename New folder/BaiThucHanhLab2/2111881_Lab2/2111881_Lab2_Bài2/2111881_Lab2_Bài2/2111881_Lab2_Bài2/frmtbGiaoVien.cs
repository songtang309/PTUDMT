using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2111881_Lab2_Bài2
{
    public partial class frmtbGiaoVien : Form
    {

        public frmtbGiaoVien()
        {
            InitializeComponent();
        }
        public void SetText(string s)
        {
            this.lblThongBao.Text = s;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
