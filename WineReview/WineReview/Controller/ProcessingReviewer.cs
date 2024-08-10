using System;
using System.Collections.Generic;
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

        internal void SelectEntry()
        {

            var ProcessingReviewersAux = new ProcessingReviewersAux();
            Console.Write("Molim unesite svoje ime: ");
            string FirstName = Console.ReadLine().Trim();
            Console.Write("Molim unesite svoje prezime: ");
            string LastName = Console.ReadLine().Trim();
            Console.Write("Molim unesite e-mail: ");
            string Email = Console.ReadLine().Trim();
            Console.Write("Molim unesite lozinku: ");
            string Password = Console.ReadLine().Trim();
            ProcessingReviewersAux.TestInputSignInData("", FirstName, LastName, Email, Password);
        }
    }
}
