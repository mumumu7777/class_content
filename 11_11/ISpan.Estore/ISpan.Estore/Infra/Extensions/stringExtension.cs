namespace ISpan.Estore.Infra.Extensions
{
	public static class stringExtension
	{
		public static int Toint(this string source, int defaultvalue)

		{
			bool isint = int.TryParse(source, out int number);
			return isint ? number : defaultvalue;
		}
	}
}
