using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ISpan.Estore.Controls
{
	public partial class usGender : UserControl
	{
		public usGender()
		{
			InitializeComponent();
		}
		public int GetValue()
		{
			RadioButton[] controls = new RadioButton[] { gender0RadioButton, gender1RadioButton };

			int value = -1;
			foreach (RadioButton item in controls)
			{
				if (item.Checked == true)
				{
					value = Convert.ToInt32(item.Tag);
					break;
				}
			}
			return value;
		}

		public void SetValue(int value)
		{
			RadioButton[] controls = new RadioButton[] { gender0RadioButton, gender1RadioButton };

			//先清空所有 radio button被勾選的狀態
			foreach (RadioButton item in controls)
			{
				item.Checked = false;
			}

			//根據 value,決定哪一個radio button 要被選取
			foreach (RadioButton item in controls)
			{
				int controlTag = Convert.ToInt32(item.Tag);
				if (controlTag == value)
				{
					item.Checked = true;
					break;
				}
			}
		}




	}
}
