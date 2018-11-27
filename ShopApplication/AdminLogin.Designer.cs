namespace ShopApplication
{
    partial class Admin_login
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
            this.LoginWelLab = new System.Windows.Forms.Label();
            this.LoginUserLab = new System.Windows.Forms.Label();
            this.LoginPassLab = new System.Windows.Forms.Label();
            this.LoginPassTBox = new System.Windows.Forms.TextBox();
            this.LoginUserTBox = new System.Windows.Forms.TextBox();
            this.LoginLoginBtn = new System.Windows.Forms.Button();
            this.LoginRegBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // LoginWelLab
            // 
            this.LoginWelLab.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoginWelLab.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.LoginWelLab.Location = new System.Drawing.Point(126, 28);
            this.LoginWelLab.Name = "LoginWelLab";
            this.LoginWelLab.Size = new System.Drawing.Size(252, 44);
            this.LoginWelLab.TabIndex = 0;
            this.LoginWelLab.Text = "Admin Login";
            // 
            // LoginUserLab
            // 
            this.LoginUserLab.AutoSize = true;
            this.LoginUserLab.Location = new System.Drawing.Point(25, 93);
            this.LoginUserLab.Name = "LoginUserLab";
            this.LoginUserLab.Size = new System.Drawing.Size(55, 13);
            this.LoginUserLab.TabIndex = 1;
            this.LoginUserLab.Text = "Username";
            // 
            // LoginPassLab
            // 
            this.LoginPassLab.AutoSize = true;
            this.LoginPassLab.Location = new System.Drawing.Point(25, 141);
            this.LoginPassLab.Name = "LoginPassLab";
            this.LoginPassLab.Size = new System.Drawing.Size(53, 13);
            this.LoginPassLab.TabIndex = 2;
            this.LoginPassLab.Text = "Password";
            // 
            // LoginPassTBox
            // 
            this.LoginPassTBox.Location = new System.Drawing.Point(118, 134);
            this.LoginPassTBox.Name = "LoginPassTBox";
            this.LoginPassTBox.Size = new System.Drawing.Size(249, 20);
            this.LoginPassTBox.TabIndex = 3;
            this.LoginPassTBox.UseSystemPasswordChar = true;
            // 
            // LoginUserTBox
            // 
            this.LoginUserTBox.Location = new System.Drawing.Point(120, 93);
            this.LoginUserTBox.Name = "LoginUserTBox";
            this.LoginUserTBox.Size = new System.Drawing.Size(247, 20);
            this.LoginUserTBox.TabIndex = 4;
            // 
            // LoginLoginBtn
            // 
            this.LoginLoginBtn.Location = new System.Drawing.Point(28, 223);
            this.LoginLoginBtn.Name = "LoginLoginBtn";
            this.LoginLoginBtn.Size = new System.Drawing.Size(99, 23);
            this.LoginLoginBtn.TabIndex = 7;
            this.LoginLoginBtn.Text = "Login";
            this.LoginLoginBtn.UseVisualStyleBackColor = true;
            this.LoginLoginBtn.Click += new System.EventHandler(this.LoginLoginBtn_Click);
            // 
            // LoginRegBtn
            // 
            this.LoginRegBtn.Location = new System.Drawing.Point(150, 223);
            this.LoginRegBtn.Name = "LoginRegBtn";
            this.LoginRegBtn.Size = new System.Drawing.Size(96, 23);
            this.LoginRegBtn.TabIndex = 8;
            this.LoginRegBtn.Text = "Registration";
            this.LoginRegBtn.UseVisualStyleBackColor = true;
            this.LoginRegBtn.Click += new System.EventHandler(this.LoginRegBtn_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(268, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(99, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Admin_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 295);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.LoginRegBtn);
            this.Controls.Add(this.LoginLoginBtn);
            this.Controls.Add(this.LoginUserTBox);
            this.Controls.Add(this.LoginPassTBox);
            this.Controls.Add(this.LoginPassLab);
            this.Controls.Add(this.LoginUserLab);
            this.Controls.Add(this.LoginWelLab);
            this.Name = "Admin_login";
            this.Text = "ADMIN LOGIN";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LoginWelLab;
        private System.Windows.Forms.Label LoginUserLab;
        private System.Windows.Forms.Label LoginPassLab;
        private System.Windows.Forms.TextBox LoginPassTBox;
        private System.Windows.Forms.TextBox LoginUserTBox;
        private System.Windows.Forms.Button LoginLoginBtn;
        private System.Windows.Forms.Button LoginRegBtn;
        private System.Windows.Forms.Button button1;
    }
}

