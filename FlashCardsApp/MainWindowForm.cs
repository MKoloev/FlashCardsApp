using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashCardsApp
{
	public partial class MainWindowForm : Form
	{
		private Size oldFormSize;
		public MainWindowForm()
		{
			InitializeComponent();
			oldFormSize = Size;
		}

		private void MainWindowForm_Resize(object sender, System.EventArgs e)
		{
			Control control = (Control)sender;

			collectionPanel.Size = new Size(Size.Width * collectionPanel.Size.Width / oldFormSize.Width, Size.Height * collectionPanel.Size.Height / oldFormSize.Height);
		}

		private void collectionPanel_Paint(object sender, PaintEventArgs e)
		{

		}

		private void addCollectionButton_Click(object sender, EventArgs e)
		{

		}
	}
}
