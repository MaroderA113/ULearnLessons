// Алгоритм Тарьяна
namespace p2t5_ConsoleApp13;

public class Program
{
	public enum State
	{
		White,
		Gray,
		Black
	}

	public static List<Node> TarjanAlgorithm(Graph graph)
	{
		var topSort = new List<Node>();
		var states = graph.Nodes.ToDictionary(node => node, node => State.White);
		while (true)
		{
			var nodeToSearch = states
				.Where(z => z.Value == State.White)
				.Select(z => z.Key)
				.FirstOrDefault();
			if (nodeToSearch == null) break;

			if (!TarjanDepthSearch(nodeToSearch, states, topSort))
				return null;
		}
		topSort.Reverse();
		return topSort;
	}

	public static bool TarjanDepthSearch(Node node, Dictionary<Node, State> states, List<Node> topSort)
	{
		if (states[node] == State.Gray) return false;
		if (states[node] == State.Black) return true;
		states[node] = State.Gray;

		var outgoingNodes = node.IncidentEdges
			.Where(edge => edge.From == node)
			.Select(edge => edge.To);
		foreach (var nextNode in outgoingNodes)
			if (!TarjanDepthSearch(nextNode, states, topSort)) return false;

		states[node] = State.Black;
		topSort.Add(node);
		return true;
	}

	static void Main()
	{
		var graph = Graph.MakeGraph(
			0, 1,
			0, 2,
			1, 4,
			2, 3,
			3, 4
		);

		var path = TarjanAlgorithm(graph);
		Console.WriteLine(
			path.Select(z => z.NodeNumber.ToString()).Aggregate((a, b) => a + " " + b));
	}
}