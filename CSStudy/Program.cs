using System.IO;

namespace SalesCalculator
{
	class Program
	{
		static void Main(string[] args)
		{
			var sales = new SalesCounter("sales.csv");
			var amountPerStore = sales.GetPerStoreSales();
			foreach(KeyValuePair<string, int> obj in amountPerStore)
			{
				Console.WriteLine("{0}, {1}", obj.Key, obj.Value);
			}
		}
	}
}