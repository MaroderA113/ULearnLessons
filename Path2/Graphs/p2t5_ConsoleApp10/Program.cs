// Поиск пути в невзвешенном графе
namespace p2t5_ConsoleApp10;

class Program
{
	public static List<Node> FindPath(Node start, Node end)
	{
		var track = new Dictionary<Node, Node>();
		track[start] = null;
		var queue = new Queue<Node>();
		queue.Enqueue(start);
		while (queue.Count != 0)
		{
			var node = queue.Dequeue();
			foreach (var nextNode in node.IncidentNodes)
			{
				if (track.ContainsKey(nextNode)) continue;
				track[nextNode] = node;
				queue.Enqueue(nextNode);
			}
			if (track.ContainsKey(end)) break;
		}
		var pathItem = end;
		var result = new List<Node>();
		while (pathItem != null)
		{
			result.Add(pathItem);
			pathItem = track[pathItem];
		}
		result.Reverse();
		return result;
	}

	public static void Main()
	{
		var graph = Graph.MakeGraph(
			0, 1,
			0, 2,
			1, 4,
			2, 3,
			3, 4
		);

		var path = FindPath(graph[0], graph[4]);
		Console.WriteLine(
			path.Select(z => z.NodeNumber.ToString()).Aggregate((a, b) => a + " " + b));
	}
}