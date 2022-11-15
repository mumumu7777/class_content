namespace ISpan.EStore.Controls
{
	partial class ucGender
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
			this.gender1 = new System.Windows.Forms.RadioButton();
			this.gender0 = new System.Windows.Forms.RadioButton();
			this.SuspendLayout();
			// 
			// gender1
			// 
			this.gender1.AutoSize = true;
			this.gender1.Location = new System.Drawing.Point(3, 3);
			this.gender1.Name = "gender1";
			this.gender1.Size = new System.Drawing.Size(35, 16);
			this.gender1.TabIndex = 0;
			this.gender1.Tag = "true";
			this.gender1.Text = "男";
			this.gender1.UseVisualStyleBackColor = true;
			// 
			// gender0
			// 
			this.gender0.AutoSize = true;
			this.gender0.Location = new System.Drawing.Point(57, 3);
			this.gender0.Name = "gender0";
			this.gender0.Size = new System.Drawing.Size(35, 16);
			this.gender0.TabIndex = 0;
			this.gender0.Tag = "false";
			this.gender0.Text = "女";
			this.gender0.UseVisualStyleBackColor = true;
			// 
			// ucGender
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.gender0);
			this.Controls.Add(this.gender1);
			this.Name = "ucGender";
			this.Size = new System.Drawing.Size(98, 25);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.RadioButton gender1;
		private System.Windows.Forms.RadioButton gender0;
	}
}
