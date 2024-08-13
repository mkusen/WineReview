using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WineReview.Model;

namespace WineReview.Controller
{
    internal class ProcessingEventPlace
    {
        public List<EventPlace> Events { get; set; }

        public ProcessingEventPlace()
        {
            Events = new List<EventPlace>();
          
        }

        /// <summary>
        /// Shows menu to work with events
        /// </summary>
        internal void ShowEventsMenu()
        {
            Console.WriteLine("****************************\n" +
                "Izbornik za rad s događajima\n" +
                "1. Pregled svih događaja\n" +
                "2. Dodaj novi događaj\n" +
                "3. Izmijeni događaj\n" +
                "4. Obriši događaj\n" +
                "5. Povratak na glavni izbornik\n" +
                "****************************");
            SelectedMenuOption();

        }

        private void SelectedMenuOption()
        {
            MainMenu mainMenu = new MainMenu();

            switch (Auxiliary.TestInputNumbers("Odaberite stavku izbornika", 1,5))
            {
                case 1:
                    EventList();
                    break;
                case 2:
                    AddNewEvent();
                    break;
                case 3:
                    UpdateEvent();
                    break;
                case 4:
                    DeleteEvent();
                    break;
                case 5:
                    mainMenu.Menu();
                    break;
            }

        }

        internal void EventList()
        {

            Console.WriteLine("lista događaja");

        }

        private void AddNewEvent()
        {
            //Auxiliary.GetId();
            Console.Write("Dodaj novi događaj: ");
            string NewEvent = Console.ReadLine().Trim();
            Events.Add(new() {EventName = NewEvent });
           
        }

        private void UpdateEvent()
        {
            Console.WriteLine("izmijeni događaj");
        }
        private void DeleteEvent()
        {
            Console.WriteLine("obriši događaj");
        }





    }
}
