namespace p2t4_ConsoleApp14;

using System;
using System.Threading;

public class Timer
{
	public int Interval;
	public Action Tick;

	public void Start()
	{
		while (true)
		{
			if (Tick != null) // если в Tick ничего не присвоить и вызвать, будет NullReferenceException
				Tick();
			Thread.Sleep(Interval); // ждет заданное время
		}
	}
}

public class Program
{
	public static void Main()
	{
		var timer = new Timer();
		timer.Interval = 1000;
		timer.Tick = () => Console.WriteLine("Tick!");
		timer.Start();
	}
}