using System;
using System.Collections.Generic;

namespace age
{
	class Program
	{
		private static List<KeyValuePair<string, int>> persons = new List<KeyValuePair<string, int>>();

		static void Main(string[] args)
		{
			getInput();
		}

		private static void getInput() 
		{
			string input = Console.ReadLine();

			switch(input) 
			{
				case "exit":
				break;
				case "add":
					addPersons();
				break;
				case "update":
				break;
				case "remove":
				break;
				case "list":
					readPersons();
				break;
				default:
				Console.WriteLine("Geen geldige input!");
				break;
			}

			getInput();
		}

		private static void readPersons() 
		{
			foreach (KeyValuePair<string, int> person in persons)
			{
			    Console.WriteLine($"{person.Key} is {person.Value} jaar oud");
			}
		}

		private static void addPersons() 
		{
			Console.WriteLine("Name: ");
			string name = Console.ReadLine();
			Console.WriteLine("Age: ");
			int age = Int32.Parse(Console.ReadLine());

			persons.Add(new KeyValuePair<string,int>(name, age));
		}
	}
}
