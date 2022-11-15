namespace ISpan.Estore
{
	partial class EditUsersForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.Accounttextbox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.PassWordTextbox = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.NameTEXTbox = new System.Windows.Forms.TextBox();
			this.updatebtn = new System.Windows.Forms.Button();
			this.deletebtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(76, 55);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(44, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "Account";
			// 
			// Accounttextbox
			// 
			this.Accounttextbox.Location = new System.Drawing.Point(143, 52);
			this.Accounttextbox.Name = "Accounttextbox";
			this.Accounttextbox.Size = new System.Drawing.Size(100, 22);
			this.Accounttextbox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(76, 103);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(51, 12);
			this.label2.TabIndex = 0;
			this.label2.Text = "PassWord";
			// 
			// PassWordTextbox
			// 
			this.PassWordTextbox.Location = new System.Drawing.Point(143, 100);
			this.PassWordTextbox.Name = "PassWordTextbox";
			this.PassWordTextbox.Size = new System.Drawing.Size(100, 22);
			this.PassWordTextbox.TabIndex = 1;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(76, 154);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(32, 12);
			this.label3.TabIndex = 0;
			this.label3.Text = "Name";
			// 
			// NameTEXTbox
			// 
			this.NameTEXTbox.Location = new System.Drawing.Point(143, 151);
			this.NameTEXTbox.Name = "NameTEXTbox";
			this.NameTEXTbox.Size = new System.Drawing.Size(100, 22);
			this.NameTEXTbox.TabIndex = 1;
			// 
			// updatebtn
			// 
			this.updatebtn.Location = new System.Drawing.Point(78, 196);
			this.updatebtn.Name = "updatebtn";
			this.updatebtn.Size = new System.Drawing.Size(75, 23);
			this.updatebtn.TabIndex = 2;
			this.updatebtn.Text = "Update";
			this.updatebtn.UseVisualStyleBackColor = true;
			this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
			// 
			// deletebtn
			// 
			this.deletebtn.Location = new System.Drawing.Point(168, 196);
			this.deletebtn.Name = "deletebtn";
			this.deletebtn.Size = new System.Drawing.Size(75, 23);
			this.deletebtn.TabIndex = 2;
			this.deletebtn.Text = "Delete";
			this.deletebtn.UseVisualStyleBackColor = true;
			this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
			// 
			// EditUsersForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(345, 307);
			this.Controls.Add(this.deletebtn);
			this.Controls.Add(this.updatebtn);
			this.Controls.Add(this.NameTEXTbox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.PassWordTextbox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.Accounttextbox);
			this.Controls.Add(this.label1);
			this.Name = "EditUsersForm";
			this.Text = "EditUsersForm";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox Accounttextbox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox PassWordTextbox;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox NameTEXTbox;
		private System.Windows.Forms.Button updatebtn;
		private System.Windows.Forms.Button deletebtn;
	}
}