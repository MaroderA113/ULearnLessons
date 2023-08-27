namespace p2t1_ConsoleApp5;

public class Program
{
	public static void MainX()
	{
		Console.WriteLine(IsCorrectString("(([])[])"));
		Console.WriteLine(IsCorrectString("((][])"));
		Console.WriteLine(IsCorrectString("((("));
		Console.WriteLine(IsCorrectString("(x)"));
	}

	public static bool IsCorrectString(string str)
	{
		var stack = new Stack<char>();
		foreach (var e in str)
		{
			switch (e)
			{
				case '[':
				case '(':
					stack.Push(e);
					break;

				case ']':
					if (stack.Count == 0) return false;
					if (stack.Pop() != '[') return false;
					break;

				case ')':
					if (stack.Count == 0) return false;
					if (stack.Pop() != '(') return false;
					break;
				default:
					return false;
			}
		}
		return stack.Count == 0;
	}

	//Немного улучшим решение, обойдемся без DRY
	public static bool IsCorrectString1(string str)
	{
		var pairs = new Dictionary<char, char>
		{
			{ '(', ')' },
			{ '[', ']' }
		};
		var stack = new Stack<char>();
		foreach (var e in str)
		{
			if (pairs.ContainsKey(e)) stack.Push(e);
			else if (pairs.ContainsValue(e))
			{
				if (stack.Count == 0 || pairs[stack.Pop()] != e) return false;
			}
			else return false;
		}
		return stack.Count == 0;
	}
}