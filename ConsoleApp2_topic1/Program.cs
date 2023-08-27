namespace p2t1_ConsoleApp2
{
	/// <summary>
	/// Элемент очереди
	/// </summary>
	public class QueueItem
		{
		/// <summary>
		/// Значение
		/// </summary>	
		public int Value { get; set; }
		/// <summary>
		/// Указатель на следующий
		/// </summary>	
		public QueueItem Next { get; set; }
		}

	/// <summary>
	/// Очередь
	/// </summary>
	public class Queue
		{
		/// <summary>
		/// Указатель на голову
		/// </summary>
		QueueItem head;

		/// <summary>
		/// Указатель на хвост
		/// </summary>
		QueueItem tail;

		/// <summary>
		/// Добавить элемент в очередь
		/// </summary>
		/// <param name="value">Добавляемый элемент</param>
		public void Enqueue(int value)
			{
				if (head == null)
					tail = head = new QueueItem { Value = value, Next = null };
				else
				{
					var item = new QueueItem { Value = value, Next = null };
					tail.Next = item;
					tail = item;
				}
			}

		/// <summary>
		/// Удалить элемент из очереди
		/// </summary>
		/// <returns>Значение первого элемента</returns>
		public int Dequeue()
			{
				if (head == null) throw new InvalidOperationException();
				var result = head.Value;

				head = head.Next;
				if (head == null)
					tail = null;
				return result;
			}
		}
	internal class Program
	{ 
		static void Main(string[] args)
		{
			var queue = new Queue();
			for (int i = 0; i < 3; i++)
			{
				queue.Enqueue(i);
			}
			for (int i = 0; i < 3; i++)
			{
				Console.WriteLine(queue.Dequeue());
			}
		}
	}
}