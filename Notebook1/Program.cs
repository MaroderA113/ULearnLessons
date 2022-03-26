using System;

namespace NoteBook1
{
  class Program
  {
    static void Main(string[] args)
    {
      string name = Console.ReadLine();
      string age = Console.ReadLine();
      int rus = int.Parse(Console.ReadLine());
      int math = int.Parse(Console.ReadLine());
      int inf = int.Parse(Console.ReadLine());

      Console.WriteLine("Введите имя:");
      Console.WriteLine("Имя ученика:"+name);
      
      Console.WriteLine("Введите возраст:");
      Console.WriteLine("Возраст ученика:"+age);
      

      Console.WriteLine("Введите балл по русскому языку:");
      
      Console.WriteLine("Введите балл по математике:");
    
      Console.WriteLine("Введите балл по информатике:");
    

      Console.WriteLine("Средний балл ученика:"+ (rus + math + inf) / 3);

      Console.ReadKey();
    }
  }
}
