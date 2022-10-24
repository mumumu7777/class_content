namespace windowsformgame
{
	partial class gamegame
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
			this.button1 = new System.Windows.Forms.Button();
			this.button3 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.button2 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// button1
			// 
			this.button1.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button1.Location = new System.Drawing.Point(47, 52);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(110, 90);
			this.button1.TabIndex = 0;
			this.button1.Tag = "1";
			this.button1.Text = "1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// button3
			// 
			this.button3.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button3.Location = new System.Drawing.Point(365, 52);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(103, 90);
			this.button3.TabIndex = 2;
			this.button3.Tag = "3";
			this.button3.Text = "3";
			this.button3.UseVisualStyleBackColor = true;
			this.button3.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(436, 174);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(59, 12);
			this.label1.TabIndex = 3;
			this.label1.Text = "Answerlabe";
			// 
			// button2
			// 
			this.button2.Font = new System.Drawing.Font("新細明體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.button2.Location = new System.Drawing.Point(212, 52);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(110, 90);
			this.button2.TabIndex = 1;
			this.button2.Tag = "2";
			this.button2.Text = "2";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.button1_Click);
			// 
			// button4
			// 
			this.button4.Location = new System.Drawing.Point(342, 169);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(75, 23);
			this.button4.TabIndex = 4;
			this.button4.Text = "在玩一次";
			this.button4.UseVisualStyleBackColor = true;
			// 
			// gamegame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(543, 218);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.button1);
			this.MaximumSize = new System.Drawing.Size(559, 257);
			this.MinimumSize = new System.Drawing.Size(559, 257);
			this.Name = "gamegame";
			this.Text = "Answerlabel";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Button button3;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.Button button4;
	}
}

