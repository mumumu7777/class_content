using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DELETEDATA
{
	internal class Program
	{
		static void Main(string[] args)
		{
			filehelper helper = new filehelper();

			string foldername = @"d:\temp\files";
			string filename = "readme.txt";
			helper.Delete(foldername, filename);


			order order = new order();
			int origtotal = 1000;
			decimal discount = 0.8m;
			int total = order.calcutotal(origtotal, discount);


			var imghelper = new imghelper();
			int targetwidth = 60;
			int targetheight = 60;
			string imgfilesource = @"d:\files\pic.jpg";
			string targetpath = @"e:\dsadas\";
			imghelper.resizeimg(imgfilesource, targetwidth, targetheight,targetpath);


		
		}

		class order

		{
		public int calcutotal(int total, decimal discount) //計算折扣

			{ 
				
				if (total <= 0) throw new Exception("原始金額必須大於零");
				if (discount <= 0 || discount > 1) throw new Exception("折扣必須正常");
					return (int)((decimal)total * discount);
			}		
		}


		class filehelper

		{

			public void Delete(string filename, string foldername)
			{}
		}

		class imghelper

		{

			public void resizeimg(string imgsrcfile, int targetwidth, int targetheight,string targetpath) { }

		}
	}
}
