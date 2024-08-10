using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WineReview.Model;

namespace WineReview.Controller
{
    internal class ProcessingReviewersAux
    {

        public List<Reviewer> Reviewers { get; set; }
       
        public ProcessingReviewersAux() 
        {
            Reviewers = new List<Reviewer>();
            
        }



        /// <summary>
        /// Tests correct input of given first and last name (only letters, not numbers or special characters)
        /// </summary>
        internal string TestInputSignInData(string message, string firstName, string lastName,
            string email, string pass)
        {
            var ProcessingReviewer = new ProcessingReviewer();
            try
            {
                try
                {
                    TestName(firstName, lastName);
                }
                catch (Exception)
                {
                    Console.WriteLine("Ime i/ili prezime nisu dobro uneseni,\n" +
                        "molim unijeti samo slova bez brojeva i/ili posebnih znakova");
                    ProcessingReviewer.SelectEntry();

                }
                try
                {
                    IsValidEmail(email);
                }
                catch (Exception)
                {
                    Console.WriteLine("Email nije dobro unesen\n"                                            );
                    ProcessingReviewer.SelectEntry(); 
                }
                try
                {
                    TestPassword(pass);
                }
                catch (Exception)
                {
                    Console.WriteLine("Lozinka nije dobro unesena\n");
                    ProcessingReviewer.SelectEntry();
                }
             
              
              
                Console.WriteLine("\nPozdrav {0} {1}\n{2} {3}", firstName, lastName, email, pass);
              
                Reviewers.Add(new()
                {
                    FirstName = firstName,
                    LastName = lastName,
                    Email = email,
                    Password = pass
                });
                Auxiliary.SaveData(Reviewers);
            }
            catch (Exception)
            {
                
                Console.WriteLine("Unos nije ispravan,\nmolim ponoviti unos");
                ProcessingReviewer.SelectEntry();
            }
            return message;
        }

        //test for entered first and last name
        private static void TestName(string fn, string ln)
        {
            if (Regex.IsMatch(fn, @"^[a-zA-Z]+$") == false &&
                   Regex.IsMatch(ln, @"^[a-zA-Z]+$") == false
                   )
            {
                throw new Exception();
            }
        }

        //test for entered password
        private static void TestPassword(string pass)
        {
            if (Regex.IsMatch(pass, @"^.{4,}") == false)
            {

                throw new Exception();

            }
        }

        //test for entered email
        internal static bool IsValidEmail(string email)
        {
            try
            {
                MailAddress mailAddress = new MailAddress(email);
                return true;
            }
            catch (FormatException)
            {
                throw new Exception();
            }

        }

    }
}
