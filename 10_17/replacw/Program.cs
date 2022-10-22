using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace replace
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string raw = "line1\r\nline2";
			raw = null;

			string html = string.Empty;

			if (!string.IsNullOrEmpty(raw))

			{ html = raw.Replace("\r\n", "<br>"); }

			Console.WriteLine(html);



		}
	}
}
