using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace FlashCardsApp
{
	public partial class AddingNewCollectionForm : Form
	{ 
		private WindowOpeningCheck openWindowAddCollection;
		List<CollectionData> collections;

		public AddingNewCollectionForm(object newCollections, object OpenWindowAddCollection)
		{
			InitializeComponent();
			this.FormBorderStyle = FormBorderStyle.FixedSingle;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			collections = (List<CollectionData>)newCollections;
			openWindowAddCollection = (WindowOpeningCheck)OpenWindowAddCollection;

			NameCollectionTextBox.MaxLength = 30;
		}

		private void AddingNewCollectionForm_Load(object sender, EventArgs e)
		{

		}

		private void CloseForm_Click(object sender, EventArgs e)
		{
			openWindowAddCollection.openWindow = false;
			this.Close();
		}

		Point lastPoint;
		private void backgroundPanel_MouseMove(object sender, MouseEventArgs e)
		{
			if(e.Button == MouseButtons.Left)
			{
				this.Left += e.X - lastPoint.X;
				this.Top += e.Y - lastPoint.Y;
			}
		}

		private void backgroundPanel_MouseDown(object sender, MouseEventArgs e)
		{
			lastPoint = new Point(e.X, e.Y);
		}

		private void CreateСollection_Click(object sender, EventArgs e)
		{
			string NameColleсtion = NameCollectionTextBox.Text;

			collections.Add(new CollectionData(NameColleсtion));
			openWindowAddCollection.openWindow = false;

			this.Close();
		}

		private void NameCollectionTextBox_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == '\n' || e.KeyChar == '\r')
				e.Handled = true;
		}

	}
}
