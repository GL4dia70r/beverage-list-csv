// David Allen
// CIS 237
// 09/27/22
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace cis237_assignment_1
{
    internal class UserInterface
    {
        /// <summary>
        /// Gets the user entry
        /// </summary>
        /// <returns>user entry if entry doesn't equal 'e'</returns>
        public string GetUserInput()
        {
            this.PrintMenu();

            string input = Console.ReadLine().ToLower();
            
            return this.UserInput(input);                       
        }
        /// <summary>
        /// Prints Menu
        /// </summary>
        public void PrintMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("a. Load a File");
            Console.WriteLine("b. Print File.");
            Console.WriteLine("c. Search File.");
            Console.WriteLine("d. Add a New Beverage.");
            Console.WriteLine("e. Exit.");
            Console.WriteLine();
            
        }
        /// <summary>
        /// Prints List
        /// </summary>
        /// <param name="oList">List provided in another class</param>
        public void PrintList(string oList)
        {
            Console.WriteLine("List printing");
            Console.WriteLine("ID \t DRINK \t \t PACK \t PRICE \t ACTIVE");
            Console.WriteLine(oList);
        }
        /// <summary>
        /// Prints error message
        /// </summary>
        public void PrintErrorMessage()
        {
            Console.WriteLine("The entry you chose does not exist...");
            Console.WriteLine("Please try again.");
            Console.WriteLine();
        }
        /// <summary>
        /// Prints error message if file wasn't loaded first (Not sure if used)
        /// </summary>
        public void PrintUnreadFileErrorMsg()
        {
            Console.WriteLine("You need to 'load' the file first before choosing an option");
            Console.WriteLine("Please try again.");
            Console.WriteLine();
        }
        /// <summary>
        /// gets new menu and new user entry
        /// </summary>
        /// <returns>new user entry</returns>
        public string GetNewUserInput()
        {
            this.PrintNewMenu();

            string input = Console.ReadLine().ToLower();

            return this.UserInput(input);
        }
        /// <summary>
        /// prints new menu
        /// </summary>
        public void PrintNewMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("b. Print File.");
            Console.WriteLine("c. Search File.");
            Console.WriteLine("d. Add a New Beverage.");
            Console.WriteLine("e. Exit.");
            Console.WriteLine();

        }
        /// <summary>
        /// gets user entry
        /// </summary>
        /// <param name="uInput">user input from another class</param>
        /// <returns>user input if true</returns>
        private string UserInput(string uInput)
        {
            while (uInput != "a" && uInput != "b" && uInput != "c" && uInput != "d" && uInput != "e")
            {
                this.PrintErrorMessage();

                this.PrintMenu();

                uInput = Console.ReadLine();
            }
            return uInput.ToLower();
        }
    }
}
