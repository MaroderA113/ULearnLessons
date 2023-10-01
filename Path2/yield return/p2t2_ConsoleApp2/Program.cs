namespace p2t2_ConsoleApp2;

public class Queue<T> : IEnumerable<T>
{
	//А это - то же самое, записанное с помощью yield return
	public IEnumerator<T> GetEnumerator()
	{
		var current = Head;
		while (current != null)
		{
			yield return current.Value;
			current = current.Next;
		}
	}

	System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
	{
		return GetEnumerator();
	}

	public QueueItem<T> Head { get; private set; }
	QueueItem<T> tail;

	public bool IsEmpty { get { return Head == null; } }

	public void Enqueue(T value)
	{
		if (IsEmpty)
			tail = Head = new QueueItem<T> { Value = value, Next = null };
		else
		{
			var item = new QueueItem<T> { Value = value, Next = null };
			tail.Next = item;
			tail = item;
		}
	}

	public T Dequeue()
	{
		if (Head == null) throw new InvalidOperationException();
		var result = Head.Value;
		Head = Head.Next;
		if (Head == null)
			tail = null;
		return result;
	}
}

public class QueueItem<T>
{
	public T Value { get; set; }
	public QueueItem<T> Next { get; set; }
}

internal class Program
{
	static void Main(string[] args)
	{
		var queue = new Queue<int>();
		queue.Enqueue(1);
		queue.Enqueue(2);
		queue.Enqueue(3);

		foreach (var value in queue)
			Console.WriteLine(value);
	}
}