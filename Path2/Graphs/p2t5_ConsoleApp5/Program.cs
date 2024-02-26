// Неориентированные графы и целостность данных
namespace p2t5_ConsoleApp5;

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

	public void Connect(Node node)
	{
		incidentNodes.Add(node);
		node.incidentNodes.Add(this);
	}
}

public class Graph
{
	public readonly List<Node> Nodes = new List<Node>();
}

public class Program
{
	static void Main()
	{
		var graph = new Graph();
		var v1 = new Node(0);
		var v2 = new Node(1);
		v1.Connect(v2);
		graph.Nodes.Add(v1);
		graph.Nodes.Add(v2);
	}
}