using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        util util = new util();

        private void buttonSum_Click(object sender, EventArgs e) 
        {
            util.Solution(textBox1, labelMinus);
        }

        private void button_plus_Click(object sender, EventArgs e) //plus
        {
            util.Operation(textBox1, 0, labelMinus);
        }

        private void button11_Click(object sender, EventArgs e) //minus
        {
            util.Operation(textBox1, 1, labelMinus);
        }

        private void button12_Click(object sender, EventArgs e) //multiply
        {
            util.Operation(textBox1, 2, labelMinus);
        }

        private void button13_Click(object sender, EventArgs e) //divide
        {
            util.Operation(textBox1, 3, labelMinus);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            util.reading("1", textBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            util.reading("2", textBox1);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            util.reading("3", textBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            util.reading("4", textBox1);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            util.reading("5", textBox1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            util.reading("6", textBox1);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            util.reading("7", textBox1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            util.reading("8", textBox1);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            util.reading("9", textBox1);
        }

        private void button0_Click(object sender, EventArgs e)
        {
            util.reading("0", textBox1);
        }


        private void button16_Click(object sender, EventArgs e) //clear
        {
            util.Clear(textBox1, labelMinus);
        }

        private void button15_Click(object sender, EventArgs e) //point
        {
            //readNum(",");
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void buttonReverseMinus_Click(object sender, EventArgs e)
        {
            util.ReverseMinus(labelMinus);
        }
    }
}
