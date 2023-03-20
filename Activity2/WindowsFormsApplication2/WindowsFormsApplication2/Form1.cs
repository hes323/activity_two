using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fill_Click(object sender, EventArgs e)
        {
            wishlist.Items.Add("Honda Click Fully Paid");
            wishlist.Items.Add("House and Lot Fully Paid");
            wishlist.Items.Add("Beach Resort");
            wishlist.Items.Add("Money");
        }

        private void sortBtn_Click(object sender, EventArgs e)
        {
            wishlist.Sorted = true;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            wishlist.Items.Clear();
        }

        private void countBtn_Click(object sender, EventArgs e)
        {
            countOutputBox.Text = Convert.ToString(wishlist.Items.Count);
        }

        private void wishlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            selectionOutputBox.Text = wishlist.Text;
        }


    }
}
