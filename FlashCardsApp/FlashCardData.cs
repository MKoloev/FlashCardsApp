using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FlashCardsApp
{
	class FlashCardData
	{
		public string questionText;
		public string responseText;
		public Button button;

		public FlashCardData(string questionText, string responseText)
		{
			this.questionText = questionText;
			this.responseText = responseText;
			button = null;
		}
	}
}
