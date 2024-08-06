using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace WineReview
{
    internal class Auxiliary
    {


        public Auxiliary()
        {

        }


        /// <summary>
        /// Tests correct input of given first and last name (only letters, not numbers or special characters)
        /// </summary>
        internal static string TestInputName(string message, string firstName, string lastName)
        {


            if (Regex.IsMatch(firstName, @"^[a-zA-Z]+$") == true &&
               Regex.IsMatch(lastName, @"^[a-zA-Z]+$") == true)
            {

                Console.WriteLine("Pozdrav {0} {1}", firstName, lastName);
                MainMenu.Menu();
            }

            else
            {
                Console.WriteLine("Unos nije ispravan,\nmolim unijeti ime i prezime bez brojeva i posebnih znakova");
                MainMenu.Start();
            }


            return message;

        }
        /// <summary>
        /// Tests correct input from menu list
        /// </summary>
        internal static int TestInputNumbers(string message, int min, int max)
        {
            int b;
            while (true)
            {
                try
                {
                    Console.Write(message + ": ");
                    b = int.Parse(Console.ReadLine());
                    if (b < min || b > max)
                    {
                        throw new Exception();
                    }
                    return b;
                }
                catch
                {
                    Console.WriteLine("Unos nije dobar, unos mora biti u rasponu {0} do {1}", min, max);
                }
            }
        }
    }
}
