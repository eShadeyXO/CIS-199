// Grading ID: B5992
// Program 2
// CIS 199-02
// Due Tuesday, March 7th, 2017
// This program allows the user to input their last name and select which class standing they're in in order to
// find out when their registration time period starts.
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Program_2
{
    public partial class programTwo : Form
    {
        public programTwo()
        {
            InitializeComponent();
        }

        public string time; //Declare variable to hold time
        public string day; //Declare variable to hold day.

        private void resultsButton_Click(object sender, EventArgs e)
        {

            string name; // To hold user's last name.
            char letter; // To hold the first lett of the last name.

            name = lastNameTxt.Text; // Assign value in last name text box to name
            letter = char.ToUpper(name[0]); // Get first letter of the variable name and assign it to the variable letter.

            if (string.IsNullOrWhiteSpace(lastNameTxt.Text)) //Validate text box. Check if empty
            {
                MessageBox.Show("Please enter a last name"); //Display message box to enter last name
            }
            else//Otherwise
            {

                if (seniorRadioButton.Checked || juniorRadioButton.Checked) //If a senior or junior
                {
                    if (letter <= 'D') //If name starts with D and under
                    {
                        time = "11:30 PM";//Assign value to time
                    }
                    else if (letter <= 'I')//If name starts with I and under
                    {
                        time = "2:00 PM";//Assign value to time
                    }
                    else if (letter <= 'O')//If name starts with O and under
                    {
                        time = "4:00 PM";//Assign value to time
                    }
                    else if (letter <= 'S')//If name starts with S and under
                    {
                        time = "8:30 AM";//Assign value to time
                    }
                    else//Otherwise
                    {
                        time = "10:00 AM";//Assign value to time
                    }
                    if (seniorRadioButton.Checked)//If a senior
                    {
                        day = "Wednesday, March 29th";//Assign value to day
                    }
                    else//Otherwise
                    {
                        day = "Thursday, March 30th";//Assign value to day
                    }
                }
                else//Otherwise
                {
                    if (sophomoreRadioButton.Checked)//If a sophomore
                    {
                        if(letter <= 'B')//If letter is less than B
                        {
                            day = "Friday, March 31st";//Assign value to day
                        }
                        else if(letter <= 'O')//If letter is less than O
                        {
                            day = "Monday, April 3rd";//Assign value to day
                        }
                        else//Otherwise
                        {
                            day = "Friday, March 31st";//Assign value to day
                        }
                    }
                    if(freshmanRadioButton.Checked)//If a freshman
                    {
                        if (letter <= 'B')//If letter less than B
                        {
                            day = "Tuesday, April 4th";//Assign value to day
                        }
                        else if (letter <= 'O')//If letter less than O
                        {
                            day = "Wednesday, April 5th";//Assign value to day
                        }
                        else//Otherwise
                        {
                            day = "Tuesday, April 4th";//Assign value to day
                        }
                    }
                        if (letter <= 'B')//If name starts with B and under
                        {
                            time = "4:00 PM";//Assign value to time
                        }
                        else if (letter <= 'D')//If name starts with D and under
                        {
                            time = "8:30 AM";//Assign value to time
                        }
                        else if (letter <= 'F')//If name starts with F and under
                        {
                            time = "10:00 AM";//Assign value to time
                        }
                        else if (letter <= 'I')//If name starts with I and under
                        {
                            time = "11:30 AM";//Assign value to time
                        }
                        else if (letter <= 'L')//If name starts with L and under
                        {
                            time = "2:00 PM";//Assign value to time
                        }
                        else if (letter <= 'O')//If name starts with O and under
                        {
                            time = "4:00 PM";//Assign value to time
                        }
                        else if (letter <= 'Q')//If name starts with Q and under
                        {
                            time = "8:30 AM";//Assign value to time
                        }
                        else if (letter <= 'S')//If name starts with S and under
                        {
                            time = "10:00 AM";//Assign value to time
                        }
                        else if (letter <= 'V')//If name starts with V and under
                        {
                            time = "11:30 AM";//Assign value to time
                        }
                        else//Otherwise
                        {
                            time = "2:00 PM";//Assign value to time
                        }
                }
            }
            //Display registration day and time.
            MessageBox.Show("Your registration begins on " + day + " at " + time);
        }
    }
}