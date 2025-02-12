using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {

        public double sum=0;
        public int var = 0;
        public String fnc = "+";

        public Form1()
        {
            InitializeComponent();
            textBox1.Text = sum.ToString("0");            
            
        }


        private void button1_Click(object sender, EventArgs e)
        {
            var = 1;
            if(textBox1.Text == "0")
                textBox1.Text = "1";
            else
                textBox1.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var = 2;
            if (textBox1.Text == "0")
                textBox1.Text = "2";
            else
                textBox1.Text += "2";
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            sum=calc(textBox1.Text);
            textBox1.Text = sum.ToString();
        }

        public double calc(string expression)
        {
            var dataTable = new System.Data.DataTable();
            var result = Convert.ToDouble(dataTable.Compute(expression, String.Empty));
            return result;

        }

        private void pls_Click(object sender, EventArgs e)
        {
            char c = textBox1.Text[textBox1.Text.Length - 1];
            fnc = "+";
            if (c == '-' || c == '+' || c == '*' || c == '/')
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1) + "+";
            else
                textBox1.Text += "+";
        }

        private void min_Click(object sender, EventArgs e)
        {
            char c = textBox1.Text[textBox1.Text.Length - 1];
            fnc = "-";

            if (c == '-' || c == '+' || c == '*' || c == '/')
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1) + "-";
            else
                textBox1.Text += "-";
        }
        private void butMulti_Click(object sender, EventArgs e)
        {
            char c = textBox1.Text[textBox1.Text.Length - 1];
            fnc = "*";
            if (c == '-' || c == '+' || c == '*' || c == '/')
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1) + "*";
            else
                textBox1.Text += "*";
        }

        private void butDiv_Click(object sender, EventArgs e)
        {
            char c = textBox1.Text[textBox1.Text.Length - 1];
            fnc = "/";
            if (c == '-' || c == '+' || c == '*' || c == '/')
                textBox1.Text = textBox1.Text.Remove(textBox1.Text.Length - 1) + "/";
            else
                textBox1.Text += "/";
        }
        private void button3_Click(object sender, EventArgs e)
        {

            var = 3;
            if (textBox1.Text == "0")
                textBox1.Text = "3";
            else
                textBox1.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {

            var = 4;
            if (textBox1.Text == "0")
                textBox1.Text = "4";
            else
                textBox1.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {

            var = 5;
            if (textBox1.Text == "0")
                textBox1.Text = "5";
            else
                textBox1.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var = 6;
            if (textBox1.Text == "0")
                textBox1.Text = "6";
            else
                textBox1.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var = 7;
            if (textBox1.Text == "0")
                textBox1.Text = "7";
            else
                textBox1.Text += "7";

        }

        private void button8_Click(object sender, EventArgs e)
        {
            var = 8;
            if (textBox1.Text == "0")
                textBox1.Text = "8";
            else
                textBox1.Text += "8";

        }

        private void button9_Click(object sender, EventArgs e)
        {
            var = 9;
            if (textBox1.Text == "0")
                textBox1.Text = "9";
            else
                textBox1.Text += "9";

        }

        private void button0_Click(object sender, EventArgs e)
        {
            var = 0;
            if (textBox1.Text == "0")
                textBox1.Text = "0";
            else
                textBox1.Text += "0";

        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
