using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace rehberdeneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            label9.Text = textBox1.Text;
            label10.Text = textBox2.Text;
            label11.Text = comboBox1.Text;
            label12.Text = textBox4.Text;
            //combobox eleman ekleme

            comboBox2.Items.Add("istanbul");
            comboBox2.Items.Add("izmir");
            comboBox2.Items.Add("ankara");
            comboBox2.Items.Add("trabzon");
        }
    }
}
