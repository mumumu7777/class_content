using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hard
{
	public partial class hiform : Form
	{
		public hiform(string name)
		{
			InitializeComponent();
			name = name;
			label1.Text = $"hi{name}";



		}


		
	}
}
