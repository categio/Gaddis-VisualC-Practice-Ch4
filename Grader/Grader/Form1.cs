using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void determineGradeButton_Click(object sender, EventArgs e)
        {
            try
            {
                // Variable to hold the test score.
                double testScore;

                // Get the test score.
                testScore = double.Parse(testScoreTextBox.Text);

                // Determine the grade.
                if (testScore < 60)
                {
                    gradeLabel.Text = "F";
                    MessageBox.Show("You are failing.");
                }
                else
                {
                    if (testScore < 70)
                    {
                        gradeLabel.Text = "D";
                        MessageBox.Show("You must bring up " +
                            "your grade to at least a C to pass");
                    }
                    else
                    {
                        if (testScore < 80)
                        {
                            gradeLabel.Text = "C";
                            MessageBox.Show("You're barely passing.");
                        }
                        else
                        {
                            if (testScore < 90)
                            {
                                gradeLabel.Text = "B";
                                MessageBox.Show("You're doing pretty good");
                            }
                            else
                            {
                                gradeLabel.Text = "A";
                                MessageBox.Show("Excellent work!");
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Display an error message.
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gradeLabel.Text = "";
            testScoreTextBox.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            // Close the form.
            this.Close();
        }
    }
}
