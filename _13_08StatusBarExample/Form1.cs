using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _13_08StatusBarExample
{
    public partial class frmListView : Form
    {
        // Member field to hold previous folders
        private StringCollection folderCol;

        public frmListView()
        {
            InitializeComponent();

            // Init ListView and folder collection
            folderCol = new StringCollection();
            CreateHeadersAndFillListView();
            PaintListView(@"C:\");
            folderCol.Add(@"C:\");

            this.lvFilesAndFolders.ItemActivate += new EventHandler(this.LvFilesAndFolders_ItemActivate);

        }

        private void LvFilesAndFolders_ItemActivate(object sender, EventArgs e)
        {
            // Cast the sender to a ListView and get the tag of the first selected item.
            ListView lw = (ListView)sender; 
            string filename = lw.SelectedItems[0].Tag.ToString();

            if (lw.SelectedItems[0].ImageIndex != 0)
            {
                try
                {
                    // Attempt to run the file
                    System.Diagnostics.Process.Start(filename);
                }
                catch
                {
                    // If the attempt fails we simply exit the method
                    return;
                }
            }
            else
            {
                // Inser the items
                PaintListView(filename);
                folderCol.Add(filename);
            }

        }

        private void CreateHeadersAndFillListView()
        {
            ColumnHeader colHead;

            // First header
            colHead = new ColumnHeader();
            colHead.Text = "Filename";
            this.lvFilesAndFolders.Columns.Add(colHead);    // Insert the header

            // Second header
            colHead = new ColumnHeader();
            colHead.Text = "Size";
            this.lvFilesAndFolders.Columns.Add(colHead);    // Insert the header

            // Third header
            colHead = new ColumnHeader();
            colHead.Text = "Last accessed";
            this.lvFilesAndFolders.Columns.Add(colHead);    // Insert the header
        }

        private void PaintListView(string root)
        {
            try
            {
                // Two local variables that are used to create the items to insert
                ListViewItem lvi;
                ListViewItem.ListViewSubItem lvsi;

                // If there's no root folder we can't insert anything
                if (root.CompareTo("") == 0)
                    return;

                // Get the information about the root folder.
                DirectoryInfo dir = new DirectoryInfo(root);

                // Retrieve the files and folders from the root folder.
                DirectoryInfo[] dirs = dir.GetDirectories();        // Folders
                FileInfo[] files = dir.GetFiles();                  // Files

                // Clear the ListView. Note that we call the Clear method on the 
                // Items collection rather than on the ListView itself.
                // The Clear method of the ListView removes everything, including column
                // headers, and we only want to remove the items from the view.
                this.lvFilesAndFolders.Items.Clear();

                // Set the label with the currecnt path
                this.lblCurrentPath.Text = root;

                // Lock the ListView for updates
                this.lvFilesAndFolders.BeginUpdate();

                // Loop through all folders in the root folder and insert them
                foreach (DirectoryInfo di in dirs)
                {
                    // Create the main ListViewItem
                    lvi = new ListViewItem();
                    lvi.Text = di.Name;     // Folder name
                    lvi.ImageIndex = 0;     // The folder icon has index 0
                    lvi.Tag = di.FullName;  // Set the tag to the qualified path of the
                                            // folder

                    // Create the two ListViewSubItems.
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = "";     // Size - a folder has no size and so this column
                                        // is empty
                    lvi.SubItems.Add(lvsi); // Add the sub item to the ListViewItem

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = di.LastAccessTime.ToString();   // Last access column
                    lvi.SubItems.Add(lvsi); // Add the sub item to the ListViewItem

                    // Add the ListViewItem to the Items collection of the ListView
                    this.lvFilesAndFolders.Items.Add(lvi);
                }

                // Loop through all the files in the root folder
                foreach (FileInfo fi in files)
                {
                    // Create the main ListViewItem
                    lvi = new ListViewItem();
                    lvi.Text = fi.Name; // Filename
                    lvi.ImageIndex = 1; // The icon we use to represent a folder has 
                                        // index 1
                    lvi.Tag = fi.FullName;  // Set the tag to teh qualified path of the 
                                            // file

                    // Create the two sub items
                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fi.Length.ToString();   // Length of the file
                    lvi.SubItems.Add(lvsi);     // Add to the SubItems collection

                    lvsi = new ListViewItem.ListViewSubItem();
                    lvsi.Text = fi.LastAccessTime.ToString();   // Last Accessed Column
                    lvi.SubItems.Add(lvsi); // Add to the Subitems collection

                    // Add the item to the Items collection of the ListView
                    this.lvFilesAndFolders.Items.Add(lvi);
                }
                
                // Unlock the ListView. The items that have been inserted will now
                // be displayed
                this.lvFilesAndFolders.EndUpdate();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error: " + err.Message);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if(folderCol.Count > 1) 
            {
                PaintListView(folderCol[folderCol.Count - 2].ToString());
                folderCol.RemoveAt(folderCol.Count - 1);
            }
            else
            {
                PaintListView(folderCol[0].ToString()); 
            }
        }

        private void rbLargeIcon_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
                this.lvFilesAndFolders.View = View.LargeIcon;
        }

        private void rbSmallIcon_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
                this.lvFilesAndFolders.View = View.SmallIcon;
        }

        private void rbList_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
                this.lvFilesAndFolders.View = View.List;
        }

        private void rbDetails_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
                this.lvFilesAndFolders.View = View.Details;
        }
    }
}
