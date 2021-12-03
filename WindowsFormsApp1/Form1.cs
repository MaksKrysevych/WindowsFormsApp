using System;
using System.Windows.Forms;
using System.Windows;
using System.Data;
using System.Windows.Input;
using System.Media;
using System.Diagnostics;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text = "Enter a message here";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show(textBox1.Text);
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                textBox1.Enabled = true;
            }
            else
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                textBox1.Enabled = false;
            }

        }

        private void checkBox2_Click(object sender, EventArgs e)
        {
            if (checkBox2.Checked == true)
            {
                button5.Enabled = true;
                comboBox1.Enabled = true;
            }
            else
            {
                button5.Enabled = false;
                comboBox1.Enabled = false;
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked == true)
            {
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                textBox1.Visible = true;
                label1.Visible = true;
            }
            else
            {
                button2.Visible = false;
                button3.Visible = false;
                button4.Visible = false;
                textBox1.Visible = false;
                label1.Visible = false;
            }
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox4.Checked == true)
            {
                button5.Visible = true;
                comboBox1.Visible = true;
                label2.Visible = true;
            }
            else
            {
                button5.Visible = false;
                comboBox1.Visible = false;
                label2.Visible = false;
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Time: 500ms" + "\n" +"Frequency: 1000hz");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int time = rnd.Next(100, 1000);
            int frequency = rnd.Next(20, 20000);
            string str = String.Format("Time: {0} ms\nFrequency: {1} hz", time, frequency);
            MessageBox.Show(str);
        }
    }
}
