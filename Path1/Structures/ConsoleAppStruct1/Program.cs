using System;

namespace ConsoleAppStruct1
{
  struct Point
  {
    public int X;
    public int Y;
    public void Print() { Console.WriteLine("{0} {1}", X, Y); }
    public Point(int x, int y)
    {
      X = x;
      Y = y;
    }
  }

  public class Program
  {
    static Point staticPoint;

    static void Main()
    {
      Point point;

      point.X = 10;
      Console.WriteLine(point.X);

      //Console.WriteLine(point.Y); //ошибка компиляции, point.Y не инициализировано
      //point.Print(); //ошибка компиляции, point не инициализирован в целом

      point.Y = 20;
      //Сейчас все будет работать, т.к. point целиком инициализирован
      Console.WriteLine(point.Y);
      point.Print();

      Point point1 = new Point();
      //вызов конструктора по умолчанию инициализирует все поля значениями по умолчанию
      //Поэтому все работает
      Console.WriteLine(point1.Y);
      point1.Print();

      point1 = new Point(30, 40);
      //Вызов другого конструктора перезаписывает поля.
      //Важно: нового объекта в памяти не выделяется! 
      point1.Print();

      //Полей, как статических, так и динамических, проблемы инициализации не касаются
      //Поля-структуры, как и всегда, инициализированы значением по умолчанию
      //То есть для них пустой конструктор вызывается автоматически
      staticPoint.Print();

      //Разумеется, и для поля эта инструкция новой памяти не выделяет
      staticPoint = new Point(4, 5);

    }
  }
}
