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
			value = "";
		}

		public double getDoubleValue()
		{
			return double.Parse(value);
		}

		public string getStringValue()
		{
			return value;
		}

		public void add(char singleNumber)
		{
			value += singleNumber;
		}

		public void invert()
		{
			if (value[0] != '-')
			{
				value = "-" + value;
			} else
			{
				value.Substring(0);
			}
		}
	}
}
