using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using WineReview.Controller;
using WineReview.Model;

namespace WineReview
{
    internal class Auxiliary
    {
        ProcessingEventPlace ProcessingEventPlace { get; set; }

        public Auxiliary()
        {
            ProcessingEventPlace = new ProcessingEventPlace();  
        }

        internal static void GetId()
        {
            
            
            
            
            throw new NotImplementedException();
        }


        /// <summary>
        /// Tests correct input of given first and last name (only letters, not numbers or special characters)
        /// </summary>
        internal static string TestInputName(string message, string firstName, string lastName)
        {


            if (Regex.IsMatch(firstName, @"^[a-zA-Z]+$") == true &&
               Regex.IsMatch(lastName, @"^[a-zA-Z]+$") == true)
            {

                Console.WriteLine("\nPozdrav {0} {1}\n", firstName, lastName);
                MainMenu.Menu();
            }

            else
            {
                Console.WriteLine("Unos nije ispravan,\nmolim unijeti ime i prezime bez brojeva i posebnih znakova");
                MainMenu.Start();
            }


            return message;

        }
        /// <summary>
        /// Tests correct input from menu list
        /// </summary>
        internal static int TestInputNumbers(string message, int min, int max)
        {
            int b;
            while (true)
            {
                try
                {
                    Console.Write(message + ": ");
                    b = int.Parse(Console.ReadLine());
                    if (b < min || b > max)
                    {
                        throw new Exception();
                    }
                    return b;
                }
                catch
                {
                    Console.WriteLine("Unos nije dobar, unos mora biti u rasponu {0} do {1}", min, max);
                }
            }
        }

        /// <summary>
        /// Loads saved data at app start
        /// </summary>
        public void LoadData()
        {
            string docPath =
         Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            try
            {
                if (File.Exists(Path.Combine(docPath, "data.json")))
                {
                    StreamReader file = File.OpenText(Path.Combine(docPath, "data.json"));
                    ProcessingEventPlace.Events = JsonConvert.DeserializeObject<List<EventPlace?>>(file.ReadToEnd());

                }
            }
            catch (Exception)
            {

                Console.WriteLine("Lista događaja je prazna");
            }
            

        }

        /// <summary>
        /// Save entered data at app close or at user request
        /// </summary>
        private void SaveData()
        {
            

            string docPath =
          Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "data.json"));
            outputFile.WriteLine(JsonConvert.SerializeObject(ProcessingEventPlace.Events));
            outputFile.Close();
        }



    }
}
