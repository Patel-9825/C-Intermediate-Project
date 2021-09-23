// Dhruv Patel #100800111
// May 22, 2021
// Description: Form about the cases which will be collected for 7 days and
//              average cases will be calculated as per the cases entered by user.


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjectDhruvP
{
    public partial class FormAverageCases : Form
    {
        // Declare class-level variables
        int currentDay = 1;
        int totalCases = 0;

        public FormAverageCases()
        {
            InitializeComponent();
        }

        /// <summary>
        /// This exits the application.
        /// </summary>

        private void CloseClick(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Clear all fields and resets the form to its default state.
        /// </summary>

        private void ResetClick(object sender, EventArgs e)
        {
            // Clear input and output controls.
            textBoxCaseEntry.Clear();
            textBoxCaseList.Clear();
            labelAverageOutput.Text = String.Empty;

            // Re-enable any controls that could be disabled.
            textBoxCaseEntry.Enabled = true;
            buttonEnter.Enabled = true;

            // Reset the value of the class-level variables.
            currentDay = 1;
            totalCases = 0;

            // Set the displayed day back to default.
            labelDay.Text = "Day" + currentDay;

            // Set Focus.
            textBoxCaseEntry.Focus();
        }

        /// <summary>
        /// Validates and accepts a value for a number of cases entered by the user. When it's valid, 
        /// records the value and adds to a running total. Once all cases are entered, calculates and 
        /// displays an average.
        /// </summary>
        private void EnterClick(object sender, EventArgs e)
        {
            // Declare a constant represaenting the number of days.
            const int NumberOfDays = 7;
            // Declare a variable to store the user's last (numeric) input.
            int enteredCases;

            // If the contents of the textbox are a number...
            if (int.TryParse(textBoxCaseEntry.Text, out enteredCases))
            {
                // If the contents of the textbox are in the valid range (positive)...
                if (enteredCases >= 0 && enteredCases <= int.MaxValue)
                {
                    // Increment the number of cases based on the user's input.
                    totalCases += enteredCases;
                    // Add the last entered value to the large textbox.
                    textBoxCaseList.Text += enteredCases + "\r\n";
                    // Increment the day.
                    currentDay++;

                    // If the day is greater is 7...
                    if (currentDay > NumberOfDays)
                    {
                        // Set the day equal to 7.
                        currentDay = 7;
                        // Calculate the average by dividing the total by the number of days.
                        double averageCases = (double)totalCases / NumberOfDays;
                        // Display the average.
                        labelAverageOutput.Text = "Average per day: " + Math.Round(averageCases, 2);

                        // Disable the input-related controls.
                        textBoxCaseEntry.Enabled = false;
                        buttonEnter.Enabled = false;
                    }
                    // Update the label that displays the current day.
                    labelDay.Text = "Day " + currentDay;
                    // Set the focus to the input textbox.
                    textBoxCaseEntry.Clear();
                    textBoxCaseEntry.Focus();
                }
                // The contents are in range. Report an error.
                else
                {
                    MessageBox.Show("Your entry must be between 0 and " + int.MaxValue, "Entry Error!");
                    textBoxCaseEntry.SelectAll();
                    textBoxCaseEntry.Focus();
                }
            }
            // The contents are not a whole number. Report an error.
            else
            {
                MessageBox.Show("Your entry must be a whole number. ", "Entry Error!");
                textBoxCaseEntry.SelectAll();
                textBoxCaseEntry.Focus();
            }
        }
    }
}
