using System;

namespace ConsoleApp23
{
	class Program
	{
    static void HoareSort(int[] array, int start, int end)
    {
      if (end == start) return;
      var pivot = array[end];
      var storeIndex = start;
      for (int i = start; i <= end - 1; i++)
        if (array[i] <= pivot)
        {
          var t = array[i];
          array[i] = array[storeIndex];
          array[storeIndex] = t;
          storeIndex++;
        }

      var n = array[storeIndex];
      array[storeIndex] = array[end];
      array[end] = n;
      if (storeIndex > start) HoareSort(array, start, storeIndex - 1);
      if (storeIndex < end) HoareSort(array, storeIndex + 1, end);
    }

    static void HoareSort(int[] array)
    {
      HoareSort(array, 0, array.Length - 1);
    }

    static Random random = new Random();

    static int[] GenerateArray(int length)
    {
      var array = new int[length];
      for (int i = 0; i < array.Length; i++)
        array[i] = random.Next();
      return array;
    }

    public static void Main()
    {
      var array = GenerateArray(10);
      HoareSort(array);
      foreach (var e in array)
        Console.WriteLine(e);
    }
  }
}
