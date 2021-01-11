using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Win_Calculator
{
    public partial class Form1 : Form
    {

        Double value = 0;
        String operation = "";
        bool operation_pressed = false;
        bool button_grey = true;
        bool button_grey2 = true;
        bool button_highlight = false;
        bool button_dark = false;


        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button_Click(object sender, EventArgs e)
        {       
            if ((result.Text == "0")||(operation_pressed))
            {
                result.Clear();
            }
            operation_pressed = false;
            Button b = (Button)sender;
            result.Text = result.Text + b.Text;
            

        }

        private void clear_Click(object sender, EventArgs e)
        {
            result.Clear();
            result.Text = "0";
           
        }

        private void operator_click(object sender, EventArgs e)
        {

            Button b = (Button)sender;
            operation = b.Text;
            value = Double.Parse(result.Text);
            operation_pressed = true;
            equation.Text = value + " " + operation;
            
        }

        private void equals_Click(object sender, EventArgs e)
        {

            equation.Text = "";
            switch(operation)
            {
                case "+":
                    result.Text = (value + Double.Parse(result.Text)).ToString();
                    break;
                case "-":
                    result.Text = (value - Double.Parse(result.Text)).ToString();
                    break;
                case "*":
                    result.Text = (value * Double.Parse(result.Text)).ToString();
                    break;
                case "/":
                    result.Text = (value / Double.Parse(result.Text)).ToString();
                    break;
                default:
                    break;
            }//end switch      
            operation_pressed = false;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            result.Text = "0";
        }

        private void result_TextChanged(object sender, EventArgs e)
        {

        }

        private void old_School_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (button_grey == true) { 
                this.BackColor = SystemColors.Highlight;
                button_highlight = true;
                button_grey = false;
                old_School.Text = "Classic Mode";

            }

            else if (button_highlight == true) { 
                this.BackColor = SystemColors.ButtonFace;
                button_grey = true;
                button_highlight = false;
                old_School.Text = "Old School Mode";                
            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            if (button_grey2 == true)
            {
                this.BackColor = SystemColors.Desktop;
                button_dark = true;
                button_grey2 = false;
                dark_Button.Text = "Classic Mode";

            }

            else if (button_dark == true)
            {
                this.BackColor = SystemColors.ButtonFace;
                button_grey2 = true;
                button_dark = false;
                dark_Button.Text = "Dark Mode";
            }

        }
    }
}
