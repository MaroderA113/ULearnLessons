namespace p2t3_ConsoleApp2;

partial class MyList<T>
{
	int count;
	T[] collection;
	//... код для добавления элементов
		
	//Это неправильный метод Contains
	public bool WrongContains(T value)
	{
		for (int i = 0; i < count; i++)
			//if (collection[i] == value) return true; // == не определено для всех типов данных
			if ((object)collection[i] == (object)value) return true;// - не имеет смысла, потому что будут сравниваться ссылки на объекты
		return false;
	}
		
	//Правильный метод Contains использует для сравнения виртуальный метод Equals
	public bool Contains(T value)
	{
		for (int i = 0; i < count; i++)
			if (collection[i].Equals(value)) return true;
		return false;
	}
}

class Point
{
	public int X { get; set; }
	public int Y { get; set; }

	//Equals позволяет определять логику "быть равным" для наших типов данных
	public override bool Equals(object obj)
	{
		if (!(obj is Point)) return false;
		var point = obj as Point;
		return X == point.X && Y == point.Y;
	}
}

public class Program
{
	static void Main(string[] args)
	{
		var point = new Point { X = 1, Y = 1 };

		var list = new List<Point>();
		//var list = new List<Point>();

		list.Add(point);
		Console.WriteLine(list.Contains(point));
		Console.WriteLine(list.Contains(new Point { X = 1, Y = 1 }));
	}
}