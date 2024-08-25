using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsCalculator
{
	internal class OperationalNumber
	{
		private string value;

		public OperationalNumber()
		{
			value = "0";
		}

		public double getDoubleValue()
		{
			return double.Parse(value);
		}

		public string getStringValue()
		{
			return value;
		}

		public void addAtEnd(char singleNumber)
		{
			if (value.Length == 1 && value == "0")
			{
				value = "";
			}
			value += singleNumber;
		}

		public void clear()
		{
			value = "0";
		}

		public void clearAtEnd()
		{
			value.Remove(value.Length - 1);
		}

		public void invert() // does not work
		{
			if (value[0] != '-')
			{
				value = "-" + value;
			}
			else
			{
				value.Replace("-", "");
			}
		}
	}
}
