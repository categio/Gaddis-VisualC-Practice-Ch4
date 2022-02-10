using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Loan_Qualifier
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkButton_Click(object sender, EventArgs e)
        {
            try
            {
                //name constant variables
                const decimal MIN_SALARY = 40000m;
                const int MIN_YEARS_ON_JOB = 2;

                //local variables
                decimal salary;
                int yrsOnJob;

                //get salary and yrs on job
                salary = decimal.Parse(salaryTextBox.Text);
                yrsOnJob = int.Parse(yearsTextBox.Text);

                if (salary >= MIN_SALARY)
                {
                    //determine qualification
                    if (yrsOnJob >= MIN_YEARS_ON_JOB)
                    {
                        //user qualifies
                        decisionLabel.Text = "You qualify for the loan.";
                    }
                    else
                    {
                        //user does not qualify
                        decisionLabel.Text = "Minimum years at current " +
                            "job not met.";
                    }
                }
                else
                {
                    //user does not qualify
                    decisionLabel.Text = "Minimum salary requirement " +
                        "not met.";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clears all data
            salaryTextBox.Text = "";
            yearsTextBox.Text = "";
            decisionLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close form/program
            this.Close();
        }
    }
}
