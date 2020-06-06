using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace text
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton1.Checked == true)
            {
                string text = textBox1.Text;
                text = text.Replace("a", "4").Replace("A", "4").Replace("i", "1").Replace("I", "1").Replace("e", "3").Replace("E", "3").Replace("o", "0").Replace("O", "0");
                textBox2.Text = text;
            }

            if(radioButton2.Checked == true)
            {
                string text = textBox1.Text;
                text = text.Replace("a", "@").Replace("A", "@").Replace("i", "!").Replace("I", "!").Replace("e", "3").Replace("E", "3").Replace("o", "0").Replace("O", "0");
                textBox2.Text = text;
            }

            if(radioButton3.Checked ==true)
            {
                string text = textBox1.Text;
                text = text.Replace("h", "|-|").Replace("H", "|-|").Replace("m", @"|\/|").Replace("M", @"|\/|").Replace("n", @"|\|").Replace("N", @"|\|").Replace("w", @"\/\/").Replace("W", @"\/\/").Replace("u", "|_|").Replace("U", "|_|").Replace("v", @"\/").Replace("V", @"\/").Replace("b", "|>").Replace("B", "|>");
                textBox2.Text = text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }
    }
}
