using System;

namespace ConsoleAppStruct3
{
	class Program
	{
    struct Point
    {
      public int X;
      public int Y;
    }

    static void ProcessStruct(ref Point point)
    {
      point.X = 10;
    }

    static void ProcessInt(ref int n)
    {
      n = 10;
    }

    static void ProcessArray(ref int[] array)
    {
      array = new int[2];
    }

    public static void Main()
    {
      Point point = new Point();
      ProcessStruct(ref point);
      Console.WriteLine(point.X);

      int n = 0;
      ProcessInt(ref n);
      Console.WriteLine(n);

      var array = new int[3];
      ProcessArray(ref array);
      Console.WriteLine(array.Length);
    }
  }
}
