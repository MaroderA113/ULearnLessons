using System;

namespace ConsoleAppPriv1
{
	public class Statistics
	{
		private int totalCount;
		private int successCount;
		public void AccountCase(bool isSuccess)
		{
			if (isSuccess) successCount++;
			totalCount++;
		}
		public void Print()
		{
			Console.WriteLine("{0}%", (successCount * 100) / totalCount);
		}
	}


	class Program
	{
		static void Main(string[] args)
		{
			var rnd = new Random();
			var stat = new Statistics();
			for (int i = 0; i < 1000; i++)
				stat.AccountCase(rnd.Next(3) > 1);
			stat.Print();

			//Теперь так сделать нельзя: доступ к приватным полям возможен только изнутри класса
			//stat.totalCount = 100;
			//stat.successCount = 146;
		}
	}
}
