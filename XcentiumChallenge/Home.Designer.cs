namespace XcentiumChallenge
{
    partial class Home
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pictureBoxWelcome = new System.Windows.Forms.PictureBox();
            this.lblUser = new System.Windows.Forms.Label();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWelcome)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.BackgroundImage = global::XcentiumChallenge.Properties.Resources.heroBanner;
            this.pnlMain.Controls.Add(this.pictureBoxWelcome);
            this.pnlMain.Controls.Add(this.lblUser);
            this.pnlMain.Location = new System.Drawing.Point(3, 40);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(819, 312);
            this.pnlMain.TabIndex = 3;
            // 
            // pictureBoxWelcome
            // 
            this.pictureBoxWelcome.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxWelcome.Image = global::XcentiumChallenge.Properties.Resources.Asset_1;
            this.pictureBoxWelcome.Location = new System.Drawing.Point(35, 41);
            this.pictureBoxWelcome.Name = "pictureBoxWelcome";
            this.pictureBoxWelcome.Size = new System.Drawing.Size(234, 72);
            this.pictureBoxWelcome.TabIndex = 2;
            this.pictureBoxWelcome.TabStop = false;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Brush Script MT", 42F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(105, 116);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(164, 86);
            this.lblUser.TabIndex = 1;
            this.lblUser.Text = "Name";
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlMain);
            this.Name = "Home";
            this.Size = new System.Drawing.Size(822, 394);
            this.Load += new System.EventHandler(this.UserProfile_Load);
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxWelcome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.PictureBox pictureBoxWelcome;
    }
}
