using System;
using System.Data;
using System.Linq.Expressions;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Calculator : Form
    {

        String current = "";
        String previous = "";

        public Calculator()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            current += "1";
            textIO.Text = current;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            current += "2";
            textIO.Text = current;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            current += "3";
            textIO.Text = current;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            current += "4";
            textIO.Text = current;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            current += "5";
            textIO.Text = current;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            current += "6";
            textIO.Text = current;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            current += "7";
            textIO.Text = current;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            current += "8";
            textIO.Text = current;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            current += "9";
            textIO.Text = current;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            current += "0";
            textIO.Text = current;
        }

        private void buttonBackspace_Click(object sender, EventArgs e)
        {
            if (!current.Equals(""))
            {
                current = current.Remove(current.Length - 1);
                textIO.Text = current;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            previous = current;
            current = "";
            textIO.Text = current;

        }

        private void buttonRevert_Click(object sender, EventArgs e)
        {
            String temp = current;
            current = previous;
            previous = temp;
            textIO.Text = current;
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (current.Length != 0)
            {
                char lastChar = current[current.Length - 1];
                if (lastChar != '+'
                & lastChar != '-'
                & lastChar != '*'
                & lastChar != '/')
                {
                    current += "+";
                    textIO.Text = current;
                }
                else
                {
                    MessageBox.Show("Invalid Operation!");
                }
            }
        }

        private void buttonSubtract_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (current.Length != 0)
            {
                char lastChar = current[current.Length - 1];
                if (lastChar != '+'
                & lastChar != '-'
                & lastChar != '*'
                & lastChar != '/')
                {
                    current += "-";
                    textIO.Text = current;
                }
                else
                {
                    MessageBox.Show("Invalid Operation!");
                }
            }
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (current.Length != 0)
            {
                char lastChar = current[current.Length - 1];
                if (lastChar != '+'
                & lastChar != '-'
                & lastChar != '*'
                & lastChar != '/')
                {
                    current += "*";
                    textIO.Text = current;
                }
                else
                {
                    MessageBox.Show("Invalid Operation!");
                }
            }
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (current.Length != 0)
            {
                char lastChar = current[current.Length - 1];
                if (lastChar != '+'
                & lastChar != '-'
                & lastChar != '*'
                & lastChar != '/')
                {
                    current += "/";
                    textIO.Text = current;
                }
                else
                {
                    MessageBox.Show("Invalid Operation!");
                }
            }
        }

        private void buttonOpen_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            current += "(";
            textIO.Text = current;
        }

        private void buttonClose_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            current += ")";
            textIO.Text = current;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            if (current.Equals("")) return;

            if(!isBalanced(current))
            {
                MessageBox.Show("Unbalanced Parentheses!");
                return;
            }

            try
            {
                var result = new DataTable().Compute(current, "");
                previous = current;
                current = result.ToString();
                textIO.Text = current;
            } 
            catch (Exception ex)
            {
                MessageBox.Show("Invalid expression: " + ex.Message);
            }
        }

        private bool isBalanced(string expr)
        {
            int count = 0;
            foreach (char c in expr)
            {
                if (c == '(') count++;
                else if (c == ')')
                {
                    count--;
                    if (count < 0) return false;
                }
            }
            return count == 0;
        }
    }
}