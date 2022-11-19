namespace LibararySystemDemo
{
	partial class CreatBookCategory
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.categorycombobox = new System.Windows.Forms.ComboBox();
            this.bookClassIndexViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.bookCategoryIndexViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bookClassIndexViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCategoryIndexViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 10F);
            this.label1.Location = new System.Drawing.Point(169, 92);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 10F);
            this.label2.Location = new System.Drawing.Point(169, 182);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 27);
            this.label2.TabIndex = 0;
            this.label2.Text = "書名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 10F);
            this.label3.Location = new System.Drawing.Point(169, 290);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "作者";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("新細明體", 10F);
            this.label4.Location = new System.Drawing.Point(169, 396);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 27);
            this.label4.TabIndex = 0;
            this.label4.Text = "ISBN";
            // 
            // categorycombobox
            // 
            this.categorycombobox.DataSource = this.bookCategoryIndexViewBindingSource;
            this.categorycombobox.DisplayMember = "CategoryName";
            this.categorycombobox.FormattingEnabled = true;
            this.categorycombobox.Location = new System.Drawing.Point(384, 600);
            this.categorycombobox.Margin = new System.Windows.Forms.Padding(6);
            this.categorycombobox.Name = "categorycombobox";
            this.categorycombobox.Size = new System.Drawing.Size(258, 32);
            this.categorycombobox.TabIndex = 1;
            this.categorycombobox.ValueMember = "CategoryID";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(384, 92);
            this.textBox1.Margin = new System.Windows.Forms.Padding(6);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(212, 36);
            this.textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(384, 182);
            this.textBox2.Margin = new System.Windows.Forms.Padding(6);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(212, 36);
            this.textBox2.TabIndex = 2;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(384, 284);
            this.textBox3.Margin = new System.Windows.Forms.Padding(6);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(212, 36);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(384, 390);
            this.textBox4.Margin = new System.Windows.Forms.Padding(6);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(212, 36);
            this.textBox4.TabIndex = 2;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(384, 490);
            this.textBox5.Margin = new System.Windows.Forms.Padding(6);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(212, 36);
            this.textBox5.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("新細明體", 10F);
            this.label5.Location = new System.Drawing.Point(169, 490);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 27);
            this.label5.TabIndex = 0;
            this.label5.Text = "出版年份";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("新細明體", 10F);
            this.label6.Location = new System.Drawing.Point(169, 600);
            this.label6.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 27);
            this.label6.TabIndex = 0;
            this.label6.Text = "分類";
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(384, 708);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(6);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(188, 60);
            this.SaveBtn.TabIndex = 3;
            this.SaveBtn.Text = "存檔";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // bookCategoryIndexViewBindingSource
            // 
            this.bookCategoryIndexViewBindingSource.DataSource = typeof(LibararySystemDemo.model.dataindex.BookCategoryIndexView);
            // 
            // CreatBookCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 898);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.categorycombobox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "CreatBookCategory";
            this.Text = "CreatBookCategory";
            ((System.ComponentModel.ISupportInitialize)(this.bookClassIndexViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCategoryIndexViewBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox categorycombobox;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button SaveBtn;
		private System.Windows.Forms.BindingSource bookClassIndexViewBindingSource;
        private System.Windows.Forms.BindingSource bookCategoryIndexViewBindingSource;
    }
}