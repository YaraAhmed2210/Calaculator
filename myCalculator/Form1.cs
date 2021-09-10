using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace myCalculator
{
    
    public partial class Form1 : Form
    {
        Double resultValue = 0;
        String operationPerformed = "";
        operations myOp= new operations();
        Boolean isOperationPerformed = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        { 
            if ((textBox_result.Text == "0")  || (isOperationPerformed))
            {
                textBox_result.Clear();
            }

            Button button = (Button)sender;
            if (button.Text == ".")
            {
                if (!textBox_result.Text.Contains("."))
                {

                    textBox_result.Text = textBox_result.Text + button.Text;
                }
            }
            else
            {

                textBox_result.Text = textBox_result.Text + button.Text;
            }
            //when number clicked so new value is added so no operation to be executed now
            isOperationPerformed = false;
        }

        private void operator_click(object sender, EventArgs e)
        {

            Button button = (Button)sender;
            if (resultValue != 0)
            {
                buttonEq.PerformClick();
                operationPerformed = button.Text;
                label_currentOp.Text = resultValue + "" + operationPerformed;
                isOperationPerformed = true; //operation to be executed
            }
            else
            {
                operationPerformed = button.Text;

                resultValue = Double.Parse(textBox_result.Text);
                label_currentOp.Text = resultValue + "" + operationPerformed;
                isOperationPerformed = true; //operation to be executed
            }

        }

        private void ButtonCE_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
        }

        private void ButtonC_Click(object sender, EventArgs e)
        {
            textBox_result.Text = "0";
            resultValue = 0;

        }

        private void ButtonEq_Click(object sender, EventArgs e)
        {
            double temp;
            switch (operationPerformed)
            {
                case "+":
                    temp=myOp.add(resultValue, Double.Parse(textBox_result.Text));
                    textBox_result.Text =temp.ToString();
                    // textBox_result.Text = (resultValue + Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "-":
                    temp = myOp.subtract(resultValue, Double.Parse(textBox_result.Text));
                    textBox_result.Text = temp.ToString();
                    //textBox_result.Text = (resultValue - Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "/":
                    if(Double.Parse(textBox_result.Text) == 0)
                    {
                        MessageBox.Show("Sorry, Can't Divide by Zero!", "Error");
                    }
                    else
                    {

                        temp = myOp.divide(resultValue, Double.Parse(textBox_result.Text));
                        textBox_result.Text = temp.ToString();
                    }
                    //  textBox_result.Text = (resultValue / Double.Parse(textBox_result.Text)).ToString();
                    break;
                case "*":
                    temp = myOp.multiply(resultValue, Double.Parse(textBox_result.Text));
                    textBox_result.Text = temp.ToString();
                    // textBox_result.Text = (resultValue * Double.Parse(textBox_result.Text)).ToString();
                    break;
                default:
                    break;

            }

            resultValue = Double.Parse(textBox_result.Text);
            label_currentOp.Text = "";
        }
    }

}



