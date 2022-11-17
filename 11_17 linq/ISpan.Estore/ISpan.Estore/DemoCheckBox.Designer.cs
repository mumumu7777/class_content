namespace ISpan.Estore
{
	partial class DemoCheckBox
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
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.getvaluebtn = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.setvaluebtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(49, 103);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(77, 16);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Text = "checkBox1";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// getvaluebtn
			// 
			this.getvaluebtn.Location = new System.Drawing.Point(236, 103);
			this.getvaluebtn.Name = "getvaluebtn";
			this.getvaluebtn.Size = new System.Drawing.Size(75, 23);
			this.getvaluebtn.TabIndex = 1;
			this.getvaluebtn.Text = "get value";
			this.getvaluebtn.UseVisualStyleBackColor = true;
			this.getvaluebtn.Click += new System.EventHandler(this.getvaluebtn_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(49, 152);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 2;
			// 
			// setvaluebtn
			// 
			this.setvaluebtn.Location = new System.Drawing.Point(236, 152);
			this.setvaluebtn.Name = "setvaluebtn";
			this.setvaluebtn.Size = new System.Drawing.Size(75, 23);
			this.setvaluebtn.TabIndex = 3;
			this.setvaluebtn.Text = "set value";
			this.setvaluebtn.UseVisualStyleBackColor = true;
			this.setvaluebtn.Click += new System.EventHandler(this.setvaluebtn_Click);
			// 
			// DemoCheckBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(400, 231);
			this.Controls.Add(this.setvaluebtn);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.getvaluebtn);
			this.Controls.Add(this.checkBox1);
			this.Name = "DemoCheckBox";
			this.Text = "Demo";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Button getvaluebtn;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button setvaluebtn;
	}
}