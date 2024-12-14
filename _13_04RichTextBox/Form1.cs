using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_04RichTextBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Event Subscription
            this.txtSize.KeyPress += new
                KeyPressEventHandler(this.txtSize_KeyPress);
            this.txtSize.Validating += new
                CancelEventHandler(this.txtSize_Validating);
            this.rtfText.LinkClicked += new 
                LinkClickedEventHandler(this.rtfText_LinkClicked);
        }

        private void rtfText_LinkClicked(object sender, LinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start(e.LinkText);
        }

        private void txtSize_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Remove all characters that are not numbers, backspace and enter
            if((e.KeyChar < 48 || e.KeyChar > 57) &&
                    e.KeyChar != 8 && e.KeyChar != 13)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 13)
            {
                // Apply size if the user hits enter
                TextBox txt = (TextBox)sender;

                if(txt.Text.Length > 0 )
                    ApplyTextSize(txt.Text);
                e.Handled = true;
                this.rtfText.Focus();
            }
        }

        private void txtSize_Validating(object sender, CancelEventArgs e)
        {
            TextBox txt = (TextBox)sender;

            ApplyTextSize(txt.Text);
            this.rtfText.Focus();

        }

        private void ApplyTextSize(string textSize)
        {
            // Convert the text to a float because we'll be needing a float shortly
            float newSize = Convert.ToSingle(textSize);
            FontFamily currentFontFamily;
            Font newFont;

            // Create a new font of the same3 family but with the new size
            currentFontFamily = this.rtfText.SelectionFont.FontFamily;
            newFont = new Font(currentFontFamily, newSize);

            // Set the font of the selected text to the new font
            this.rtfText.SelectionFont = newFont;
        }

        private void btnBold_Click(object sender, EventArgs e)
        {
            Font oldFont;
            Font newFont;

            // Get the font that is being used in the selected text
            oldFont = this.rtfText.SelectionFont;

            // If the font is using bold style now, we should remove the 
            // Formatting
            if (oldFont.Bold)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Bold);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Bold);

            // Insert the new font and return focus to the RichTextBox
            this.rtfText.SelectionFont = newFont;
            this.rtfText.Focus();
        }

        private void btnItalic_Click(object sender, EventArgs e)
        {
            Font oldFont;
            Font newFont;

            // Get the font that is being used in the selected text
            oldFont = this.rtfText.SelectionFont;

            // If the font is using Italic styule now, we should remove it
            if (oldFont.Italic)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Italic);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Italic);

            // Insert the new font
            this.rtfText.SelectionFont = newFont;
            this.rtfText.Focus();

        }

        private void btnUnderline_Click(object sender, EventArgs e)
        {
            Font oldFont;
            Font newFont;

            // Get the font that is being used ion the selected text
            oldFont = this.rtfText.SelectionFont;

            // If the font is using Underline style now, we should remove it
            if (oldFont.Underline)
                newFont = new Font(oldFont, oldFont.Style & ~FontStyle.Underline);
            else
                newFont = new Font(oldFont, oldFont.Style | FontStyle.Underline);

            // Insert the new font
            this.rtfText.SelectionFont= newFont; 
            this.rtfText.Focus();
        }

        private void btnCenter_Click(object sender, EventArgs e)
        {
            if (this.rtfText.SelectionAlignment == HorizontalAlignment.Center)
                this.rtfText.SelectionAlignment = HorizontalAlignment.Center;
            else
                this.rtfText.SelectionAlignment = HorizontalAlignment.Center;

            this.rtfText.Focus();
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            // Load the file into the RichTextBox
            try
            {
                rtfText.LoadFile("../../Test.rtf");
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("No file to load yet");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Save the text
            try
            {
                rtfText.SaveFile("../../Test.rtf");
            }
            catch(System.Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }
    }
}
