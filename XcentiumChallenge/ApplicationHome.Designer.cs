namespace XcentiumChallenge
{
    partial class ApplicationHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApplicationHome));
            this.pnlMenuStrip3 = new System.Windows.Forms.Panel();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.pnlMenuStrip1 = new System.Windows.Forms.Panel();
            this.lblCodeChallenge = new System.Windows.Forms.Label();
            this.pnlMenuStrip2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnAbout = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.pnlMain = new System.Windows.Forms.Panel();
            this.pnlMenuStrip3.SuspendLayout();
            this.pnlMenuStrip1.SuspendLayout();
            this.pnlMenuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMenuStrip3
            // 
            this.pnlMenuStrip3.BackColor = System.Drawing.Color.Black;
            this.pnlMenuStrip3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMenuStrip3.Controls.Add(this.btnMinimize);
            this.pnlMenuStrip3.Controls.Add(this.btnExit);
            this.pnlMenuStrip3.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuStrip3.Location = new System.Drawing.Point(0, 0);
            this.pnlMenuStrip3.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenuStrip3.Name = "pnlMenuStrip3";
            this.pnlMenuStrip3.Size = new System.Drawing.Size(822, 40);
            this.pnlMenuStrip3.TabIndex = 2;
            this.pnlMenuStrip3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_Event);
            this.pnlMenuStrip3.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_Event);
            this.pnlMenuStrip3.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_Event);
            // 
            // btnMinimize
            // 
            this.btnMinimize.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnMinimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Image = ((System.Drawing.Image)(resources.GetObject("btnMinimize.Image")));
            this.btnMinimize.Location = new System.Drawing.Point(714, 0);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(52, 36);
            this.btnMinimize.TabIndex = 1;
            this.btnMinimize.UseVisualStyleBackColor = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(766, 0);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(52, 36);
            this.btnExit.TabIndex = 0;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // pnlMenuStrip1
            // 
            this.pnlMenuStrip1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.pnlMenuStrip1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMenuStrip1.Controls.Add(this.lblCodeChallenge);
            this.pnlMenuStrip1.Controls.Add(this.pnlMenuStrip2);
            this.pnlMenuStrip1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMenuStrip1.Location = new System.Drawing.Point(0, 40);
            this.pnlMenuStrip1.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenuStrip1.Name = "pnlMenuStrip1";
            this.pnlMenuStrip1.Size = new System.Drawing.Size(822, 53);
            this.pnlMenuStrip1.TabIndex = 3;
            this.pnlMenuStrip1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_Event);
            this.pnlMenuStrip1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_Event);
            this.pnlMenuStrip1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_Event);
            // 
            // lblCodeChallenge
            // 
            this.lblCodeChallenge.AutoSize = true;
            this.lblCodeChallenge.BackColor = System.Drawing.Color.LightSteelBlue;
            this.lblCodeChallenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCodeChallenge.ForeColor = System.Drawing.Color.Black;
            this.lblCodeChallenge.Location = new System.Drawing.Point(6, 5);
            this.lblCodeChallenge.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCodeChallenge.Name = "lblCodeChallenge";
            this.lblCodeChallenge.Size = new System.Drawing.Size(416, 36);
            this.lblCodeChallenge.TabIndex = 4;
            this.lblCodeChallenge.Text = "XCENTIUM Code Challenge";
          
            // 
            // pnlMenuStrip2
            // 
            this.pnlMenuStrip2.Controls.Add(this.btnLogout);
            this.pnlMenuStrip2.Controls.Add(this.btnAbout);
            this.pnlMenuStrip2.Controls.Add(this.btnHome);
            this.pnlMenuStrip2.Location = new System.Drawing.Point(451, -1);
            this.pnlMenuStrip2.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMenuStrip2.Name = "pnlMenuStrip2";
            this.pnlMenuStrip2.Size = new System.Drawing.Size(347, 49);
            this.pnlMenuStrip2.TabIndex = 3;
            this.pnlMenuStrip2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_Event);
            this.pnlMenuStrip2.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_Event);
            this.pnlMenuStrip2.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_Event);
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Black;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnLogout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.Color.White;
            this.btnLogout.Location = new System.Drawing.Point(241, 5);
            this.btnLogout.Margin = new System.Windows.Forms.Padding(4);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(106, 41);
            this.btnLogout.TabIndex = 8;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // btnAbout
            // 
            this.btnAbout.BackColor = System.Drawing.Color.Black;
            this.btnAbout.FlatAppearance.BorderSize = 0;
            this.btnAbout.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnAbout.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnAbout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbout.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbout.ForeColor = System.Drawing.Color.White;
            this.btnAbout.Location = new System.Drawing.Point(129, 5);
            this.btnAbout.Margin = new System.Windows.Forms.Padding(4);
            this.btnAbout.Name = "btnAbout";
            this.btnAbout.Size = new System.Drawing.Size(106, 41);
            this.btnAbout.TabIndex = 7;
            this.btnAbout.Text = "About";
            this.btnAbout.UseVisualStyleBackColor = false;
            this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.Black;
            this.btnHome.FlatAppearance.BorderSize = 0;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DodgerBlue;
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.Color.White;
            this.btnHome.Location = new System.Drawing.Point(17, 5);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(106, 41);
            this.btnHome.TabIndex = 6;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pnlMain
            // 
            this.pnlMain.BackColor = System.Drawing.Color.AliceBlue;
            this.pnlMain.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 93);
            this.pnlMain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(822, 394);
            this.pnlMain.TabIndex = 4;
            // 
            // ApplicationHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.AliceBlue;
            this.ClientSize = new System.Drawing.Size(822, 487);
            this.Controls.Add(this.pnlMain);
            this.Controls.Add(this.pnlMenuStrip1);
            this.Controls.Add(this.pnlMenuStrip3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ApplicationHome";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Activated += new System.EventHandler(this.ApplicationHome_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.mouseDown_Event);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.mouseMove_Event);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.mouseUp_Event);
            this.pnlMenuStrip3.ResumeLayout(false);
            this.pnlMenuStrip1.ResumeLayout(false);
            this.pnlMenuStrip1.PerformLayout();
            this.pnlMenuStrip2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMenuStrip3;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel pnlMenuStrip1;
        private System.Windows.Forms.Label lblCodeChallenge;
        private System.Windows.Forms.Panel pnlMenuStrip2;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Button btnAbout;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlMain;
    }
}