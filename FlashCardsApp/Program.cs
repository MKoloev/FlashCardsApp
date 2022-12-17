using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlashCardsApp
{
	class WindowOpeningCheck
	{
		public bool openWindow = false;
	}

	static class Program
	{
		/// <summary>
		///  The main entry point for the application.
		/// </summary>
		[STAThread]
		static void Main()
		{
			var collections = new List<CollectionData>();
			/*
			{
				new CollectionData("llll"),
				new CollectionData("angl"),
				new CollectionData("rus"),
				new CollectionData("lnem"),
				new CollectionData("fran"),
				new CollectionData("ispan"),
			};*/
			Application.SetHighDpiMode(HighDpiMode.SystemAware);
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainWindowForm(collections));
		}
	}
}
