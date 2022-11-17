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
	public partial class CheckBoxList : Form
	{
		public CheckBoxList()
		{
			InitializeComponent();
		}

		private void textBox5_TextChanged(object sender, EventArgs e)
		{

		}

		private void GETVALUE_Click(object sender, EventArgs e)
		{
			CheckBox[] controls = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6 };

			string value = string.Empty;
			foreach (CheckBox item in controls)
			{
				if (item.Checked) value += "," + item.Tag.ToString();
			}
			if (string.IsNullOrEmpty(value) == false)
			{
				value = value.Substring(0); //把前豆刪除
			}
			MessageBox.Show(value);

		}

		private void SETVALUE_Click(object sender, EventArgs e)
		{

			CheckBox[] controls = new CheckBox[] { checkBox1, checkBox2, checkBox3, checkBox4, checkBox5, checkBox6 };

			//先取消勾選全部
			foreach (CheckBox item in controls)
			{
				item.Checked = false;
			}

			string valuedb = textBox1.Text;
			if (string.IsNullOrEmpty(valuedb)) return;

			//找出dictionary對照表
			Dictionary<string, CheckBox> map = new Dictionary<string, CheckBox>();

			//[{"A",checkbox1}]...
			foreach (CheckBox item in controls) { map.Add(item.Tag.ToString(), item); }

			//根據valuedb直,決定勾選ccheckbox	

			string[] values = valuedb.Split(',');
			foreach (string key in values)
			{
				if (map.ContainsKey(key))
				{
					CheckBox control = map[key];
					control.Checked = true;
				}
			}

		}
	}
}
