namespace _13_01ButtonTest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnEnglish = new System.Windows.Forms.Button();
            this.btnDanish = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEnglish
            // 
            this.btnEnglish.Image = ((System.Drawing.Image) (resources.GetObject("btnEnglish.Image")));
            this.btnEnglish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEnglish.Location = new System.Drawing.Point(69, 53);
            this.btnEnglish.Name = "btnEnglish";
            this.btnEnglish.Size = new System.Drawing.Size(200, 50);
            this.btnEnglish.TabIndex = 0;
            this.btnEnglish.Text = "btnEnglish";
            this.btnEnglish.UseVisualStyleBackColor = true;
            this.btnEnglish.Click += new System.EventHandler(this.btnEnglish_Click);
            // 
            // btnDanish
            // 
            this.btnDanish.Image = ((System.Drawing.Image) (resources.GetObject("btnDanish.Image")));
            this.btnDanish.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDanish.Location = new System.Drawing.Point(513, 53);
            this.btnDanish.Name = "btnDanish";
            this.btnDanish.Size = new System.Drawing.Size(200, 50);
            this.btnDanish.TabIndex = 1;
            this.btnDanish.Text = "btnDanish";
            this.btnDanish.UseVisualStyleBackColor = true;
            this.btnDanish.Click += new System.EventHandler(this.btnDanish_Click);
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(289, 153);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(200, 50);
            this.btnOK.TabIndex = 2;
            this.btnOK.Text = "btnOK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 253);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnDanish);
            this.Controls.Add(this.btnEnglish);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnEnglish;
        private System.Windows.Forms.Button btnDanish;
        private System.Windows.Forms.Button btnOK;

        #endregion
    }
}