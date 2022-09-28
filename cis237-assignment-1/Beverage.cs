// David Allen
// CIS 237
// 09/27/22
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cis237_assignment_1
{
    internal class Beverage
    {
        //*************************
        // Attributes/Variables/Backing Fields
        //*************************
        private string _iD;
        private string _bevName;
        private string _packAmount;
        private decimal _approxPrice;
        private bool _isActive;


        //*************************
        // Properties
        //*************************
        /// <summary>
        /// Gets ID
        /// </summary>
        public string ID
        {
            get { return _iD; }
            set { _iD = value; }
        }
        /// <summary>
        /// Gets beverage name
        /// </summary>
        public string BevName
        {
            get { return _bevName; }
            set { _bevName = value; }
        }
        /// <summary>
        /// gets the beverage pack
        /// </summary>
        public string PackAmount
        {
            get { return _packAmount; }
            set { _packAmount = value; }
        }
        /// <summary>
        /// Gets the beverage price
        /// </summary>
        public decimal ApproxPrice
        {
            get { return _approxPrice; }
            set { _approxPrice = value; }
        }
        /// <summary>
        /// Gets the beverage activity
        /// </summary>
        public bool isActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        //*************************
        // Methods
        //*************************
        /// <summary>
        /// ToString Override for each variable
        /// </summary>
        /// <returns>variables as string</returns>
        public override string ToString()
        {
            return _iD + " \t " + _bevName + " \t " + _packAmount + " \t " + _approxPrice + " \t " + _isActive;
        }

        //*************************
        // Constructors
        //*************************
        /// <summary>
        /// Organizes each variable
        /// </summary>
        /// <param name="iD">stores variable into constructor variable</param>
        /// <param name="bevName">stores variable into constructor variable</param>
        /// <param name="packAmount">stores variable into constructor variable</param>
        /// <param name="approxPrice">stores variable into constructor variable</param>
        /// <param name="isActive">stores variable into constructor variable</param>
        public Beverage(string iD, string bevName, string packAmount, decimal approxPrice, bool isActive)
        {
            this._iD = iD;
            this._bevName = bevName;
            this._packAmount = packAmount;
            this._approxPrice = approxPrice;
            this._isActive = isActive;
        }

        public Beverage() { }

    }
}
