using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Arac_Kullanimlari
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add("Bayburt");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            comboBox2.Items.Add(textBox1.Text);
            label4.Text = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            listBox2.Items.Add("Samantha Carter");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            listBox3.Items.Add("Nicholas Rush");
            listBox3.Items.Add("Nicholas Rush");
            listBox3.Items.Add("Nicholas Rush");
            listBox3.Items.Add("Nicholas Rush");
            listBox3.Items.Add("Nicholas Rush");
            listBox3.Items.Add("Nicholas Rush");
            listBox3.Items.Add("Nicholas Rush");
            listBox3.Items.Add("Nicholas Rush");
            listBox3.Items.Add("Nicholas Rush");
            listBox3.Items.Add("Nicholas Rush");

        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox3.Text);
        }
    }
}
