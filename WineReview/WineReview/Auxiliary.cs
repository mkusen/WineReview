using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using WineReview.Controller;
using WineReview.Model;

namespace WineReview
{
    internal class Auxiliary
    {
        public Auxiliary()
        {
        }

        internal int GetId(int id)
        {
            
            for (int i = 0; i < id; i++)
            {
                ++id;
            }
            return id;

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
        internal static List<Reviewer>? LoadData()
        {
            string docPath =
         Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);


            if (File.Exists(Path.Combine(docPath, "data.json")))
            {
                StreamReader file = File.OpenText(Path.Combine(docPath, "data.json"));
                var data = JsonConvert.DeserializeObject<List<Reviewer>>(file.ReadToEnd());

                return data;
            }
            else
            {

                throw new Exception();
            }


        }

        /// <summary>
        /// Save entered data at app close or at user request
        /// </summary>
        internal void SaveData(List<Reviewer> data)
        {

            string docPath =
          Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);

            try
            {
                StreamWriter outputFile = new StreamWriter(Path.Combine(docPath, "data.json"));
                outputFile.WriteLine(JsonConvert.SerializeObject(data));
                outputFile.Close();
            }
            catch (Exception)
            {

                throw new Exception();
            }
          
        }



    }
}
