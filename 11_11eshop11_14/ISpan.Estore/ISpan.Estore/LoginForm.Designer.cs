namespace ISpan.Estore
{
	partial class LoginForm
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
			this.Loginbtn = new System.Windows.Forms.Button();
			this.Passwordtxtbox = new System.Windows.Forms.TextBox();
			this.passwordbtn = new System.Windows.Forms.Label();
			this.Accounttxtbox = new System.Windows.Forms.TextBox();
			this.accountbtn = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// Loginbtn
			// 
			this.Loginbtn.Location = new System.Drawing.Point(34, 176);
			this.Loginbtn.Name = "Loginbtn";
			this.Loginbtn.Size = new System.Drawing.Size(351, 50);
			this.Loginbtn.TabIndex = 8;
			this.Loginbtn.Text = "Login";
			this.Loginbtn.UseVisualStyleBackColor = true;
			this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click);
			// 
			// Passwordtxtbox
			// 
			this.Passwordtxtbox.Location = new System.Drawing.Point(159, 121);
			this.Passwordtxtbox.Name = "Passwordtxtbox";
			this.Passwordtxtbox.Size = new System.Drawing.Size(148, 22);
			this.Passwordtxtbox.TabIndex = 7;
			// 
			// passwordbtn
			// 
			this.passwordbtn.AutoSize = true;
			this.passwordbtn.Location = new System.Drawing.Point(68, 124);
			this.passwordbtn.Name = "passwordbtn";
			this.passwordbtn.Size = new System.Drawing.Size(29, 12);
			this.passwordbtn.TabIndex = 4;
			this.passwordbtn.Text = "密碼";
			// 
			// Accounttxtbox
			// 
			this.Accounttxtbox.Location = new System.Drawing.Point(159, 70);
			this.Accounttxtbox.Name = "Accounttxtbox";
			this.Accounttxtbox.Size = new System.Drawing.Size(148, 22);
			this.Accounttxtbox.TabIndex = 5;
			// 
			// accountbtn
			// 
			this.accountbtn.AutoSize = true;
			this.accountbtn.Location = new System.Drawing.Point(68, 73);
			this.accountbtn.Name = "accountbtn";
			this.accountbtn.Size = new System.Drawing.Size(29, 12);
			this.accountbtn.TabIndex = 6;
			this.accountbtn.Text = "帳號";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// LoginForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(424, 285);
			this.Controls.Add(this.Loginbtn);
			this.Controls.Add(this.Passwordtxtbox);
			this.Controls.Add(this.passwordbtn);
			this.Controls.Add(this.Accounttxtbox);
			this.Controls.Add(this.accountbtn);
			this.Name = "LoginForm";
			this.Text = "LoginForm";
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Loginbtn;
		private System.Windows.Forms.TextBox Passwordtxtbox;
		private System.Windows.Forms.Label passwordbtn;
		private System.Windows.Forms.TextBox Accounttxtbox;
		private System.Windows.Forms.Label accountbtn;
		private System.Windows.Forms.ErrorProvider errorProvider1;
	}
}