using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WineReview.Controller;

namespace WineReview
{
    internal class MainMenu
    {
        public MainMenu()
        {

        }

        public void Start()
        {

          
            Console.WriteLine("***********************\n" +
                              "Dobrodošli u aplikaciju\n" +
                              "za ljubitelje vina\n" +
                              "***********************\n");
            
            Console.Write("Molim unesite svoje ime: ");
            string FirstName = Console.ReadLine().Trim();
            Console.Write("Molim unesite svoje prezime: ");
            string LastName = Console.ReadLine().Trim();
            Auxiliary.TestInputName("", FirstName, LastName);
          
        }


        /// <summary>
        /// Main menu
        /// asks users to pick one entry
        /// </summary>        
        public static void Menu()
        {
            Console.WriteLine("*****************\n" +
                "Glavni izbornik: \n1.Popis događaja\n2.Vina\n3.Recenzije\n" +
                "*****************");

            switch (Auxiliary.TestInputNumbers("Molim odabrati", 1, 3))
            {
                case 1:
                    //Console.WriteLine("upisan 1");
                    ProcessingEventPlace.ShowEventsMenu();
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
