using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashCardsApp
{
	public partial class WindowFlashCardForm : Form
	{
		CollectionData collection;
		FlashCardData flashCard;

		public WindowFlashCardForm(object collection, object flashCard)
		{
			InitializeComponent();

			this.collection = (CollectionData) collection;
			this.flashCard = (FlashCardData)flashCard;

			this.questionTextBox.Text = this.flashCard.questionText;
			this.responsetTextBox.Text = this.flashCard.responseText;
		}

		private void deleteFlashCard_Click(object sender, EventArgs e)
		{
			CollectionData.DeleteFlashCard(collection, flashCard);
			this.Close();
		}

		private void closeWindow_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		Point lastPoint;

		private void backgroundPanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Left += e.X - lastPoint.X;
				this.Top += e.Y - lastPoint.Y;
			}
		}

		private void backgroundPanel_MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint = new Point(e.X, e.Y);
		}

		private void questionTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}

		private void responsetTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}
	}
}
