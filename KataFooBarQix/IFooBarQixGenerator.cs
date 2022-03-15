using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KataFooBarQix
{
    public interface IFooBarQixGenerator
    {
        public String DetermineForDivisionValueOf(int number);

        public String DetermineForContainsValueOf(int number);

        public String DetermineValueOf(int number);

    }
}
