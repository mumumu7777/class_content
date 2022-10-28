namespace lottery
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
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.searchbtm = new System.Windows.Forms.Button();
			this.newgamebtm = new System.Windows.Forms.Button();
			this.resultlbl = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(131, 165);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(157, 22);
			this.textBox1.TabIndex = 0;
			// 
			// searchbtm
			// 
			this.searchbtm.Location = new System.Drawing.Point(294, 165);
			this.searchbtm.Name = "searchbtm";
			this.searchbtm.Size = new System.Drawing.Size(161, 23);
			this.searchbtm.TabIndex = 1;
			this.searchbtm.Text = "查詢";
			this.searchbtm.UseVisualStyleBackColor = true;
			this.searchbtm.Click += new System.EventHandler(this.searchbtm_Click);
			// 
			// newgamebtm
			// 
			this.newgamebtm.Location = new System.Drawing.Point(131, 111);
			this.newgamebtm.Name = "newgamebtm";
			this.newgamebtm.Size = new System.Drawing.Size(161, 23);
			this.newgamebtm.TabIndex = 1;
			this.newgamebtm.Text = "NewGame";
			this.newgamebtm.UseVisualStyleBackColor = true;
			this.newgamebtm.Click += new System.EventHandler(this.newgamebtm_Click);
			// 
			// resultlbl
			// 
			this.resultlbl.AutoSize = true;
			this.resultlbl.Font = new System.Drawing.Font("微軟正黑體", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.resultlbl.Location = new System.Drawing.Point(175, 218);
			this.resultlbl.Name = "resultlbl";
			this.resultlbl.Size = new System.Drawing.Size(75, 26);
			this.resultlbl.TabIndex = 2;
			this.resultlbl.Text = "Result";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.resultlbl);
			this.Controls.Add(this.newgamebtm);
			this.Controls.Add(this.searchbtm);
			this.Controls.Add(this.textBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Button searchbtm;
		private System.Windows.Forms.Button newgamebtm;
		private System.Windows.Forms.Label resultlbl;
	}
}

