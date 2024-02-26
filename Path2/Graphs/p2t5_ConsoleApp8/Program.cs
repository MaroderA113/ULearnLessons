// Обходы графа
namespace p2t5_ConsoleApp8;

public static class NodeExtensions
{
	public static IEnumerable<Node> DepthSearch(this Node startNode)
	{
		// Внимание! Перед использованием этого кода, прочитайте следующий слайд «Использование памяти»
		var visited = new HashSet<Node>();
		var stack = new Stack<Node>();
		stack.Push(startNode);
		while (stack.Count != 0)
		{
			var node = stack.Pop();
			if (visited.Contains(node)) continue;
			visited.Add(node);
			yield return node;
			foreach (var incidentNode in node.IncidentNodes)
				stack.Push(incidentNode);
		}
	}

	public static IEnumerable<Node> BreadthSearch(this Node startNode)
	{
		// Внимание! Перед использованием этого кода, прочитайте следующий слайд «Использование памяти»
		var visited = new HashSet<Node>();
		var queue = new Queue<Node>();
		queue.Enqueue(startNode);
		while (queue.Count != 0)
		{
			var node = queue.Dequeue();
			if (visited.Contains(node)) continue;
			visited.Add(node);
			yield return node;
			foreach (var incidentNode in node.IncidentNodes)
				queue.Enqueue(incidentNode);
		}
	}
}

class Program
{
	public static void Main()
	{
		var graph = Graph.MakeGraph(
			0, 1,
			0, 2,
			1, 3,
			1, 4,
			2, 3,
			2, 4);

		Console.WriteLine(graph[0]
			.DepthSearch()
			.Select(z => z.NodeNumber.ToString())
			.Aggregate((a, b) => a + " " + b));

		Console.WriteLine(graph[0]
			.BreadthSearch()
			.Select(z => z.NodeNumber.ToString())
			.Aggregate((a, b) => a + " " + b));
	}
}