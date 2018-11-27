namespace ShopApplication
{
    partial class Salesman_Information
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
            this.components = new System.ComponentModel.Container();
            this.AdminSalesLab = new System.Windows.Forms.Label();
            this.AdminAddBtn = new System.Windows.Forms.Button();
            this.AdminUpdateBtn = new System.Windows.Forms.Button();
            this.AdminDelBtn = new System.Windows.Forms.Button();
            this.AdminLoadBtn = new System.Windows.Forms.Button();
            this.AdminBackBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.NametextBox1 = new System.Windows.Forms.TextBox();
            this.IDtextBox3 = new System.Windows.Forms.TextBox();
            this.PasswordtextBox4 = new System.Windows.Forms.TextBox();
            this.AddresstextBox5 = new System.Windows.Forms.TextBox();
            this.MobiletextBox6 = new System.Windows.Forms.TextBox();
            this.Search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.cSharpDataSet = new ShopApplication.CSharpDataSet();
            this.cSharpDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cSharpDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSharpDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AdminSalesLab
            // 
            this.AdminSalesLab.AutoSize = true;
            this.AdminSalesLab.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AdminSalesLab.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.AdminSalesLab.Location = new System.Drawing.Point(339, 12);
            this.AdminSalesLab.Name = "AdminSalesLab";
            this.AdminSalesLab.Size = new System.Drawing.Size(173, 18);
            this.AdminSalesLab.TabIndex = 0;
            this.AdminSalesLab.Text = "Salesman Information";
            this.AdminSalesLab.Click += new System.EventHandler(this.AdminSalesLab_Click);
            // 
            // AdminAddBtn
            // 
            this.AdminAddBtn.Location = new System.Drawing.Point(714, 59);
            this.AdminAddBtn.Name = "AdminAddBtn";
            this.AdminAddBtn.Size = new System.Drawing.Size(114, 23);
            this.AdminAddBtn.TabIndex = 1;
            this.AdminAddBtn.Text = "Add salesman";
            this.AdminAddBtn.UseVisualStyleBackColor = true;
            this.AdminAddBtn.Click += new System.EventHandler(this.AdminAddBtn_Click);
            // 
            // AdminUpdateBtn
            // 
            this.AdminUpdateBtn.Location = new System.Drawing.Point(714, 204);
            this.AdminUpdateBtn.Name = "AdminUpdateBtn";
            this.AdminUpdateBtn.Size = new System.Drawing.Size(114, 23);
            this.AdminUpdateBtn.TabIndex = 2;
            this.AdminUpdateBtn.Text = "Update Salesman";
            this.AdminUpdateBtn.UseVisualStyleBackColor = true;
            this.AdminUpdateBtn.Click += new System.EventHandler(this.AdminUpdateBtn_Click);
            // 
            // AdminDelBtn
            // 
            this.AdminDelBtn.Location = new System.Drawing.Point(714, 108);
            this.AdminDelBtn.Name = "AdminDelBtn";
            this.AdminDelBtn.Size = new System.Drawing.Size(114, 23);
            this.AdminDelBtn.TabIndex = 3;
            this.AdminDelBtn.Text = "Delete Salesman";
            this.AdminDelBtn.UseVisualStyleBackColor = true;
            this.AdminDelBtn.Click += new System.EventHandler(this.AdminDelBtn_Click);
            // 
            // AdminLoadBtn
            // 
            this.AdminLoadBtn.Location = new System.Drawing.Point(714, 260);
            this.AdminLoadBtn.Name = "AdminLoadBtn";
            this.AdminLoadBtn.Size = new System.Drawing.Size(114, 23);
            this.AdminLoadBtn.TabIndex = 4;
            this.AdminLoadBtn.Text = "Load";
            this.AdminLoadBtn.UseVisualStyleBackColor = true;
            this.AdminLoadBtn.Click += new System.EventHandler(this.AdminCheckBtn_Click);
            // 
            // AdminBackBtn
            // 
            this.AdminBackBtn.Location = new System.Drawing.Point(42, 12);
            this.AdminBackBtn.Name = "AdminBackBtn";
            this.AdminBackBtn.Size = new System.Drawing.Size(114, 23);
            this.AdminBackBtn.TabIndex = 5;
            this.AdminBackBtn.Text = "Back";
            this.AdminBackBtn.UseVisualStyleBackColor = true;
            this.AdminBackBtn.Click += new System.EventHandler(this.AdminBackBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(339, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Password";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(52, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "MobileNo";
            // 
            // NametextBox1
            // 
            this.NametextBox1.Location = new System.Drawing.Point(132, 59);
            this.NametextBox1.Name = "NametextBox1";
            this.NametextBox1.Size = new System.Drawing.Size(100, 20);
            this.NametextBox1.TabIndex = 11;
            this.NametextBox1.TextChanged += new System.EventHandler(this.NametextBox1_TextChanged);
            // 
            // IDtextBox3
            // 
            this.IDtextBox3.Location = new System.Drawing.Point(132, 101);
            this.IDtextBox3.Name = "IDtextBox3";
            this.IDtextBox3.Size = new System.Drawing.Size(100, 20);
            this.IDtextBox3.TabIndex = 13;
            // 
            // PasswordtextBox4
            // 
            this.PasswordtextBox4.Location = new System.Drawing.Point(429, 59);
            this.PasswordtextBox4.Name = "PasswordtextBox4";
            this.PasswordtextBox4.Size = new System.Drawing.Size(100, 20);
            this.PasswordtextBox4.TabIndex = 14;
            // 
            // AddresstextBox5
            // 
            this.AddresstextBox5.Location = new System.Drawing.Point(429, 105);
            this.AddresstextBox5.Name = "AddresstextBox5";
            this.AddresstextBox5.Size = new System.Drawing.Size(100, 20);
            this.AddresstextBox5.TabIndex = 15;
            // 
            // MobiletextBox6
            // 
            this.MobiletextBox6.Location = new System.Drawing.Point(132, 156);
            this.MobiletextBox6.Name = "MobiletextBox6";
            this.MobiletextBox6.Size = new System.Drawing.Size(100, 20);
            this.MobiletextBox6.TabIndex = 16;
            // 
            // Search
            // 
            this.Search.Location = new System.Drawing.Point(714, 156);
            this.Search.Name = "Search";
            this.Search.Size = new System.Drawing.Size(114, 23);
            this.Search.TabIndex = 18;
            this.Search.Text = "Search";
            this.Search.UseVisualStyleBackColor = true;
            this.Search.Click += new System.EventHandler(this.Search_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(575, 159);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 19;
            // 
            // cSharpDataSet
            // 
            this.cSharpDataSet.DataSetName = "CSharpDataSet";
            this.cSharpDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cSharpDataSetBindingSource
            // 
            this.cSharpDataSetBindingSource.DataSource = this.cSharpDataSet;
            this.cSharpDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(238, 204);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(437, 150);
            this.dataGridView1.TabIndex = 20;
            // 
            // Salesman_Information
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 379);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Search);
            this.Controls.Add(this.MobiletextBox6);
            this.Controls.Add(this.AddresstextBox5);
            this.Controls.Add(this.PasswordtextBox4);
            this.Controls.Add(this.IDtextBox3);
            this.Controls.Add(this.NametextBox1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AdminBackBtn);
            this.Controls.Add(this.AdminLoadBtn);
            this.Controls.Add(this.AdminDelBtn);
            this.Controls.Add(this.AdminUpdateBtn);
            this.Controls.Add(this.AdminAddBtn);
            this.Controls.Add(this.AdminSalesLab);
            this.Name = "Salesman_Information";
            this.Text = "Salesman_Information";
            this.Load += new System.EventHandler(this.Admin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cSharpDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cSharpDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AdminSalesLab;
        private System.Windows.Forms.Button AdminAddBtn;
        private System.Windows.Forms.Button AdminUpdateBtn;
        private System.Windows.Forms.Button AdminDelBtn;
        private System.Windows.Forms.Button AdminLoadBtn;
        private System.Windows.Forms.Button AdminBackBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox NametextBox1;
        private System.Windows.Forms.TextBox IDtextBox3;
        private System.Windows.Forms.TextBox PasswordtextBox4;
        private System.Windows.Forms.TextBox AddresstextBox5;
        private System.Windows.Forms.TextBox MobiletextBox6;
        private System.Windows.Forms.Button Search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.BindingSource cSharpDataSetBindingSource;
        private CSharpDataSet cSharpDataSet;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}