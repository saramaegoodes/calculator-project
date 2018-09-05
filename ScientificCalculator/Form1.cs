using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScientificCalculator
{
    public partial class Form1 : Form
    {
        Double value = 0; //for the decimal
        String operation = ""; // used to capture what operator was pressed
        bool operator_chosen = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, EventArgs e)
        {
            if ((answer.Text == "0")||(operator_chosen)) //clears zero when label clicked, boolean determines whether or not to clear the value in text field
                answer.Clear();

            operator_chosen = false;
            Button bTTon = (Button)sender; //converts sender object into a button
            answer.Text = answer.Text + bTTon.Text; //show what is in the textbx and show the label pressed

        }

        private void buttonClearE_Click(object sender, EventArgs e)
        {
            answer.Text = "0"; //resets entry back to zero
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button bTTon = (Button)sender;
            operation = bTTon.Text; //stores the operation pressed
            value = Double.Parse(answer.Text); //Parses string as double
            operator_chosen = true;
            equation.Text = value + " " + operation;
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {

            equation.Text = "";
            switch(operation)
            {
                //Addition
                case "+":
                    answer.Text = (value + Double.Parse(answer.Text)).ToString(); //number stored in value + what is in text field
                    break;

                //Subtraction
                case "-":
                    answer.Text = (value - Double.Parse(answer.Text)).ToString(); //To.String() because only strings can be stored in the text field
                    break;

                //Multiplication
                case "*":
                    answer.Text = (value * Double.Parse(answer.Text)).ToString();
                    break;

                //Division
                case "/":
                    answer.Text = (value / Double.Parse(answer.Text)).ToString();
                    break;
                default:
                    break;
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            answer.Clear();
            value = 0;

        }
    }
}
