namespace p2t3_ConsoleApp3;

class Point
{
	public double X { get; set; }
	public double Y { get; set; }

	public override bool Equals(object obj)
	{
		if (!(obj is Point)) return false;
		var point = obj as Point;
		return X == point.X && Y == point.Y;
	}

	public static bool operator ==(Point p1, Point p2)
	{
		return p1.X == p2.X && p1.Y == p2.Y;
	}

	public static bool operator !=(Point p1, Point p2)
	{
		return !(p1 == p2);
	}

	public static Point operator +(Point p1, Point p2)
	{
		return new Point { X = p1.X + p2.X, Y = p1.Y + p2.Y };
	}

	public static Point operator *(Point p1, double value)
	{
		return new Point { X = p1.X * value, Y = p1.Y * value };
	}
}

public class Program
{
	static void Main(string[] args)
	{
		var point1 = new Point { X = 1, Y = 2 };
		var point2 = new Point { X = 1, Y = 2 };
		Console.WriteLine(point1.Equals(point2)); // выведет true
		Console.WriteLine(point1 == point2);  //выведет true
		var point = point1 + point2;
		Console.WriteLine("{0} {1}", point.X, point.Y); //выведет 2 4
		point = point1 * 3;
		Console.WriteLine("{0} {1}", point.X, point.Y); //выведет 3 6
		point *= 2; // операторы +=, *= и подобные переопределяются автоматически
		Console.WriteLine("{0} {1}", point.X, point.Y); //выведет 6 12
	}
}