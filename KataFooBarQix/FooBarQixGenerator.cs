using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataFooBarQix
{
    public class FooBarQixGenerator : IFooBarQixGenerator
	{
		private static String QIX = "Qix";
		private static String BAR = "Bar";
		private static String FOO = "Foo";

		public String DetermineForDivisionValueOf(int number)
        {
			string retour = "";

			bool isDivBy3 = number % 3 == 0;
			bool isDivBy5 = number % 5 == 0;

			if (isDivBy3)
			{
				retour = FOO;
			}

			if (isDivBy5)
			{
				retour += BAR;
			}
			return retour;
		}
		
		public String DetermineForContainsValueOf(int number)
        {
			string input = number.ToString();

			string retour = "";

			foreach (char c in input)
			{
                bool contains3 = c == '3';
                bool contains5 = c == '5';
				bool contains7 = c == '7';

				if (contains3)
				{
					retour += FOO;
				}
				else if (contains5)
				{
					retour += BAR;
				}
				else if (contains7)
				{
					retour += QIX;
				}
			}

			return retour;
		}

		public String DetermineValueOf(int number)
		{
			String retour = DetermineForDivisionValueOf(number);

			retour += DetermineForContainsValueOf(number);

			return retour == "" ? number.ToString() : retour;
		}
	}
}
