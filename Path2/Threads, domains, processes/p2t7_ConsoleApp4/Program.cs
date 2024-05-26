// Общие ресурсы и lock
// не рабочий код
using NUnit.Framework;
using System.Diagnostics;

namespace p2t7_ConsoleApp4;

internal class Program
{
	private static readonly List<int> list = new List<int>();

	static void MakeWork()
	{
		for (int i = 0; ; i++)
		{
			// если не поставить lock, возникнут странные,
			// плохо повторяемые и, возможно, редкие ошибки
			lock (list)
			{
				list.Add(i);
			}
		}
	}

	static void MakeWorkNoLock()
	{
		for (int i = 0; ; i++) list.Add(i);
	}

	// BeginInvoke не поддерживается в .NET 5
	public static void Main()
	{
		new Action(MakeWork).BeginInvoke(null, null);
		var sw = Stopwatch.StartNew();
		while (sw.Elapsed < TimeSpan.FromSeconds(10))
		{
			lock (list)
			{
				if (list.Count > 0) list.RemoveAt(0);
			}
		}
	}

	// BeginInvoke не поддерживается в .NET 5
	public static void Fail_without_syncronization()
	{
		new Action(MakeWorkNoLock).BeginInvoke(null, null);
		var sw = Stopwatch.StartNew();
		Assert.That(
				() =>
				{
					while (sw.Elapsed < TimeSpan.FromSeconds(10))
					{
						if (list.Count > 0) list.RemoveAt(0);
					}
				}, Throws.Exception);
	}
}