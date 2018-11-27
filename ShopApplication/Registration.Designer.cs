namespace ShopApplication
{
    partial class reg
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
            this.RegNameLab = new System.Windows.Forms.Label();
            this.ID = new System.Windows.Forms.Label();
            this.Mobile = new System.Windows.Forms.Label();
            this.RegAddBtn = new System.Windows.Forms.Button();
            this.RegBackBtn = new System.Windows.Forms.Button();
            this.RegWelLab = new System.Windows.Forms.Label();
            this.nametextbox = new System.Windows.Forms.TextBox();
            this.idtextbox = new System.Windows.Forms.TextBox();
            this.passwordtextbox = new System.Windows.Forms.TextBox();
            this.mobiletextbox = new System.Windows.Forms.TextBox();
            this.addresstextbox = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.Label();
            this.Password = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // RegNameLab
            // 
            this.RegNameLab.AutoSize = true;
            this.RegNameLab.Location = new System.Drawing.Point(33, 67);
            this.RegNameLab.Name = "RegNameLab";
            this.RegNameLab.Size = new System.Drawing.Size(35, 13);
            this.RegNameLab.TabIndex = 0;
            this.RegNameLab.Text = "Name";
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Location = new System.Drawing.Point(33, 100);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(18, 13);
            this.ID.TabIndex = 1;
            this.ID.Text = "ID";
            // 
            // Mobile
            // 
            this.Mobile.AutoSize = true;
            this.Mobile.Location = new System.Drawing.Point(33, 165);
            this.Mobile.Name = "Mobile";
            this.Mobile.Size = new System.Drawing.Size(38, 13);
            this.Mobile.TabIndex = 3;
            this.Mobile.Text = "Mobile";
            // 
            // RegAddBtn
            // 
            this.RegAddBtn.Location = new System.Drawing.Point(102, 261);
            this.RegAddBtn.Name = "RegAddBtn";
            this.RegAddBtn.Size = new System.Drawing.Size(75, 23);
            this.RegAddBtn.TabIndex = 4;
            this.RegAddBtn.Text = "SignUp";
            this.RegAddBtn.UseVisualStyleBackColor = true;
            this.RegAddBtn.Click += new System.EventHandler(this.RegAddBtn_Click);
            // 
            // RegBackBtn
            // 
            this.RegBackBtn.Location = new System.Drawing.Point(203, 261);
            this.RegBackBtn.Name = "RegBackBtn";
            this.RegBackBtn.Size = new System.Drawing.Size(75, 23);
            this.RegBackBtn.TabIndex = 5;
            this.RegBackBtn.Text = "Back";
            this.RegBackBtn.UseVisualStyleBackColor = true;
            this.RegBackBtn.Click += new System.EventHandler(this.RegBackBtn_Click);
            // 
            // RegWelLab
            // 
            this.RegWelLab.BackColor = System.Drawing.SystemColors.HighlightText;
            this.RegWelLab.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegWelLab.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.RegWelLab.Location = new System.Drawing.Point(102, 9);
            this.RegWelLab.Name = "RegWelLab";
            this.RegWelLab.Size = new System.Drawing.Size(121, 41);
            this.RegWelLab.TabIndex = 6;
            this.RegWelLab.Text = "Registration";
            // 
            // nametextbox
            // 
            this.nametextbox.Location = new System.Drawing.Point(102, 67);
            this.nametextbox.Name = "nametextbox";
            this.nametextbox.Size = new System.Drawing.Size(176, 20);
            this.nametextbox.TabIndex = 7;
            // 
            // idtextbox
            // 
            this.idtextbox.Location = new System.Drawing.Point(102, 97);
            this.idtextbox.Name = "idtextbox";
            this.idtextbox.Size = new System.Drawing.Size(176, 20);
            this.idtextbox.TabIndex = 8;
            // 
            // passwordtextbox
            // 
            this.passwordtextbox.Location = new System.Drawing.Point(102, 132);
            this.passwordtextbox.Name = "passwordtextbox";
            this.passwordtextbox.Size = new System.Drawing.Size(176, 20);
            this.passwordtextbox.TabIndex = 9;
            // 
            // mobiletextbox
            // 
            this.mobiletextbox.Location = new System.Drawing.Point(102, 165);
            this.mobiletextbox.Name = "mobiletextbox";
            this.mobiletextbox.Size = new System.Drawing.Size(176, 20);
            this.mobiletextbox.TabIndex = 10;
            this.mobiletextbox.TextChanged += new System.EventHandler(this.RegPassTBox_TextChanged);
            // 
            // addresstextbox
            // 
            this.addresstextbox.Location = new System.Drawing.Point(102, 191);
            this.addresstextbox.Name = "addresstextbox";
            this.addresstextbox.Size = new System.Drawing.Size(176, 20);
            this.addresstextbox.TabIndex = 11;
            this.addresstextbox.TextChanged += new System.EventHandler(this.RegIDBox_TextChanged);
            // 
            // Address
            // 
            this.Address.AutoSize = true;
            this.Address.Location = new System.Drawing.Point(33, 194);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(45, 13);
            this.Address.TabIndex = 12;
            this.Address.Text = "Address";
            // 
            // Password
            // 
            this.Password.AutoSize = true;
            this.Password.Location = new System.Drawing.Point(33, 132);
            this.Password.Name = "Password";
            this.Password.Size = new System.Drawing.Size(52, 13);
            this.Password.TabIndex = 2;
            this.Password.Text = "password";
            // 
            // reg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 296);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.addresstextbox);
            this.Controls.Add(this.mobiletextbox);
            this.Controls.Add(this.passwordtextbox);
            this.Controls.Add(this.idtextbox);
            this.Controls.Add(this.nametextbox);
            this.Controls.Add(this.RegWelLab);
            this.Controls.Add(this.RegBackBtn);
            this.Controls.Add(this.RegAddBtn);
            this.Controls.Add(this.Mobile);
            this.Controls.Add(this.Password);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.RegNameLab);
            this.Name = "reg";
            this.Text = "Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label RegNameLab;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.Label Mobile;
        private System.Windows.Forms.Button RegAddBtn;
        private System.Windows.Forms.Button RegBackBtn;
        private System.Windows.Forms.Label RegWelLab;
        private System.Windows.Forms.TextBox nametextbox;
        private System.Windows.Forms.TextBox idtextbox;
        private System.Windows.Forms.TextBox passwordtextbox;
        private System.Windows.Forms.TextBox mobiletextbox;
        private System.Windows.Forms.TextBox addresstextbox;
        private System.Windows.Forms.Label Address;
        private System.Windows.Forms.Label Password;
    }
}