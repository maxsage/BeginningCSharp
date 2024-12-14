using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_03RadioButtonAndCheckBoxExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.btnOk.Enabled = false;

            // Tag values for testing if the data is valid
            this.txtAddress.Tag = false;
            this.txtAge.Tag = false;
            this.txtName.Tag = false;

            // Subscriptions to events
            this.txtName.Validating += new CancelEventHandler(this.txtBoxEmpty_Validating);
            this.txtAddress.Validating += new CancelEventHandler(this.txtBoxEmpty_Validating);
            this.txtAge.KeyPress += new KeyPressEventHandler(this.txtAge_KeyPress);
            this.txtAge.Validating += new CancelEventHandler(this.txtBoxEmpty_Validating);

            this.txtName.TextChanged += new EventHandler(this.txtBox_TextChanged);
            this.txtAddress.TextChanged += new EventHandler(this.txtBox_TextChanged);
            this.txtAge.TextChanged += new EventHandler(this.txtBox_TextChanged);
        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
            // Cast the sender object to a TextBox
            TextBox tb = (TextBox)sender;

            // Test if the data is valid and set the tag and background
            // color accordingly
            if (tb.Text.Length == 0)
            {
                tb.Tag = false;
                tb.BackColor = Color.Red;
            }
            else
            {
                tb.Tag = true;
                tb.BackColor = SystemColors.Window;
            }

            // Call ValidateAll to set the OK button
            ValidateAll();
        }

        private void ValidateAll()
        {
            // Set the OK button to enabled if all the Tags are true
            this.btnOk.Enabled = (
                (bool)(this.txtAddress.Tag) &&
                (bool)(this.txtAge.Tag) &&
                (bool)(this.txtName.Tag));
        }

        private void txtAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if((e.KeyChar < 48 || e.KeyChar > 57) && e.KeyChar != 8)
                e.Handled = true; // Remove the character
        }


        private void txtBoxEmpty_Validating(object sender, CancelEventArgs e)
        {
            // We know the sender is a TextBox , so we cast the sender object to that
            TextBox tb = (TextBox)sender;

            // If the text is empty we set the background color of the 
            // Textbox to red to indicate a problem. We use the tag value
            // of the control to indicate if the control contains valid 
            // information.
            if(tb.Text.Length == 0)
            {
                tb.BackColor = Color.Red;
                tb.Tag = false;

                // In this case we do not want to cancel further processing,
                // but if we had wanted to do this, we would have added this line:
                // e.Cancel = true;
            }
            else
            {
                tb.BackColor = System.Drawing.SystemColors.Window;
                tb.Tag = true;
            }

            // Finally, we call ValidateAll which will set the value of
            // the OK button.
            ValidateAll();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // No testing for invalid values are made, as that should
            // not be necessary

            string output;

            // Concatenate the text values of the four TextBoxes
            output = "Name: " + this.txtName.Text + "\r\n";
            output += "Address: " + this.txtAddress.Text + "\r\n";
            output += "Occupation: " + (string)(this.chkProgrammer.Checked ?
                "Programmer" : "Not a programmer") + "\r\n";
            output += "Sex: " + (string)(this.rdoFemale.Checked ? "Female" :
                "Male") + "\r\n";
            output += "Age: " + this.txtAge.Text;

            // Insert the new text
            this.txtOutput.Text = output;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            // Write a short description of each TextBox in the Output TextBox 

            string output;

            output = "Name = Your name\r\n";
            output += "Address = Your address\r\n";
            output += "Occupation = Only allowed value is 'Programmer'\r\n";
            output += "Age = Your age";

            // Insert the new text
            this.txtOutput.Text = output;
        }
    }
}