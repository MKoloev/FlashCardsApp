using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace FlashCardsApp
{
	class CollectionData
	{
		private static int LearningStage = 0;

		private static List<CollectionData> collections;
		private static string dataFileName = "DataCollections.txt";

		private string nameCollection;
		public List<FlashCardData> firstGroup;
		public List<FlashCardData> secondGroup;
		public List<FlashCardData> thirdGroup;

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

		//ввести название коллекции
		public void SetNameCollection( string name)
		{
			nameCollection = name;
		}

		//Получить номер этапы обучения
		public static int GetLearningStage()
		{
			return LearningStage;
		}

		public static void SetLearningStage(int stage)
		{
			LearningStage = stage;
		}

		public static int SetNuberGroupLearning()
		{
			int numberGroup = 1;
			if (LearningStage % 8 == 0) numberGroup = 3;
			else if (LearningStage % 3 == 0) numberGroup = 2;

			if (LearningStage > 7) LearningStage = 1;
			else LearningStage++;

			return numberGroup;
		}

		//Удалить коллекцию по кнопке
		public static void DeleteCollection(Button button)
		{
			for (int i = 0; i < collections.Count; i++)
			{
				if (collections[i].button == button)
				{
					collections.RemoveAt(i);
					break;
				}
			}
		}

		//Найти коллекцию по кнопке
		public static CollectionData GetCollection(Button button)
		{
			foreach(var collection in collections)
			{
				if (collection.button == button)
					return collection;
			}

			return null;
		}

		//Найти флеш карту по кнопке
		public static FlashCardData GetFlashCard(CollectionData collection, Button button)
		{
			var flashCard = GetFromGroupFlashCard(collection.firstGroup, button);
			if (flashCard != null) return flashCard;
			flashCard = GetFromGroupFlashCard(collection.secondGroup, button);
			if (flashCard != null) return flashCard;
			return GetFromGroupFlashCard(collection.thirdGroup, button);
		}

		private static FlashCardData GetFromGroupFlashCard(List<FlashCardData> group, Button button)
		{
			foreach(var flashCard in group)
			{
				if (flashCard.button == button)
					return flashCard;
			}

			return null;
		}

		//удалить флеш карту
		public static void  DeleteFlashCard(CollectionData collection, FlashCardData flashCard)
		{
			if (collection != null && flashCard != null)
			{
				collection.firstGroup.Remove(flashCard);
				collection.secondGroup.Remove(flashCard);
				collection.thirdGroup.Remove(flashCard);
			}
			else
				throw new AccessViolationException("Коллекция или флеш карта равно яnull");
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
					if (text.Length > 0)
					{

						SetLearningStage(int.Parse(textLines[0]));

						for (int i = 1; i < textLines.Length; i++)
						{
							string line = textLines[i];
							//char o = line[1];
							var PartOfTheCollection = line.Split('\0');
							var newCollection = new CollectionData(PartOfTheCollection[0]);
							if (PartOfTheCollection.Length > 1)
								GroupingFlashCards(newCollection, PartOfTheCollection[1]);

							collections.Add(newCollection);
						}
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
			WriteAFlashCardToTheGroup(newCollection.secondGroup, groups[1]);
			WriteAFlashCardToTheGroup(newCollection.thirdGroup, groups[2]);
		}

		//Записать по группам флеш карты
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
			string text = GetLearningStage().ToString() + "\n";
			foreach (var collection in collections)
				text += ConcatenateCollectionsIntOAString(collection);
			//if(text.Length > 1)
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
