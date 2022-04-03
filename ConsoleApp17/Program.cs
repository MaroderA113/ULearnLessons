using System;
using System.IO;
using System.Text;

namespace ConsoleApp17
{
	class Program
	{
		static void Main(string[] args)
		{

			//Английский язык и базовые символы одинаковы во всех кодировках
			//Однако, при сохранении текста в кодировке UTF добавляется специальный маркер файла,
			//по которому текстовые редакторы определяют кодировку текста
			WriteAndRead("Hello!", Encoding.ASCII);
			WriteAndRead("Hello!", Encoding.UTF8);

			//Русские буквы нельзя сохранять в ASCII
			WriteAndRead("Привет!", Encoding.ASCII);

			//Можно попробовать в кодировке локали, но этого лучше не делать:
			//В этом случае файл не самодостаточен, для его прочтения нужно знать
			//какая кодировка у вас в локали
			WriteAndRead("Привет!", Encoding.Default);

			//UTF-8 - лучшее решение!
			//Русские буквы кодируются в ней двумя байтами
			WriteAndRead("Привет!", Encoding.UTF8);

			//А китайские иероглифы - уже тремя
			WriteAndRead("你好!", Encoding.UTF8);

			Console.ReadKey();
		}

		static void WriteAndRead(string text, Encoding encoding)
		{
			Console.WriteLine("{0}, encoding {1}", text, encoding.EncodingName);
			//Так можно записать в файл некий текст
			//Альтернативы - WriteAllLines (записывает массив строк) или WriteAllBytes (массив байт)
			File.WriteAllText("temp.txt", text, encoding);

			//Так можно прочитать массив байт
			//Альтернативы интуитивно понятны
			var bytes = File.ReadAllBytes("temp.txt");
			foreach (var e in bytes)
				Console.Write("  {0} ", (char)e);
			Console.WriteLine();
			foreach (var e in bytes)
				Console.Write("{0:D3} ", e);
			Console.WriteLine();

			//В С# есть явное преобразование типа byte в char. 
			//Это — наследие прежних эпох, когда кодировка была только одна.
			//Злоупотреблять этим не стоит

		}
	}
}
