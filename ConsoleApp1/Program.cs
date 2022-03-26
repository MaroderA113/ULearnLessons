using System;
using System.Globalization;

namespace ConsoleApp1
{
  public class MainClass
  {
    static void Main(string[] args)
    {

      for (int i = -100; i <= 100; i++)

      {
        Console.WriteLine("Для остановки введите 'exit':");
        string b = Console.ReadLine();

        if (b == "exit")
        { 
          break; 
        }

        Console.WriteLine(i);
      }


      Console.ReadKey();
    }
  }
}
