using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionApp.Model
{
    class LineItem
    {
        private string _ProductName;
        private double _Price;
        private int _Quantity;
        private double _TotalPrice;

        public LineItem(string _ProductName, double _Price,int _Quantity)
        {
            this._ProductName = _ProductName;
            this._Price = _Price;
            this._Quantity = _Quantity;
        }
        public void CalculateTotalPrice()
        {

        }
        public string GetProductName()
        {
            return _ProductName;
        }
        public double GetPrice()
        {
            return _Price;
        }
        public int GetQuantity()
        {
            return _Quantity;
        }
    }
}
