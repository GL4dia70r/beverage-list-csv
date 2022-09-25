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

            CSVContainer container = new CSVContainer();

            string choice = ui.GetUserInput();

            while (choice != "e")
            {
                if (choice == "a")
                {
                    string pathToCSVFile = "../../../beverage_list.csv";

                    Beverage[] drinks = new Beverage[pathToCSVFile.Length];

                    container.CsvImportPath(pathToCSVFile, drinks);

                    while (choice != "e")
                    {
                        if (choice == "b")
                        {
                           

                        }
                    }
                }
                choice = ui.GetUserInput();
            }
        }
    }
}
