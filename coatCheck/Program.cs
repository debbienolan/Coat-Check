using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace coatCheck
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, int> coatCheck = new Dictionary<string, int>(); //create dictionary
            {
                coatCheck.Add("Rain Coat", 0);   //adding value of coatCheck and key numbers
                coatCheck.Add("Ski Jacket", 1);
                coatCheck.Add("Puffer Coat", 2);
                coatCheck.Add("Stadium Coat", 3);
                coatCheck.Add("Barn Coat", 4);
                coatCheck.Add("Poncho Coat", 5);
                coatCheck.Add("Slicker Coat", 6);
                coatCheck.Add("Trench Coat", 7);
                coatCheck.Add("Commuter Coat", 8);
                coatCheck.Add("Faux Fur Coat", 9);
            }
            List<string> list = new List<string>(coatCheck.Keys);  //creating new list linking coatCheck names and key numbers

            foreach (string k in list)  //looping through the list
            {
                Console.WriteLine("{0}, {1}", k, coatCheck[k] );  //printing to console the name of the coat at the index of 0,
            }                                                       //and printing the key numbers which are at the index of 1
        }                                                           //calling the key and printing coat name with key number

    }
}
