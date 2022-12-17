using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FlashCardsApp
{
	class CollectionData
	{
		private static List<CollectionData> collections;
		private static string dataFileName = "DataCollections.txt";

		private string nameCollection;
		List<FlashCardData> firstGroup;
		List<FlashCardData> secondGroup;
		List<FlashCardData> thirdGroup;

		public Button button;

		public CollectionData(string name)
		{
			firstGroup = new List<FlashCardData>();
			secondGroup = new List<FlashCardData>();
			thirdGroup = new List<FlashCardData>();
			nameCollection = name;
			button = null;
		}

		//вывести название коллекции
		public string GetNameCollection()
		{
			return nameCollection;
		}

		public static CollectionData GetCollection(Button button)
		{
			foreach(var collection in collections)
			{
				if (collection.button == button)
					return collection;
			}

			return null;
		}

		//Получить из файла все коллекции 
		public static List<CollectionData> GetDataFromFile()
		{
			collections = new List<CollectionData>();

			if (File.Exists(dataFileName))
			{
				string text = File.ReadAllText(dataFileName);
				string[] textLines = text.Split('\n');
				try
				{
					foreach (var line in textLines)
					{
						var PartOfTheCollection = line.Split('\0');
						var newCollection = new CollectionData(PartOfTheCollection[0]);

						GroupingFlashCards(newCollection, PartOfTheCollection[1]);

						collections.Add(newCollection);
					}
				}
				catch
				{
					File.Create(dataFileName);
					throw new AccessViolationException("Нарушана целостность данных");
				}
			}
			else
			{
				File.Create(dataFileName);
			}
			return collections;
		}

		//разделить на группы флеш карты
		private static void GroupingFlashCards(CollectionData newCollection, string groupFlashCards)
		{
			var groups = groupFlashCards.Split(((char)1));

			WriteAFlashCardToTheGroup(newCollection.firstGroup, groups[0]);
			WriteAFlashCardToTheGroup(newCollection.secondGroup, groups[0]);
			WriteAFlashCardToTheGroup(newCollection.thirdGroup, groups[0]);
		}

		//Записать в группам флеш карты
		private static void WriteAFlashCardToTheGroup(List<FlashCardData> group, string groupFlashCards)
		{
			var flashCards = groupFlashCards.Split(((char)2));
			foreach(var flashCard in flashCards)
			{
				var questionAndResponse = flashCard.Split(((char)3));
				if (questionAndResponse.Length > 1)
					group.Add(new FlashCardData(questionAndResponse[0], questionAndResponse[1]));
			}
		}

		//записать в файл все коллекции
		public static void WriteDataToFile()
		{
			string text = "";
			foreach (var collection in collections)
				text += ConcatenateCollectionsIntOAString(collection);

			text = text.Remove(text.Length - 1);

			StreamWriter sr = new StreamWriter(dataFileName, false);
			sr.Write(text);
			sr.Close();
		}

		//Объединяет данные из коллекции в строку
		private static string ConcatenateCollectionsIntOAString(CollectionData collection)
		{
			string line = collection.GetNameCollection() + '\0';

			line += ConcatenateFlashIntOAString(collection.firstGroup);
			line += ConcatenateFlashIntOAString(collection.secondGroup);
			line += ConcatenateFlashIntOAString(collection.thirdGroup);

			if (line.Length > 0)
				line = line.Remove(line.Length - 1);

			return line + '\n';
		}

		//Обединяте карты группы
		private static string ConcatenateFlashIntOAString(List<FlashCardData> flashCards)
		{
			string line = "";
			foreach (var flashCard in flashCards)
				line += flashCard.questionText + ((char)3) + flashCard.responseText + ((char)2);

			if(line.Length > 0)
				line = line.Remove(line.Length - 1);

			return line + ((char)1);
		}
	}
}
