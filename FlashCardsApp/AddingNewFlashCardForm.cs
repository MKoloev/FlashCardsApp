using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashCardsApp
{
	public partial class AddingNewFlashCardForm : Form
	{
		private int maximumCountText = 50;
		private WindowOpeningCheck openWindowAddFlashCard;
		CollectionData collection;

		public AddingNewFlashCardForm(object collection, object openWindowAddFlashCard)
		{
			InitializeComponent();

			this.collection = (CollectionData)collection;
			this.openWindowAddFlashCard = (WindowOpeningCheck)openWindowAddFlashCard;

			this.questionTextBox.MaxLength = maximumCountText;
			this.responsetTextBox.MaxLength = maximumCountText;
		}

		//создать новую флеш карту
		private void createFlashCardButton_Click(object sender, EventArgs e)
		{
			var question = this.questionTextBox.Text;
			var responset = this.responsetTextBox.Text;

			collection.firstGroup.Add(new FlashCardData(question, responset));
			openWindowAddFlashCard.openWindow = false;

			this.Close();
		}

		//Закрыть окно
		private void closeFormButton_Click(object sender, EventArgs e)
		{
			openWindowAddFlashCard.openWindow = false;
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
			if (e.KeyChar == '\n' || e.KeyChar == '\r')
				e.Handled = true;
		}

		private void responsetTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\n' || e.KeyChar == '\r')
				e.Handled = true;
		}
	}
}
