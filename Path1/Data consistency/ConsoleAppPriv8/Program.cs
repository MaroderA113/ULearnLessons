using System;

namespace ConsoleAppPriv8
{
  class Test
  {
    public static readonly DateTime Readonly;
    public readonly int Number;
    //Статические конструкторы всегда без параметров
    static Test()
    {
      Readonly = DateTime.Now;
    }
    //это динамический конструктор
    public Test()
    {
      Number = 3;
    }
  }

  class Program
  {
    public static void Main()
    {
      var test = new Test();
      //сначала вызовется статический конструктор (настройка типа)
      //и только после этого - динамический
    }
  }
}
