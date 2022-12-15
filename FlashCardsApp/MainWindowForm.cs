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
				int shift = 0;
				if (collection != null)
				{
					collection.button = new Button()
					{
						Text = collection.nameCollection,
						Location = new Point(0, shift),
						Dock = DockStyle.Top,
						Size = new Size(482, 90),
						BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(239))))),
						Font = new System.Drawing.Font("Gabriola", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
					};
					shift += 60;
				}
			}
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

		}

		private void addCollectionButton_Click(object sender, EventArgs e)
		{

		}
	}
}
