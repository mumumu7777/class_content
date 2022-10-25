using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lottery
{
	public partial class 樂透 : Form
	{
		public 樂透()
		{
			InitializeComponent();
		}

		private void drawbuttom_Click(object sender, EventArgs e)
		{
			Lottery lottery = new Lottery();
			int[] numbers = lottery.draw(51,3);
			Array.Sort(numbers);

			string msg = string.Join(",", numbers);//5,35,16,1,9,78,55
			label1.Text = msg;



		}


		
		public class Lottery
		{/// <summary>
		/// 從多個數字中取得n個不重複值
		/// </summary>
		/// <param name="numbers">1~numbers是取亂數對象</param>
		/// <param name="drawnumber">取出不重複值</param>
		/// <returns>傳回陣列含不重複值</returns>
			public int[] draw(int numbers, int drawnumber)
			{ 			
			return new int[] { 55,35,16,1,9,78,55 };	
				


			}		
			

		}


	}
}
