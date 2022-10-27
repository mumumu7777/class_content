using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Ispan.Utilties
{
	public class ParkingFee
	{

		public int calc(int minutes)
		{
			int hours = (int)Math.Ceiling((double)minutes / 60d);
			int fee =  hours * 5;

			return Math.Min(fee,30);
		}






	}

}

