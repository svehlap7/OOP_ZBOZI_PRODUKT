using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOP_ZBOZI_PRODUKT
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Zbozi zbozi = new Zbozi(textBox1.Text, Convert.ToInt32(textBox2.Text), dateTimePicker1.Value, Convert.ToInt32(textBox3.Text));
            MessageBox.Show(zbozi.ToString());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Produkt produkt = new Produkt(textBox1.Text, Convert.ToInt32(textBox2.Text), dateTimePicker1.Value, Convert.ToInt32(textBox3.Text), true);
            MessageBox.Show(produkt.ToString());
        }
    }
}
