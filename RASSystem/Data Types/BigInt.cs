using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RASSystem.Extensions;

namespace RAS_System.Data_Types
{
    public struct BigInt
    {
        private Digit[] data;

        public BigInt(Digit[] literal)
        {
            data = literal;
        }

        public BigInt(string literal)
        {
            this = (BigInt) literal;
        }

        public static explicit operator BigInt(string literal)
        {
            return new BigInt("");
        }

        public static bool IsBigInt(string literal)
        {
            return !literal.ContainsOther("0123456789");
        }
    }
}
