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

        public static void Start()
        {
            var ProcessingReviewer = new ProcessingReviewer();
            var Auxiliary = new Auxiliary();

            Console.WriteLine("***********************\n" +
                              "Dobrodošli u aplikaciju\n" +
                              "za ljubitelje vina\n" +
                              "***********************\n");
            try
            {
                Auxiliary.LoadData();
            }
            catch (Exception)
            {
                Console.WriteLine("****************************\n" +
                    "Greška: Nema podataka u bazi\n" +
                    "****************************\n");
            }

            ProcessingReviewer.SelectEntry();            
          
        }


        /// <summary>
        /// Main menu
        /// asks users to pick one entry
        /// </summary>        
        public void Menu()
        {
            var processingEventPlace = new ProcessingEventPlace(); 

            Console.WriteLine("*****************\n" +
                "Glavni izbornik: \n1.Popis događaja\n2.Vina\n3.Recenzije\n" +
                "*****************");

            switch (Auxiliary.TestInputNumbers("Molim odabrati", 1, 3))
            {
                case 1:
                    //Console.WriteLine("upisan 1");
                    processingEventPlace.ShowEventsMenu();
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
