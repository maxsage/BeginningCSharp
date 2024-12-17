using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_05ListBoxExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Fill the CheckedListBox
            this.chkListPossibleValues.Items.Add("One");
            this.chkListPossibleValues.Items.Add("Two");
            this.chkListPossibleValues.Items.Add("Three");
            this.chkListPossibleValues.Items.Add("Four");
            this.chkListPossibleValues.Items.Add("Five");
            this.chkListPossibleValues.Items.Add("Six");
            this.chkListPossibleValues.Items.Add("Seven");
            this.chkListPossibleValues.Items.Add("Eight");
            this.chkListPossibleValues.Items.Add("Nine");
            this.chkListPossibleValues.Items.Add("Ten");

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnMove_Click(object sender, EventArgs e)
        {
            // Check if there are any checked items in the CheckedListBox
            if(this.chkListPossibleValues.CheckedItems.Count > 0)
            {
                // Clear the ListBox we'll move the selection to
                this.lstSelected.Items.Clear();

                // Loop through the CheckedItems collection of the CheckedListBox
                // and add the items in the Selected ListBox
                foreach(string item in this.chkListPossibleValues.CheckedItems)
                {
                    this.lstSelected.Items.Add(item.ToString());
                    
                }

                // Clear all the checks in the CheckedListBox
                for (int i = 0; i < this.chkListPossibleValues.Items.Count; i++) 
                    this.chkListPossibleValues.SetItemChecked(i, false);
            }
        }
    }
}
