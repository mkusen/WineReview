﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WineReview.Controller;
using WineReview.Interface;

namespace WineReview
{
    internal class MainMenu : IMainMenu
    {
        

        public MainMenu()
        {
             
        }

        public static void Start()
        {
                   
            Console.WriteLine("***********************\n" +
                              "Dobrodošli u aplikaciju\n" +
                              "za ljubitelje vina\n" +
                              "***********************\n");
            ChooseLoginOrSingin();
        }


        /// <summary>
        /// Menu to select login or singin
        /// </summary>
        public static void ChooseLoginOrSingin()
        {
            Console.WriteLine("****************\nMolim odabrati: \n" +
                "1. Postojeći korisnik\n" +
                "2. Novi korisnik\n****************");

            switch (Auxiliary.TestInputNumbers("Molim odabrati", 1, 2))
            {
                case 1:
                    ProcessingReviewer.Select(1);
                    break;
                case 2:
                    ProcessingReviewer.Select(2);
                    break;
            }

        }


        /// <summary>
        /// Main menu asks users to pick one entry
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
