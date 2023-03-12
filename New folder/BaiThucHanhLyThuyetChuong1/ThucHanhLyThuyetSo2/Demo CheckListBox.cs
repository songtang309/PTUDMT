using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ThucHanhLyThuyetSo2
{
    public partial class Demo_CheckListBox : Form
    {
        public Demo_CheckListBox()
        {
            InitializeComponent();
        }

        private void ckbMonHoc_SelectedIndexChanged(object sender, EventArgs e)
        {
            CheckedListBox.CheckedItemCollection items;
            items = this.clbMonHoc.CheckedItems;
            string s = "";
            foreach (object ob in items)
            {
                s += ob.ToString() + ",";
             }
            MessageBox.Show("Danh sách môn học:" + s);
        }

        private void ckbMonHoc_SelectedValueChanged(object sender, EventArgs e)
        {
       
        }

    }
}
