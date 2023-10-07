namespace p2t3_ConsoleApp1;

public partial class MyList<T> : IEnumerable<T>
{
	public T[] collection;
	int count = 0;

	public MyList()
	{
		collection = new T[100];
	}

	void Enlarge()
	{
		throw new NotImplementedException();
	}

	public void Add(T value)
	{
		if (count == collection.Length)
			Enlarge();
		collection[count++] = value;
	}

	public IEnumerator<T> GetEnumerator()
	{
		for (int i = 0; i < count; i++)
			yield return collection[i];
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public T this[int index]
	{
		get
		{
			if (index < 0 || index >= count) throw new IndexOutOfRangeException();
			return collection[index];
		}
		set
		{
			if (index < 0 || index >= count) throw new IndexOutOfRangeException();
			collection[index] = value;
		}
	}
}

public class Program
{
	static void Main(string[] args)
	{
		var list = new MyList<int>();
		list.Add(1);
		list.Add(2);
		list.Add(3);

		foreach (var e in list)
			Console.WriteLine(e);
	}
}