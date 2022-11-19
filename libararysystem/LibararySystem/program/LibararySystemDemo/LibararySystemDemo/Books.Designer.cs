namespace LibararySystemDemo
{
	partial class Books
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
            this.bookclasscombobox = new System.Windows.Forms.ComboBox();
            this.bookCategoryIndexViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Searchbtn = new System.Windows.Forms.Button();
            this.BooknameText = new System.Windows.Forms.TextBox();
            this.authortext = new System.Windows.Forms.TextBox();
            this.isbntexbox = new System.Windows.Forms.TextBox();
            this.publishyeartextbox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.addbtn = new System.Windows.Forms.Button();
            this.BooksIndexViewBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.bookCategoryViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.booksViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BooksIndexViewBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.booksViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.booksViewBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.booksViewBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.booksIndexViewBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.booksIndexViewBindingSource6 = new System.Windows.Forms.BindingSource(this.components);
            this.booksViewBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
            this.booksViewBindingSource5 = new System.Windows.Forms.BindingSource(this.components);
            this.booksIndexViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.booksIndexViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.booksIndexViewBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.booksIndexViewBindingSource7 = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.booksIndexViewBindingSource8 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bookCategoryIndexViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksIndexViewBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCategoryViewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksIndexViewBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksViewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksViewBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksViewBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksIndexViewBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksIndexViewBindingSource6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksViewBindingSource4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksViewBindingSource5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksIndexViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksIndexViewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksIndexViewBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksIndexViewBindingSource7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksIndexViewBindingSource8)).BeginInit();
            this.SuspendLayout();
            // 
            // bookclasscombobox
            // 
            this.bookclasscombobox.DataSource = this.bookCategoryIndexViewBindingSource;
            this.bookclasscombobox.DisplayMember = "CategoryName";
            this.bookclasscombobox.FormattingEnabled = true;
            this.bookclasscombobox.Location = new System.Drawing.Point(35, 82);
            this.bookclasscombobox.Margin = new System.Windows.Forms.Padding(6);
            this.bookclasscombobox.Name = "bookclasscombobox";
            this.bookclasscombobox.Size = new System.Drawing.Size(251, 32);
            this.bookclasscombobox.TabIndex = 2;
            this.bookclasscombobox.ValueMember = "CategoryID";
            // 
            // bookCategoryIndexViewBindingSource
            // 
            this.bookCategoryIndexViewBindingSource.DataSource = typeof(LibararySystemDemo.model.dataindex.BookCategoryIndexView);
            // 
            // Searchbtn
            // 
            this.Searchbtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.Searchbtn.Location = new System.Drawing.Point(1384, 102);
            this.Searchbtn.Margin = new System.Windows.Forms.Padding(6);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(219, 58);
            this.Searchbtn.TabIndex = 3;
            this.Searchbtn.Text = "查詢";
            this.Searchbtn.UseVisualStyleBackColor = false;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // BooknameText
            // 
            this.BooknameText.Location = new System.Drawing.Point(338, 78);
            this.BooknameText.Margin = new System.Windows.Forms.Padding(6);
            this.BooknameText.Name = "BooknameText";
            this.BooknameText.Size = new System.Drawing.Size(206, 36);
            this.BooknameText.TabIndex = 4;
            // 
            // authortext
            // 
            this.authortext.Location = new System.Drawing.Point(598, 76);
            this.authortext.Margin = new System.Windows.Forms.Padding(6);
            this.authortext.Name = "authortext";
            this.authortext.Size = new System.Drawing.Size(206, 36);
            this.authortext.TabIndex = 4;
            // 
            // isbntexbox
            // 
            this.isbntexbox.Location = new System.Drawing.Point(847, 76);
            this.isbntexbox.Margin = new System.Windows.Forms.Padding(6);
            this.isbntexbox.Name = "isbntexbox";
            this.isbntexbox.Size = new System.Drawing.Size(206, 36);
            this.isbntexbox.TabIndex = 4;
            // 
            // publishyeartextbox
            // 
            this.publishyeartextbox.Location = new System.Drawing.Point(1107, 74);
            this.publishyeartextbox.Margin = new System.Windows.Forms.Padding(6);
            this.publishyeartextbox.Name = "publishyeartextbox";
            this.publishyeartextbox.Size = new System.Drawing.Size(206, 36);
            this.publishyeartextbox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 9F);
            this.label1.Location = new System.Drawing.Point(35, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "分類";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 46);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 24);
            this.label2.TabIndex = 5;
            this.label2.Text = "書名";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(594, 46);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "作者";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(843, 46);
            this.label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 24);
            this.label4.TabIndex = 5;
            this.label4.Text = "ISBN";
            // 
            // addbtn
            // 
            this.addbtn.BackColor = System.Drawing.Color.LavenderBlush;
            this.addbtn.Location = new System.Drawing.Point(1384, 28);
            this.addbtn.Margin = new System.Windows.Forms.Padding(6);
            this.addbtn.Name = "addbtn";
            this.addbtn.Size = new System.Drawing.Size(219, 58);
            this.addbtn.TabIndex = 3;
            this.addbtn.Text = "新增";
            this.addbtn.UseVisualStyleBackColor = false;
            this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
            // 
            // booksViewBindingSource
            // 
            this.booksViewBindingSource.DataSource = typeof(LibararySystemDemo.model.dataindex.BooksView);
            // 
            // booksViewBindingSource1
            // 
            this.booksViewBindingSource1.DataSource = typeof(LibararySystemDemo.model.dataindex.BooksView);
            // 
            // booksViewBindingSource2
            // 
            this.booksViewBindingSource2.DataSource = typeof(LibararySystemDemo.model.dataindex.BooksView);
            // 
            // booksViewBindingSource3
            // 
            this.booksViewBindingSource3.DataSource = typeof(LibararySystemDemo.model.dataindex.BooksView);
            // 
            // booksIndexViewBindingSource5
            // 
            this.booksIndexViewBindingSource5.DataSource = typeof(LibararySystemDemo.model.dataindex.BooksIndexView);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1103, 44);
            this.label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 24);
            this.label5.TabIndex = 5;
            this.label5.Text = "出版年份";
            // 
            // booksIndexViewBindingSource6
            // 
            this.booksIndexViewBindingSource6.DataSource = typeof(LibararySystemDemo.model.dataindex.BooksIndexView);
            // 
            // booksViewBindingSource4
            // 
            this.booksViewBindingSource4.DataSource = typeof(LibararySystemDemo.model.dataindex.BooksView);
            // 
            // booksViewBindingSource5
            // 
            this.booksViewBindingSource5.DataSource = typeof(LibararySystemDemo.model.dataindex.BooksView);
            // 
            // booksIndexViewBindingSource
            // 
            this.booksIndexViewBindingSource.DataSource = typeof(LibararySystemDemo.model.dataindex.BooksIndexView);
            // 
            // booksIndexViewBindingSource1
            // 
            this.booksIndexViewBindingSource1.DataSource = typeof(LibararySystemDemo.model.dataindex.BooksIndexView);
            // 
            // booksIndexViewBindingSource2
            // 
            this.booksIndexViewBindingSource2.DataSource = typeof(LibararySystemDemo.model.dataindex.BooksIndexView);
            // 
            // booksIndexViewBindingSource7
            // 
            this.booksIndexViewBindingSource7.DataSource = typeof(LibararySystemDemo.model.dataindex.BooksIndexView);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn2,
            this.categoryNameDataGridViewTextBoxColumn,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.dataGridView1.DataSource = this.booksIndexViewBindingSource8;
            this.dataGridView1.Location = new System.Drawing.Point(35, 300);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 38;
            this.dataGridView1.Size = new System.Drawing.Size(1551, 338);
            this.dataGridView1.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "BookName";
            this.dataGridViewTextBoxColumn2.HeaderText = "BookName";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // categoryNameDataGridViewTextBoxColumn
            // 
            this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.HeaderText = "CategoryName";
            this.categoryNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
            this.categoryNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Author";
            this.dataGridViewTextBoxColumn3.HeaderText = "Author";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 200;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "ISBN";
            this.dataGridViewTextBoxColumn4.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 200;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "PublishYear";
            this.dataGridViewTextBoxColumn5.HeaderText = "PublishYear";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 10;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 200;
            // 
            // booksIndexViewBindingSource8
            // 
            this.booksIndexViewBindingSource8.DataSource = typeof(LibararySystemDemo.model.dataindex.BooksIndexView);
            // 
            // Books
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Pink;
            this.ClientSize = new System.Drawing.Size(1640, 670);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.publishyeartextbox);
            this.Controls.Add(this.isbntexbox);
            this.Controls.Add(this.authortext);
            this.Controls.Add(this.BooknameText);
            this.Controls.Add(this.addbtn);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.bookclasscombobox);
            this.Location = new System.Drawing.Point(783, 406);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximumSize = new System.Drawing.Size(1666, 741);
            this.MinimumSize = new System.Drawing.Size(1666, 741);
            this.Name = "Books";
            this.Text = "BookCategory";
            this.Load += new System.EventHandler(this.BookCategory_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookCategoryIndexViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksIndexViewBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCategoryViewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BooksIndexViewBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksViewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksViewBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksViewBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksIndexViewBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksIndexViewBindingSource6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksViewBindingSource4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksViewBindingSource5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksIndexViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksIndexViewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksIndexViewBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksIndexViewBindingSource7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksIndexViewBindingSource8)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ComboBox bookclasscombobox;
		private System.Windows.Forms.Button Searchbtn;
		private System.Windows.Forms.TextBox BooknameText;
		private System.Windows.Forms.TextBox authortext;
		private System.Windows.Forms.TextBox isbntexbox;
		private System.Windows.Forms.TextBox publishyeartextbox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookClassDataGridViewTextBoxColumn;
		private System.Windows.Forms.Button addbtn;
		private System.Windows.Forms.BindingSource BooksIndexViewBindingSource3;
		private System.Windows.Forms.BindingSource bookCategoryViewBindingSource1;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn publishYearDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource BooksIndexViewBindingSource4;
        private System.Windows.Forms.BindingSource bookCategoryIndexViewBindingSource;
        private System.Windows.Forms.BindingSource booksViewBindingSource;
        private System.Windows.Forms.BindingSource booksViewBindingSource1;
        private System.Windows.Forms.BindingSource booksViewBindingSource2;
        private System.Windows.Forms.BindingSource booksViewBindingSource3;
        private System.Windows.Forms.BindingSource booksIndexViewBindingSource5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.BindingSource booksViewBindingSource4;
        private System.Windows.Forms.BindingSource booksIndexViewBindingSource6;
        private System.Windows.Forms.BindingSource booksViewBindingSource5;
        private System.Windows.Forms.BindingSource booksIndexViewBindingSource;
        private System.Windows.Forms.BindingSource booksIndexViewBindingSource1;
        private System.Windows.Forms.BindingSource booksIndexViewBindingSource2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource booksIndexViewBindingSource7;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.BindingSource booksIndexViewBindingSource8;
    }
}