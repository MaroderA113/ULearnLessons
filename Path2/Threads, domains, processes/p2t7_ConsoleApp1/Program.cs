// Класс Thread
namespace p2t7_ConsoleApp1;

public class Program
{
	static void MakeWork(int number)
	{
		double a = 1;
		while (true)
		{
			for (int i = 0; i < 1000000; i++)
				a /= 1.01;
			Console.WriteLine(number);
		}
	}
	static void Main(string[] args)
	{
		var thread1 = new Thread(() => MakeWork(1));
		thread1.Start();
		var thread2 = new Thread(() => MakeWork(2));
		thread2.Start();
		Thread.Sleep(Timeout.Infinite);
	}

	static void MainX(string[] args)
	{
		// ThreadStart делегат который фактически запускает метод с параметром
		// Заметьте что самому делегату не передается параметр, что соответствует его описанию
		// first.Start(1); Так будет исключение: Поток был создан с делегатом, который не допускает параметров
		//var first = new Thread(new ThreadStart(() => MakeWork(1)));
		//first.Start();

		// Тоже самое что и выше.
		// Эта техника называется техникой предположения делегата.
		//var second = new Thread(() => MakeWork(2));
		//second.Start();

		// Также есть перегрузка конструктора с ParameterizedThreadStart, где происходит "связка" метода с делегатом
		// Аргумент передается во время запуска потока
		//var parameterizedThreadStart = new ParameterizedThreadStart(MakeWork);
		//var third = new Thread(parameterizedThreadStart);
		//third.Start(3);

		// Тоже самое что и выше, сокращенная запись
		//var fourth = new Thread((arg) => MakeWork(arg));
		//fourth.Start(4);

		//ThreadStart - это делегат, с такой же сигнатурой как и Action: ничего не принимает и ничего не возвращает
		//ParameterizedThreadStart - это также делегат, который принимает один объект типа object и ничего не возвращает
	}
}