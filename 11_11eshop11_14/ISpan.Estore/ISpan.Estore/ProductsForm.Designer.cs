namespace ISpan.Estore
{
	partial class ProductsForm
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
			this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.categoryNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.listPriceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.productIndexViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.searchbtn = new System.Windows.Forms.Button();
			this.categoryidcombox = new System.Windows.Forms.ComboBox();
			this.productCategoryVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.addbtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productIndexViewBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productCategoryVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productVMBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.categoryNameDataGridViewTextBoxColumn,
            this.productNameDataGridViewTextBoxColumn,
            this.listPriceDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.productIndexViewBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(21, 68);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(470, 234);
			this.dataGridView1.TabIndex = 0;
			this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
			// 
			// idDataGridViewTextBoxColumn
			// 
			this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
			this.idDataGridViewTextBoxColumn.HeaderText = "id";
			this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
			// 
			// categoryNameDataGridViewTextBoxColumn
			// 
			this.categoryNameDataGridViewTextBoxColumn.DataPropertyName = "CategoryName";
			this.categoryNameDataGridViewTextBoxColumn.HeaderText = "分類名稱";
			this.categoryNameDataGridViewTextBoxColumn.Name = "categoryNameDataGridViewTextBoxColumn";
			// 
			// productNameDataGridViewTextBoxColumn
			// 
			this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
			this.productNameDataGridViewTextBoxColumn.HeaderText = "品名";
			this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
			// 
			// listPriceDataGridViewTextBoxColumn
			// 
			this.listPriceDataGridViewTextBoxColumn.DataPropertyName = "ListPrice";
			this.listPriceDataGridViewTextBoxColumn.HeaderText = "牌價";
			this.listPriceDataGridViewTextBoxColumn.Name = "listPriceDataGridViewTextBoxColumn";
			// 
			// productIndexViewBindingSource
			// 
			this.productIndexViewBindingSource.DataSource = typeof(ISpan.Estore.Models.ViewModels.ProductIndexView);
			// 
			// searchbtn
			// 
			this.searchbtn.Location = new System.Drawing.Point(148, 39);
			this.searchbtn.Name = "searchbtn";
			this.searchbtn.Size = new System.Drawing.Size(75, 23);
			this.searchbtn.TabIndex = 1;
			this.searchbtn.Text = "Search";
			this.searchbtn.UseVisualStyleBackColor = true;
			this.searchbtn.Click += new System.EventHandler(this.searchbtn_Click);
			// 
			// categoryidcombox
			// 
			this.categoryidcombox.DataSource = this.productCategoryVMBindingSource;
			this.categoryidcombox.DisplayMember = "Categoryname";
			this.categoryidcombox.FormattingEnabled = true;
			this.categoryidcombox.Location = new System.Drawing.Point(21, 41);
			this.categoryidcombox.Name = "categoryidcombox";
			this.categoryidcombox.Size = new System.Drawing.Size(121, 20);
			this.categoryidcombox.TabIndex = 2;
			this.categoryidcombox.ValueMember = "Displayorder";
			// 
			// productCategoryVMBindingSource
			// 
			this.productCategoryVMBindingSource.DataSource = typeof(ISpan.Estore.Models.ViewModels.ProductCategoryVM);
			// 
			// productVMBindingSource
			// 
			this.productVMBindingSource.DataSource = typeof(ISpan.Estore.Models.ViewModels.ProductVM);
			// 
			// addbtn
			// 
			this.addbtn.Location = new System.Drawing.Point(433, 39);
			this.addbtn.Name = "addbtn";
			this.addbtn.Size = new System.Drawing.Size(75, 23);
			this.addbtn.TabIndex = 3;
			this.addbtn.Text = "addbtn";
			this.addbtn.UseVisualStyleBackColor = true;
			this.addbtn.Click += new System.EventHandler(this.addbtn_Click);
			// 
			// ProductsForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(515, 322);
			this.Controls.Add(this.addbtn);
			this.Controls.Add(this.categoryidcombox);
			this.Controls.Add(this.searchbtn);
			this.Controls.Add(this.dataGridView1);
			this.MaximumSize = new System.Drawing.Size(531, 361);
			this.MinimumSize = new System.Drawing.Size(531, 361);
			this.Name = "ProductsForm";
			this.Text = "ProductsForm";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productIndexViewBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productCategoryVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productVMBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Button searchbtn;
		private System.Windows.Forms.BindingSource productIndexViewBindingSource;
		private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn categoryNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
		private System.Windows.Forms.DataGridViewTextBoxColumn listPriceDataGridViewTextBoxColumn;
		private System.Windows.Forms.ComboBox categoryidcombox;
		private System.Windows.Forms.BindingSource productVMBindingSource;
		private System.Windows.Forms.BindingSource productCategoryVMBindingSource;
		private System.Windows.Forms.Button addbtn;
	}
}