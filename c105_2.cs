using System;
					
public class Program
{
	
	//создаем класс для работы со строками
	class MyString
	{
		public string message;
		
		//конструктор класса
		public MyString (string message)
		{
			message = this.message;
		
		}
		
		//создаем свойство, которое возвращает все слова, в которых не более n букв;
		
		//метод, который, удаляет из сообщения все слова, которые заканчиваются на заданный символ;
		
		//свойство, которое возвращает самое длинное слово сообщения;
		public string LongestWord
		{
			get { return " "; }
		}
		
		//свойство, которое возвращает все самые длинные слова сообщения;
		
		
	}
	
	
	static string GetLongestWord(string message)
	{
		string longestWord;
		longestWord = "";
		
		
		return longestWord;
	}
	
	
	public static void Main()
	{
		
		Console.WriteLine("Введите строку:");
		string message = Console.ReadLine();
		
		MyString str = new MyString(message);
	}
}
