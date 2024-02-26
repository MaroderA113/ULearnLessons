// Топологическая сортировка. Алгоритм Кана
namespace p2t5_ConsoleApp12;

public class Program
{
	public static List<Node> KahnAlgorithm(Graph graph)
	{
		var topSort = new List<Node>();
		var nodes = graph.Nodes.ToList();
		while (nodes.Count != 0)
		{
			var nodeToDelete = nodes
				.Where(node => !node.IncidentEdges.Any(edge => edge.To == node))
				.FirstOrDefault();

			if (nodeToDelete == null) return null;
			nodes.Remove(nodeToDelete);
			topSort.Add(nodeToDelete);
			foreach (var edge in nodeToDelete.IncidentEdges.ToList())
				graph.Delete(edge);
		}
		return topSort;
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

		var path = KahnAlgorithm(graph);
		Console.WriteLine(
			path.Select(z => z.NodeNumber.ToString()).Aggregate((a, b) => a + " " + b));
	}
}