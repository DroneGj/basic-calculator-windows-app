using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        double result = 0;
        string operation = "";
        bool operationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void BtOne_Click(object sender, EventArgs e)
        {
            if ((Output.Text == "0") || operationPerformed)
                Output.Clear();
            operationPerformed = false;
            Button button = (Button)sender;

            if(button.Text == ".")
            {
                if(!Output.Text.Contains("."))
                    Output.Text = Output.Text + button.Text;
            }
            else
                Output.Text = Output.Text + button.Text;
        }

        private void BtOperator_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(Output.Text);
            labelStoreOperation.Text = result + " " + operation;
            operationPerformed = true;
        }

        private void BtAC_Click(object sender, EventArgs e)
        {
            Output.Text = "0";
            result = 0;
            labelStoreOperation.Text = "";
        }

        private void BtCut_Click(object sender, EventArgs e)
        {
            Output.Text = "0";
        }

        private void BtEqual_Click(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    Output.Text = (result + double.Parse(Output.Text)).ToString();
                    labelStoreOperation.Text = "";
                    break;
                case "-":
                    Output.Text = (result - double.Parse(Output.Text)).ToString();
                    labelStoreOperation.Text = "";
                    break;
                case "*":
                    Output.Text = (result * double.Parse(Output.Text)).ToString();
                    labelStoreOperation.Text = "";
                    break;
                case "/":
                    Output.Text = (result / double.Parse(Output.Text)).ToString();
                    labelStoreOperation.Text = "";
                    break;
                default:
                    break;
            }
        }
    }
}
