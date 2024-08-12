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
        }

        public static void Singin()
        {
            while (true)
            {
                Console.Write("Molim unesite svoje ime: ");
                try
                {
                    var FirstName = Console.ReadLine().Trim();
                    ProcessingReviewersAux.TestName(FirstName);
                }
                catch (Exception)
                {
                    Console.WriteLine("Ime nije dobro upisano");
                }
                Console.Write("Molim unesite svoje prezime: ");
                try
                {
                    var LastName = Console.ReadLine().Trim();
                    ProcessingReviewersAux.TestName(LastName);
                }
                catch (Exception)
                {
                    Console.WriteLine("Prezime nije dobro upisano");
                }
                Console.Write("Molim unesite e-mail: ");
                try
                {
                    var Email = Console.ReadLine().Trim();
                    ProcessingReviewersAux.IsValidEmail(Email);
                }
                catch (Exception)
                {
                    Console.WriteLine("Email nije dobro upisan");
                }

                Console.Write("Molim unesite lozinku: ");
                try
                {
                    var Password = Console.ReadLine().Trim();
                    ProcessingReviewersAux.TestPassword(Password);
                }
                catch (Exception)
                {
                    Console.WriteLine("Lozinka nije dobro upisana");
                }

                ProcessingReviewersAux.SaveReviewer();


            }

        }
    }
}
