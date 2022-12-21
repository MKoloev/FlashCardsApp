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
		CollectionData collection;

		//Для возврашения в WindowCollectionForm
		Method method;

		int[] lengthGroup = new int[3];

		List<List<FlashCardData>> groupsFlashCards = new List<List<FlashCardData>>();

		int maximumGroupChangeStep = 3;
		int groupChangeStep = 0;
		int numberGroup = 0;

		int maximumCountFlashcard = 10;
		int numberFlashCards = 0;
		int numberGroupFlashCard = 0;
		public LearningWindowForm(object collection, Method method)
		{
			InitializeComponent();

			this.method = method;
			this.collection = (CollectionData)collection;

			lengthGroup[0] = this.collection.firstGroup.Count;
			lengthGroup[1] = this.collection.secondGroup.Count;
			lengthGroup[2] = this.collection.thirdGroup.Count;

			groupsFlashCards.Add(this.collection.firstGroup);
			groupsFlashCards.Add(this.collection.secondGroup);
			groupsFlashCards.Add(this.collection.thirdGroup);

			numberGroup = CollectionData.SetNuberGroupLearning() - 1;
			DisplayFlashCard();
		}

		private void CloseForm()
		{
			method();
			this.Close();
		}

		//Выводит на экран флеш карту
		private void DisplayFlashCard()
		{
			if (numberFlashCards < maximumCountFlashcard &&
				groupChangeStep < maximumGroupChangeStep)
			{
				if (lengthGroup[numberGroup] <= numberGroupFlashCard
					|| lengthGroup[numberGroup] == 0)
					GroupTransition();

				if (groupChangeStep >= maximumGroupChangeStep)
					this.CloseForm();
				else
					this.questionTextBox.Text = groupsFlashCards[numberGroup][0].questionText;
			}
			else
				this.CloseForm();
		}

		 
		private void GroupTransition()
		{
			for (int i = 0; (lengthGroup[numberGroup] == 0 || i == 0) && i < 3 ; i++)
			{
				if (numberGroup == 2) numberGroup = 0;
				else numberGroup++;

				numberGroupFlashCard = 0;
				groupChangeStep++;
			}
		}

		private void closeWindow_Click(object sender, EventArgs e)
		{
			this.CloseForm();
		}

		/*
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
		*/

		//знаю ответ
		private void knowTheAnswerButton_Click(object sender, EventArgs e)
		{
			var flashCard = groupsFlashCards[numberGroup][0];
			groupsFlashCards[numberGroup].RemoveAt(0);

			if(numberGroup == 0)
				groupsFlashCards[1].Add(flashCard);
			if (numberGroup > 0)
				groupsFlashCards[2].Add(flashCard);

			CollectionData.WriteDataToFile();

			this.responsetTextBox.Text = null;

			numberGroupFlashCard++;
			numberFlashCards++;

			DisplayFlashCard();
		}

		private void showAnswerButton_Click(object sender, EventArgs e)
		{
			this.responsetTextBox.Text = groupsFlashCards[numberGroup][0].responseText;
		}

		//кнопка не знаю отета
		private void dontKnowTheAnswerButton_Click(object sender, EventArgs e)
		{
			var flashCard = groupsFlashCards[numberGroup][0];
			groupsFlashCards[numberGroup].RemoveAt(0);

			groupsFlashCards[0].Add(flashCard);

			CollectionData.WriteDataToFile();

			this.responsetTextBox.Text = null;

			numberGroupFlashCard++;
			numberFlashCards++;

			DisplayFlashCard();
		}
	}
}
