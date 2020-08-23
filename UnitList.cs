using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitConverter
{
	// Model for unit
	class UnitList
	{
		string unitName;
		string unitFrom;
		string unitTo;

		//define the delegate type to be used to set the convert function
		public delegate double ConvertVal(double val);


		public UnitList(string unitName, string unitFrom, string unitTo, ConvertVal del)
		{
			this.UnitName = unitName;
			this.UnitFrom = unitFrom;
			this.UnitTo = unitTo;
			this.convert = del;
		}

		public string UnitName { get => unitName; set => unitName = value; }
		public string UnitFrom { get => unitFrom; set => unitFrom = value; }
		public string UnitTo { get => unitTo; set => unitTo = value; }

		//So this is a variable with a type of the delegate we defined above. That means we can set this convert vairable to any function that matches the delegate above
		public ConvertVal convert { get; set; }

		public override string ToString()
		{
			return $"{this.UnitName}: {this.UnitFrom} -> {this.UnitTo}";
		}
	}
}
