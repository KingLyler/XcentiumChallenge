namespace XcentiumChallenge
{
    partial class About
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblAboutDesc = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAboutDesc
            // 
            this.lblAboutDesc.AutoSize = true;
            this.lblAboutDesc.BackColor = System.Drawing.Color.AliceBlue;
            this.lblAboutDesc.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAboutDesc.Location = new System.Drawing.Point(198, 70);
            this.lblAboutDesc.Name = "lblAboutDesc";
            this.lblAboutDesc.Size = new System.Drawing.Size(393, 232);
            this.lblAboutDesc.TabIndex = 0;
            this.lblAboutDesc.Text = "This application was designed \r\nby Kyle Klink\r\nin completion of the code challeng" +
    "e\r\nfor an Associate Developer role\r\nissued by Xcentium \r\non December 14, 2022\r\n\r" +
    "\nThank you for your consideration!";
            this.lblAboutDesc.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // About
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.Controls.Add(this.lblAboutDesc);
            this.Name = "About";
            this.Size = new System.Drawing.Size(800, 394);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAboutDesc;
    }
}
