using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLib.Model
{
    class LineItem
    {
        private int _Id;
        private Product _product;
        private int _Quantity;
        private double _TotalPrice;

        public LineItem(int Id,Product product,int Quantity)
        {
            this._Id = Id;
            this._product = product;
            this._Quantity = Quantity;
            
        }
        
        public int ID
        {
            get
            {
                return _Id;
            }
        }
        public Product Product
        {
            get
            {
                return _product;
            }
        }
        public int Quantity
        {
            get
            {
                return _Quantity;
            }
        }
        public double Calculate()
        {
            _TotalPrice = _product.DiscountAmount * _Quantity;
            return _TotalPrice;
        }

    }
}
