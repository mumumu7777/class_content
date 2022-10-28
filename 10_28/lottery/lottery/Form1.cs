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
	public partial class Form1 : Form
	{
		private Guessnumber game;
		public Form1()
		{
			InitializeComponent();
			game = new Guessnumber();
			resultlbl.Text=String.Empty;
		}
		private void searchbtm_Click(object sender, EventArgs e)
		{

			int?guessNumber = Getuserint();
			if (guessNumber.HasValue==false)
			{
				MessageBox.Show("請輸入值再試一次");
			}

			GuessResult result = game.guess(guessNumber.Value);
				if (result.issuccess == true)
			{ MessageBox.Show("答對了"); }

			else { MessageBox.Show("答錯了"); resultlbl.Text = result.hint;  }


		}
		private void newgamebtm_Click(object sender, EventArgs e)
		{
			game.Newgame();
			resultlbl.Text = game.hint;
			
		}
		/// <summary>
		/// 取得使用者輸入值
		/// </summary>
		/// <returns></returns>
		private int? Getuserint()
		{
			TextBox txt = this.textBox1;
			string input = txt.Text;
			if (string.IsNullOrEmpty(input))return null;
			bool isint = int.TryParse(input, out int number);
			return isint ? number : (int?)null;		
		}
		

		public class Guessnumber
		{
			private int answer; //這次得答案
			private int min = 1, max = 99; //目前的範圍
			/// <summary>
			/// 新遊戲，重新產生一個亂數
			/// </summary>
			public void Newgame()
			{ 
				int seed = Guid.NewGuid().GetHashCode(); 

				var random = new Random(seed);

				answer = random.Next(1,100);
			}
			public GuessResult guess(int guessNumber)
			{
				if (this.answer == guessNumber)
				{
					return GuessResult.Success();
				}
				//提示範圍

				if (guessNumber < min || guessNumber > max)
				{ return new GuessResult { issuccess = false, hint = this.hint }; }
				//chane range
				if (guessNumber < answer)
				{
					min = guessNumber;
				}
				else { max = guessNumber; }

					return new GuessResult { issuccess = false, hint = this.hint };	
				
			}
			public string hint { get{ return $"{min}~{max},answer = {answer}"; } }
				
		}
		public class GuessResult
		{
			public static GuessResult Success()
			{
				return new GuessResult { issuccess = true, hint = string.Empty };
			}
			public static GuessResult Failed(string errMessage)
			{
				return new GuessResult() { issuccess = false, hint = errMessage};
			}

			public bool issuccess { get; set; }
			public bool isfailed { get { return !issuccess; } }
			//public bool Isfailed => !issuccess

			public string hint { get; set; }
		}

		
	}
}
