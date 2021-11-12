using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLib.Model
{
    public class Product
    {
        private int _Id;
        private string _Name;
        private double _Price;
        private float _Discnt;
        private double _discountAmount;

        public Product(int id,string name, double price,float discnt)
        {
            this._Id = id;
            this._Name = name;
            this._Price = price;
            this._Discnt = discnt;
            CalculateDiscount(_Price);
        }

       
        public int ID
        {
            get
            {
                return _Id;
            }
        }
        public string Name
        {
            get
            {
                return _Name;
            }
        }
        public double Price
        {
            get
            {
                return _Price;
            }
        }
        public float Discnt
        {
            get
            {
                return _Discnt;
            }
        }
        public override int GetHashCode()
        {
            return ID;
        }
        public override bool Equals(object obj)
        {
            if (this.ID == obj.GetHashCode())
            {
                return true;
            }
            return false;
        }
        private double CalculateDiscount(double amout)
        {
            _discountAmount = _Discnt / 100 * _Price;
            return _discountAmount;
        }

        public double DiscountAmount
        {
            get
            {
                return _discountAmount;
            }
        }
    }
}
