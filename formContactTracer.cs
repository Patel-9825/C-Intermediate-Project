/* 
 * Author: Dhruv Patel
 * Date: July 11, 2021
 * Title: Lab 4 for NETD class.
 * Description: This is the main file where all the coding goes for the form Contact Tracer.
 *              All validation and showing error coding is done here.
 * */


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
    public partial class FormContactTracer : Form
    {
        public FormContactTracer()
        {
            InitializeComponent();
        }

        List<CustomerClass> Customer = new List<CustomerClass>();


        // Enter button event are done by adding the error for not inputting the value in textboxes.
        // If all inputs are there, then it will show value in DataGridView.
        private void buttonEnter_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(textBoxFirstName.Text))
            {
                textBoxOutput.Text = "First name is not entered.";
            }
            else if (String.IsNullOrEmpty(textBoxLastName.Text))
            {
                textBoxOutput.Text = "Last name is not entered.";
            }
            else if (String.IsNullOrEmpty(maskedTextBoxEmail.Text))
            {
                textBoxOutput.Text = "Email address is not entered.";
            }
            else if (String.IsNullOrEmpty(maskedTextBoxPhoneNumber.Text))
            {
                textBoxOutput.Text = "Phone Number is not entered.";
            }
            else
            {
                history(ColID.Index, checkBoxContacted.Checked, textBoxFirstName.Text,
                    textBoxLastName.Text, DateTime.Now, maskedTextBoxEmail.Text);
            }
        }

        // String is made to call all the values and then calling this string into the enter button click event.
        private void history(int id, Boolean contactStatus, String firstName, String lastName,
            DateTime date, String emailAddress)
        {
            try
            {

                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridViewTracer);
                newRow.Cells[0].Value = id;
                newRow.Cells[1].Value = contactStatus;
                newRow.Cells[2].Value = firstName;
                newRow.Cells[3].Value = lastName;
                newRow.Cells[4].Value = date;
                newRow.Cells[5].Value = emailAddress;
                dataGridViewTracer.Rows.Add(newRow);
            }
            catch { }
        }

        //Form is set to the defaults by clicking the Reset Button.
        private void buttonReset_Click(object sender, EventArgs e)
        {
            SetDefaults();
        }

        //SetDefaults() method is created to implement the actions in Reset Button.
        private void SetDefaults()
        {
            textBoxFirstName.Clear();
            textBoxLastName.Clear();
            maskedTextBoxEmail.Clear();
            maskedTextBoxPhoneNumber.Clear();
            checkBoxContacted.Checked = false;
        }


        //Exit button click method is implemented here. After clicking exit button, the 
        //dialog box is popped up to the user to confirm if they want to exit or not.
        private void buttonClose_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
