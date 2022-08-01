using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee_corner
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int total = 0;
            listBox1.Items.Clear();
            listBox1.Items.Add("welcome to coffee corner");
            listBox1.Items.Add("hello" + textBox1.Text);
            if (checkBox1.Checked)
            {
                int tea = (int)numericUpDown1.Value;
                int temp = 10 * tea;
                total += temp;
                listBox1.Items.Add("your tea amount is:" + temp);
            }
            if (checkBox2.Checked)
            {
                int coffee = (int)numericUpDown2.Value;
                int temp = 20 * coffee;
                total += temp;
                listBox1.Items.Add("your coffee amount is:" + temp);
            }
            if (checkBox3.Checked)
            {
                int cookies = (int)numericUpDown2.Value;
                int temp = 5 * cookies;
                total += temp;
                listBox1.Items.Add("your cookies amount is:" + temp);
            }
            if (checkBox4.Checked)
            {
                int snacks = (int)numericUpDown2.Value;
                int temp = 10 * snacks;
                total += temp;
                listBox1.Items.Add("your snacks amount is:" + temp);
            }
                listBox1.Items.Add("your total amount is:" + total);

                






        }
    }
}
