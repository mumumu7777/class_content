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

namespace ISpan.Estore
{
	public partial class ProductCategoriesForm : Form
	{
		DataTable categories;
		public ProductCategoriesForm()
		{
			InitializeComponent();
			DisplayProductCategories();
		}


		private void DisplayProductCategories()
		{
			string sql = "select * from productcategories order by displayorder";
			categories = new SqlDBhelper("default").Select(sql, null);
			BindData (categories);
		}
		private void BindData(DataTable model)
		{
			dataGridView1.DataSource = model;
		}

		private void addnewbutton_Click(object sender, EventArgs e)
		{

			var frm = new CreateNewProductCategory();
			//frm.ShowDialog();
			DialogResult result =frm.ShowDialog ();

			if (result == DialogResult.OK)
			{ 
			DisplayProductCategories ();
			}

		}

		
		private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
		{
			int rowindx = e.RowIndex;
			if (rowindx < 0) return;
			DataRow row = this.categories.Rows[rowindx];//data user click 
			int id = row.Field<int>("id");// user click data's id 

			// 把id傳給表單的建構函數
			var frm = new EditProductCategoryForm(id);
			//frm.Show();
			DialogResult result = frm.ShowDialog();
			if (result == DialogResult.OK)
			{
				DisplayProductCategories();
			}
		}
	}


}
