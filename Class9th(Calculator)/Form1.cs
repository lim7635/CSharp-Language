using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class9th_Calculator_
{
    public partial class Form1 : Form
    {
        enum Operator
        {
            None,
            Plus,
            Minus,
            Multiply,
            Divide,
            Result
        }

        Operator curoperator = Operator.None;
        Boolean operatorchangeflag = false;
        int firstoperand = 0;
        int secondoperand = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if(operatorchangeflag == true)
            {
                display.Text = "";
                operatorchangeflag = false;
            }

            string strnumber = display.Text += "0";
            int intnumber = Int32.Parse(strnumber);
            display.Text = intnumber.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (operatorchangeflag == true)
            {
                display.Text = "";
                operatorchangeflag = false;
            }

            string strnumber = display.Text += "1";
            int intnumber = Int32.Parse(strnumber);
            display.Text = intnumber.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (operatorchangeflag == true)
            {
                display.Text = "";
                operatorchangeflag = false;
            }

            string strnumber = display.Text += "2";
            int intnumber = Int32.Parse(strnumber);
            display.Text = intnumber.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (operatorchangeflag == true)
            {
                display.Text = "";
                operatorchangeflag = false;
            }

            string strnumber = display.Text += "3";
            int intnumber = Int32.Parse(strnumber);
            display.Text = intnumber.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (operatorchangeflag == true)
            {
                display.Text = "";
                operatorchangeflag = false;
            }

            string strnumber = display.Text += "4";
            int intnumber = Int32.Parse(strnumber);
            display.Text = intnumber.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (operatorchangeflag == true)
            {
                display.Text = "";
                operatorchangeflag = false;
            }

            string strnumber = display.Text += "5";
            int intnumber = Int32.Parse(strnumber);
            display.Text = intnumber.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (operatorchangeflag == true)
            {
                display.Text = "";
                operatorchangeflag = false;
            }

            string strnumber = display.Text += "6";
            int intnumber = Int32.Parse(strnumber);
            display.Text = intnumber.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (operatorchangeflag == true)
            {
                display.Text = "";
                operatorchangeflag = false;
            }

            string strnumber = display.Text += "7";
            int intnumber = Int32.Parse(strnumber);
            display.Text = intnumber.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (operatorchangeflag == true)
            {
                display.Text = "";
                operatorchangeflag = false;
            }

            string strnumber = display.Text += "8";
            int intnumber = Int32.Parse(strnumber);
            display.Text = intnumber.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (operatorchangeflag == true)
            {
                display.Text = "";
                operatorchangeflag = false;
            }

            string strnumber = display.Text += "9";
            int intnumber = Int32.Parse(strnumber);
            display.Text = intnumber.ToString();
        }

        private void buttondelete_Click(object sender, EventArgs e)
        {
            firstoperand = 0;
            secondoperand = 0;
            curoperator = Operator.None;
            display.Text = "0";
        }

        private void buttondot_Click(object sender, EventArgs e)
        {

        }

        private void buttonresult_Click(object sender, EventArgs e)
        {
            secondoperand = Int32.Parse(display.Text);
            if(curoperator == Operator.Plus)
            {
                firstoperand += secondoperand;
                display.Text = firstoperand.ToString();
            }
            else if(curoperator == Operator.Minus)
            {
                firstoperand -= secondoperand;
                display.Text = firstoperand.ToString();
            }
            else if (curoperator == Operator.Multiply)
            {
                firstoperand *= secondoperand;
                display.Text = firstoperand.ToString();
            }
            else if (curoperator == Operator.Divide)
            {
                if(secondoperand == 0)
                {
                    display.Text = "0으로 나눌 수 없습니다.";
                }
                else
                {
                    firstoperand /= secondoperand;
                    display.Text = firstoperand.ToString();
                }
            }
        }

        private void buttonplus_Click(object sender, EventArgs e)
        {
            firstoperand = Int32.Parse(display.Text);
            curoperator = Operator.Plus;
            operatorchangeflag = true;
        }

        private void buttonminus_Click(object sender, EventArgs e)
        {
            firstoperand = Int32.Parse(display.Text);
            curoperator = Operator.Minus;
            operatorchangeflag = true;
        }

        private void buttonmultiply_Click(object sender, EventArgs e)
        {
            firstoperand = Int32.Parse(display.Text);
            curoperator = Operator.Multiply;
            operatorchangeflag = true;
        }

        private void buttondivide_Click(object sender, EventArgs e)
        {
            firstoperand = Int32.Parse(display.Text);
            curoperator = Operator.Divide;
            operatorchangeflag = true;
        }
    }
}
