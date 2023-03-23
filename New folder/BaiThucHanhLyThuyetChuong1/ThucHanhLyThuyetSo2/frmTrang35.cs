using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanhLyThuyetSo2
{
    public partial class frmTrang35 : Form
    {
        public frmTrang35()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblDiaChi_Click(object sender, EventArgs e)
        {

        }


        private void frmTrang35_Load(object sender, EventArgs e)
        {
            string strURl = "mailto:ctk45@gmail.com";
            this.linkLabel1.Links.Add(0, strURl.Length, strURl);
            strURl = "http://www.ctk45b.dlu.com";
            this.linkLabel2.Links.Add(0, strURl.Length, strURl);
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strURl = Convert.ToString(e.Link.LinkData);
            if (strURl.StartsWith("mailto:"))
                Process.Start(strURl + "?subject=hello");

        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string strURl = Convert.ToString(e.Link.LinkData);
            if (strURl.StartsWith("https://www.ctk45.com"))
            {
                Process.Start(strURl); 
            }
        }
    }
}
