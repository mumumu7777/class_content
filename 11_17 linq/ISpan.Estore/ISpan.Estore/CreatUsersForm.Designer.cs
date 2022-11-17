namespace ISpan.Estore
{
	partial class CreatUsersForm
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.Accounttxtbox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.Passwordtxtbox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.Nametxtbox = new System.Windows.Forms.TextBox();
			this.Savebtn = new System.Windows.Forms.Button();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(165, 120);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(29, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "帳號";
			// 
			// Accounttxtbox
			// 
			this.Accounttxtbox.Location = new System.Drawing.Point(256, 117);
			this.Accounttxtbox.Name = "Accounttxtbox";
			this.Accounttxtbox.Size = new System.Drawing.Size(148, 22);
			this.Accounttxtbox.TabIndex = 0;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(165, 171);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(29, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "密碼";
			// 
			// Passwordtxtbox
			// 
			this.Passwordtxtbox.Location = new System.Drawing.Point(256, 168);
			this.Passwordtxtbox.Name = "Passwordtxtbox";
			this.Passwordtxtbox.Size = new System.Drawing.Size(148, 22);
			this.Passwordtxtbox.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(165, 229);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(29, 12);
			this.label3.TabIndex = 0;
			this.label3.Text = "姓名";
			// 
			// Nametxtbox
			// 
			this.Nametxtbox.Location = new System.Drawing.Point(256, 226);
			this.Nametxtbox.Name = "Nametxtbox";
			this.Nametxtbox.Size = new System.Drawing.Size(148, 22);
			this.Nametxtbox.TabIndex = 2;
			// 
			// Savebtn
			// 
			this.Savebtn.Location = new System.Drawing.Point(387, 279);
			this.Savebtn.Name = "Savebtn";
			this.Savebtn.Size = new System.Drawing.Size(75, 23);
			this.Savebtn.TabIndex = 2;
			this.Savebtn.Text = "Save";
			this.Savebtn.UseVisualStyleBackColor = true;
			this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// CreatUsersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.Savebtn);
			this.Controls.Add(this.Nametxtbox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.Passwordtxtbox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Accounttxtbox);
			this.Controls.Add(this.label1);
			this.Name = "CreatUsersForm";
			this.Text = "CreatUsersForm";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Accounttxtbox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox Passwordtxtbox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox Nametxtbox;
		private System.Windows.Forms.Button Savebtn;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}