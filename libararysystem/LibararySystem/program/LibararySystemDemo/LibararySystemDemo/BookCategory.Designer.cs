namespace LibararySystemDemo
{
	partial class BookCategory
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
			this.bookCategoryIndexViewBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.bookCategoryViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.bookCategoryIndexViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.bookCategoryIndexViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.bookclasscombobox = new System.Windows.Forms.ComboBox();
			this.bookClassIndexViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.bookClassIndexViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.Searchbtn = new System.Windows.Forms.Button();
			this.BooknameText = new System.Windows.Forms.TextBox();
			this.authortext = new System.Windows.Forms.TextBox();
			this.isbntexbox = new System.Windows.Forms.TextBox();
			this.publishyeartextbox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.addbtn = new System.Windows.Forms.Button();
			this.programBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.programBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.bookClassIndexViewBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
			this.bookCategoryIndexViewBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
			this.bookCategoryViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.publishYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bookCategoryIndexViewBindingSource4 = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.bookCategoryIndexViewBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bookCategoryViewBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bookCategoryIndexViewBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bookCategoryIndexViewBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bookClassIndexViewBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bookClassIndexViewBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.programBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bookClassIndexViewBindingSource2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bookCategoryIndexViewBindingSource3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bookCategoryViewBindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bookCategoryIndexViewBindingSource4)).BeginInit();
			this.SuspendLayout();
			// 
			// bookCategoryIndexViewBindingSource2
			// 
			this.bookCategoryIndexViewBindingSource2.DataSource = typeof(LibararySystemDemo.model.dataindex.BookCategoryIndexView);
			// 
			// bookCategoryViewBindingSource
			// 
			this.bookCategoryViewBindingSource.DataSource = typeof(LibararySystemDemo.model.dataindex.BookCategoryView);
			// 
			// bookCategoryIndexViewBindingSource1
			// 
			this.bookCategoryIndexViewBindingSource1.DataSource = typeof(LibararySystemDemo.model.dataindex.BookCategoryIndexView);
			// 
			// bookCategoryIndexViewBindingSource
			// 
			this.bookCategoryIndexViewBindingSource.DataSource = typeof(LibararySystemDemo.model.dataindex.BookCategoryIndexView);
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// bookclasscombobox
			// 
			this.bookclasscombobox.DataSource = this.bookClassIndexViewBindingSource1;
			this.bookclasscombobox.DisplayMember = "Class";
			this.bookclasscombobox.FormattingEnabled = true;
			this.bookclasscombobox.Location = new System.Drawing.Point(16, 41);
			this.bookclasscombobox.Name = "bookclasscombobox";
			this.bookclasscombobox.Size = new System.Drawing.Size(118, 20);
			this.bookclasscombobox.TabIndex = 2;
			this.bookclasscombobox.ValueMember = "ClassID";
			// 
			// bookClassIndexViewBindingSource1
			// 
			this.bookClassIndexViewBindingSource1.DataSource = typeof(LibararySystemDemo.model.dataindex.BookClassIndexView);
			// 
			// bookClassIndexViewBindingSource
			// 
			this.bookClassIndexViewBindingSource.DataSource = typeof(LibararySystemDemo.model.dataindex.BookClassIndexView);
			// 
			// Searchbtn
			// 
			this.Searchbtn.BackColor = System.Drawing.Color.LavenderBlush;
			this.Searchbtn.Location = new System.Drawing.Point(639, 51);
			this.Searchbtn.Name = "Searchbtn";
			this.Searchbtn.Size = new System.Drawing.Size(101, 29);
			this.Searchbtn.TabIndex = 3;
			this.Searchbtn.Text = "查詢";
			this.Searchbtn.UseVisualStyleBackColor = false;
			this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
			// 
			// BooknameText
			// 
			this.BooknameText.Location = new System.Drawing.Point(156, 39);
			this.BooknameText.Name = "BooknameText";
			this.BooknameText.Size = new System.Drawing.Size(97, 22);
			this.BooknameText.TabIndex = 4;
			// 
			// authortext
			// 
			this.authortext.Location = new System.Drawing.Point(276, 38);
			this.authortext.Name = "authortext";
			this.authortext.Size = new System.Drawing.Size(97, 22);
			this.authortext.TabIndex = 4;
			// 
			// isbntexbox
			// 
			this.isbntexbox.Location = new System.Drawing.Point(391, 38);
			this.isbntexbox.Name = "isbntexbox";
			this.isbntexbox.Size = new System.Drawing.Size(97, 22);
			this.isbntexbox.TabIndex = 4;
			// 
			// publishyeartextbox
			// 
			this.publishyeartextbox.Location = new System.Drawing.Point(511, 37);
			this.publishyeartextbox.Name = "publishyeartextbox";
			this.publishyeartextbox.Size = new System.Drawing.Size(97, 22);
			this.publishyeartextbox.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("新細明體", 9F);
			this.label1.Location = new System.Drawing.Point(16, 23);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 5;
			this.label1.Text = "分類";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(154, 23);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 5;
			this.label2.Text = "書名";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(274, 23);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 5;
			this.label3.Text = "作者";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(389, 23);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(31, 12);
			this.label4.TabIndex = 5;
			this.label4.Text = "ISBN";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(509, 22);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(53, 12);
			this.label5.TabIndex = 5;
			this.label5.Text = "出版年份";
			// 
			// addbtn
			// 
			this.addbtn.BackColor = System.Drawing.Color.LavenderBlush;
			this.addbtn.Location = new System.Drawing.Point(639, 14);
			this.addbtn.Name = "addbtn";
			this.addbtn.Size = new System.Drawing.Size(101, 29);
			this.addbtn.TabIndex = 3;
			this.addbtn.Text = "新增";
			this.addbtn.UseVisualStyleBackColor = false;
			this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
			// 
			// programBindingSource
			// 
			this.programBindingSource.DataSource = typeof(LibararySystemDemo.Program);
			// 
			// programBindingSource1
			// 
			this.programBindingSource1.DataSource = typeof(LibararySystemDemo.Program);
			// 
			// bookClassIndexViewBindingSource2
			// 
			this.bookClassIndexViewBindingSource2.DataSource = typeof(LibararySystemDemo.model.dataindex.BookClassIndexView);
			// 
			// bookCategoryIndexViewBindingSource3
			// 
			this.bookCategoryIndexViewBindingSource3.DataSource = typeof(LibararySystemDemo.model.dataindex.BookCategoryIndexView);
			// 
			// bookCategoryViewBindingSource1
			// 
			this.bookCategoryViewBindingSource1.DataSource = typeof(LibararySystemDemo.model.dataindex.BookCategoryView);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.LavenderBlush;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.publishYearDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.bookCategoryIndexViewBindingSource4;
			this.dataGridView1.Location = new System.Drawing.Point(16, 86);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(728, 252);
			this.dataGridView1.TabIndex = 6;
			// 
			// bookIDDataGridViewTextBoxColumn
			// 
			this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID";
			this.bookIDDataGridViewTextBoxColumn.HeaderText = "BookID";
			this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
			// 
			// bookNameDataGridViewTextBoxColumn
			// 
			this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName";
			this.bookNameDataGridViewTextBoxColumn.HeaderText = "BookName";
			this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
			// 
			// classDataGridViewTextBoxColumn
			// 
			this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
			this.classDataGridViewTextBoxColumn.HeaderText = "Class";
			this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
			// 
			// authorDataGridViewTextBoxColumn
			// 
			this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
			this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
			this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
			// 
			// iSBNDataGridViewTextBoxColumn
			// 
			this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
			this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
			this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
			// 
			// publishYearDataGridViewTextBoxColumn
			// 
			this.publishYearDataGridViewTextBoxColumn.DataPropertyName = "PublishYear";
			this.publishYearDataGridViewTextBoxColumn.HeaderText = "PublishYear";
			this.publishYearDataGridViewTextBoxColumn.Name = "publishYearDataGridViewTextBoxColumn";
			// 
			// bookCategoryIndexViewBindingSource4
			// 
			this.bookCategoryIndexViewBindingSource4.DataSource = typeof(LibararySystemDemo.model.dataindex.BookCategoryIndexView);
			// 
			// BookCategory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.Pink;
			this.ClientSize = new System.Drawing.Size(767, 367);
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
			this.MaximumSize = new System.Drawing.Size(783, 406);
			this.MinimumSize = new System.Drawing.Size(783, 406);
			this.Name = "BookCategory";
			this.Text = "BookCategory";
			this.Load += new System.EventHandler(this.BookCategory_Load);
			((System.ComponentModel.ISupportInitialize)(this.bookCategoryIndexViewBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bookCategoryViewBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bookCategoryIndexViewBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bookCategoryIndexViewBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bookClassIndexViewBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bookClassIndexViewBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.programBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.programBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bookClassIndexViewBindingSource2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bookCategoryIndexViewBindingSource3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bookCategoryViewBindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bookCategoryIndexViewBindingSource4)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.BindingSource programBindingSource;
		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
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
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.BindingSource programBindingSource1;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookClassDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource bookCategoryIndexViewBindingSource;
		private System.Windows.Forms.Button addbtn;
		private System.Windows.Forms.BindingSource bookClassIndexViewBindingSource;
		private System.Windows.Forms.BindingSource bookClassIndexViewBindingSource1;
		private System.Windows.Forms.BindingSource bookCategoryIndexViewBindingSource1;
		private System.Windows.Forms.BindingSource bookCategoryViewBindingSource;
		private System.Windows.Forms.BindingSource bookCategoryIndexViewBindingSource2;
		private System.Windows.Forms.BindingSource bookClassIndexViewBindingSource2;
		private System.Windows.Forms.BindingSource bookCategoryIndexViewBindingSource3;
		private System.Windows.Forms.BindingSource bookCategoryViewBindingSource1;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn publishYearDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource bookCategoryIndexViewBindingSource4;
	}
}