namespace hard
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
			this.namebox = new System.Windows.Forms.TextBox();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.buttonlogin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// namebox
			// 
			this.namebox.Location = new System.Drawing.Point(53, 45);
			this.namebox.Name = "namebox";
			this.namebox.Size = new System.Drawing.Size(100, 22);
			this.namebox.TabIndex = 0;
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(53, 98);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(100, 22);
			this.textBox2.TabIndex = 0;
			// 
			// buttonlogin
			// 
			this.buttonlogin.Location = new System.Drawing.Point(66, 176);
			this.buttonlogin.Name = "buttonlogin";
			this.buttonlogin.Size = new System.Drawing.Size(75, 23);
			this.buttonlogin.TabIndex = 1;
			this.buttonlogin.Text = "log in ";
			this.buttonlogin.UseVisualStyleBackColor = true;
			this.buttonlogin.Click += new System.EventHandler(this.buttonlogin_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(227, 298);
			this.Controls.Add(this.buttonlogin);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.namebox);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox namebox;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Button buttonlogin;
	}
}

