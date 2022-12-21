using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashCardsApp
{
	public partial class WindowCollectionForm : Form
	{
		CollectionData collection;

		//Для возврашения в MainWindowForm
		Method method;

		//Открыто ли окно добавление новой флеш карты
		private WindowOpeningCheck openWindowAddFlashCard;
		//Открыто ли окно флеш карты
		private WindowOpeningCheck openWindowFlashCard;

		//максимальное количество флеш карт
		private int maximumCountFlashCards = 15;

		public WindowCollectionForm(object collection, Method method)
		{
			InitializeComponent();

			this.collection = (CollectionData)collection;
			this.nameCollection.Text = this.collection.GetNameCollection();

			this.method = method;

			openWindowAddFlashCard = new WindowOpeningCheck();
			openWindowFlashCard = new WindowOpeningCheck();

			InitializationButton();//создание кнропок
			DisplayFlashCards();//Вывод на панель
			ToCheckTheNumberOfFlashCards();//Проверить и ограничить колличеству флеш карт
		}

		//Первичная инициализация кнопок по каждую коллекцию
		private void InitializationButton()
		{
			CreateGroupButton(collection.firstGroup);
			CreateGroupButton(collection.secondGroup);
			CreateGroupButton(collection.thirdGroup);
		}


		//Создание флеш карт для групп
		private void CreateGroupButton(List<FlashCardData> flashCards)
		{
			foreach (var flashCard in flashCards)
			{
				if (flashCard != null)
				{
					flashCard.button = CreateButtonFlashCard(flashCard.questionText);
				}
			}
		}

		//Создание кнопки для флеш карт
		private Button CreateButtonFlashCard(string text)
		{
			return new Button()
			{
				Text = text,
				//Location = new Point(0, shift),
				Dock = DockStyle.Top,
				Size = new Size(482, 90),
				BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(239))))),
				Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
			};
		}


		//Добовление кнопок флеш карт на панель
		private void DisplayFlashCards()
		{
			flashCardsPanel.Controls.Clear();
			DisplayGroupFlashCards(collection.firstGroup);
			DisplayGroupFlashCards(collection.secondGroup);
			DisplayGroupFlashCards(collection.thirdGroup);
		}


		//Добавление флеш карт для отделных групп
		private void DisplayGroupFlashCards(List<FlashCardData> flashCards)
		{
			foreach (var flashCard in flashCards)
			{
				flashCard.button.Click += ButtonOnClick;
				flashCardsPanel.Controls.Add(flashCard.button);
			}
		}

		//Кнопки флеш карт
		private void ButtonOnClick(object sender, EventArgs eventArgs)
		{
			var button = (Button)sender;

			FlashCardData flashCard = CollectionData.GetFlashCard(collection, button);

			if (flashCard != null)
			{
				WindowFlashCardForm windowFlashCardForm = new WindowFlashCardForm(collection, flashCard);
				windowFlashCardForm.Show();
			}
		}

		//Возврашение на главное окно
		private void ComeBackButton_Click(object sender, EventArgs e)
		{
			collection.SetNameCollection(this.nameCollection.Text);
			method();
			this.Close();
		}

		//удаление коллекции
		private void deleteCollection_Click(object sender, EventArgs e)
		{
			CollectionData.DeleteCollection(collection.button);
			method();
			this.Close();
		}


		Point lastPoint;

		private void collectionPanel_MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint = new Point(e.X, e.Y);
		}

		private void collectionPanel_MouseMove(object sender, MouseEventArgs e)
		{
			if (e.Button == MouseButtons.Left)
			{
				this.Left += e.X - lastPoint.X;
				this.Top += e.Y - lastPoint.Y;
			}
		}

		private void NameCollection_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (e.KeyChar == '\n' || e.KeyChar == '\r')
				e.Handled = true;
		}

		//Добавление флеш карт
		private void addFlashCard_Click(object sender, EventArgs e)
		{
			if (!openWindowAddFlashCard.openWindow)
			{
				openWindowAddFlashCard.openWindow = true;
				AddingNewFlashCardForm newFlashCardForm = new AddingNewFlashCardForm(collection, openWindowAddFlashCard);
				newFlashCardForm.Show();
			}
		}
		

		//Обновление изменение
		private void collectionPanel_Paint(object sender, PaintEventArgs e)
		{
			var countFlashcards = collection.firstGroup.Count +
				collection.secondGroup.Count +
				collection.thirdGroup.Count;

			if (flashCardsPanel.Controls.Count != countFlashcards)
			{
				InitializationButton();//создание кнропок
				DisplayFlashCards();//Вывод на панель
				CollectionData.WriteDataToFile();

				ToCheckTheNumberOfFlashCards();
			}
		}

		//Проверить и ограничить колличеству флеш карт
		private void ToCheckTheNumberOfFlashCards()
		{
			if (flashCardsPanel.Controls.Count >= maximumCountFlashCards)
				addFlashCard.Enabled = false;
			else
				addFlashCard.Enabled = true;
		}

		//Начать обучение
		private void startLearning_Click(object sender, EventArgs e)
		{
			var countFlashcards = collection.firstGroup.Count +
				collection.secondGroup.Count +
				collection.thirdGroup.Count;

			if (countFlashcards > 0)
			{
				this.Visible = false;
				Method method = ContinueWork;
				LearningWindowForm learningWindowForm = new LearningWindowForm(collection, method);
				learningWindowForm.Show();
			}
		}


		//Продолжить работу после конца бучения
		public void ContinueWork()
		{
			InitializationButton();//создание кнопок
			DisplayFlashCards();//Вывод на панель
			CollectionData.WriteDataToFile();
			this.Visible = true;
		}
	}
}
