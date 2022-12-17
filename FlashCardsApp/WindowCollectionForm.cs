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

		public WindowCollectionForm(object collection)
		{
			InitializeComponent();

			this.collection = (CollectionData)collection;
			this.nameCollection.Text = this.collection.GetNameCollection();
		}

		private void ComeBackButton_Click(object sender, EventArgs e)
		{

		}

		private void deleteCollection_Click(object sender, EventArgs e)
		{

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

		private void NameCollection_TextChanged(object sender, EventArgs e)
		{

		}

		private void NameCollection_KeyPress(object sender, KeyPressEventArgs e)
		{
			e.Handled = true;
		}
	}
}
