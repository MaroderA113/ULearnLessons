// Больше защиты целостности в графах
namespace p2t5_ConsoleApp6;

public class Node
{
	private readonly List<Node> incidentNodes = new List<Node>();
	public readonly int NodeNumber;

	public Node(int number)
	{
		NodeNumber = number;
	}

	public IEnumerable<Node> IncidentNodes
	{
		get
		{
			foreach (var node in incidentNodes)
				yield return node;
		}
	}
	public static void Connect(Node node1, Node node2, Graph graph)
	{
		if (!graph.Nodes.Contains(node1) || !graph.Nodes.Contains(node2)) throw new ArgumentException();
		node1.incidentNodes.Add(node2);
		node2.incidentNodes.Add(node1);
	}
}

public class Graph
{
	private Node[] nodes;
	public Graph(int nodesCount)
	{
		// nodes = new Node[nodesCount];
		// for (int i = 0; i < nodesCount; i++ )
		//		nodes[i] = new Node(i)
		nodes = Enumerable.Range(0, nodesCount)
			.Select(z => new Node(z))
			.ToArray();
	}

	public int Length { get { return nodes.Length; } }

	public Node this[int index] { get { return nodes[index]; } }

	public IEnumerable<Node> Nodes
	{
		get
		{
			foreach (var node in nodes) yield return node;
		}
	}

	public void Connect(int index1, int index2)
	{
		Node.Connect(nodes[index1], nodes[index2], this);
	}
}

public class Program
{
	static void Main()
	{
		var graph = new Graph(2);
		graph.Connect(0, 1);

	}
}