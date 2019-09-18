using System;
using System.Collections.Generic;
using System.Linq;

namespace age
{
	class Program
	{
		private static List<KeyValuePair<string, int>> persons = new List<KeyValuePair<string, int>>();
		private static bool exit = false;
		
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
					exitProgram();
				break;
				case "add":
					addPersons();
				break;
				case "update":
					updatePersons();
				break;
				case "remove":
					removePerson();
				break;
				case "list":
					readPersons();
				break;
				default:
				Console.WriteLine("Geen geldige input!");
				break;
			}

			if (!exit)
			{
				getInput();
			}
		}

		private static void exitProgram() {
			exit = true;
		}

		private static void removePerson() {
			Console.WriteLine("Name of person: ");
			string name = Console.ReadLine();

			foreach (KeyValuePair<string, int> person in persons.ToList())
			{
			    if (person.Key == name)
			    {
			    	persons.Remove(person);
			    	Console.WriteLine($"De persoon is succesvol verwijderd.");
			    }
			    else
			    {
			    	Console.WriteLine($"Persoon niet gevonden.");
			    }
			}
		}

		private static void updatePersons()
		{
			Console.WriteLine("Name of person: ");
			string name = Console.ReadLine();

			foreach (KeyValuePair<string, int> person in persons.ToList())
			{
			    if (person.Key == name)
			    {
			    	Console.WriteLine($"Geef een nieuwe leeftijd op voor {person.Key} (De ingegeven leeftijd moet hoger liggen dan {person.Value} jaar):");
			    	int age = Int32.Parse(Console.ReadLine());

			    	if (age > person.Value) 
			    	{
			    		KeyValuePair<string, int> newPersons = new KeyValuePair<string, int>(person.Key, age);
			    		persons.Remove(person);
			    		persons.Add(newPersons);

			    		Console.WriteLine($"De leeftijd is succesvol gewijzigd.");
			    	}
			    	else
			    	{
			    		Console.WriteLine($"De opgegeven leeftijd is niet hoger dan {person.Value} jaar.");
			    	}
			    }
			    else
			    {
			    	Console.WriteLine($"Persoon niet gevonden.");
			    }
			}
		}

		private static void readPersons() 
		{
			foreach (KeyValuePair<string, int> person in persons)
			{
			    Console.WriteLine($"{person.Key} is {person.Value} jaar oud.");
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
