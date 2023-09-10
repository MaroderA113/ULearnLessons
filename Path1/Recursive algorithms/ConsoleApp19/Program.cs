using System;

namespace ConsoleApp19
{
	class Program
	{
		static void Make (int n)
		{
			for (int i = n-1; i >= 0; i--)
			{
				Console.Write(i + " ");
				Make(i);
			}
		}
		
		static void Main(string[] args)
		{
			Make(3);
		}
	}
}
