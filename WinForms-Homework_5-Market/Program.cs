namespace WinForms_Homework_5_Market;

static class Program
{
	[STAThread]
	static void Main()
	{
		ApplicationConfiguration.Initialize();
		Application.Run(new Form1());
	}
}