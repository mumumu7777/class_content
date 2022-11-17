namespace ISpan.Estore
{
	partial class CheckBoxList
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
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.checkBox6 = new System.Windows.Forms.CheckBox();
			this.GETVALUE = new System.Windows.Forms.Button();
			this.SETVALUE = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Location = new System.Drawing.Point(88, 76);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(77, 16);
			this.checkBox1.TabIndex = 0;
			this.checkBox1.Tag = "A";
			this.checkBox1.Text = "checkBox1";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Location = new System.Drawing.Point(183, 76);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(77, 16);
			this.checkBox2.TabIndex = 0;
			this.checkBox2.Tag = "B";
			this.checkBox2.Text = "checkBox2";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Location = new System.Drawing.Point(285, 76);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(77, 16);
			this.checkBox3.TabIndex = 0;
			this.checkBox3.Tag = "C";
			this.checkBox3.Text = "checkBox3";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// checkBox4
			// 
			this.checkBox4.AutoSize = true;
			this.checkBox4.Location = new System.Drawing.Point(88, 112);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(77, 16);
			this.checkBox4.TabIndex = 0;
			this.checkBox4.Tag = "D";
			this.checkBox4.Text = "checkBox4";
			this.checkBox4.UseVisualStyleBackColor = true;
			// 
			// checkBox5
			// 
			this.checkBox5.AutoSize = true;
			this.checkBox5.Location = new System.Drawing.Point(183, 112);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(77, 16);
			this.checkBox5.TabIndex = 0;
			this.checkBox5.Tag = "E";
			this.checkBox5.Text = "checkBox5";
			this.checkBox5.UseVisualStyleBackColor = true;
			// 
			// checkBox6
			// 
			this.checkBox6.AutoSize = true;
			this.checkBox6.Location = new System.Drawing.Point(285, 112);
			this.checkBox6.Name = "checkBox6";
			this.checkBox6.Size = new System.Drawing.Size(77, 16);
			this.checkBox6.TabIndex = 0;
			this.checkBox6.Tag = "F";
			this.checkBox6.Text = "checkBox6";
			this.checkBox6.UseVisualStyleBackColor = true;
			// 
			// GETVALUE
			// 
			this.GETVALUE.Location = new System.Drawing.Point(386, 86);
			this.GETVALUE.Name = "GETVALUE";
			this.GETVALUE.Size = new System.Drawing.Size(75, 23);
			this.GETVALUE.TabIndex = 1;
			this.GETVALUE.Text = "GETVALUE";
			this.GETVALUE.UseVisualStyleBackColor = true;
			this.GETVALUE.Click += new System.EventHandler(this.GETVALUE_Click);
			// 
			// SETVALUE
			// 
			this.SETVALUE.Location = new System.Drawing.Point(301, 230);
			this.SETVALUE.Name = "SETVALUE";
			this.SETVALUE.Size = new System.Drawing.Size(75, 23);
			this.SETVALUE.TabIndex = 1;
			this.SETVALUE.Text = "SET VALUE";
			this.SETVALUE.UseVisualStyleBackColor = true;
			this.SETVALUE.Click += new System.EventHandler(this.SETVALUE_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(111, 230);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 22);
			this.textBox1.TabIndex = 2;
			// 
			// CheckBoxList
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.SETVALUE);
			this.Controls.Add(this.GETVALUE);
			this.Controls.Add(this.checkBox4);
			this.Controls.Add(this.checkBox6);
			this.Controls.Add(this.checkBox5);
			this.Controls.Add(this.checkBox3);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.checkBox1);
			this.Name = "CheckBoxList";
			this.Text = "CheckBoxList";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox5;
		private System.Windows.Forms.CheckBox checkBox6;
		private System.Windows.Forms.Button GETVALUE;
		private System.Windows.Forms.Button SETVALUE;
		private System.Windows.Forms.TextBox textBox1;
	}
}