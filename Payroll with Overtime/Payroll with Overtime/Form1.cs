using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Payroll_with_Overtime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            try
            {
                //named constants
                const decimal BASE_HOURS = 40m;
                const decimal OT_MULTIPLIER = 1.5m;

                //local variables
                decimal hoursWorked; //num hours worked
                decimal hourlyPayRate; //hourly rate of pay
                decimal basePay; //pay not incl. OT
                decimal overtimeHours; // OT hrs worked
                decimal overtimePay; //OT pay
                decimal grossPay; //tot gross pay

                //get hours worked and hourly pay rate
                hoursWorked = decimal.Parse(hoursWorkedTextBox.Text);
                hourlyPayRate = decimal.Parse(hourlyPayRateTextBox.Text);

                //determine gross pay
                if (hoursWorked > BASE_HOURS)
                {
                    //calc the base pay w/o OT
                    basePay = hourlyPayRate * BASE_HOURS;

                    //calc num of OT hrs
                    overtimeHours = hoursWorked - BASE_HOURS;

                    //calc OT pay
                    overtimePay = overtimeHours * hourlyPayRate * OT_MULTIPLIER;

                    //calc gross pay
                    grossPay = basePay + overtimePay;
                }
                else
                {
                    //calc gross pay.
                    grossPay = hoursWorked * hourlyPayRate;
                }
                //display gross pay
                grossPayLabel.Text = grossPay.ToString("c");
            }
            catch(Exception ex)
            {
                //display error message
                MessageBox.Show(ex.Message);
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear all data
            hoursWorkedTextBox.Text = "";
            hourlyPayRateTextBox.Text = "";
            grossPayLabel.Text = "";

            //reset focus
            hoursWorkedTextBox.Focus();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close form/program
            this.Close();
        }
    }
}
