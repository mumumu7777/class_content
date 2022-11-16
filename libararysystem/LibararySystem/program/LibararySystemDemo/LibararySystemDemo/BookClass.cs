using ISpan.Utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibararySystemDemo
{
	public partial class BookClass : Form
	{

		DataTable bookclass;
		public BookClass()
		{
			InitializeComponent();
			DisplayBookClass();
		}


		private void DisplayBookClass()
		{
			string sql = @"SELECT * from bookclass order by id ";
			
			bookclass = new SqlDBhelper("default").Select(sql, null);

			BindData(bookclass);
		}
		private void BindData(DataTable model)
		{
			dataGridView1.DataSource = model;
		}

	}
}
