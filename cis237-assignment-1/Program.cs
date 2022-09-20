using Microsoft.VisualBasic;
using System;

namespace cis237_assignment_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Beverage beverages = new Beverage();

            UserInterface ui = new UserInterface();

            string pathToCSVFile = "../../../beverage_list.csv";

            CSVContainer csvContainer = new CSVContainer();

            csvContainer.CsvImportPath(pathToCSVFile, beverages);

            string choice = ui.GetUserInput();

            while (choice != "e")
            {
                if (choice == "a")
                {
                    OpenAccess.Read.Equals(pathToCSVFile);
                }
                else if (choice == "b")
                {
                    string outputString = "";

                    foreach (Beverage beverage in beverages)
                    {
                        if (beverage != null)
                        {
                            outputString += beverage.ToString() +
                                Environment.NewLine;
                        }
                    }    
                }
            }
        }
    }
}
