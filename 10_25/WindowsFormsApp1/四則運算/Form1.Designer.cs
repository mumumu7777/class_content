namespace 四則運算
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
			this.NUMBER1 = new System.Windows.Forms.TextBox();
			this.NUMBER2 = new System.Windows.Forms.TextBox();
			this.Resultlabel = new System.Windows.Forms.Label();
			this.caculatebuttom = new System.Windows.Forms.Button();
			this.OPTIONS = new System.Windows.Forms.ComboBox();
			this.SuspendLayout();
			// 
			// NUMBER1
			// 
			this.NUMBER1.Location = new System.Drawing.Point(72, 57);
			this.NUMBER1.Name = "NUMBER1";
			this.NUMBER1.Size = new System.Drawing.Size(100, 22);
			this.NUMBER1.TabIndex = 0;
			// 
			// NUMBER2
			// 
			this.NUMBER2.Location = new System.Drawing.Point(343, 57);
			this.NUMBER2.Name = "NUMBER2";
			this.NUMBER2.Size = new System.Drawing.Size(100, 22);
			this.NUMBER2.TabIndex = 0;
			// 
			// Resultlabel
			// 
			this.Resultlabel.AutoSize = true;
			this.Resultlabel.Font = new System.Drawing.Font("新細明體", 25F);
			this.Resultlabel.Location = new System.Drawing.Point(466, 45);
			this.Resultlabel.Name = "Resultlabel";
			this.Resultlabel.Size = new System.Drawing.Size(120, 34);
			this.Resultlabel.TabIndex = 1;
			this.Resultlabel.Text = "lblresult";
			// 
			// caculatebuttom
			// 
			this.caculatebuttom.Location = new System.Drawing.Point(368, 147);
			this.caculatebuttom.Name = "caculatebuttom";
			this.caculatebuttom.Size = new System.Drawing.Size(75, 23);
			this.caculatebuttom.TabIndex = 2;
			this.caculatebuttom.Text = "Caculation";
			this.caculatebuttom.UseVisualStyleBackColor = true;
			this.caculatebuttom.Click += new System.EventHandler(this.caculatebuttom_Click);
			// 
			// OPTIONS
			// 
			this.OPTIONS.FormattingEnabled = true;
			this.OPTIONS.Items.AddRange(new object[] {
            "+",
            "-",
            "*",
            "/"});
			this.OPTIONS.Location = new System.Drawing.Point(200, 57);
			this.OPTIONS.Name = "OPTIONS";
			this.OPTIONS.Size = new System.Drawing.Size(121, 20);
			this.OPTIONS.TabIndex = 3;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(608, 231);
			this.Controls.Add(this.OPTIONS);
			this.Controls.Add(this.caculatebuttom);
			this.Controls.Add(this.Resultlabel);
			this.Controls.Add(this.NUMBER2);
			this.Controls.Add(this.NUMBER1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox NUMBER1;
		private System.Windows.Forms.TextBox NUMBER2;
		private System.Windows.Forms.Label Resultlabel;
		private System.Windows.Forms.Button caculatebuttom;
		private System.Windows.Forms.ComboBox OPTIONS;
	}
}

