namespace ISpan.Estore
{
	partial class CreateNewProductCategory
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
			this.label1 = new System.Windows.Forms.Label();
			this.category = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.displaytext = new System.Windows.Forms.TextBox();
			this.savebtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(75, 57);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "分類名稱:";
			// 
			// category
			// 
			this.category.Location = new System.Drawing.Point(125, 54);
			this.category.Name = "category";
			this.category.Size = new System.Drawing.Size(200, 22);
			this.category.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(75, 96);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "顯示順序";
			// 
			// displaytext
			// 
			this.displaytext.Location = new System.Drawing.Point(125, 93);
			this.displaytext.Name = "displaytext";
			this.displaytext.Size = new System.Drawing.Size(200, 22);
			this.displaytext.TabIndex = 1;
			// 
			// savebtn
			// 
			this.savebtn.Location = new System.Drawing.Point(249, 136);
			this.savebtn.Name = "savebtn";
			this.savebtn.Size = new System.Drawing.Size(75, 23);
			this.savebtn.TabIndex = 2;
			this.savebtn.Text = "save";
			this.savebtn.UseVisualStyleBackColor = true;
			this.savebtn.Click += new System.EventHandler(this.savebtn_Click);
			// 
			// CreateNewProductCategory
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(371, 208);
			this.Controls.Add(this.savebtn);
			this.Controls.Add(this.displaytext);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.category);
			this.Controls.Add(this.label1);
			this.Name = "CreateNewProductCategory";
			this.Text = "新增商品分類";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox category;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox displaytext;
		private System.Windows.Forms.Button savebtn;
	}
}