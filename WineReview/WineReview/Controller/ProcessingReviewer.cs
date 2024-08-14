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
            string Email;
            string Password;
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
                    Console.WriteLine("Email nije upisan");
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
                    Console.WriteLine("Lozinka nije upisana");
                }


            }

            GetUser(Email, Password);

        }

        private static void GetUser(string eml, string pass)
        {
            int id;
            string em;
            string password;
            string fn;
            string ln;

            foreach (var item in Auxiliary.LoadData())
            {
                id = item.Id;
                em = item.Email;
                password = item.Password;
                fn = item.FirstName;
                ln = item.LastName;

                do
                {

                    if (em.Equals(eml) && password.Equals(pass))
                    {
                        Console.WriteLine("{0} {1} {2}", id, fn, ln);
                    }

                    Console.WriteLine(id + " id");

                } while (false);

                if (id==0)
                {

                    Console.WriteLine("****************************\n" +
                "Greška: Nema podataka u bazi\n" +
                "****************************\n"); LogIn();
                }

            }

        }


        internal static void Singin()
        {
            int Id=0;
            string FirstName;
            string LastName;
            string Email;
            string Password;

            try
            {
                foreach (var item in Auxiliary.LoadData())
                {
                    Id = item.Id;
                };
            }
            catch (Exception)
            {
             Id=0;
            }
                    
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
            ProcessingReviewersAux processingReviewersAux = new ProcessingReviewersAux();   
            processingReviewersAux.SaveReviewer(Id, FirstName, LastName, Email, Password);
        }
    }
}
