using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace cis237_assignment_1
{
    internal class BeverageCollection
    {
        public BeverageCollection(string csvPath)
        {
            Beverage[] beverages = new Beverage[csvPath.Length];

            string uInput = Console.ReadLine();

            string result = Array.Find(uInput, beverages);
        }

        public static string FindDrink(Beverage[] drink, string uInput)
        {
            return drink.Find(uInput);
        }
    }
}
