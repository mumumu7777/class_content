namespace ISpan.Estore
{
	partial class EditProductCategoryForm
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
			this.deletebtn = new System.Windows.Forms.Button();
			this.displaytext = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.category = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.updatebtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// deletebtn
			// 
			this.deletebtn.Location = new System.Drawing.Point(339, 217);
			this.deletebtn.Name = "deletebtn";
			this.deletebtn.Size = new System.Drawing.Size(75, 23);
			this.deletebtn.TabIndex = 7;
			this.deletebtn.Text = "delete";
			this.deletebtn.UseVisualStyleBackColor = true;
			this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
			// 
			// displaytext
			// 
			this.displaytext.Location = new System.Drawing.Point(215, 174);
			this.displaytext.Name = "displaytext";
			this.displaytext.Size = new System.Drawing.Size(200, 22);
			this.displaytext.TabIndex = 6;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(165, 177);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(53, 12);
			this.label2.TabIndex = 3;
			this.label2.Text = "顯示順序";
			// 
			// category
			// 
			this.category.Location = new System.Drawing.Point(215, 135);
			this.category.Name = "category";
			this.category.Size = new System.Drawing.Size(200, 22);
			this.category.TabIndex = 4;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(165, 138);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(56, 12);
			this.label1.TabIndex = 5;
			this.label1.Text = "分類名稱:";
			// 
			// updatebtn
			// 
			this.updatebtn.Location = new System.Drawing.Point(258, 217);
			this.updatebtn.Name = "updatebtn";
			this.updatebtn.Size = new System.Drawing.Size(75, 23);
			this.updatebtn.TabIndex = 7;
			this.updatebtn.Text = "update";
			this.updatebtn.UseVisualStyleBackColor = true;
			this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
			// 
			// EditProductCategoryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.updatebtn);
			this.Controls.Add(this.deletebtn);
			this.Controls.Add(this.displaytext);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.category);
			this.Controls.Add(this.label1);
			this.Name = "EditProductCategoryForm";
			this.Text = "EditProductCategoryForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button deletebtn;
		private System.Windows.Forms.TextBox displaytext;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox category;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button updatebtn;
	}
}