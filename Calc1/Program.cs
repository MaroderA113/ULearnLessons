using System;

namespace Calc1
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Нажмите 1 если хотите выполнить сложение");
      Console.WriteLine("Нажмите 2 если хотите выполнить вычитание");
      Console.WriteLine("Нажмите 3 если хотите выполнить умножение");
      Console.WriteLine("Нажмите 4 если хотите выполнить деление");
      Console.WriteLine("Нажмите 5 если хотите найти остаток от деления");
      int oper = int.Parse(Console.ReadLine());
      
      if (oper == 1)
      {
        Console.WriteLine("Введите слагаемое 1:");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите слагаемое 2:");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Сумма чисел = " + (num1 + num2));
      }
      else if (oper == 2)
      {
        Console.WriteLine("Введите уменьшаемое 1:");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите вычитаемое 2:");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Разность чисел = " + (num1 - num2));
      }
      else if (oper == 3)
      {
        Console.WriteLine("Введите множитель 1:");
        int num1 = int.Parse(Console.ReadLine());
        Console.WriteLine("Введите множитель 2:");
        int num2 = int.Parse(Console.ReadLine());
        Console.WriteLine("Произведение чисел = " + (num1 * num2));
      }
      else if (oper == 4)
      {
        Console.WriteLine("Введите делимое 1:");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите делитель 2:");
        double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Частное чисел = " + (num1 / num2));
      }
      else if (oper == 5)
      {
        Console.WriteLine("Введите число 1:");
        double num1 = double.Parse(Console.ReadLine());
        Console.WriteLine("Введите число 2:");
        double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine("Остаток от деления чисел = " + (num1 % num2));
      }
      else 
      {
        Console.WriteLine("Значение некорректно");
      }
      Console.ReadKey()
;    }
  }
}
