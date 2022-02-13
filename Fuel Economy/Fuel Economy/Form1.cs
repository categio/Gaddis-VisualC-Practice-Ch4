using System;
using System.Windows.Forms;

namespace Fuel_Economy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            double miles; //holds miles driven entered by user
            double gallons; //holds gallons used entered by user
            double mpg; //holds the mpg calculated
                        //retreive miles given and assign to the miles variable
                        //validate miles textbox control
                        //retrieve miles driven and assign to the miles variable
            if (double.TryParse(milesTextBox.Text, out miles))
            {
                //validate gallons textbox 
                //retrieve gallons used and assign to the miles variable
                if (double.TryParse(gallonsTextBox.Text, out gallons))
                {
                    //calculate mpg with following formula: miles drive/gallons used
                    mpg = miles / gallons;
                    //display mpg calculated in the mpgLabel control
                    mpgLabel.Text = mpg.ToString();
                }
                else
                {
                    //display an error message for gallonsTextBox
                    MessageBox.Show("Invalid gallons input. " +
                        "gallons can only accept numerical input.");
                }
            }
            else
            {
                //display an error message for milesTextBox
                MessageBox.Show("Invalid miles input. " +
                    "miles can only accept numerical input.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            milesTextBox.Text = "";
            gallonsTextBox.Text = "";
            mpgLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //closes the form
            this.Close();
        }
    }
}
