using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLib.Model
{
    class Order
    {
        private int _Id;
        private int _DateTime;

        public Order(int id, int DateTime)
        {
            this._Id = id;
            this._DateTime = DateTime;
        }
        public int Id
        {
            get
            {
                return _Id;
            }
        }
        public int DateTime
        {
            get
            {
                return _DateTime;
            }
        }

    }
}
