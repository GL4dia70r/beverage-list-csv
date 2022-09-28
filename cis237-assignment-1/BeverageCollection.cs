// David Allen
// CIS 237
// 09/27/22
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
        Beverage[] beverages = new Beverage[4142];
        /// <summary>
        /// adds entry to array list. Not entirely sure this works as intended...
        /// </summary>
        /// <param name="newBeverage"> new parameter inputted by the user in another class.</param>
        public void AddBeverage(Beverage newBeverage)
        {
            beverages.Append(newBeverage);
        }

        /// <summary>
        /// Doesn't work, but was suppose to search for the key property 'searchKey' provided by the user.
        /// </summary>
        /// <param name="beverages">Array list</param>
        /// <param name="searchKey">User input parameter</param>
        /// <returns>the searchKey if found</returns>
        public string LinearSearch(Beverage[] beverages, string searchKey)
        {
            foreach (Beverage beverage in beverages)
            {
                if (searchKey == beverage.ID)
                {
                    searchKey = beverage.ID;
                }
                else
                {
                    Console.WriteLine("That drink doesn't exist. ");
                }
            }
            return searchKey;
        }

    }
}
