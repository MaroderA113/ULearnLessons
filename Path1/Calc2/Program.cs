using System;

namespace Calc2
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Введите число 1:");
      double num1 = double.Parse(Console.ReadLine());
      Console.WriteLine("Введите число 2:");
      double num2 = double.Parse(Console.ReadLine());
      Console.WriteLine("Выберите операцию: '+' '-' '*' '/'");
      char oper = char.Parse(Console.ReadLine());

      switch (oper)
      {
        case '+':
          Console.WriteLine($"a {oper} b = " + (num1 + num2));
          break;

        case '-':
          Console.WriteLine($"a {oper} b = " + (num1 - num2));
          break;

        case '*':
          Console.WriteLine($"a {oper} b = " + (num1 * num2));
          break;

        case '/':
          Console.WriteLine($"a {oper} b = " + (num1 / num2));
          break;

        default:
          Console.WriteLine("Попробуйте еще раз");
          break;
      }

          Console.ReadKey();
    }
  }
}
