namespace ISpan.Estore
{
	partial class DemoGender
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
			this.getvaluebtn = new System.Windows.Forms.Button();
			this.usGender1 = new ISpan.Estore.Controls.usGender();
			this.setbtn = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// getvaluebtn
			// 
			this.getvaluebtn.Location = new System.Drawing.Point(308, 78);
			this.getvaluebtn.Name = "getvaluebtn";
			this.getvaluebtn.Size = new System.Drawing.Size(75, 23);
			this.getvaluebtn.TabIndex = 0;
			this.getvaluebtn.Text = "getvalue";
			this.getvaluebtn.UseVisualStyleBackColor = true;
			this.getvaluebtn.Click += new System.EventHandler(this.getvaluebtn_Click);
			// 
			// usGender1
			// 
			this.usGender1.Location = new System.Drawing.Point(51, 50);
			this.usGender1.Name = "usGender1";
			this.usGender1.Size = new System.Drawing.Size(211, 107);
			this.usGender1.TabIndex = 2;
			this.usGender1.Load += new System.EventHandler(this.usGender1_Load);
			// 
			// setbtn
			// 
			this.setbtn.Location = new System.Drawing.Point(308, 134);
			this.setbtn.Name = "setbtn";
			this.setbtn.Size = new System.Drawing.Size(75, 23);
			this.setbtn.TabIndex = 3;
			this.setbtn.Text = "set";
			this.setbtn.UseVisualStyleBackColor = true;
			this.setbtn.Click += new System.EventHandler(this.setbtn_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(162, 178);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 4;
			// 
			// DemoGender
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.setbtn);
			this.Controls.Add(this.usGender1);
			this.Controls.Add(this.getvaluebtn);
			this.Name = "DemoGender";
			this.Text = "DemoGender";
			this.Load += new System.EventHandler(this.DemoGender_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button getvaluebtn;
		private Controls.usGender usGender1;
		private System.Windows.Forms.Button setbtn;
		private System.Windows.Forms.TextBox textBox1;
	}
}