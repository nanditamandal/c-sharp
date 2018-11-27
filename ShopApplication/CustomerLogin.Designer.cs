namespace ShopApplication
{
    partial class CustomerLogin
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
            this.lgoinbtn = new System.Windows.Forms.Button();
            this.regbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nametextbtn = new System.Windows.Forms.TextBox();
            this.passwordtextbtn = new System.Windows.Forms.TextBox();
            this.backbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lgoinbtn
            // 
            this.lgoinbtn.Location = new System.Drawing.Point(47, 180);
            this.lgoinbtn.Name = "lgoinbtn";
            this.lgoinbtn.Size = new System.Drawing.Size(75, 23);
            this.lgoinbtn.TabIndex = 0;
            this.lgoinbtn.Text = "Log in";
            this.lgoinbtn.UseVisualStyleBackColor = true;
            this.lgoinbtn.Click += new System.EventHandler(this.lgoinbtn_Click);
            // 
            // regbtn
            // 
            this.regbtn.Location = new System.Drawing.Point(142, 180);
            this.regbtn.Name = "regbtn";
            this.regbtn.Size = new System.Drawing.Size(75, 23);
            this.regbtn.TabIndex = 1;
            this.regbtn.Text = "Registration";
            this.regbtn.UseVisualStyleBackColor = true;
            this.regbtn.Click += new System.EventHandler(this.regbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 65);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(44, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // nametextbtn
            // 
            this.nametextbtn.Location = new System.Drawing.Point(142, 57);
            this.nametextbtn.Name = "nametextbtn";
            this.nametextbtn.Size = new System.Drawing.Size(157, 20);
            this.nametextbtn.TabIndex = 4;
            // 
            // passwordtextbtn
            // 
            this.passwordtextbtn.Location = new System.Drawing.Point(142, 122);
            this.passwordtextbtn.Name = "passwordtextbtn";
            this.passwordtextbtn.Size = new System.Drawing.Size(157, 20);
            this.passwordtextbtn.TabIndex = 5;
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(224, 180);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 6;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // CustomerLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 261);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.passwordtextbtn);
            this.Controls.Add(this.nametextbtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regbtn);
            this.Controls.Add(this.lgoinbtn);
            this.Name = "CustomerLogin";
            this.Text = "CustomerLogin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lgoinbtn;
        private System.Windows.Forms.Button regbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nametextbtn;
        private System.Windows.Forms.TextBox passwordtextbtn;
        private System.Windows.Forms.Button backbtn;
    }
}