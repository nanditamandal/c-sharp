namespace ShopApplication
{
    partial class ProjectMain_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProjectMain_Form));
            this.Adimn = new System.Windows.Forms.Button();
            this.Salesman = new System.Windows.Forms.Button();
            this.Customer = new System.Windows.Forms.Button();
            this.Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Adimn
            // 
            this.Adimn.Location = new System.Drawing.Point(490, 12);
            this.Adimn.Name = "Adimn";
            this.Adimn.Size = new System.Drawing.Size(98, 23);
            this.Adimn.TabIndex = 0;
            this.Adimn.Text = "ADMIN";
            this.Adimn.UseVisualStyleBackColor = true;
            this.Adimn.Click += new System.EventHandler(this.Adimn_Click);
            // 
            // Salesman
            // 
            this.Salesman.Location = new System.Drawing.Point(490, 41);
            this.Salesman.Name = "Salesman";
            this.Salesman.Size = new System.Drawing.Size(98, 23);
            this.Salesman.TabIndex = 1;
            this.Salesman.Text = "SALESMAN";
            this.Salesman.UseVisualStyleBackColor = true;
            this.Salesman.Click += new System.EventHandler(this.Salesman_Click);
            // 
            // Customer
            // 
            this.Customer.Location = new System.Drawing.Point(490, 70);
            this.Customer.Name = "Customer";
            this.Customer.Size = new System.Drawing.Size(98, 23);
            this.Customer.TabIndex = 2;
            this.Customer.Text = "CUSTOMER";
            this.Customer.UseVisualStyleBackColor = true;
            this.Customer.Click += new System.EventHandler(this.Customer_Click);
            // 
            // Exit
            // 
            this.Exit.Location = new System.Drawing.Point(490, 308);
            this.Exit.Name = "Exit";
            this.Exit.Size = new System.Drawing.Size(98, 23);
            this.Exit.TabIndex = 3;
            this.Exit.Text = "EXIT";
            this.Exit.UseVisualStyleBackColor = true;
            this.Exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // ProjectMain_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(600, 343);
            this.Controls.Add(this.Exit);
            this.Controls.Add(this.Customer);
            this.Controls.Add(this.Salesman);
            this.Controls.Add(this.Adimn);
            this.Name = "ProjectMain_Form";
            this.Text = "ProjectMain_Form";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Adimn;
        private System.Windows.Forms.Button Salesman;
        private System.Windows.Forms.Button Customer;
        private System.Windows.Forms.Button Exit;
    }
}