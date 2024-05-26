//Асинхронные операции в GUI
using System;
using System.Drawing;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace p2t7_ConsoleApp6;

public class MyForm : Form
{
	private readonly Label label;
	private readonly Button button;
	public MyForm()
	{
		label = new Label { Size = new Size(ClientSize.Width, 30) };
		button = new Button
		{
			Location = new Point(0, label.Bottom),
			Text = "Start",
			Size = label.Size
		};
		button.Click += MakeWorkInThread;
		Controls.Add(label);
		Controls.Add(button);
	}

	void MakeWorkInThreadX()
	{
		Thread.Sleep(5000);
		//label.Text = "Complete"; // Операции с контролами можно совершать только из GUI-потока
		BeginInvoke(new Action(() => label.Text = "Complete")); // ← это можно делать так
	}

	// BeginInvoke не поддерживается в .NET 5
	void MakeWork(object sender, EventArgs e)
	{
		new Action(MakeWorkInThreadX).BeginInvoke(null, null);
		// Не нужно путать BeginInvoke у делегата (асинхронный запуск операции в другом потоке)
		// и у формы (асинхронный запуск операции в GUI-потоке этой формы)
	}

	public static void Main()
	{
		Application.Run(new MyForm());
	}

	// всё абсолютно тоже самое можно сделать с помощью async/await
	async void MakeWorkInThread(object obj, EventArgs eventArgs)
	{
		await Task.Delay(5000);
		label.Text = "Complete"; // ← это будет выполнено на UI-потоке
	}

}