namespace LibararySystemDemo
{
	partial class EditBooksForm
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
			this.categorycombobox = new System.Windows.Forms.ComboBox();
			this.bookCategoryIndexViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.booknametxtbox = new System.Windows.Forms.TextBox();
			this.authortxtbox = new System.Windows.Forms.TextBox();
			this.isbntxtbox = new System.Windows.Forms.TextBox();
			this.pbytxtbox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.deletebtn = new System.Windows.Forms.Button();
			this.executebtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.bookCategoryIndexViewBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// categorycombobox
			// 
			this.categorycombobox.BackColor = System.Drawing.Color.LavenderBlush;
			this.categorycombobox.DataSource = this.bookCategoryIndexViewBindingSource;
			this.categorycombobox.DisplayMember = "CategoryName";
			this.categorycombobox.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.categorycombobox.FormattingEnabled = true;
			this.categorycombobox.Location = new System.Drawing.Point(127, 50);
			this.categorycombobox.Name = "categorycombobox";
			this.categorycombobox.Size = new System.Drawing.Size(216, 27);
			this.categorycombobox.TabIndex = 0;
			this.categorycombobox.ValueMember = "CategoryID";
			// 
			// bookCategoryIndexViewBindingSource
			// 
			this.bookCategoryIndexViewBindingSource.DataSource = typeof(LibararySystemDemo.model.dataindex.BookCategoryIndexView);
			// 
			// booknametxtbox
			// 
			this.booknametxtbox.BackColor = System.Drawing.Color.LavenderBlush;
			this.booknametxtbox.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.booknametxtbox.Location = new System.Drawing.Point(127, 104);
			this.booknametxtbox.Name = "booknametxtbox";
			this.booknametxtbox.Size = new System.Drawing.Size(216, 27);
			this.booknametxtbox.TabIndex = 1;
			this.booknametxtbox.TextChanged += new System.EventHandler(this.booknametxtbox_TextChanged);
			// 
			// authortxtbox
			// 
			this.authortxtbox.BackColor = System.Drawing.Color.LavenderBlush;
			this.authortxtbox.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.authortxtbox.Location = new System.Drawing.Point(127, 162);
			this.authortxtbox.Name = "authortxtbox";
			this.authortxtbox.Size = new System.Drawing.Size(216, 27);
			this.authortxtbox.TabIndex = 1;
			// 
			// isbntxtbox
			// 
			this.isbntxtbox.BackColor = System.Drawing.Color.LavenderBlush;
			this.isbntxtbox.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.isbntxtbox.Location = new System.Drawing.Point(127, 211);
			this.isbntxtbox.Name = "isbntxtbox";
			this.isbntxtbox.Size = new System.Drawing.Size(216, 27);
			this.isbntxtbox.TabIndex = 1;
			// 
			// pbytxtbox
			// 
			this.pbytxtbox.BackColor = System.Drawing.Color.LavenderBlush;
			this.pbytxtbox.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.pbytxtbox.Location = new System.Drawing.Point(126, 259);
			this.pbytxtbox.Name = "pbytxtbox";
			this.pbytxtbox.Size = new System.Drawing.Size(216, 27);
			this.pbytxtbox.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(45, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(69, 19);
			this.label1.TabIndex = 2;
			this.label1.Text = "書籍分類";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(51, 104);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 19);
			this.label2.TabIndex = 2;
			this.label2.Text = "書名";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(51, 162);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 19);
			this.label3.TabIndex = 2;
			this.label3.Text = "作者";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(51, 211);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 19);
			this.label4.TabIndex = 2;
			this.label4.Text = "ISBN";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.Location = new System.Drawing.Point(51, 262);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 19);
			this.label5.TabIndex = 2;
			this.label5.Text = "出版年份";
			// 
			// deletebtn
			// 
			this.deletebtn.BackColor = System.Drawing.Color.LavenderBlush;
			this.deletebtn.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.deletebtn.Location = new System.Drawing.Point(194, 318);
			this.deletebtn.Name = "deletebtn";
			this.deletebtn.Size = new System.Drawing.Size(81, 32);
			this.deletebtn.TabIndex = 3;
			this.deletebtn.Text = "刪除";
			this.deletebtn.UseVisualStyleBackColor = false;
			this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
			// 
			// executebtn
			// 
			this.executebtn.BackColor = System.Drawing.Color.LavenderBlush;
			this.executebtn.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.executebtn.Location = new System.Drawing.Point(312, 318);
			this.executebtn.Name = "executebtn";
			this.executebtn.Size = new System.Drawing.Size(85, 32);
			this.executebtn.TabIndex = 3;
			this.executebtn.Text = "執行";
			this.executebtn.UseVisualStyleBackColor = false;
			this.executebtn.Click += new System.EventHandler(this.updateButton_Click);
			// 
			// EditBooksForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Pink;
			this.ClientSize = new System.Drawing.Size(442, 412);
			this.Controls.Add(this.executebtn);
			this.Controls.Add(this.deletebtn);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.pbytxtbox);
			this.Controls.Add(this.isbntxtbox);
			this.Controls.Add(this.authortxtbox);
			this.Controls.Add(this.booknametxtbox);
			this.Controls.Add(this.categorycombobox);
			this.MaximumSize = new System.Drawing.Size(458, 451);
			this.MinimumSize = new System.Drawing.Size(458, 451);
			this.Name = "EditBooksForm";
			this.Text = "EditBooksForm";
			this.Load += new System.EventHandler(this.EditBooksForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.bookCategoryIndexViewBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox categorycombobox;
		private System.Windows.Forms.TextBox booknametxtbox;
		private System.Windows.Forms.TextBox authortxtbox;
		private System.Windows.Forms.TextBox isbntxtbox;
		private System.Windows.Forms.TextBox pbytxtbox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Button deletebtn;
		private System.Windows.Forms.Button executebtn;
		private System.Windows.Forms.BindingSource bookCategoryIndexViewBindingSource;
	}
}