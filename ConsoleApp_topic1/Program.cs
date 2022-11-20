namespace ConsoleApp_topic1
{
	internal class Program
	{
		static Random rnd = new Random();

		static int? GetNumber7()
		{
			for (int i = 0; i < 10; i++)
			{
				if (Console.KeyAvailable)
				{
					return rnd.Next(100);
				}
				Thread.Sleep(100);
			}
			return null;
		}

		static void Main()
		{
			var value = GetNumber7();
			if (value != null)
				Console.WriteLine(value);
			else
			{
				Console.WriteLine(value.HasValue);
				Console.WriteLine("The server was unreachable");
			}		
		}

	}
}