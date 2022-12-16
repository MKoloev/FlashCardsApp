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

	public partial class MainWindowForm : Form
	{
		List<CollectionData> collections;

		public MainWindowForm(object newCollections)
		{
			InitializeComponent();
			collections = (List < CollectionData >) newCollections;

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
					collection.button = CreateButtonCollection(collection.nameCollection);
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

		private void DisplayCollections()
		{
			collectionPanel.Controls.Clear();
			foreach (var collection in collections)
			{
				collection.button.Click += ButtonOnClick;
				collectionPanel.Controls.Add(collection.button);
			}
		}

		private void ButtonOnClick(object sender, EventArgs eventArgs)
		{
			var button = (Button)sender;
			if (button != null)
			{
				MessageBox.Show("Прощай " + button.Name);
				button.Dispose();
			}
		}

		private void collectionPanel_Paint(object sender, PaintEventArgs e)
		{
			if(collectionPanel.Controls.Count != collections.Count)
			{
				InitializationButton();//создание кнропок
				DisplayCollections();//Вывод на панель
			}
		}

		private void addCollectionButton_Click(object sender, EventArgs e)
		{
			AddingNewCollectionForm addingNewCollectionForm = new AddingNewCollectionForm(collections);
			addingNewCollectionForm.Show();
		}
	}
}
