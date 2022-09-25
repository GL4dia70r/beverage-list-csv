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
        public string GetUserInput()
        {
            this.PrintMenu();

            string input = Console.ReadLine().ToLower();
            
            this.UserInput(input);

            return input;
        }

        public void PrintMenu()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("a. Load a File");
            Console.WriteLine("b. Print List from select file");
            Console.WriteLine("c. Search List from select file");
            Console.WriteLine("d. Add a New Beverage to the List from select file");
            Console.WriteLine("e. Exit");
            Console.WriteLine();
            
        }

        public void PrintList(string oList)
        {
            Console.WriteLine("List printing");
            Console.WriteLine("ID \t DRINK \t \t PACK \t PRICE \t ACTIVE");
            Console.WriteLine(oList);
        }

        public void PrintErrorMessage()
        {
            Console.WriteLine("The entry you chose does not exist...");
            Console.WriteLine("Please try again.");
            Console.WriteLine();
        }

        public void PrintUnreadFileErrorMsg()
        {
            Console.WriteLine("You need to 'load' the file first before choosing an option");
            Console.WriteLine("Please try again.");
            Console.WriteLine();
        }

        private string UserInput(string uInput)
        {
            while (uInput != "a" && uInput != "b" && uInput != "c" && uInput != "d" && uInput != "e")
            {
                this.PrintErrorMessage();

                this.PrintMenu();

                uInput = Console.ReadLine();

                if (uInput == "e")
                {
                    
                }
            }
            return uInput.ToLower();
        }

        public void GetUserSearch(string uInput) 
        {
            
        }
    }
}
