using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StripCharacterProject
{
    class Program
    {
        public static string StripZeros(string n, char target)
        {
            var index = n.IndexOf(target);

            if (index < 0)
            {
                return n;
            }
            else
            {
                return StripZeros(n.Substring(0, index) + n.Substring(index + 1), target);
            }
        }

        static void Main(string[] args)
        {
            var test1 = StripZeros("0000000000004354", '0');
            var test2 = StripZeros("00fd04fdsgfdsgs", '0');
            var test3 = StripZeros("0000000000004fdgdfgdgd354", '0');
            var test4 = StripZeros("00000000fdg4354" ,'0');
        }
    }
}
