using System;

namespace ConsoleApp24
{
	class Program
	{
    static int[] temporaryArray;

    static void Merge(int[] array, int start, int middle, int end)
    {
      var leftPtr = start;
      var rightPtr = middle + 1;
      var length = end - start + 1;
      for (int i = 0; i < length; i++)
      {
        if (rightPtr > end || (leftPtr <= middle && array[leftPtr] < array[rightPtr]))
        {
          temporaryArray[i] = array[leftPtr];
          leftPtr++;
        }
        else
        {
          temporaryArray[i] = array[rightPtr];
          rightPtr++;
        }
      }
      for (int i = 0; i < length; i++)
        array[i + start] = temporaryArray[i];
    }

    static void MergeSort(int[] array, int start, int end)
    {
      if (start == end) return;
      var middle = (start + end) / 2;
      MergeSort(array, start, middle);
      MergeSort(array, middle + 1, end);
      Merge(array, start, middle, end);

    }

    static void MergeSort(int[] array)
    {
      temporaryArray = new int[array.Length];
      MergeSort(array, 0, array.Length - 1);
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
      MergeSort(array);
      foreach (var e in array)
        Console.WriteLine(e);
      Console.ReadKey();
    }
  }
}
