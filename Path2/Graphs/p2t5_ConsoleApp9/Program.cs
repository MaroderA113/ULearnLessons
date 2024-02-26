// Поиск компонент связности
namespace p2t5_ConsoleApp9;

public static class NodeExtensions
{
	public static IEnumerable<Node> DepthSearch(this Node startNode)
	{
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
	public static IEnumerable<List<Node>> FindConnectedComponents(Graph graph)
	{
		var markedNodes = new HashSet<Node>();
		while (true)
		{
			var nextNode = graph.Nodes.Where(node => !markedNodes.Contains(node)).FirstOrDefault();
			if (nextNode == null) break;
			var breadthSearch = nextNode.BreadthSearch().ToList();
			foreach (var node in breadthSearch)
				markedNodes.Add(node);
			yield return breadthSearch;
		}
	}

	public static void Main()
	{
		var graph = Graph.MakeGraph(
			1, 2,
			3, 4,
			3, 5,
			4, 5);

		var connected = FindConnectedComponents(graph);
		Console.WriteLine(
			connected
				.Select(component => component.Select(node => node.NodeNumber.ToString()).Aggregate((a, b) => a + " " + b))
				.Aggregate((a, b) => a + "\n" + b));
	}
}