using System;

namespace ConsoleAppInher3
{
	class Transport
	{
	}

	class CombustionEngineTransport : Transport
	{
	}

	class Car : CombustionEngineTransport
	{
	}

	class Program
	{
		static void Main(string[] args)
		{
			var car = new Car();

			var carAsTransport = (Transport)car; //это upcast
																					 // здесь мы начинаем смотреть на автомобиль просто как 
																					 // на какое-то транспортное средство

			Transport carAsTransport1 = car; //можно писать так. 
																			 // upcast - безопасная процедура, поэтому, как и с конверсией типа
																			 // ее можно не указывать явно

			var car1 = (Car)carAsTransport;  //это downcast
																			 // мы снова начинаем смотреть на автомобиль, как на автомобиль

			var elephant = new Transport();
			// Car wrongCar = (Car)elephant;
			// этот downcast выбросит InvalidCastException, 
			// потому что слон - это не автомобиль.
			// мы не можем смотреть на произвольный транспорт, как на автомобиль

			// оператор is позволяет проверить,
			// является ли объект типа Transport 
			// на самом деле автомобилем
			if (elephant is Car)
			{
				Console.WriteLine("Ok, elephant is car");
			}
		}
	}
}
