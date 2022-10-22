namespace _99
{
	internal partial class Program
	{
		class mathutill

		{
			public string multiplaytables()

			{
				string tables = string.Empty;

				for (int i = 2; i < 10; i++)
				{
					tables = tables + generatesingletable(i);


				}
				return tables;
			}




			private string generatesingletable(int firstnumber)
			{

				string table = string.Empty;
				for (int secondnumber = 1; secondnumber < 10; secondnumber++)
				{
					string row = $"{firstnumber}*{secondnumber}={firstnumber * secondnumber}\r\n";
					table = table + row;

				}

				return table + "\r\n";




			}

		}






	}
}

