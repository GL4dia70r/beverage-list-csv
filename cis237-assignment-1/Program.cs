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
            Beverage[] drinks = new Beverage[4142];

            UserInterface ui = new UserInterface();

            CSVContainer proc = new CSVContainer();

            string CSVFile = "../../../beverage_list.csv";

            string choice = ui.GetUserInput();

            while (choice != "e")
            {
                if (choice == "a")
                {
                    proc.CsvImportPath(CSVFile, drinks);

                    Console.WriteLine("File loaded...");                                                        
                }
                while (proc.CsvImportPath(CSVFile, drinks))
                {
                    if (choice == "a")
                    {
                        Console.WriteLine("You already loaded the file...");
                        break;
                    }

                    if (choice == "b")
                    {
                        string putString = "";

                        foreach (Beverage beverage in drinks)
                        {
                            if (beverage != null)
                            {
                                putString += beverage.ToString() +
                                    Environment.NewLine;
                            }
                        }
                        ui.PrintList(putString);
                        Console.WriteLine();
                        Console.WriteLine("List Printed...");
                        break;
                    }
                    else if (choice == "c")
                    {
                        Console.WriteLine("What drink (ID) do you need to find? ");
                        string userInput = Console.ReadLine();

                        foreach (Beverage drink in drinks)
                        {
                            if (drink != null)
                            {

                            }
                        }

                    }
                    choice = ui.GetNewUserInput();
                }
                                                 

                
                choice = ui.GetUserInput();
            }
        }
    }
}
