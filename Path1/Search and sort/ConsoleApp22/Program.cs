using System;

namespace ConsoleApp22
{
	class Program
	{
    private static readonly Random random = new Random();
    private static void BubbleSort(int[] array)
    {
      for (int i = 0; i < array.Length; i++)
        for (int j = 0; j < array.Length - 1; j++)
          if (array[j] > array[j + 1])
          {
            int t = array[j + 1];
            array[j + 1] = array[j];
            array[j] = t;
          }
    }

    public static void Main()
    {
      int[] array = GenerateArray(10);
      BubbleSort(array);
      foreach (int e in array)
        Console.WriteLine(e);
      Console.ReadKey();
    }

    private static int[] GenerateArray(int length)
    {
      var array = new int[length];
      for (int i = 0; i < array.Length; i++)
        array[i] = random.Next();
      return array;
    }
  }
}
