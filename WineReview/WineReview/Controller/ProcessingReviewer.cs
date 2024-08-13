using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WineReview.Model;

namespace WineReview.Controller
{
    internal class ProcessingReviewer
    {

        public ProcessingReviewer()
        {

        }

        internal static void Select(int selectedNum)
        {
            if (selectedNum == 1)
            {
                LogIn();
            }
            else
            {
                Singin();
            }

        }

        private static void LogIn()
        {
            Console.Write("Molim unesite e-mail: ");
            var Email = Console.ReadLine().Trim();
            Console.Write("Molim unesite lozinku: ");
            var Password = Console.ReadLine().Trim();

            GetUser(Email, Password);
        }

        private static void GetUser(string eml, string pass)
        {
           
            
            
            
            throw new NotImplementedException();
        }

        internal static void Singin()
        {
            ProcessingReviewersAux processingReviewersAux = new ProcessingReviewersAux();   
            string FirstName;
            string LastName;
            string Email;
            string Password;
            while (true)
            {
                Console.Write("Molim unesite svoje ime: ");
                try
                {
                    FirstName = Console.ReadLine().Trim();
                    ProcessingReviewersAux.TestName(FirstName);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Ime nije dobro upisano");
                }
            }
            while (true)
            {
                Console.Write("Molim unesite svoje prezime: ");
                try
                {
                    LastName = Console.ReadLine().Trim();
                    ProcessingReviewersAux.TestName(LastName);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Prezime nije dobro upisano");
                }

            }
            while (true)
            {
                Console.Write("Molim unesite e-mail: ");
                try
                {
                    Email = Console.ReadLine().Trim();
                    ProcessingReviewersAux.IsValidEmail(Email);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Email nije dobro upisan");
                }
            }

            while (true)
            {

                Console.Write("Molim unesite lozinku: ");
                try
                {
                    Password = Console.ReadLine().Trim();
                    ProcessingReviewersAux.TestPassword(Password);
                    break;
                }
                catch (Exception)
                {
                    Console.WriteLine("Lozinka nije dobro upisana");
                }
            }

            //Auxiliary.GetId(Id);


            processingReviewersAux.SaveReviewer(FirstName, LastName, Email, Password);
        }
    }
}
