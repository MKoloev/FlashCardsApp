using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace FlashCardsApp
{
	class CollectionData
	{
		public string nameCollection;
		Dictionary<int, string> firstGroup;
		Dictionary<int, string> secondGroup;
		Dictionary<int, string> thirdGroup;

		public Button button;

		public CollectionData(string name)
		{
			firstGroup = null;
			secondGroup = null;
			thirdGroup = null;
			nameCollection = name;
			button = null;
		}
	}
}
