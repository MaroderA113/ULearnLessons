namespace p2t1_ConsoleApp3;

public class QueueItem
{
	public object Value { get; set; }
	public QueueItem Next { get; set; }
}

public class Queue
{
	QueueItem head;
	QueueItem tail;

	public bool IsEmpty { get { return head == null; } }

	public void Enqueue(object value)
	{
		if (IsEmpty)
			tail = head = new QueueItem { Value = value, Next = null };
		else
		{
			var item = new QueueItem { Value = value, Next = null };
			tail.Next = item;
			tail = item;
		}
	}

	public object Dequeue()
	{
		if (head == null) throw new InvalidOperationException();
		var result = head.Value;
		head = head.Next;
		if (head == null)
			tail = null;
		return result;
	}
}

public class Program
{
	static void Main()
	{
		var myIntQueue = new Queue();
		myIntQueue.Enqueue(10);
		myIntQueue.Enqueue(20);
		myIntQueue.Enqueue(30);

		//Но что, если кто-то напишет так?
		myIntQueue.Enqueue("Surprise!");

		int sum = 0;
		while (!myIntQueue.IsEmpty)
		{
			int value = (int)myIntQueue.Dequeue(); //здесь будет InvalidCastException
			sum += value;
		}

	}
}