namespace ClassLibrary2_Linq
{
	public class Class1
	{
		public static void Main()
		{
			foreach (var num in ParseNumbers(new[] { "-0", "+0000" }))
				Console.WriteLine(num);
			foreach (var num in ParseNumbers(new List<string> { "1", "", "-03", "0" }))
				Console.WriteLine(num);
		}

		public static int[] ParseNumbers(IEnumerable<string> lines)
		{
			return lines
				.Where(p => p != "")
				.Select(p => int.Parse(p))
				.ToArray();
		}
	}
}