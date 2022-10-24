namespace printstar
{
	partial class printstar
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
			this.label1 = new System.Windows.Forms.Label();
			this.printbox = new System.Windows.Forms.TextBox();
			this.starbox = new System.Windows.Forms.TextBox();
			this.printbottom = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(83, 73);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "列數";
			// 
			// printbox
			// 
			this.printbox.Location = new System.Drawing.Point(145, 70);
			this.printbox.MaxLength = 100;
			this.printbox.Name = "printbox";
			this.printbox.Size = new System.Drawing.Size(121, 22);
			this.printbox.TabIndex = 1;
			// 
			// starbox
			// 
			this.starbox.Location = new System.Drawing.Point(145, 110);
			this.starbox.MaxLength = 500;
			this.starbox.Multiline = true;
			this.starbox.Name = "starbox";
			this.starbox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.starbox.Size = new System.Drawing.Size(330, 256);
			this.starbox.TabIndex = 2;
			this.starbox.WordWrap = false;
			this.starbox.TextChanged += new System.EventHandler(this.starbox_TextChanged);
			// 
			// printbottom
			// 
			this.printbottom.Location = new System.Drawing.Point(294, 68);
			this.printbottom.Name = "printbottom";
			this.printbottom.Size = new System.Drawing.Size(75, 23);
			this.printbottom.TabIndex = 3;
			this.printbottom.Text = "列印";
			this.printbottom.UseVisualStyleBackColor = true;
			this.printbottom.Click += new System.EventHandler(this.printbottom_Click);
			// 
			// printstar
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.printbottom);
			this.Controls.Add(this.starbox);
			this.Controls.Add(this.printbox);
			this.Controls.Add(this.label1);
			this.Name = "printstar";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox printbox;
		private System.Windows.Forms.TextBox starbox;
		private System.Windows.Forms.Button printbottom;
	}
}

