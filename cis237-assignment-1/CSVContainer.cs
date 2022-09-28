// David Allen
// CIS 237
// 09/27/22
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment_1
{
    internal class CSVContainer
    {
        /// <summary>
        /// Reads the CSV file.
        /// </summary>
        /// <param name="pathToCSV">variable that holds the file.</param>
        /// <param name="beverages">array to store the file into.</param>
        /// <returns></returns>
        public bool CsvImportPath(string pathToCSV, Beverage[] beverages)
        {
            StreamReader streamR = null;

            try
            {
                string line;

                streamR = new StreamReader(File.OpenRead(pathToCSV));

                int count = 0;

                while ((line = streamR.ReadLine()) != null)
                {
                    this.ProcessLine(line, beverages, count++);
                }
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine();
                Console.WriteLine(e.StackTrace);

                return false;
            }
            finally
            {                
                if (streamR != null)
                {
                    streamR.Close();
                }
            }
        }
        /// <summary>
        /// Processes each line of the file.
        /// </summary>
        /// <param name="line">depicted as the column of the file.</param>
        /// <param name="beverages">the array that holds the file to sort into.</param>
        /// <param name="index">organizes the line by indexing them.</param>
        private void ProcessLine(string line, Beverage[] beverages, int index)
        {
            string[] description = line.Split(',');

            string iD = description[0];
            string bevName = description[1];
            string packAmount = description[2];
            decimal approxPrice = decimal.Parse(description[3]);
            bool isActive = bool.Parse(description[4]);

            beverages[index] = new Beverage(iD, bevName, packAmount, approxPrice, isActive);

        }
    }
}
