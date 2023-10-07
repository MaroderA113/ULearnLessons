namespace p2t3_ConsoleApp5;

class Point
{
	public int X { get; set; }
	public int Y { get; set; }
	public override bool Equals(object obj)
	{
		var point = obj as Point;
		return X == point.X && Y == point.Y;
	}
	public override int GetHashCode()
	{
		unchecked
		{
			return X * 1023 + Y; // тут может быть переполнение, но unchecked заставляет его игнорировать.
		}
	}
}

public class Program
{
	static void Main(string[] args)
	{
		var point1 = new Point { X = 1, Y = 1 };
		var dictionary = new Dictionary<Point, string>();
		dictionary[point1] = "Test";
		Console.WriteLine(dictionary[point1]);
		var point2 = new Point { X = 1, Y = 1 };
		Console.WriteLine(dictionary[point2]);
	}
}