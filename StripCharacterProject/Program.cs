using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripCharacterProject
{
    class Program
    {
        public static string StripZeros(string n)
        {
            if (n.StartsWith("0"))
            {
                string substring = n.Substring(1);
                var newString = StripZeros(substring);
                return newString;
            }

            return n;
        }

        static void Main(string[] args)
        {
            var test1 = StripZeros("0000000000004354");
            var test2 = StripZeros("00fd04fdsgfdsgs");
            var test3 = StripZeros("0000000000004fdgdfgdgd354");
            var test4 = StripZeros("00000000fdg4354");
        }
    }
}
