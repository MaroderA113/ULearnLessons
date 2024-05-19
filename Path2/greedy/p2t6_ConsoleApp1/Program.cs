// Алгоритм Дейкстры
namespace p2t6_ConsoleApp1;

class DijkstraData
{
	public Node Previous { get; set; }
	public double Price { get; set; }
}

public class Program
{
	public static List<Node> Dijkstra(Graph graph, Dictionary<Edge, double> weights, Node start, Node end)
	{
		var notVisited = graph.Nodes.ToList();
		var track = new Dictionary<Node, DijkstraData>();
		track[start] = new DijkstraData { Price = 0, Previous = null };

		while (true)
		{
			Node toOpen = null;
			var bestPrice = double.PositiveInfinity;
			foreach (var e in notVisited)
			{
				if (track.ContainsKey(e) && track[e].Price < bestPrice)
				{
					bestPrice = track[e].Price;
					toOpen = e;
				}
			}

			if (toOpen == null) return null;
			if (toOpen == end) break;

			foreach (var e in toOpen.IncidentEdges.Where(z => z.From == toOpen))
			{
				var currentPrice = track[toOpen].Price + weights[e];
				var nextNode = e.OtherNode(toOpen);
				if (!track.ContainsKey(nextNode) || track[nextNode].Price > currentPrice)
				{
					track[nextNode] = new DijkstraData { Previous = toOpen, Price = currentPrice };
				}
			}

			notVisited.Remove(toOpen);
		}

		var result = new List<Node>();
		while (end != null)
		{
			result.Add(end);
			end = track[end].Previous;
		}
		result.Reverse();
		return result;
	}

	//[Test]
	public static void Main()
	{
		var graph = new Graph(4);
		var weights = new Dictionary<Edge, double>();
		weights[graph[0, 1]] = 1;
		weights[graph[0, 2]] = 2;
		weights[graph[0, 3]] = 6;
		weights[graph[1, 3]] = 4;
		weights[graph[2, 3]] = 2;

		var path = Dijkstra(graph, weights, graph[0], graph[3]).Select(n => n.NodeNumber);
		//CollectionAssert.AreEqual(new[] { 0, 2, 3 }, path);
	}
}