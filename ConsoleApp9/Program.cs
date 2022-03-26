using System;

namespace ConsoleApp9
{
	class Program
	{
		static void Main(string[] args)
		{
      var arrayToPower = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
      Console.WriteLine(GetPoweredArray(arrayToPower, 0));

      // Метод PrintArray уже написан за вас
     // PrintArray(GetPoweredArray(arrayToPower, 1));

      // если вы будете менять исходный массив, то следующие два теста сработают неверно:
   //   PrintArray(GetPoweredArray(arrayToPower, 2));
   //   PrintArray(GetPoweredArray(arrayToPower, 3));

      // не забывайте про частные случаи:
   //   PrintArray(GetPoweredArray(new int[0], 1));
   //   PrintArray(GetPoweredArray(new[] { 42 }, 0));

      Console.ReadKey();
    }

    public static int[] GetPoweredArray(int[] arr, int power)
    {
      var arr2 = new int[arr.Length];
      if (arr.Length == 0) return arr2;
      
      if (power == 0)
			{
        for (int i = 0; i < arr.Length; i++)
        {
          arr2[i] = 1;
        }
        return arr2;
      }

      for (int i = 0;i < arr.Length;i++)
			{
        arr2[i] = (int)Math.Pow(arr[i], power);
      }
      return arr2;
    }
  }
}
