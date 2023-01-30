using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cacl_Nguyen18ct1
{
    public partial class frmnguyen : Form
    {
        public Double result = 0;
        public Double num1 = 0;
        public String str1 = "";
        public String operation = "";
        public String operation1 = "";
        public bool operationselect = false;
        public bool secondnum = false;
        bool value=false;
        public frmnguyen()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (operationselect))
            {
                textBox1.Text = "";
            }
            if (textBox1.Text == "-0")
            {
                textBox1.Text = "-";
            }
            Button b = (Button)sender;
            textBox1.Text = textBox1.Text + b.Text;
            operationselect = false;
            secondnum = true;
            value = true;

        }

        private void button17_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
            textBox2.Text = "";
            result = 0;
            operation = "";
            operation1 = "";
            value = false;
            operationselect = false;
            secondnum = false;
            num1 = 0;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if ((textBox1.Text == "0") || (operationselect))
            {
                textBox1.Text = "";
            }
            if(textBox1.Text=="-0")
            {
                textBox1.Text = "-0";
            }
            else
            {
                Button b = (Button)sender;
                textBox1.Text = textBox1.Text + b.Text;
                operationselect = false;
                secondnum = true;
                value = true;
            }
        }

        private void button_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text = textBox1.Text + ".";
            }
            operationselect = false;
            secondnum = true;
            value = true;
        }

        private void buttonPT_Click(object sender, EventArgs e)
        {
            result = Double.Parse(textBox1.Text);
            textBox1.Text = "";
            textBox1.Text = (result / 100).ToString();
            operationselect = true;
            textBox2.Text = result + "%";
            value = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
            textBox1.Text = "0";
        }

        private void button21_Click(object sender, EventArgs e)
        {
            str1 = textBox2.Text.ToString();
            if ((textBox1.Text != "") && (str1.Length > 1))
            {
                textBox2.Text = str1.Substring(0, str1.Length - 1);
            }
            else
            {
                textBox2.Text = "";
            }
            operationselect = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (operation1 != "")
            {
                switch (operation1)
                {
                    case "+":
                        textBox2.Text = textBox2.Text + " " + operation + " " + textBox1.Text;
                        switch (operation)
                        {
                            case "x":
                                textBox1.Text = (num1 + (result * Double.Parse(textBox1.Text))).ToString();
                                break;
                            case ":":
                                textBox1.Text = (num1 + (result / (Double.Parse(textBox1.Text)))).ToString();
                                break;
                            default:
                                break;
                        }
                        operation1 = operation;
                        break;
                    case "-":
                        textBox2.Text = textBox2.Text + " " + operation + " " + textBox1.Text;
                        switch (operation)
                        {
                            case "x":
                                textBox1.Text = (num1 - (result * Double.Parse(textBox1.Text))).ToString();
                                break;
                            case ":":
                                textBox1.Text = (num1 - (result / (Double.Parse(textBox1.Text)))).ToString();
                                break;
                            default:
                                break;
                        }
                        operation1 = operation;
                        break;
                    case "x":
                        textBox2.Text = textBox2.Text + " " + operation + " " + textBox1.Text;
                        switch (operation)
                        {
                            case "x":
                                textBox1.Text = (num1 + ((result - num1) * Double.Parse(textBox1.Text))).ToString();
                                break;
                            case ":":
                                textBox1.Text = (num1 - ((-1 * result + num1) * (Double.Parse(textBox1.Text)))).ToString();
                                break;
                            default:
                                break;
                        }
                        operation1 = operation;
                        break;
                    case ":":
                        textBox2.Text = textBox2.Text + " " + operation + " " + textBox1.Text;
                        switch (operation)
                        {
                            case "x":
                                textBox1.Text = (num1 + ((result - num1) / Double.Parse(textBox1.Text))).ToString();
                                break;
                            case ":":
                                textBox1.Text = (num1 - ((-1 * result + num1) / (Double.Parse(textBox1.Text)))).ToString();
                                break;
                            default:
                                break;
                        }
                        operation1 = operation;
                        break;
                    default:
                        break;
                }
                result = Double.Parse(textBox1.Text);
                secondnum = false;
                operationselect = true;
                value = true;
            }
            else
            {
                switch (operation)
                {
                    case "+":
                        textBox2.Text = textBox2.Text + " " + operation + " " + textBox1.Text;
                        result = result + (Double.Parse(textBox1.Text));
                        textBox1.Text = result.ToString();
                        break;
                    case "-":
                        textBox2.Text = textBox2.Text + " " + operation + " " + textBox1.Text;
                        textBox1.Text = (result - (Double.Parse(textBox1.Text))).ToString();
                        break;
                    case "x":
                        textBox2.Text = textBox2.Text + " " + operation + " " + textBox1.Text;
                        textBox1.Text = (result * (Double.Parse(textBox1.Text))).ToString();
                        break;
                    case ":":
                        textBox2.Text = textBox2.Text + " " + operation + " " + textBox1.Text;
                        textBox1.Text = (result / (Double.Parse(textBox1.Text))).ToString();
                        break;
                    default:
                        textBox2.Text = textBox1.Text;
                        break;
                }
                result = Double.Parse(textBox1.Text);
                secondnum = false;
                operationselect = true;
                value = true;
            }

        }

        private void operator_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (secondnum == true)
            {
                if ((textBox1.Text == "0") || (operationselect))
                {
                    textBox1.Text = "";
                }
                button12.PerformClick();
                operationselect = true;
                operation = b.Text;
                value = false;
            }
            else
            {
                operation = b.Text;
                result = Double.Parse(textBox1.Text);
                operationselect = true;
                secondnum = false;
                value = false;
            }
        }

        private void operatorx_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            if (secondnum == true)
            {
                if ((textBox1.Text == "0") || (operationselect))
                {
                    textBox1.Text = "";
                }
                if (operation1 != "")
                {
                    switch (operation1)
                    {
                        case "+":
                            textBox2.Text = textBox2.Text + " " + operation + " " + textBox1.Text;
                            switch (operation)
                            {
                                case "x":
                                    textBox1.Text = (num1 + (result * Double.Parse(textBox1.Text))).ToString();
                                    break;
                                case ":":
                                    textBox1.Text = (num1 + (result / (Double.Parse(textBox1.Text)))).ToString();
                                    break;
                                default:
                                    break;
                            }
                            operation1 = operation;
                            break;
                        case "-":
                            textBox2.Text = textBox2.Text + " " + operation + " " + textBox1.Text;
                            switch (operation)
                            {
                                case "x":
                                    textBox1.Text = (num1 - (result * Double.Parse(textBox1.Text))).ToString();
                                    break;
                                case ":":
                                    textBox1.Text = (num1 - (result / (Double.Parse(textBox1.Text)))).ToString();
                                    break;
                                default:
                                    break;
                            }
                            operation1 = operation;
                            break;
                        case "x":
                            textBox2.Text = textBox2.Text + " " + operation + " " + textBox1.Text;
                            switch (operation)
                            {
                                case "x":
                                    textBox1.Text = (num1 + ((result - num1) * Double.Parse(textBox1.Text))).ToString();
                                    break;
                                case ":":
                                    textBox1.Text = (num1 - ((-1 * result + num1) * (Double.Parse(textBox1.Text)))).ToString();
                                    break;
                                default:
                                    break;
                            }
                            operation1 = operation;
                            break;
                        case ":":
                            textBox2.Text = textBox2.Text + " " + operation + " " + textBox1.Text;
                            switch (operation)
                            {
                                case "x":
                                    textBox1.Text = (num1 + ((result - num1) / Double.Parse(textBox1.Text))).ToString();
                                    break;
                                case ":":
                                    textBox1.Text = (num1 - ((-1 * result + num1) / (Double.Parse(textBox1.Text)))).ToString();
                                    break;
                                default:
                                    break;
                            }
                            operation1 = operation;
                            break;
                        default:
                            break;
                    }
                    result = Double.Parse(textBox1.Text);
                    operation = "";
                    secondnum = false;
                    operation = b.Text;
                    operationselect = true;
                    value = false;
                }
                else
                {
                    switch (operation)
                    {
                        case "+":
                            textBox2.Text = textBox2.Text + " " + operation + " " + textBox1.Text;
                            num1 = result;
                            operation1 = operation;
                            break;
                        case "-":
                            textBox2.Text = textBox2.Text + " " + operation + " " + textBox1.Text;
                            num1 = result;
                            operation1 = operation;
                            break;
                        case "x":
                            textBox2.Text = textBox2.Text + " " + operation + " " + textBox1.Text;
                            textBox1.Text = (result * (Double.Parse(textBox1.Text))).ToString();
                            break;
                        case ":":
                            textBox2.Text = textBox2.Text + " " + operation + " " + textBox1.Text;
                            textBox1.Text = (result / (Double.Parse(textBox1.Text))).ToString();
                            break;
                        default:
                            textBox2.Text = textBox1.Text;
                            break;
                    }
                    result = Double.Parse(textBox1.Text);
                    secondnum = false;
                    operation = b.Text;
                    operationselect = true;
                    value = false;
                }

            }
            else
            {
                operation = b.Text;
                result = Double.Parse(textBox1.Text);
                textBox2.Text = result.ToString();
                operationselect = true;
                secondnum = false;
                value = false;
            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            if (value==false)
            {
                textBox1.Text = "-0";
                operationselect = false;
            }
            else
            {
                textBox1.Text = (-1 * Double.Parse(textBox1.Text)).ToString();
            }
        }
    }
}
