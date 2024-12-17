namespace _13_05ListBoxExample
{
    partial class Form1
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
            this.chkListPossibleValues = new System.Windows.Forms.CheckedListBox();
            this.lstSelected = new System.Windows.Forms.ListBox();
            this.btnMove = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // chkListPossibleValues
            // 
            this.chkListPossibleValues.FormattingEnabled = true;
            this.chkListPossibleValues.Location = new System.Drawing.Point(12, 12);
            this.chkListPossibleValues.Name = "chkListPossibleValues";
            this.chkListPossibleValues.Size = new System.Drawing.Size(289, 394);
            this.chkListPossibleValues.TabIndex = 0;
            this.chkListPossibleValues.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // lstSelected
            // 
            this.lstSelected.FormattingEnabled = true;
            this.lstSelected.Location = new System.Drawing.Point(499, 12);
            this.lstSelected.Name = "lstSelected";
            this.lstSelected.Size = new System.Drawing.Size(289, 394);
            this.lstSelected.TabIndex = 1;
            // 
            // btnMove
            // 
            this.btnMove.Location = new System.Drawing.Point(364, 187);
            this.btnMove.Name = "btnMove";
            this.btnMove.Size = new System.Drawing.Size(75, 30);
            this.btnMove.TabIndex = 2;
            this.btnMove.Text = "Move>";
            this.btnMove.UseVisualStyleBackColor = true;
            this.btnMove.Click += new System.EventHandler(this.btnMove_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnMove);
            this.Controls.Add(this.lstSelected);
            this.Controls.Add(this.chkListPossibleValues);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckedListBox chkListPossibleValues;
        private System.Windows.Forms.ListBox lstSelected;
        private System.Windows.Forms.Button btnMove;
    }
}

