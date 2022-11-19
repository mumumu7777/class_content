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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.classCategoryIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iSBNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publishYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCategoryIndexViewBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bookClassIndexViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.Addbtn = new System.Windows.Forms.Button();
            this.bookCategoryIndexViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCategoryIndexViewBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookClassIndexViewBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCategoryIndexViewBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookIDDataGridViewTextBoxColumn,
            this.bookNameDataGridViewTextBoxColumn,
            this.classCategoryIDDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.iSBNDataGridViewTextBoxColumn,
            this.publishYearDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.bookCategoryIndexViewBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 154);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(637, 402);
            this.dataGridView1.TabIndex = 0;
            // 
            // bookIDDataGridViewTextBoxColumn
            // 
            this.bookIDDataGridViewTextBoxColumn.DataPropertyName = "BookID";
            this.bookIDDataGridViewTextBoxColumn.HeaderText = "BookID";
            this.bookIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.bookIDDataGridViewTextBoxColumn.Name = "bookIDDataGridViewTextBoxColumn";
            this.bookIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // bookNameDataGridViewTextBoxColumn
            // 
            this.bookNameDataGridViewTextBoxColumn.DataPropertyName = "BookName";
            this.bookNameDataGridViewTextBoxColumn.HeaderText = "BookName";
            this.bookNameDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.bookNameDataGridViewTextBoxColumn.Name = "bookNameDataGridViewTextBoxColumn";
            this.bookNameDataGridViewTextBoxColumn.Width = 200;
            // 
            // classCategoryIDDataGridViewTextBoxColumn
            // 
            this.classCategoryIDDataGridViewTextBoxColumn.DataPropertyName = "ClassCategoryID";
            this.classCategoryIDDataGridViewTextBoxColumn.HeaderText = "ClassCategoryID";
            this.classCategoryIDDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.classCategoryIDDataGridViewTextBoxColumn.Name = "classCategoryIDDataGridViewTextBoxColumn";
            this.classCategoryIDDataGridViewTextBoxColumn.Width = 200;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.Width = 200;
            // 
            // iSBNDataGridViewTextBoxColumn
            // 
            this.iSBNDataGridViewTextBoxColumn.DataPropertyName = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.HeaderText = "ISBN";
            this.iSBNDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.iSBNDataGridViewTextBoxColumn.Name = "iSBNDataGridViewTextBoxColumn";
            this.iSBNDataGridViewTextBoxColumn.Width = 200;
            // 
            // publishYearDataGridViewTextBoxColumn
            // 
            this.publishYearDataGridViewTextBoxColumn.DataPropertyName = "PublishYear";
            this.publishYearDataGridViewTextBoxColumn.HeaderText = "PublishYear";
            this.publishYearDataGridViewTextBoxColumn.MinimumWidth = 10;
            this.publishYearDataGridViewTextBoxColumn.Name = "publishYearDataGridViewTextBoxColumn";
            this.publishYearDataGridViewTextBoxColumn.Width = 200;
            // 
            // bookCategoryIndexViewBindingSource1
            // 
            this.bookCategoryIndexViewBindingSource1.DataSource = typeof(LibararySystemDemo.model.dataindex.BookCategoryIndexView);
            // 
            // Addbtn
            // 
            this.Addbtn.Location = new System.Drawing.Point(54, 80);
            this.Addbtn.Margin = new System.Windows.Forms.Padding(6);
            this.Addbtn.Name = "Addbtn";
            this.Addbtn.Size = new System.Drawing.Size(162, 46);
            this.Addbtn.TabIndex = 1;
            this.Addbtn.Text = "新增";
            this.Addbtn.UseVisualStyleBackColor = true;
            // 
            // bookCategoryIndexViewBindingSource
            // 
            this.bookCategoryIndexViewBindingSource.DataSource = typeof(LibararySystemDemo.model.dataindex.BookCategoryIndexView);
            // 
            // BookClass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 646);
            this.Controls.Add(this.Addbtn);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "BookClass";
            this.Text = "BookClass";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCategoryIndexViewBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookClassIndexViewBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookCategoryIndexViewBindingSource)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn classDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource bookClassIndexViewBindingSource;
		private System.ComponentModel.BackgroundWorker backgroundWorker1;
		private System.ComponentModel.BackgroundWorker backgroundWorker2;
		private System.Windows.Forms.Button Addbtn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn bookNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn classCategoryIDDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn iSBNDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn publishYearDataGridViewTextBoxColumn;
		private System.Windows.Forms.BindingSource bookCategoryIndexViewBindingSource;
        private System.Windows.Forms.BindingSource bookCategoryIndexViewBindingSource1;
    }
}