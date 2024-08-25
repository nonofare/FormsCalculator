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

		public void setDoubleValue(double value)
		{
			this.value = value.ToString();
		}

		public void setStringValue(string value)
		{
			this.value = value;
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
			if (value.Length > 1)
			{
				value = value.Remove(value.Length - 1);
			} else
			{
				value = "0";
			}
		}

		public void invert()
		{
			value = (getDoubleValue() * -1).ToString();
		}
	}
}
