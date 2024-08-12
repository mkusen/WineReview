using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WineReview.Controller;
using WineReview.Model;

namespace WineReview
{
    internal class Auxiliary
    {
        ProcessingEventPlace ProcessingEventPlace { get; set; }
        ProcessingReviewer ProcessingReviewer { get; set; } 
        ProcessingWine ProcessingWine { get; set; }

        public Auxiliary()
        {
            ProcessingEventPlace = new ProcessingEventPlace();
            ProcessingReviewer = new ProcessingReviewer();
            ProcessingWine  = new ProcessingWine();

        }

        internal static void GetId()
        {
            
            
            
            
            throw new NotImplementedException();
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
        public static void LoadData()
        {
            string docPath =
         Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
         

            if (File.Exists(Path.Combine(docPath, "data.json")))
            {                
                StreamReader file = File.OpenText(Path.Combine(docPath, "data.json"));
                var data = JsonConvert.DeserializeObject<List<Reviewer>>(file.ReadToEnd());          

                foreach (var item in data)
                {
                    var id = item.Id;
                    var fn = item.FirstName;
                    var ln = item.LastName;
                    var email = item.Email;
                    var pass = item.Password;
                    //Console.WriteLine("{0} {1} {2} {3} {4}", id, fn, ln, email, pass);
                }
              

            }
            else {

                throw new Exception(); }  
           

        }

        /// <summary>
        /// Save entered data at app close or at user request
        /// </summary>
        public static void SaveData(List<Reviewer> data)
        {

            string docPath =
          Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "data.json"));
            outputFile.WriteLine(JsonConvert.SerializeObject(data));
            outputFile.Close();
        }



    }
}
