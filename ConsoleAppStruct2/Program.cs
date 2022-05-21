using System;

namespace ConsoleAppStruct2
{
  struct PointStruct
  {
    public int X;
    public int Y;
  }

  class PointClass
  {
    public int X;
    public int Y;
  }

  public class Program1
  {
    static void ProcessStruct(PointStruct point)
    {
      point.X = 10;
    }
    static void ProcessClass(PointClass point)
    {
      point.X = 10;
    }

    public static void Main()
    {
      var pointStruct = new PointStruct();
      ProcessStruct(pointStruct);
      Console.WriteLine(pointStruct.X);//напечатает 0, т.е. структуры копируются

      var pointClass = new PointClass();
      ProcessClass(pointClass);
      Console.WriteLine(pointClass.X); //напечатает 10, т.к. объект передается по ссылке
    }
  }

  public class MyClass
  {
    public int classField;
  }

  public struct MyStruct
  {
    public MyClass myObject;
  }

  public class Program2
  {
    public static void ProcessStruct(MyStruct str)
    {
      str.myObject.classField = 10;
    }

    public static void Main2()
    {
      var str = new MyStruct();
      str.myObject = new MyClass();
      ProcessStruct(str);
      Console.WriteLine(str.myObject.classField);
    }
  }
}
