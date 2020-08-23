using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
	public class Menu
	{
		// Display the menu for user to pick which unit they need to convert
		public static void Displaymenu()
		{
			Console.BackgroundColor = ConsoleColor.White;
			Console.ForegroundColor = ConsoleColor.Black;
			Console.WriteLine("======================================");
			Console.WriteLine("Welcome to the Unit Converter");
			Console.WriteLine("======================================");

			// Populate the unit list in memory;
			UnitListController.AddUnit();

			OptionMenu();

		}

		public static void OptionMenu()
		{
			Console.WriteLine("Choose which unit you need to convert: ");
			Console.WriteLine("(Type the number then press enter to choose.)");

			// Display unit list
			int count = 0;
			foreach (var i in UnitListController.unitList)
			{
				count++;
				Console.WriteLine($"{count}. {i}");
			}
			Console.WriteLine("6. Exit the Program");

			// Logic to intake user input and give user the correct unit conversions 
			Console.WriteLine();
			string tmp = Console.ReadLine();
			string[] validOptions = { "1", "2", "3", "4", "5" };
			while (tmp != "6")
			{
				if (Array.Exists(validOptions, element => element == tmp)) //check to make sure we have a valid option (1-5)
				{
					Console.Clear();
					UnitListController.ConvertGeneric(tmp);
				}
				else
				{
					tmp = Console.ReadLine();
				}
			}
			Environment.Exit(0);
		}

	}
}
