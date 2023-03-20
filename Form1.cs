using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fillBttn_Click(object sender, EventArgs e)
        {
            wishList.Items.Add("iPhone Pro Max 14 Fully Paid");
            wishList.Items.Add("Joola Pro Blast Shoes");
            wishList.Items.Add("Butterfly Tenergy 05 Rubber");
            wishList.Items.Add("ZJK BLADE");
            wishList.Items.Add("House & Lot");
        }

        private void wishList_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectionOutputBox.Text = wishList.Text;
        }

        private void closeBttn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void sortBttn_Click(object sender, EventArgs e)
        {
            wishList.Sorted = true;
        }

        private void clearBttn_Click(object sender, EventArgs e)
        {
            wishList.Items.Clear();
        }

        private void countBttn_Click(object sender, EventArgs e)
        {
            countOutputBox.Text = Convert.ToString(wishList.Items.Count);
        }
    }
}
