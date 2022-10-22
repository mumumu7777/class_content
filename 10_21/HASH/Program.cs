using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HASH
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<int> ITEMS = new List<int> { 3,7,1,99,2,5};
			bool B1 = ITEMS.Contains(1);//FALSE時做事迴圈比較慢

			HashSet<int>set1 = new HashSet<int> {3,7,1,99,2,5};
			bool b2 = set1.Contains(1);//flase ,內部用雜湊比較快
		}
	}
}
