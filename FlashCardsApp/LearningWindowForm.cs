using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashCardsApp
{
	public partial class LearningWindowForm : Form
	{
		public LearningWindowForm()
		{
			InitializeComponent();
		}

		private void closeWindow_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		Point lastPoint;

		private void backgroundPanel_MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint = new Point(e.X, e.Y);
		}

		private void backgroundPanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Left += e.X - lastPoint.X;
				this.Top += e.Y - lastPoint.Y;
			}
		}
	}
}
