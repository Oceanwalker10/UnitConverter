using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * 
    Area: ft2 -> m2 (square feet to square meters)
    Temperature: °C ->°F (Celsius to Fahrenheit)
    Length: in -> cm (inch to centimeter)
    Weight: lb -> kg (pound to kilogram)
    Volume: qt -> lt (quart to liter)

 */
namespace UnitConverter
{
	class UnitListController
	{
		public static List<UnitList> unitList = new List<UnitList>();
		public static void AddUnit()
		{
			//We pass in a "variable" that is actually an anonymous funbction. This is valid because our function matches the delegate type declaration
			//so now each convert() will return the correctly converted value.
			UnitList area = new UnitList("Area", "square feet", "square meters", (double val) => val / 10.764);
			UnitList temperature = new UnitList("temperature", "Fahrenheit", "Celsius", (double val) => (val - 32) / 1.8);
			UnitList length = new UnitList("Length", "in", "cm", (double val) => val * 2.54);
			UnitList weight = new UnitList("Weight", "lb", "kg", (double val) => val * 0.45359237);
			UnitList volume = new UnitList("Volume", "qt", "lt", (double val) => val * 0.946353);
			unitList.Add(area);
			unitList.Add(temperature);
			unitList.Add(length);
			unitList.Add(weight);
			unitList.Add(volume);
		}

		//Since we have the convert() method set on each type to do the correct calculation, we can just use 1 method instead of 1 for each type
		//Now in some cases you might want to have a different method for each one, but in this case it was duplciated code except for the conversion so it
		//makes sense to abstract it all into 1 method
		public static void ConvertGeneric(string option)
		{
			var index = int.Parse(option) - 1;
			double tmp;
			var item = unitList[index];
			Console.WriteLine($"Enter the {item.UnitName}:");
			tmp = double.Parse(Console.ReadLine());
			//So we call the convert() method which was set above in each constructor to perform the correct conversion calculation
			Console.WriteLine($"{item.UnitName}: {String.Format("{0:0.##}", tmp)} {item.UnitFrom} = {String.Format("{0:0.##}", item.convert(tmp))} {item.UnitTo}");

			// Go back to the main menu after user press enter
			Console.ReadLine();
			Console.Clear();
			Menu.OptionMenu();
		}
	}



}
