using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashCardsApp
{
	//#F2F2EF цвет коллекций
	public delegate void Method();

	public partial class MainWindowForm : Form
	{
		//Открыто ли окно добавление новой коллекции
		private WindowOpeningCheck openWindowAddCollection;
		private int maximumCountCollection = 10;

		List<CollectionData> collections;

		public MainWindowForm()
		{
			InitializeComponent();
			//collections = (List < CollectionData >) newCollections;
			collections = CollectionData.GetDataFromFile();
			openWindowAddCollection = new WindowOpeningCheck();

			InitializationButton();//создание кнропок
			DisplayCollections();//Вывод на панель
		}

		//Первичная инициализация кнопок по каждую коллекцию
		private void InitializationButton()
		{
			foreach (var collection in collections)
			{
				if (collection != null)
				{
					collection.button = CreateButtonCollection(collection.GetNameCollection());
				}
			}
		}

		//Создание кнопки для коллекции
		private Button CreateButtonCollection(string text)
		{
			return new Button()
			{
				Text = text,
				//Location = new Point(0, shift),
				Dock = DockStyle.Top,
				Size = new Size(482, 90),
				BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(239))))),
				Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
			};
		}

		//Добовление кнопок коллекций на панель
		private void DisplayCollections()
		{
			collectionPanel.Controls.Clear();
			foreach (var collection in collections)
			{
				collection.button.Click += ButtonOnClick;
				collectionPanel.Controls.Add(collection.button);
			}
		}

		//Кнопки коллекции
		private void ButtonOnClick(object sender, EventArgs eventArgs)
		{
			
			var button = (Button)sender;
			/*
			if (button != null)
			{
				MessageBox.Show("Прощай " + button.Name);
				button.Dispose();
			}*/
			CollectionData collection = CollectionData.GetCollection(button);

			if(collection != null)
			{
				this.Visible = false;
				Method method = ContinueWork;
				WindowCollectionForm windowCollection = new WindowCollectionForm(collection, method);
				windowCollection.Show();
				//this.Close();
			}
		}

		//Добавить новую коллекцию
		private void addCollectionButton_Click(object sender, EventArgs e)
		{
			if (!openWindowAddCollection.openWindow)
			{
				openWindowAddCollection.openWindow = true;
				AddingNewCollectionForm addingNewCollectionForm = new AddingNewCollectionForm(collections, openWindowAddCollection);
				addingNewCollectionForm.Show();
			}
		}

		//Фон Окна
		private void backgroundPanel_Paint(object sender, PaintEventArgs e)
		{
			if (collectionPanel.Controls.Count != collections.Count)
			{
				InitializationButton();//создание кнропок
				DisplayCollections();//Вывод на панель
				CollectionData.WriteDataToFile();

				if (collectionPanel.Controls.Count >= maximumCountCollection)
					addCollectionButton.Enabled = false;
				else
					addCollectionButton.Enabled = true;
			}
		}

		//Продолжить работу после закрытия коллекции
		public void ContinueWork()
		{
			InitializationButton();//создание кнропок
			DisplayCollections();//Вывод на панель
			CollectionData.WriteDataToFile();
			this.Visible = true;
		}

	}
}
