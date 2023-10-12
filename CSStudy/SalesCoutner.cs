﻿namespace SalesCalculator
{
	public class SalesCounter
	{
		private List<Sale> _sales;

		public SalesCounter(string filePath)
		{
			_sales = ReadSales(filePath);
		}
		public static List<Sale> ReadSales(string filePath)
		{
			List<Sale> sales = new List<Sale>();
			string[] lines = File.ReadAllLines(filePath);
			foreach (string line in lines)
			{
				string[] items = line.Split(',');
				Sale sale = new Sale
				{
					ShopName = items[0],
					ProductCategory = items[1],
					Amount = int.Parse(items[2])
				};
				sales.Add(sale);
			}
			return sales;
		}

		public Dictionary<string, int> GetPerStoreSales()
		{
			Dictionary<string, int> dict = new Dictionary<string, int>();
			foreach (Sale sale in _sales)
			{
				if (dict.ContainsKey(sale.ShopName))
					dict[sale.ShopName] += sale.Amount;
				else
					dict[sale.ShopName] = sale.Amount;
			}
			return dict;
		}
	}
}
