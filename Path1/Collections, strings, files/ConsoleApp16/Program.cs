using System;
using System.IO;
using System.Reflection;

namespace ConsoleApp16
{
	class Program
	{
		static void Main(string[] args)
		{
      // Запись текста в файл:
      File.WriteAllText("1.txt", "Hello, world!");

      // Путь относительно "текущей директории", которую можно узнать так:
      Console.WriteLine(Environment.CurrentDirectory);
      // Обычно это директория, в которой была запущена ваша программа

      // А размещение запущенного exe-файла можно узнать так:
      Console.WriteLine(Assembly.GetExecutingAssembly().Location);

      // Сформировать абсолютный путь по относительному можно так:
      Console.WriteLine(Path.Combine(Environment.CurrentDirectory, "1.txt"));

      // Записать строки в файл,
      // разделив их символом конца строки (\r\n для Windows и \n для Linux и MacOS)
      File.WriteAllLines("2.txt", new[] { "Hello", "world" });

      // Записать в файл массив байтов в бинарном виде:
      File.WriteAllBytes("3.dat", new byte[10240]);

      // Чтение данных из файла
      string text = File.ReadAllText("1.txt");
      string[] lines = File.ReadAllLines("2.txt");
      byte[] bytes = File.ReadAllBytes("3.dat");

      // Все файлы в текущей директории (точка в пути означает текущую директорию)
      foreach (var file in Directory.GetFiles("."))
        Console.WriteLine(file);

      Console.ReadKey();
    }
	}
}
