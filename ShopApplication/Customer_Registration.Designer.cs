namespace ShopApplication
{
    partial class Customer_Registration
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.idtextBox1 = new System.Windows.Forms.TextBox();
            this.nametextBox2 = new System.Windows.Forms.TextBox();
            this.passwordtextBox3 = new System.Windows.Forms.TextBox();
            this.addresstextBox4 = new System.Windows.Forms.TextBox();
            this.mobiletextBox5 = new System.Windows.Forms.TextBox();
            this.confirmbtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mobile";
            // 
            // idtextBox1
            // 
            this.idtextBox1.Location = new System.Drawing.Point(123, 42);
            this.idtextBox1.Name = "idtextBox1";
            this.idtextBox1.Size = new System.Drawing.Size(100, 20);
            this.idtextBox1.TabIndex = 5;
            // 
            // nametextBox2
            // 
            this.nametextBox2.Location = new System.Drawing.Point(123, 73);
            this.nametextBox2.Name = "nametextBox2";
            this.nametextBox2.Size = new System.Drawing.Size(100, 20);
            this.nametextBox2.TabIndex = 6;
            // 
            // passwordtextBox3
            // 
            this.passwordtextBox3.Location = new System.Drawing.Point(123, 111);
            this.passwordtextBox3.Name = "passwordtextBox3";
            this.passwordtextBox3.Size = new System.Drawing.Size(100, 20);
            this.passwordtextBox3.TabIndex = 7;
            // 
            // addresstextBox4
            // 
            this.addresstextBox4.Location = new System.Drawing.Point(123, 143);
            this.addresstextBox4.Name = "addresstextBox4";
            this.addresstextBox4.Size = new System.Drawing.Size(100, 20);
            this.addresstextBox4.TabIndex = 8;
            // 
            // mobiletextBox5
            // 
            this.mobiletextBox5.Location = new System.Drawing.Point(123, 173);
            this.mobiletextBox5.Name = "mobiletextBox5";
            this.mobiletextBox5.Size = new System.Drawing.Size(100, 20);
            this.mobiletextBox5.TabIndex = 9;
            // 
            // confirmbtn
            // 
            this.confirmbtn.Location = new System.Drawing.Point(28, 216);
            this.confirmbtn.Name = "confirmbtn";
            this.confirmbtn.Size = new System.Drawing.Size(75, 23);
            this.confirmbtn.TabIndex = 10;
            this.confirmbtn.Text = "Confirm";
            this.confirmbtn.UseVisualStyleBackColor = true;
            this.confirmbtn.Click += new System.EventHandler(this.confirmbtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(148, 216);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(75, 23);
            this.backbtn.TabIndex = 11;
            this.backbtn.Text = "Back";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // Customer_Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.confirmbtn);
            this.Controls.Add(this.mobiletextBox5);
            this.Controls.Add(this.addresstextBox4);
            this.Controls.Add(this.passwordtextBox3);
            this.Controls.Add(this.nametextBox2);
            this.Controls.Add(this.idtextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Customer_Registration";
            this.Text = "Customer_Registration";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox idtextBox1;
        private System.Windows.Forms.TextBox nametextBox2;
        private System.Windows.Forms.TextBox passwordtextBox3;
        private System.Windows.Forms.TextBox addresstextBox4;
        private System.Windows.Forms.TextBox mobiletextBox5;
        private System.Windows.Forms.Button confirmbtn;
        private System.Windows.Forms.Button backbtn;
    }
}