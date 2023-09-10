using System;

namespace ConsoleApp2
{
	class Program
	{
    public enum Color
    {
      Red,
      Green,
      Blue,
      Yellow
    }

    public static void Main()
    {
      GetColorNameGoodWay(Color.Yellow);
      Console.ReadKey();
    }

    static string GetColorNameGoodWay(Color color)
    {
      if (color == Color.Red) return "Красный";
      if (color == Color.Blue) return "Синий";
      if (color == Color.Green) return "Зеленый";
      throw new Exception("Unknown color " + color);
      /* 
      В большинстве случаев писать нужно именно так.
      Если появится новый цвет, то "магическая" строка throw new Exception
      сгенерирует исключительную ситуацию, которая прервет работу программы.

      Обычно падение программы в таком случае лучше, чем некорректная работа.
        (Лучше вообще не стрелять, чем стрелять не туда)
      */
    }

  }
}
