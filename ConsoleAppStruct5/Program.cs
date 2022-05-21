using System;

namespace ConsoleAppStruct5
{
	class Program
	{
    public struct Point
    {
      public int X { get; set; }
      public int Y { get; set; }
    }

    public class Rectangle
    {
      public Point Point { get; set; }
      public int Width { get; set; }
      public int Height { get; set; }
    }

    public static void Main()
    {
      Point point;
      // point.X = 10; // Так писать нельзя. Сеттер - это метод, а метод
      // можно вызывать, только если структура полностью
      // проинициализирована
      point = new Point();
      point.X = 10;    // Теперь так писать можно

      var rectangle = new Rectangle();
      //rectangle.Point.X = 10; //Так писать нельзя. Rectangle.Point - это сеттер,
      //сеттер - это метод, и как изменить значение, 
      // возвращенное методом и нигде не сохраненное?
      point = rectangle.Point;
      point.X = 10; //так писать можно, но к изменению прямоугольника это не приведет
                    //поскольку будет изменена копия, сохраненная в стеке метода Main
      rectangle.Point = new Point { X = 10, Y = 10 }; //Вот это другое дело.

      //Если бы rectangle.Point было полем, а не свойством, то этой проблемы бы не было

    }
  }
}
