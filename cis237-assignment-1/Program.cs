// David Allen
// CIS 237
// 09/27/22
using Microsoft.VisualBasic;
using System;
using System.IO;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;

namespace cis237_assignment_1
{
    class Program
    {        
        static void Main(string[] args)
        {
            // beverageCollection variable
            BeverageCollection collection = new BeverageCollection();
            // Beverage array variable
            Beverage[] drinks = new Beverage[4142];
            // UI variable
            UserInterface ui = new UserInterface();
            // CSV Reader variable
            CSVContainer proc = new CSVContainer();
            // file variable
            string CSVFile = "../../../beverage_list.csv";
            // bool to read if file was opened
            bool loaded = false;
            // gets the user input entry
            string choice = ui.GetUserInput();
            // While user doesn't enter 'e' the program runs on
            while (choice != "e")
            {                
                if (choice == "a") // of 'a' is chosen, the program runs
                {
                    loaded = false; // bool is false

                    if (!loaded) // if not loaded
                    {
                        loaded = true; // load is true

                        do // the program runs below
                        {
                            proc.CsvImportPath(CSVFile, drinks); // opens file and stores in array
                            
                            choice = ui.GetNewUserInput(); // gets new UI user input 

                            if (choice == "a") // if chosen then error message appears
                            {
                                Console.WriteLine("You already loaded it once...");
                            }
                            if (choice == "b") // if chosen then the list Prints
                            {
                                string putString = ""; // empty string to hold list elements

                                foreach (Beverage beverage in drinks)
                                {
                                    if (beverage != null) // if list is not empty
                                    {
                                        putString += beverage.ToString() +
                                            Environment.NewLine; // reads line by line
                                    }
                                }
                                ui.PrintList(putString); // prints list
                                Console.WriteLine();

                                Console.WriteLine("List Printed...");
                                Console.WriteLine();
                                break;
                            }
                            if (choice == "c") // does NOT work, do not understand this quite yet.
                            {
                                Console.WriteLine("What drink (ID) do you need to find? ");

                                string userInput = Console.ReadLine();

                                collection.LinearSearch(drinks, userInput);
                                break;
                            }
                            if (choice == "d") // gets the beverage critiria from user input. Not sure if works properly...
                            {
                                Beverage additionalBeverage = new Beverage();

                                Console.WriteLine("What is the ID? ");
                                additionalBeverage.ID = Console.ReadLine();

                                Console.WriteLine("What is the Name? ");
                                additionalBeverage.BevName = Console.ReadLine();

                                Console.WriteLine("How big is the Pack? ");
                                additionalBeverage.PackAmount = Console.ReadLine();

                                Console.WriteLine("What is the Price? ");
                                additionalBeverage.ApproxPrice = decimal.Parse(Console.ReadLine());

                                Console.WriteLine("Is the beverage Active? (Yes or No)");
                                additionalBeverage.isActive = bool.Parse(Console.ReadLine()); // error occurs here.

                                if (additionalBeverage.isActive == bool.Parse("yes".ToLower()))
                                {
                                    additionalBeverage.isActive = bool.Parse("True");
                                }
                                else
                                {
                                    additionalBeverage.isActive = bool.Parse("False");
                                }
                                collection.AddBeverage(additionalBeverage);
                                break;
                            }
                            if (choice == "e") // quits the new menu option
                            {
                                break;
                            }
                        }
                        while (loaded);
                    }
                    else
                    {                        
                        Console.WriteLine("You already loaded it once..."); // couldn't get this to pop up...
                    }                                    
                }
                else
                {
                    Console.WriteLine("You must load the file first! "); // if choice != "a" this occurs
                    Console.WriteLine();
                }
                choice = ui.GetUserInput(); // repeats the process until "e" is entered...
            }
        }
    }
}
