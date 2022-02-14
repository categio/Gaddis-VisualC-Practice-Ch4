using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Time_Zone_Selector
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void selectButton_Click(object sender, EventArgs e)
        {
            string city; //holds the value selected by user

            if (cityListBox.SelectedIndex != -1)
            {
                //get selected value
                city = cityListBox.SelectedItem.ToString();

                //determine time zone for city selected by user
                switch (city)
                {
                    case "Honolulu":
                        timeZoneOutputLabel.Text = "Hawaii-Aleutian Standard Time";
                        break;

                    case "San Francisco":
                        timeZoneOutputLabel.Text = "Pacific Standard Time";
                        break;

                    case "Denver":
                        timeZoneOutputLabel.Text = "Mountain Standard Time";
                        break;

                    case "Minneapolis":
                        timeZoneOutputLabel.Text = "Central Standard Time";
                        break;

                    case "New York":
                        timeZoneOutputLabel.Text = "Eastern Standard Time";
                        break;
                }
            }
            else
            {
                //no value selected
                MessageBox.Show("Select a city from the list.");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            //clear the output label
            timeZoneOutputLabel.Text = "";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            //close the form/program
            this.Close();
        }
    }
}
