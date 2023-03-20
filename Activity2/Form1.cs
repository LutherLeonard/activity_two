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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            Wishlist.Items.Add("Water bottle");
            Wishlist.Items.Add("Mugs and Cups");
            Wishlist.Items.Add("Jugs and pitcher");
            Wishlist.Items.Add("Baby Cup");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Wishlist.Sorted = true;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Wishlist_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectionOutputBox.Text = Wishlist.Text;
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            Wishlist.Items.Clear();
        }

        private void Closebtn_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void CountBtn_Click(object sender, EventArgs e)
        {
            CountOutPutBox.Text = Convert.ToString(Wishlist.Items.Count);
        }

        private void CountOutPutBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
