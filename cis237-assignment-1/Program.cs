using Microsoft.VisualBasic;
using System;
using System.Security.Cryptography.X509Certificates;

namespace cis237_assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            

            UserInterface ui = new UserInterface();

            CSVContainer proc = new CSVContainer();

            Beverage[] drinks = new Beverage[4142];

            string pathToCSVFile = "../../beverage_list.csv";

            string choice = ui.GetUserInput();

            while (choice != "e")
            {
                if (choice == "a")
                {
                    proc.CsvImportPath(pathToCSVFile, drinks);

                    string choice2 = ui.GetNewUserInput();

                       if (choice2 == "b")
                       {
                            string putString = "";

                            foreach (Beverage beverage in drinks)
                            {
                                putString += beverage.ToString() +
                                    Environment.NewLine;
                            }
                            ui.PrintList(putString);
                       }
                       else if (choice2 == "c")
                       {
                            string userInput = Console.ReadLine();

                            foreach (Beverage beverage in drinks)
                            {
                                Array.Sort(drinks);

                                Array.BinarySearch(drinks, userInput);
                            }
                            Console.WriteLine(userInput);
                       }
                       choice2 = ui.GetNewUserInput();
                                                 

                }
                choice = ui.GetUserInput();
            }
        }
    }
}
