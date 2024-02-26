// Простейшая реализация графа
namespace p2t5_ConsoleApp4;

public class Node
{
	public readonly List<Node> IncidentNodes = new List<Node>();
}

public class Graph
{
	public readonly List<Node> Nodes = new List<Node>();
}

// Принцип «Y.A.G.N.I.»
public class Program
{
	static void Main()
	{
		var graph = new Graph();
		var v1 = new Node();
		var v2 = new Node();
		v1.IncidentNodes.Add(v2);
		graph.Nodes.Add(v1);
		graph.Nodes.Add(v2);
	}
}