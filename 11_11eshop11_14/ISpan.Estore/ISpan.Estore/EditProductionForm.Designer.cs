namespace ISpan.Estore
{
	partial class EditProductionForm
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
			this.updatebtn = new System.Windows.Forms.Button();
			this.deletebtn = new System.Windows.Forms.Button();
			this.listpricetxt = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.productnametxt = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.categoridcombox = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// updatebtn
			// 
			this.updatebtn.Location = new System.Drawing.Point(215, 199);
			this.updatebtn.Name = "updatebtn";
			this.updatebtn.Size = new System.Drawing.Size(75, 23);
			this.updatebtn.TabIndex = 12;
			this.updatebtn.Text = "update";
			this.updatebtn.UseVisualStyleBackColor = true;
			this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
			// 
			// deletebtn
			// 
			this.deletebtn.Location = new System.Drawing.Point(296, 199);
			this.deletebtn.Name = "deletebtn";
			this.deletebtn.Size = new System.Drawing.Size(75, 23);
			this.deletebtn.TabIndex = 13;
			this.deletebtn.Text = "delete";
			this.deletebtn.UseVisualStyleBackColor = true;
			// 
			// listpricetxt
			// 
			this.listpricetxt.Location = new System.Drawing.Point(172, 156);
			this.listpricetxt.Name = "listpricetxt";
			this.listpricetxt.Size = new System.Drawing.Size(200, 22);
			this.listpricetxt.TabIndex = 11;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(113, 159);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 8;
			this.label2.Text = "牌價";
			// 
			// productnametxt
			// 
			this.productnametxt.Location = new System.Drawing.Point(172, 117);
			this.productnametxt.Name = "productnametxt";
			this.productnametxt.Size = new System.Drawing.Size(200, 22);
			this.productnametxt.TabIndex = 9;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(113, 120);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(53, 12);
			this.label1.TabIndex = 10;
			this.label1.Text = "商品名稱";
			// 
			// categoridcombox
			// 
			this.categoridcombox.FormattingEnabled = true;
			this.categoridcombox.Location = new System.Drawing.Point(172, 83);
			this.categoridcombox.Name = "categoridcombox";
			this.categoridcombox.Size = new System.Drawing.Size(200, 20);
			this.categoridcombox.TabIndex = 14;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(113, 86);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 10;
			this.label3.Text = "分類";
			// 
			// EditProductionForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(568, 360);
			this.Controls.Add(this.categoridcombox);
			this.Controls.Add(this.updatebtn);
			this.Controls.Add(this.deletebtn);
			this.Controls.Add(this.listpricetxt);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.productnametxt);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label1);
			this.Name = "EditProductionForm";
			this.Text = "EditProductionForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button updatebtn;
		private System.Windows.Forms.Button deletebtn;
		private System.Windows.Forms.TextBox listpricetxt;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox productnametxt;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox categoridcombox;
		private System.Windows.Forms.Label label3;
	}
}