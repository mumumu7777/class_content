namespace LibararySystemDemo
{
	partial class MainForm
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.維護書本ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.維護書籍類別ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.維護使用者ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.登出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.label1 = new System.Windows.Forms.Label();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.menuStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.BackColor = System.Drawing.Color.LavenderBlush;
			this.menuStrip1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.維護書本ToolStripMenuItem,
            this.維護書籍類別ToolStripMenuItem,
            this.維護使用者ToolStripMenuItem,
            this.登出ToolStripMenuItem});
			this.menuStrip1.Location = new System.Drawing.Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(858, 25);
			this.menuStrip1.TabIndex = 1;
			this.menuStrip1.Text = "11111";
			// 
			// 維護書本ToolStripMenuItem
			// 
			this.維護書本ToolStripMenuItem.Name = "維護書本ToolStripMenuItem";
			this.維護書本ToolStripMenuItem.Size = new System.Drawing.Size(72, 21);
			this.維護書本ToolStripMenuItem.Text = "維護書本";
			this.維護書本ToolStripMenuItem.Click += new System.EventHandler(this.維護書本ToolStripMenuItem_Click);
			// 
			// 維護書籍類別ToolStripMenuItem
			// 
			this.維護書籍類別ToolStripMenuItem.Name = "維護書籍類別ToolStripMenuItem";
			this.維護書籍類別ToolStripMenuItem.Size = new System.Drawing.Size(98, 21);
			this.維護書籍類別ToolStripMenuItem.Text = "維護書籍類別";
			this.維護書籍類別ToolStripMenuItem.Click += new System.EventHandler(this.維護書本類別ToolStripMenuItem_Click);
			// 
			// 維護使用者ToolStripMenuItem
			// 
			this.維護使用者ToolStripMenuItem.Name = "維護使用者ToolStripMenuItem";
			this.維護使用者ToolStripMenuItem.Size = new System.Drawing.Size(85, 21);
			this.維護使用者ToolStripMenuItem.Text = "維護使用者";
			this.維護使用者ToolStripMenuItem.Click += new System.EventHandler(this.維護使用者ToolStripMenuItem_Click);
			// 
			// 登出ToolStripMenuItem
			// 
			this.登出ToolStripMenuItem.Name = "登出ToolStripMenuItem";
			this.登出ToolStripMenuItem.Size = new System.Drawing.Size(46, 21);
			this.登出ToolStripMenuItem.Text = "登出";
			this.登出ToolStripMenuItem.Click += new System.EventHandler(this.登出ToolStripMenuItem_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.LavenderBlush;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(666, 8);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "label1";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.LightSteelBlue;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(858, 425);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.menuStrip1);
			this.ForeColor = System.Drawing.Color.Black;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.MaximumSize = new System.Drawing.Size(874, 464);
			this.MinimumSize = new System.Drawing.Size(874, 464);
			this.Name = "MainForm";
			this.Text = "MainForm";
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.ToolStripMenuItem 維護書本ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 維護書籍類別ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 維護使用者ToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem 登出ToolStripMenuItem;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Timer timer1;
	}
}