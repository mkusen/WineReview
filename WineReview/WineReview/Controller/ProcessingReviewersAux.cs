﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Runtime.InteropServices.Marshalling;
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
        /// Saves data about new user (reviewer)
        /// </summary>
        internal void SaveReviewer(string fn, string ln, string eml, string pass)
        {
            Auxiliary auxiliary = new Auxiliary();

            Console.WriteLine("\nPozdrav \n{0} {1}\n{2} {3}", fn, ln, eml, pass);
            var id = 0;

            Console.WriteLine(  id + " id in PRX");

            //creates list of data (user signin) to enter into DB
            Reviewers.Add(new()
            {
                Id = ++id,
                FirstName = fn,
                LastName = ln,
                Email = eml,
                Password = pass
            });
            auxiliary.SaveData(Reviewers);


            //Console.WriteLine("Unos nije ispravan,\nmolim ponoviti unos");
        }

        //test for entered first and last name
        public static void TestName(string name)
        {
            if (Regex.IsMatch(name, @"^[a-zA-Z]+$") == false)
            {
                throw new Exception();
            }
        }

        //test for entered password
        public static void TestPassword(string pass)
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
