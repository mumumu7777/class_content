﻿namespace lottery
{
	partial class 樂透
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
			this.drawbuttom = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(281, 133);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(33, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "label1";
			// 
			// drawbuttom
			// 
			this.drawbuttom.Location = new System.Drawing.Point(257, 300);
			this.drawbuttom.Name = "drawbuttom";
			this.drawbuttom.Size = new System.Drawing.Size(75, 23);
			this.drawbuttom.TabIndex = 1;
			this.drawbuttom.Text = "亂數紐";
			this.drawbuttom.UseVisualStyleBackColor = true;
			this.drawbuttom.Click += new System.EventHandler(this.drawbuttom_Click);
			// 
			// 樂透
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.drawbuttom);
			this.Controls.Add(this.label1);
			this.Name = "樂透";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button drawbuttom;
	}
}
