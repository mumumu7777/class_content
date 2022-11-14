namespace ISpan.Estore
{
	partial class CreateProductForm
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
			this.productnamebox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.listpricebox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.categorycombobox = new System.Windows.Forms.ComboBox();
			this.productVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.savebtn = new System.Windows.Forms.Button();
			this.productCategoryVMBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.productCategoryVMBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.productVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productCategoryVMBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.productCategoryVMBindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(39, 78);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "商品名稱";
			// 
			// productnamebox
			// 
			this.productnamebox.Location = new System.Drawing.Point(101, 75);
			this.productnamebox.Name = "productnamebox";
			this.productnamebox.Size = new System.Drawing.Size(121, 22);
			this.productnamebox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(39, 125);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "牌價";
			// 
			// listpricebox
			// 
			this.listpricebox.Location = new System.Drawing.Point(101, 125);
			this.listpricebox.Name = "listpricebox";
			this.listpricebox.Size = new System.Drawing.Size(121, 22);
			this.listpricebox.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(39, 43);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 0;
			this.label3.Text = "分類";
			// 
			// categorycombobox
			// 
			this.categorycombobox.DataSource = this.productCategoryVMBindingSource1;
			this.categorycombobox.DisplayMember = "Categoryname";
			this.categorycombobox.FormattingEnabled = true;
			this.categorycombobox.Location = new System.Drawing.Point(101, 40);
			this.categorycombobox.Name = "categorycombobox";
			this.categorycombobox.Size = new System.Drawing.Size(121, 20);
			this.categorycombobox.TabIndex = 2;
			this.categorycombobox.ValueMember = "Id";
			// 
			// productVMBindingSource
			// 
			this.productVMBindingSource.DataSource = typeof(ISpan.Estore.Models.ViewModels.ProductVM);
			// 
			// savebtn
			// 
			this.savebtn.Location = new System.Drawing.Point(241, 172);
			this.savebtn.Name = "savebtn";
			this.savebtn.Size = new System.Drawing.Size(92, 62);
			this.savebtn.TabIndex = 3;
			this.savebtn.Text = "save";
			this.savebtn.UseVisualStyleBackColor = true;
			this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
			// 
			// productCategoryVMBindingSource
			// 
			this.productCategoryVMBindingSource.DataSource = typeof(ISpan.Estore.Models.ViewModels.ProductCategoryVM);
			// 
			// productCategoryVMBindingSource1
			// 
			this.productCategoryVMBindingSource1.DataSource = typeof(ISpan.Estore.Models.ViewModels.ProductCategoryVM);
			// 
			// CreateProductForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(354, 286);
			this.Controls.Add(this.savebtn);
			this.Controls.Add(this.categorycombobox);
			this.Controls.Add(this.listpricebox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.productnamebox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "CreateProductForm";
			this.Text = "新增商品紀錄";
			this.Load += new System.EventHandler(this.CreateProductForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.productVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productCategoryVMBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.productCategoryVMBindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox productnamebox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox listpricebox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox categorycombobox;
		private System.Windows.Forms.Button savebtn;
		private System.Windows.Forms.BindingSource productVMBindingSource;
		private System.Windows.Forms.BindingSource productCategoryVMBindingSource;
		private System.Windows.Forms.BindingSource productCategoryVMBindingSource1;
	}
}