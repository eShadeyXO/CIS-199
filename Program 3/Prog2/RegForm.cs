// Program 3
// CIS 199-02
// Due: 4/11/2017
// Gradind ID: B5992
// This application calculates the earliest registration date
// and time for an undergraduate student given their class standing
// and last name.

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Prog2
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();
        }

        //Precondition: lastNameStr.Length > 0, lastNameLetterCh must be a letter
        //Poscondition: Returns the day and time of registration based on the given last name and class standing into an output label.
        private void findRegTimeBtn_Click(object sender, EventArgs e)
        {
            char[] LastNameLowerLimits = { 'A', 'C', 'E', 'G', 'J', 'M', 'P', 'R', 'T', 'W' };
            string[] SeniorJuniorTimes = {"11:30 AM","11:30 AM","2:00 PM","2:00 PM","4:00 PM","4:00 PM",
                "8:30 AM","8:30 AM","10:00 AM","10:00 AM" };
            string[] SophomoreFreshmanTimes = {"4:00 PM","8:30 AM","10:00 AM","11:30 AM","2:00 PM","4:00 PM",
            "8:30 AM","10:00 AM","11:30 AM","2:00 PM"};

            const string DAY1 = "March 29";  // 1st day of registration
            const string DAY2 = "March 30";  // 2nd day of registration
            const string DAY3 = "March 31";  // 3rd day of registration
            const string DAY4 = "April 3";   // 4th day of registration
            const string DAY5 = "April 4";   // 5th day of registration
            const string DAY6 = "April 5";   // 6th day of registration

            string lastNameStr;       // Entered last name
            char lastNameLetterCh;    // First letter of last name, as char
            string dateStr = "Error"; // Holds date of registration
            string timeStr = "Error"; // Holds time of registration
            bool isUpperClass;        // Upperclass or not?
            bool found = false;
            int index = LastNameLowerLimits.Length - 1; //Start from the end

            lastNameStr = lastNameTxt.Text;
            if (lastNameStr.Length > 0) // Empty string?
            {
                lastNameLetterCh = lastNameStr[0];   // First char of last name
                lastNameLetterCh = char.ToUpper(lastNameLetterCh); // Ensure upper case

                if (char.IsLetter(lastNameLetterCh)) // Is it a letter?
                {
                    isUpperClass = (seniorRBtn.Checked || juniorRBtn.Checked);

                    // Juniors and Seniors share same schedule but different days
                    if (isUpperClass)
                    {
                        if (seniorRBtn.Checked)
                            dateStr = DAY1;
                        else // Must be juniors
                            dateStr = DAY2;

                        while(index >= 0 && !found)
                        {
                            if (lastNameLetterCh >= LastNameLowerLimits[index])
                                found = true;
                            else
                                --index;
                        }
                        if (found)
                            timeStr = SeniorJuniorTimes[index];
                    }
                    // Sophomores and Freshmen
                    else // Must be soph/fresh
                    {
                        if (sophomoreRBtn.Checked)
                        {
                            // C-O on one day
                            if ((lastNameLetterCh >= 'C') && // >= C and
                                (lastNameLetterCh <= 'O'))   // <= O
                                dateStr = DAY4;
                            else // All other letters on previous day
                                dateStr = DAY3;

                            while (index >= 0 && !found)
                            {
                                if (lastNameLetterCh >= LastNameLowerLimits[index])
                                    found = true;
                                else
                                    --index;
                            }
                            if (found)
                                timeStr = SophomoreFreshmanTimes[index];
                        }
                        else // must be freshman
                        {
                            // C-O on one day
                            if ((lastNameLetterCh >= 'C') && // >= C and
                                (lastNameLetterCh <= 'O'))   // <= O
                                dateStr = DAY6;
                            else // All other letters on previous day
                                dateStr = DAY5;

                            while (index >= 0 && !found)
                            {
                                if (lastNameLetterCh >= LastNameLowerLimits[index])
                                    found = true;
                                else
                                    --index;
                            }
                            if (found)
                                timeStr = SophomoreFreshmanTimes[index];
                        }


                    }

                    // Output results
                    dateTimeLbl.Text = dateStr + " at " + timeStr;
                }
                else // First char not a letter
                    MessageBox.Show("Make sure last name starts with a letter");
            }
            else // Empty textbox
                MessageBox.Show("Enter a last name!");
        }
    }
}
