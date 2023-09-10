using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp2
{
	public class Program
	{
		static Random random = new Random();

		static int LinearSearch(int[] array, int element)
		{
			for (int i = 0; i < array.Length; i++)
				if (array[i] == element) return i;
			return -1;
		}

		static int BinarySearch(int[] array, int element)
		{
			var left = 0;
			var right = array.Length - 1;
			while (left < right)
			{
				var middle = (right + left) / 2;
				if (element <= array[middle])
					right = middle;
				else left = middle + 1;
			}
			if (array[right] == element)
				return right;
			return -1;
		}

		static int[] GenerateSortedArray(int length)
		{
			var array = new int[length];
			for (int i = 1; i < array.Length; i++)
				array[i] = array[i - 1] + random.Next(10000) + 1;
			return array;
		}

		static void MeasureTime(int[] array, Func<int[], int, int> searchProcedure, Series series)
		{
			searchProcedure(array, array[random.Next(array.Length)]);
			var repetitions = 10000;
			var watch = new Stopwatch();
			watch.Start();
			for (int i = 0; i < repetitions; i++)
				searchProcedure(array, array[random.Next(array.Length)]);
			watch.Stop();
			series.Points.Add(new DataPoint(array.Length, (float)watch.ElapsedTicks / repetitions));
		}

		private static Chart MakeChart(Series linearGraph, Series binaryGraph)
		{
			var chart = new Chart();
			chart.ChartAreas.Add(new ChartArea());

			linearGraph.ChartType = SeriesChartType.FastLine;
			linearGraph.Color = Color.Red;

			binaryGraph.ChartType = SeriesChartType.FastLine;
			binaryGraph.Color = Color.Green;
			binaryGraph.BorderWidth = 3;

			chart.Series.Add(linearGraph);
			chart.Series.Add(binaryGraph);
			chart.Dock = DockStyle.Fill;
			return chart;
		}

		//[Test]
		//[Explicit]
		public static void Main()
		{
			var linearGraph = new Series();
			var binaryGraph = new Series();

			for (int i = 100; i <= 10000; i *= 2)
			{
				GC.Collect();
				var array = GenerateSortedArray(i);
				MeasureTime(array, LinearSearch, linearGraph);
				MeasureTime(array, BinarySearch, binaryGraph);
			}

			var chart = MakeChart(linearGraph, binaryGraph);
			var form = new Form();
			form.ClientSize = new Size(800, 600);
			form.Controls.Add(chart);
			Application.Run(form);
		}
	}
}
