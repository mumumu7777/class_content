namespace ISpan.Estore
{
	partial class ProductCategoriesForm
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
			this.addnewbutton = new System.Windows.Forms.Button();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			this.SuspendLayout();
			// 
			// addnewbutton
			// 
			this.addnewbutton.Location = new System.Drawing.Point(307, 33);
			this.addnewbutton.Name = "addnewbutton";
			this.addnewbutton.Size = new System.Drawing.Size(110, 48);
			this.addnewbutton.TabIndex = 0;
			this.addnewbutton.Text = "Add New";
			this.addnewbutton.UseVisualStyleBackColor = true;
			this.addnewbutton.Click += new System.EventHandler(this.addnewbutton_Click);
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.BackgroundColor = System.Drawing.Color.Linen;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(12, 87);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowTemplate.Height = 24;
			this.dataGridView1.Size = new System.Drawing.Size(405, 292);
			this.dataGridView1.TabIndex = 1;
			this.dataGridView1.Tag = "商品檢視表";
			this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
			// 
			// ProductCategoriesForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(429, 391);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.addnewbutton);
			this.Name = "ProductCategoriesForm";
			this.Text = "ProductCategoriesForm";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button addnewbutton;
		private System.Windows.Forms.DataGridView dataGridView1;
	}
}