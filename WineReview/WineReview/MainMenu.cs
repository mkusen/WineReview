using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WineReview
{
    internal class MainMenu
    {
        public MainMenu()
        {

        }

        public static void Start()
        {
            Console.WriteLine("***********************\n" +
                              "Dobrodošli u aplikaciju\n " +
                              "za ljubitelje vina\n" +
                              "***********************\n");
            
            Console.Write("Molim unesite svoje ime: ");
            string FirstName = Console.ReadLine().Trim().ToLower();
            Console.Write("Molim unesite svoje prezime: ");
            string LastName = Console.ReadLine().Trim().ToLower();

            Console.WriteLine("Pozdrav {0} {1}", FirstName, LastName);

            Menu();
        }


        /// <summary>
        /// Main menu
        /// </summary>
        /// From user asks to pick one entry
        /// 
        private static void Menu()
        {
            Console.WriteLine("Glavni izbornik: \n1.Popis događaja\n2.Vina\n3.Recenzije");

            switch (Auxiliary.TestInputNumbers("Molim odabrati", 1, 3))
            {
                case 1:
                    Console.WriteLine("upisan 1");
                    break;
                case 2:
                    Console.WriteLine("upisan 2");
                    break;
                case 3:
                    Console.WriteLine("upisan 3");
                    break;
            }

        }
    }
}
