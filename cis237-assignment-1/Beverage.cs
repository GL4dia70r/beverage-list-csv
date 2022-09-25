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
        public string ID
        {
            get { return _iD; }
            set { _iD = value; }
        }

        public string BevName
        {
            get { return _bevName; }
            set { _bevName = value; }
        }

        public string PackAmount
        {
            get { return _packAmount; }
            set { _packAmount = value; }
        }

        public decimal ApproxPrice
        {
            get { return _approxPrice; }
            set { _approxPrice = value; }
        }

        public bool isActive
        {
            get { return _isActive; }
            set { _isActive = value; }
        }

        //*************************
        // Methods
        //*************************
        public string findBevNameWithId()
        {
            return _bevName + " " + _iD;
        }

        public override string ToString()
        {
            return _iD + " \t " + _bevName + " \t " + _packAmount + " \t " + _approxPrice + " \t " + _isActive;
        }

        //*************************
        // Constructors
        //*************************
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
