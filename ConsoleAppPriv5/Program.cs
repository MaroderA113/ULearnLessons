using System;

namespace ConsoleAppPriv5
{
  public class Student
  {
    //Даже в тех случаях, когда поля не требуют процедуры проверки целостности
    //используют свойства.
    private string lastName;
    public string LastName
    {
      //тут можно получить бесконечную рекурсию, если по ошибке написать LastName вместо lastName. Осторожнее!
      get { return lastName; }
      set { lastName = value; }
    }

    //Чтобы упростить эту практику, придумали автосвойства
    //Следующая строка делает то же самое, что и предыдущие 5, автоматически
    public string FirstName { get; set; }

    //Возможны различные модификаторы доступа у свойств
    public string Id { get; private set; }
  }

  public class Purchase
  {
    public double Price { get; set; }
    public double Count { get; set; }

    //В этом случае никакого поля не создается, и вообще это свойство не связано с хранением данных
    //Это просто удобный синтаксический сахар, можно было бы использовать метод 
    //GetSalary() { return Price*Count; }
    //Но в C# более принято писать так
    public double Summary
    {
      get { return Price * Count; }
    }
  }

  public class Program
  {
    static void Main()
    {
      var purchase = new Purchase { Price = 1000, Count = 5 };
      // purchase.Summary=100; // так нельзя, поскольку сеттер не определен
      Console.WriteLine(purchase.Summary);

    }
  }
}
