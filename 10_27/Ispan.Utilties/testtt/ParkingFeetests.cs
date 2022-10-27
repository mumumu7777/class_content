using Ispan.Utilties;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testtt
{
	public class ParkingFeetests
	{
		
		public void calcfee_一小時_傳5元()
		{
			var obj = new ParkingFee();
			int minute = 60;
			int expect = 5;
			int actual = obj.calc(minute);
			Assert.AreEqual(expect, actual);
		}
		
		[TestCase(35)]
		[TestCase(50)]
		public void calcfee_每天最多收三十元(int minutes)
		{
			int expected = 30;
			var obj = new ParkingFee();
			int acual = obj.calc(minutes);
			Assert.AreEqual(expected, acual);


		}
		[TestCase(59,5)]
		[TestCase(61,10)]
		public void calcfee_不足一小時無條件進位(int minutes, int expected)
		{
			var obj = new ParkingFee();
			int acual = obj.calc(minutes);
			Assert.AreEqual(expected, acual);


		}


	}

}
