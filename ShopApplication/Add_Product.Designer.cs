namespace ShopApplication
{
    partial class product_detail
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
            this.AddProNameLab = new System.Windows.Forms.Label();
            this.AddProIDLab = new System.Windows.Forms.Label();
            this.AddProQuaLab = new System.Windows.Forms.Label();
            this.AddProPriLab = new System.Windows.Forms.Label();
            this.AddProAddBtn = new System.Windows.Forms.Button();
            this.backbtn = new System.Windows.Forms.Button();
            this.AddProNameTBox = new System.Windows.Forms.TextBox();
            this.AddProIDTBox = new System.Windows.Forms.TextBox();
            this.AddProQuaTBox = new System.Windows.Forms.TextBox();
            this.AddProPriTBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.delete = new System.Windows.Forms.Button();
            this.update = new System.Windows.Forms.Button();
            this.search = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.Load = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // AddProNameLab
            // 
            this.AddProNameLab.AutoSize = true;
            this.AddProNameLab.Location = new System.Drawing.Point(25, 32);
            this.AddProNameLab.Name = "AddProNameLab";
            this.AddProNameLab.Size = new System.Drawing.Size(75, 13);
            this.AddProNameLab.TabIndex = 0;
            this.AddProNameLab.Text = "Product Name";
            // 
            // AddProIDLab
            // 
            this.AddProIDLab.AutoSize = true;
            this.AddProIDLab.Location = new System.Drawing.Point(25, 66);
            this.AddProIDLab.Name = "AddProIDLab";
            this.AddProIDLab.Size = new System.Drawing.Size(58, 13);
            this.AddProIDLab.TabIndex = 1;
            this.AddProIDLab.Text = "Product ID";
            // 
            // AddProQuaLab
            // 
            this.AddProQuaLab.AutoSize = true;
            this.AddProQuaLab.Location = new System.Drawing.Point(25, 102);
            this.AddProQuaLab.Name = "AddProQuaLab";
            this.AddProQuaLab.Size = new System.Drawing.Size(46, 13);
            this.AddProQuaLab.TabIndex = 2;
            this.AddProQuaLab.Text = "Quantity";
            // 
            // AddProPriLab
            // 
            this.AddProPriLab.AutoSize = true;
            this.AddProPriLab.Location = new System.Drawing.Point(25, 135);
            this.AddProPriLab.Name = "AddProPriLab";
            this.AddProPriLab.Size = new System.Drawing.Size(71, 13);
            this.AddProPriLab.TabIndex = 3;
            this.AddProPriLab.Text = "Product Price";
            // 
            // AddProAddBtn
            // 
            this.AddProAddBtn.Location = new System.Drawing.Point(28, 193);
            this.AddProAddBtn.Name = "AddProAddBtn";
            this.AddProAddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddProAddBtn.TabIndex = 5;
            this.AddProAddBtn.Text = "Add Product";
            this.AddProAddBtn.UseVisualStyleBackColor = true;
            this.AddProAddBtn.Click += new System.EventHandler(this.AddProAddBtn_Click);
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(671, 226);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(100, 23);
            this.backbtn.TabIndex = 16;
            this.backbtn.Text = "Back";
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // AddProNameTBox
            // 
            this.AddProNameTBox.Location = new System.Drawing.Point(122, 29);
            this.AddProNameTBox.Name = "AddProNameTBox";
            this.AddProNameTBox.Size = new System.Drawing.Size(100, 20);
            this.AddProNameTBox.TabIndex = 7;
            // 
            // AddProIDTBox
            // 
            this.AddProIDTBox.Location = new System.Drawing.Point(122, 66);
            this.AddProIDTBox.Name = "AddProIDTBox";
            this.AddProIDTBox.Size = new System.Drawing.Size(100, 20);
            this.AddProIDTBox.TabIndex = 8;
            // 
            // AddProQuaTBox
            // 
            this.AddProQuaTBox.Location = new System.Drawing.Point(122, 102);
            this.AddProQuaTBox.Name = "AddProQuaTBox";
            this.AddProQuaTBox.Size = new System.Drawing.Size(100, 20);
            this.AddProQuaTBox.TabIndex = 9;
            // 
            // AddProPriTBox
            // 
            this.AddProPriTBox.Location = new System.Drawing.Point(122, 135);
            this.AddProPriTBox.Name = "AddProPriTBox";
            this.AddProPriTBox.Size = new System.Drawing.Size(100, 20);
            this.AddProPriTBox.TabIndex = 10;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(330, 29);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(469, 126);
            this.dataGridView1.TabIndex = 11;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(122, 193);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(75, 23);
            this.delete.TabIndex = 12;
            this.delete.Text = "delete";
            this.delete.UseVisualStyleBackColor = true;
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // update
            // 
            this.update.Location = new System.Drawing.Point(225, 193);
            this.update.Name = "update";
            this.update.Size = new System.Drawing.Size(75, 23);
            this.update.TabIndex = 13;
            this.update.Text = "update";
            this.update.UseVisualStyleBackColor = true;
            this.update.Click += new System.EventHandler(this.update_Click);
            // 
            // search
            // 
            this.search.Location = new System.Drawing.Point(555, 193);
            this.search.Name = "search";
            this.search.Size = new System.Drawing.Size(75, 23);
            this.search.TabIndex = 14;
            this.search.Text = "search";
            this.search.UseVisualStyleBackColor = true;
            this.search.Click += new System.EventHandler(this.search_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(671, 193);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 15;
            // 
            // Load
            // 
            this.Load.Location = new System.Drawing.Point(306, 193);
            this.Load.Name = "Load";
            this.Load.Size = new System.Drawing.Size(75, 23);
            this.Load.TabIndex = 17;
            this.Load.Text = "Load";
            this.Load.UseVisualStyleBackColor = true;
            this.Load.Click += new System.EventHandler(this.Load_Click);
            // 
            // product_detail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 261);
            this.Controls.Add(this.Load);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.search);
            this.Controls.Add(this.update);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.AddProPriTBox);
            this.Controls.Add(this.AddProQuaTBox);
            this.Controls.Add(this.AddProIDTBox);
            this.Controls.Add(this.AddProNameTBox);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.AddProAddBtn);
            this.Controls.Add(this.AddProPriLab);
            this.Controls.Add(this.AddProQuaLab);
            this.Controls.Add(this.AddProIDLab);
            this.Controls.Add(this.AddProNameLab);
            this.Name = "product_detail";
            this.Text = "PRODUCT DETAIL";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label AddProNameLab;
        private System.Windows.Forms.Label AddProIDLab;
        private System.Windows.Forms.Label AddProQuaLab;
        private System.Windows.Forms.Label AddProPriLab;
        private System.Windows.Forms.Button AddProAddBtn;
        private System.Windows.Forms.Button backbtn;
        private System.Windows.Forms.TextBox AddProNameTBox;
        private System.Windows.Forms.TextBox AddProIDTBox;
        private System.Windows.Forms.TextBox AddProQuaTBox;
        private System.Windows.Forms.TextBox AddProPriTBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button delete;
        private System.Windows.Forms.Button update;
        private System.Windows.Forms.Button search;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button Load;
    }
}