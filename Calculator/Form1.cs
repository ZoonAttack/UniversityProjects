using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double number;
        double number2;
        double result;
        string option;


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            AllocConsole();
        }
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void One_Click(object sender, EventArgs e)
        {
            IoBox.Text += One.Text;
        }

        private void Two_Click(object sender, EventArgs e)
        {
            IoBox.Text += Two.Text;
        }

        private void Three_Click(object sender, EventArgs e)
        {
            IoBox.Text += Three.Text;
        }

        private void Four_Click(object sender, EventArgs e)
        {
            IoBox.Text += Four.Text;
        }

        private void Five_Click(object sender, EventArgs e)
        {
            IoBox.Text += Five.Text;
        }

        private void Six_Click(object sender, EventArgs e)
        {
            IoBox.Text += Six.Text;

        }

        private void Seven_Click(object sender, EventArgs e)
        {
            IoBox.Text += Seven.Text;
        }

        private void Eight_Click(object sender, EventArgs e)
        {
            IoBox.Text += Eight.Text;
        }

        private void Nine_Click(object sender, EventArgs e)
        {
            IoBox.Text += Nine.Text;
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            IoBox.Text += Zero.Text;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            IoBox.Clear();
            History.Clear();
            option = "";
            number = 0;
            number2 = 0;
            result = 0;
        }

        private void Equals_Click(object sender, EventArgs e)
        {
            Calculate();
            IoBox.Text = Convert.ToString(result);
            number = result;
        }

        private void Add_Click(object sender, EventArgs e)
        {
            option = "+";
            if (result == 0 && double.TryParse(IoBox.Text, out number))

                if (History.Text != null)
            {
                Calculate();
                IoBox.Clear();
            }
            History.Text = option;
        }
        private void Substract_Click(object sender, EventArgs e)
        {
            option = "-";
            if (result == 0 && double.TryParse(IoBox.Text, out number))
            if (History.Text != null)
            {
                Calculate();
                IoBox.Clear();
            }
            History.Text = option;
        }

        private void Multiply_Click(object sender, EventArgs e)
        {
            option = "*";
            if (result == 0 && double.TryParse(IoBox.Text, out number))
            if (History.Text != null)
            {
                Calculate();
                IoBox.Clear();
            }
            History.Text = option;
        }

        private void Divide_Click(object sender, EventArgs e)
        {
            option = "/";
            if (result == 0 && double.TryParse(IoBox.Text, out number))
            if (History.Text != null)
            {
                Calculate();
                IoBox.Clear();
            }
            History.Text = option;
        }

        private void Modulus_Click(object sender, EventArgs e)
        {
            option = "%";
            if (result == 0 && double.TryParse(IoBox.Text, out number))

                if (History.Text != null)
            {
                Calculate();
                IoBox.Clear();
            }
            History.Text = option;

        }
        private void Factorial_Click(object sender, EventArgs e)
        {
            if (double.TryParse(IoBox.Text, out number))
            {
                double factorial = number;
                for (double i = 2; i < factorial; i++)
                {
                    number *= i;
                    Console.WriteLine(number);
                }
                IoBox.Text = number.ToString();
            }
        }

        void Calculate()
        {
            if (double.TryParse(IoBox.Text, out number2))
            {
                if (option.Equals("+"))
                {
                    result = number + number2;
                }
                else if (option.Equals("-"))
                {
                    result = number - number2;
                }
                else if (option.Equals("*"))
                {
                    result = number * number2;

                }
                else if (option.Equals("/"))
                {
                    result = number / number2;

                }
                else if (option.Equals("%"))
                {
                    result = number % number2;
                }
            }
        }
        private void IoBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void History_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
