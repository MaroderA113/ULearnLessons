using System;

namespace ConsoleAppStruct4
{
	class Program
	{
    struct MyStruct
    {
      public int field;
    }

    public static void Main()
    {
      MyStruct original;
      original.field = 10;

      object boxed = (object)original;
      MyStruct unboxed = (MyStruct)boxed;

      unboxed.field = 20;

      Console.WriteLine(original.field);
      Console.WriteLine(unboxed.field);
    }
  }
}
