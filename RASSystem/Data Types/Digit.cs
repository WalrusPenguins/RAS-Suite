using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAS_System.Data_Types
{
    public struct Digit
    {
        private byte data;

        public Digit(byte literal)
        {
            if (IsDigit(literal))
                data = literal;
            else
                throw new ArgumentOutOfRangeException($"{literal} is not a digit");
        }

        public Digit(int literal) : this((byte) literal)
        {
        }

        public static bool IsDigit(int literal)
        {
            return literal >= 0 && literal <= 9;
        }
    }
}
