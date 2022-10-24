namespace laBel
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
			this.身高 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// 身高
			// 
			this.身高.AutoSize = true;
			this.身高.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.身高.Location = new System.Drawing.Point(113, 45);
			this.身高.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.身高.Name = "身高";
			this.身高.Size = new System.Drawing.Size(46, 21);
			this.身高.TabIndex = 0;
			this.身高.Text = "姓名:";
			this.身高.Click += new System.EventHandler(this.身高_Click);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(42, 97);
			this.textBox1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(196, 34);
			this.textBox1.TabIndex = 1;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
			this.label1.Location = new System.Drawing.Point(38, 147);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(52, 21);
			this.label1.TabIndex = 2;
			this.label1.Text = "早安";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("Showcard Gothic", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button1.Location = new System.Drawing.Point(15, 209);
			this.button1.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(238, 89);
			this.button1.TabIndex = 3;
			this.button1.Text = "確認";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 26F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.Info;
			this.ClientSize = new System.Drawing.Size(284, 345);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.身高);
			this.Font = new System.Drawing.Font("Comic Sans MS", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
			this.MaximizeBox = false;
			this.MaximumSize = new System.Drawing.Size(300, 384);
			this.MinimumSize = new System.Drawing.Size(300, 384);
			this.Name = "Form1";
			this.Text = "你好表單";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label 身高;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button1;
	}
}

