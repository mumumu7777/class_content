namespace WindowsFormsApp1
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.greatbottom = new System.Windows.Forms.Button();
			this.nicebtm = new System.Windows.Forms.Button();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// greatbottom
			// 
			this.greatbottom.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.greatbottom.ForeColor = System.Drawing.SystemColors.HotTrack;
			this.greatbottom.Location = new System.Drawing.Point(117, 116);
			this.greatbottom.Name = "greatbottom";
			this.greatbottom.Size = new System.Drawing.Size(210, 115);
			this.greatbottom.TabIndex = 5;
			this.greatbottom.Text = "okbottom";
			this.greatbottom.UseVisualStyleBackColor = true;
			this.greatbottom.Click += new System.EventHandler(this.button1_Click);
			// 
			// nicebtm
			// 
			this.nicebtm.Location = new System.Drawing.Point(45, 176);
			this.nicebtm.Name = "nicebtm";
			this.nicebtm.Size = new System.Drawing.Size(75, 57);
			this.nicebtm.TabIndex = 4;
			this.nicebtm.Text = "bottom02";
			this.nicebtm.UseVisualStyleBackColor = true;
			this.nicebtm.Click += new System.EventHandler(this.nuicebtclick);
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(47, 117);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 63);
			this.button1.TabIndex = 3;
			this.button1.Text = "bottom01";
			this.button1.UseVisualStyleBackColor = true;
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(45, 88);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(175, 22);
			this.textBox1.TabIndex = 2;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(45, 60);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(175, 22);
			this.textBox2.TabIndex = 1;
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(45, 32);
			this.textBox3.MaxLength = 12;
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(175, 22);
			this.textBox3.TabIndex = 0;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(339, 253);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.nicebtm);
			this.Controls.Add(this.greatbottom);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button greatbottom;
		private System.Windows.Forms.Button nicebtm;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.TextBox textBox3;
	}
}

