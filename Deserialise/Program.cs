using System;
using System.Linq;
using Deserialise.Logic;
using Deserialise.Models;
using Newtonsoft.Json;

namespace Deserialise
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // the data from Json is now deserialized to C# objects
            var myObjectFromJsonToCSharp = JsonConvert.DeserializeObject<FriendsList>(JsonFile.GetJsonDataFromTextFile());

            //a quick test to get the name and mobile number
            Console.WriteLine(myObjectFromJsonToCSharp.person.name);

            foreach (var item in myObjectFromJsonToCSharp.person.contactNumber)
            {
                Console.WriteLine(MakeFirstStringLetterCapital(nameof(item.mobile)) + ": " + item.mobile);
            }
        }

        // a method that takes a string -> 'mobile' and make the first letter Capital -> 'Mobile'
        public static string MakeFirstStringLetterCapital(string letter)
        {
            return string.Format("{0}", letter.First().ToString().ToUpper() + letter.Substring(1));
        }
    }
}
