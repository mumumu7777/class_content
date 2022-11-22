namespace LibararySystemDemo
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
			this.Loginbtn = new System.Windows.Forms.Button();
			this.Passwordtxtbox = new System.Windows.Forms.TextBox();
			this.passwordbtn = new System.Windows.Forms.Label();
			this.Accounttxtbox = new System.Windows.Forms.TextBox();
			this.accountbtn = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// Loginbtn
			// 
			this.Loginbtn.BackColor = System.Drawing.Color.LavenderBlush;
			this.Loginbtn.Location = new System.Drawing.Point(88, 150);
			this.Loginbtn.Name = "Loginbtn";
			this.Loginbtn.Size = new System.Drawing.Size(274, 50);
			this.Loginbtn.TabIndex = 3;
			this.Loginbtn.Text = "登入";
			this.Loginbtn.UseVisualStyleBackColor = false;
			this.Loginbtn.Click += new System.EventHandler(this.Loginbtn_Click_1);
			// 
			// Passwordtxtbox
			// 
			this.Passwordtxtbox.Location = new System.Drawing.Point(193, 102);
			this.Passwordtxtbox.Name = "Passwordtxtbox";
			this.Passwordtxtbox.PasswordChar = '*';
			this.Passwordtxtbox.Size = new System.Drawing.Size(148, 22);
			this.Passwordtxtbox.TabIndex = 1;
			// 
			// passwordbtn
			// 
			this.passwordbtn.AutoSize = true;
			this.passwordbtn.BackColor = System.Drawing.Color.White;
			this.passwordbtn.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.passwordbtn.Location = new System.Drawing.Point(102, 105);
			this.passwordbtn.Name = "passwordbtn";
			this.passwordbtn.Size = new System.Drawing.Size(39, 19);
			this.passwordbtn.TabIndex = 9;
			this.passwordbtn.Text = "密碼";
			// 
			// Accounttxtbox
			// 
			this.Accounttxtbox.Location = new System.Drawing.Point(193, 51);
			this.Accounttxtbox.Name = "Accounttxtbox";
			this.Accounttxtbox.Size = new System.Drawing.Size(148, 22);
			this.Accounttxtbox.TabIndex = 0;
			// 
			// accountbtn
			// 
			this.accountbtn.AutoSize = true;
			this.accountbtn.BackColor = System.Drawing.Color.White;
			this.accountbtn.Font = new System.Drawing.Font("微軟正黑體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.accountbtn.Location = new System.Drawing.Point(102, 54);
			this.accountbtn.Name = "accountbtn";
			this.accountbtn.Size = new System.Drawing.Size(39, 19);
			this.accountbtn.TabIndex = 0;
			this.accountbtn.Text = "帳號";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
			this.label1.Location = new System.Drawing.Point(132, 236);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(60, 17);
			this.label1.TabIndex = 10;
			this.label1.Text = "新增帳號";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.White;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(281, 236);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 17);
			this.label2.TabIndex = 10;
			this.label2.Text = "忘記密碼";
			// 
			// LoginForm
			// 
			this.AcceptButton = this.Loginbtn;
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(424, 286);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
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
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}