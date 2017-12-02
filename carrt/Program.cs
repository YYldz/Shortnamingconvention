using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace carrt
{
    class Program
    {
        public static string inputString;
        static void Main(string[] args)
        {
            // Take the last name of the author
            inputString = Console.ReadLine();

            // Output the authors short variation
            if (char.IsUpper(inputString[0])
                && !string.IsNullOrEmpty(inputString)
                && inputString.Length <= 100)
            {
                Console.WriteLine(NamingConventionCheck(inputString));
                Console.ReadKey();
            }
        }

        public static string NamingConventionCheck(string str)
        {
            string lastNameShort = "";
            string[] foundNames = str.Split('-');
            List<string> lettersForLastNames = new List<string>();

            int indexOfName = 0;

            foreach (string name in foundNames)
            {
                if (char.IsUpper(name[0]))
                {
                    lastNameShort = name[0].ToString();
                    lettersForLastNames.Insert(indexOfName, lastNameShort);
                }
            }

            lettersForLastNames.Reverse();
            return lastNameShort = string.Join("", lettersForLastNames.ToArray()); ;
        }
    }
}
