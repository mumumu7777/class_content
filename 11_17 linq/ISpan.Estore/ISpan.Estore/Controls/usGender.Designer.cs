namespace ISpan.Estore.Controls
{
	partial class usGender
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

		#region 元件設計工具產生的程式碼

		/// <summary> 
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.gender1RadioButton = new System.Windows.Forms.RadioButton();
			this.gender0RadioButton = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// gender1RadioButton
			// 
			this.gender1RadioButton.AutoSize = true;
			this.gender1RadioButton.Location = new System.Drawing.Point(3, 65);
			this.gender1RadioButton.Name = "gender1RadioButton";
			this.gender1RadioButton.Size = new System.Drawing.Size(45, 16);
			this.gender1RadioButton.TabIndex = 0;
			this.gender1RadioButton.TabStop = true;
			this.gender1RadioButton.Text = "male";
			this.gender1RadioButton.UseVisualStyleBackColor = true;
			// 
			// gender0RadioButton
			// 
			this.gender0RadioButton.AutoSize = true;
			this.gender0RadioButton.Location = new System.Drawing.Point(133, 65);
			this.gender0RadioButton.Name = "gender0RadioButton";
			this.gender0RadioButton.Size = new System.Drawing.Size(54, 16);
			this.gender0RadioButton.TabIndex = 1;
			this.gender0RadioButton.TabStop = true;
			this.gender0RadioButton.Text = "female";
			this.gender0RadioButton.UseVisualStyleBackColor = true;
			// 
			// usGender
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.gender0RadioButton);
			this.Controls.Add(this.gender1RadioButton);
			this.Name = "usGender";
			this.Size = new System.Drawing.Size(342, 150);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton gender1RadioButton;
		private System.Windows.Forms.RadioButton gender0RadioButton;
	}
}
