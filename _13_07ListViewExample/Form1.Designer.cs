namespace _13_07ListViewExample
{
    partial class frmListView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmListView));
            this.lvFilesAndFolders = new System.Windows.Forms.ListView();
            this.ilLarge = new System.Windows.Forms.ImageList(this.components);
            this.ilSmall = new System.Windows.Forms.ImageList(this.components);
            this.btnBack = new System.Windows.Forms.Button();
            this.lblCurrentPath = new System.Windows.Forms.Label();
            this.gbViewMode = new System.Windows.Forms.GroupBox();
            this.rbDetails = new System.Windows.Forms.RadioButton();
            this.rbList = new System.Windows.Forms.RadioButton();
            this.rbSmallIcon = new System.Windows.Forms.RadioButton();
            this.rbLargeIcon = new System.Windows.Forms.RadioButton();
            this.gbViewMode.SuspendLayout();
            this.SuspendLayout();
            // 
            // lvFilesAndFolders
            // 
            this.lvFilesAndFolders.HideSelection = false;
            this.lvFilesAndFolders.LargeImageList = this.ilLarge;
            this.lvFilesAndFolders.Location = new System.Drawing.Point(15, 38);
            this.lvFilesAndFolders.Name = "lvFilesAndFolders";
            this.lvFilesAndFolders.Size = new System.Drawing.Size(567, 354);
            this.lvFilesAndFolders.SmallImageList = this.ilSmall;
            this.lvFilesAndFolders.TabIndex = 0;
            this.lvFilesAndFolders.UseCompatibleStateImageBehavior = false;
            this.lvFilesAndFolders.View = System.Windows.Forms.View.Details;
            // 
            // ilLarge
            // 
            this.ilLarge.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilLarge.ImageStream")));
            this.ilLarge.TransparentColor = System.Drawing.Color.Transparent;
            this.ilLarge.Images.SetKeyName(0, "CLSDFOLD.ico");
            this.ilLarge.Images.SetKeyName(1, "redinfo.ico");
            // 
            // ilSmall
            // 
            this.ilSmall.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilSmall.ImageStream")));
            this.ilSmall.TransparentColor = System.Drawing.Color.Transparent;
            this.ilSmall.Images.SetKeyName(0, "CLSDFOLD.ico");
            this.ilSmall.Images.SetKeyName(1, "redinfo.ico");
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(319, 415);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(75, 23);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblCurrentPath
            // 
            this.lblCurrentPath.AutoSize = true;
            this.lblCurrentPath.Location = new System.Drawing.Point(12, 9);
            this.lblCurrentPath.Name = "lblCurrentPath";
            this.lblCurrentPath.Size = new System.Drawing.Size(29, 13);
            this.lblCurrentPath.TabIndex = 2;
            this.lblCurrentPath.Text = "Path";
            // 
            // gbViewMode
            // 
            this.gbViewMode.Controls.Add(this.rbDetails);
            this.gbViewMode.Controls.Add(this.rbList);
            this.gbViewMode.Controls.Add(this.rbSmallIcon);
            this.gbViewMode.Controls.Add(this.rbLargeIcon);
            this.gbViewMode.Location = new System.Drawing.Point(588, 38);
            this.gbViewMode.Name = "gbViewMode";
            this.gbViewMode.Size = new System.Drawing.Size(200, 197);
            this.gbViewMode.TabIndex = 3;
            this.gbViewMode.TabStop = false;
            this.gbViewMode.Text = "View Mode";
            // 
            // rbDetails
            // 
            this.rbDetails.AutoSize = true;
            this.rbDetails.Checked = true;
            this.rbDetails.Location = new System.Drawing.Point(6, 158);
            this.rbDetails.Name = "rbDetails";
            this.rbDetails.Size = new System.Drawing.Size(57, 17);
            this.rbDetails.TabIndex = 3;
            this.rbDetails.TabStop = true;
            this.rbDetails.Text = "Details";
            this.rbDetails.UseVisualStyleBackColor = true;
            this.rbDetails.CheckedChanged += new System.EventHandler(this.rbDetails_CheckedChanged);
            // 
            // rbList
            // 
            this.rbList.AutoSize = true;
            this.rbList.Location = new System.Drawing.Point(6, 109);
            this.rbList.Name = "rbList";
            this.rbList.Size = new System.Drawing.Size(41, 17);
            this.rbList.TabIndex = 2;
            this.rbList.Text = "List";
            this.rbList.UseVisualStyleBackColor = true;
            this.rbList.CheckedChanged += new System.EventHandler(this.rbList_CheckedChanged);
            // 
            // rbSmallIcon
            // 
            this.rbSmallIcon.AutoSize = true;
            this.rbSmallIcon.Location = new System.Drawing.Point(6, 61);
            this.rbSmallIcon.Name = "rbSmallIcon";
            this.rbSmallIcon.Size = new System.Drawing.Size(74, 17);
            this.rbSmallIcon.TabIndex = 1;
            this.rbSmallIcon.Text = "Small Icon";
            this.rbSmallIcon.UseVisualStyleBackColor = true;
            this.rbSmallIcon.CheckedChanged += new System.EventHandler(this.rbSmallIcon_CheckedChanged);
            // 
            // rbLargeIcon
            // 
            this.rbLargeIcon.AutoSize = true;
            this.rbLargeIcon.Location = new System.Drawing.Point(6, 19);
            this.rbLargeIcon.Name = "rbLargeIcon";
            this.rbLargeIcon.Size = new System.Drawing.Size(76, 17);
            this.rbLargeIcon.TabIndex = 0;
            this.rbLargeIcon.Text = "Large Icon";
            this.rbLargeIcon.UseVisualStyleBackColor = true;
            this.rbLargeIcon.CheckedChanged += new System.EventHandler(this.rbLargeIcon_CheckedChanged);
            // 
            // frmListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbViewMode);
            this.Controls.Add(this.lblCurrentPath);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lvFilesAndFolders);
            this.Name = "frmListView";
            this.Text = "List View";
            this.gbViewMode.ResumeLayout(false);
            this.gbViewMode.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvFilesAndFolders;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label lblCurrentPath;
        private System.Windows.Forms.GroupBox gbViewMode;
        private System.Windows.Forms.RadioButton rbDetails;
        private System.Windows.Forms.RadioButton rbList;
        private System.Windows.Forms.RadioButton rbSmallIcon;
        private System.Windows.Forms.RadioButton rbLargeIcon;
        private System.Windows.Forms.ImageList ilSmall;
        private System.Windows.Forms.ImageList ilLarge;
    }
}

