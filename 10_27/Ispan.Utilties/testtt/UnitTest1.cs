using Ispan.Utilties;

namespace testtt
{
	public class Tests
	{
		[SetUp]
		public void Setup()
		{

		}

		[Test]
		public void Test1()
		{
			var math = new Mymath();
			int price = 1890;
			double discount = 0.05;
			int actual = math.Gettotal(price, discount);
			Assert.AreEqual(95,actual);
		}
		[Test]
		public void Test2()
		{
			var math = new Mymath();
			int price = 100;
			double discount = 0.05;
			int actual = math.Gettotal(price, discount);
			Assert.AreEqual(5, actual);
		}
	}
}