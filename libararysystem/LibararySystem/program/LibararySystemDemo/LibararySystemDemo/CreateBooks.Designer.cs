namespace LibararySystemDemo
{
	partial class CreateBooks
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
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.categorycombobox = new System.Windows.Forms.ComboBox();
			this.bookCategoryIndexViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bookClassIndexViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.BookTXTBOX = new System.Windows.Forms.TextBox();
			this.authortxtbox = new System.Windows.Forms.TextBox();
			this.isbmtxtbox = new System.Windows.Forms.TextBox();
			this.pbyeartxtbox = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.SaveBtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.bookCategoryIndexViewBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bookClassIndexViewBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(68, 53);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(39, 19);
			this.label2.TabIndex = 0;
			this.label2.Text = "書名";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label3.Location = new System.Drawing.Point(68, 107);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(39, 19);
			this.label3.TabIndex = 0;
			this.label3.Text = "作者";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label4.Location = new System.Drawing.Point(68, 160);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(45, 19);
			this.label4.TabIndex = 0;
			this.label4.Text = "ISBN";
			// 
			// categorycombobox
			// 
			this.categorycombobox.DataSource = this.bookCategoryIndexViewBindingSource;
			this.categorycombobox.DisplayMember = "CategoryName";
			this.categorycombobox.FormattingEnabled = true;
			this.categorycombobox.Location = new System.Drawing.Point(167, 262);
			this.categorycombobox.Name = "categorycombobox";
			this.categorycombobox.Size = new System.Drawing.Size(121, 20);
			this.categorycombobox.TabIndex = 1;
			this.categorycombobox.ValueMember = "CategoryID";
			this.categorycombobox.SelectedIndexChanged += new System.EventHandler(this.categorycombobox_SelectedIndexChanged);
			// 
			// bookCategoryIndexViewBindingSource
			// 
			this.bookCategoryIndexViewBindingSource.DataSource = typeof(LibararySystemDemo.model.dataindex.BookCategoryIndexView);
			// 
			// BookTXTBOX
			// 
			this.BookTXTBOX.Location = new System.Drawing.Point(167, 53);
			this.BookTXTBOX.Name = "BookTXTBOX";
			this.BookTXTBOX.Size = new System.Drawing.Size(100, 22);
			this.BookTXTBOX.TabIndex = 2;
			// 
			// authortxtbox
			// 
			this.authortxtbox.Location = new System.Drawing.Point(167, 104);
			this.authortxtbox.Name = "authortxtbox";
			this.authortxtbox.Size = new System.Drawing.Size(100, 22);
			this.authortxtbox.TabIndex = 2;
			// 
			// isbmtxtbox
			// 
			this.isbmtxtbox.Location = new System.Drawing.Point(167, 157);
			this.isbmtxtbox.Name = "isbmtxtbox";
			this.isbmtxtbox.Size = new System.Drawing.Size(100, 22);
			this.isbmtxtbox.TabIndex = 2;
			// 
			// pbyeartxtbox
			// 
			this.pbyeartxtbox.Location = new System.Drawing.Point(167, 207);
			this.pbyeartxtbox.Name = "pbyeartxtbox";
			this.pbyeartxtbox.Size = new System.Drawing.Size(100, 22);
			this.pbyeartxtbox.TabIndex = 2;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label5.Location = new System.Drawing.Point(68, 207);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(69, 19);
			this.label5.TabIndex = 0;
			this.label5.Text = "出版年份";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label6.Location = new System.Drawing.Point(68, 262);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(39, 19);
			this.label6.TabIndex = 0;
			this.label6.Text = "分類";
			// 
			// SaveBtn
			// 
			this.SaveBtn.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.SaveBtn.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.SaveBtn.Location = new System.Drawing.Point(158, 326);
			this.SaveBtn.Name = "SaveBtn";
			this.SaveBtn.Size = new System.Drawing.Size(100, 38);
			this.SaveBtn.TabIndex = 3;
			this.SaveBtn.Text = "存檔";
			this.SaveBtn.UseVisualStyleBackColor = false;
			this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
			// 
			// CreateBooks
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightPink;
			this.ClientSize = new System.Drawing.Size(380, 418);
			this.Controls.Add(this.SaveBtn);
			this.Controls.Add(this.pbyeartxtbox);
			this.Controls.Add(this.isbmtxtbox);
			this.Controls.Add(this.authortxtbox);
			this.Controls.Add(this.BookTXTBOX);
			this.Controls.Add(this.categorycombobox);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Name = "CreateBooks";
			this.Text = "CreatBookCategory";
			this.Load += new System.EventHandler(this.CreateBooks_Load);
			((System.ComponentModel.ISupportInitialize)(this.bookCategoryIndexViewBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bookClassIndexViewBindingSource)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox categorycombobox;
		private System.Windows.Forms.TextBox BookTXTBOX;
		private System.Windows.Forms.TextBox authortxtbox;
		private System.Windows.Forms.TextBox isbmtxtbox;
		private System.Windows.Forms.TextBox pbyeartxtbox;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Button SaveBtn;
		private System.Windows.Forms.BindingSource bookClassIndexViewBindingSource;
        private System.Windows.Forms.BindingSource bookCategoryIndexViewBindingSource;
    }
}