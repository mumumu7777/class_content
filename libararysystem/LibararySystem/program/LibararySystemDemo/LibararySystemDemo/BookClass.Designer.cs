namespace LibararySystemDemo
{
	partial class BookClass
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
			this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.classDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.bookClassIndexViewBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
			this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
			this.Addbtn = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.bookClassIndexViewBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.AutoGenerateColumns = false;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.classDataGridViewTextBoxColumn});
			this.dataGridView1.DataSource = this.bookClassIndexViewBindingSource;
			this.dataGridView1.Location = new System.Drawing.Point(25, 78);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(298, 201);
			this.dataGridView1.TabIndex = 0;
			// 
			// iDDataGridViewTextBoxColumn
			// 
			this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
			this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
			this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
			// 
			// classDataGridViewTextBoxColumn
			// 
			this.classDataGridViewTextBoxColumn.DataPropertyName = "Class";
			this.classDataGridViewTextBoxColumn.HeaderText = "Class";
			this.classDataGridViewTextBoxColumn.Name = "classDataGridViewTextBoxColumn";
			// 
			// bookClassIndexViewBindingSource
			// 
			this.bookClassIndexViewBindingSource.DataSource = typeof(LibararySystemDemo.model.dataindex.BookClassIndexView);
			// 
			// Addbtn
			// 
			this.Addbtn.Location = new System.Drawing.Point(25, 40);
			this.Addbtn.Name = "Addbtn";
			this.Addbtn.Size = new System.Drawing.Size(75, 23);
			this.Addbtn.TabIndex = 1;
			this.Addbtn.Text = "新增";
			this.Addbtn.UseVisualStyleBackColor = true;
			// 
			// BookClass
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(350, 323);
			this.Controls.Add(this.Addbtn);
			this.Controls.Add(this.dataGridView1);
			this.Name = "BookClass";
			this.Text = "BookClass";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.bookClassIndexViewBindingSource)).EndInit();
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
	}
}