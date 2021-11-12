using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingCartLib.Model
{
    public class Customer
    {
        private int _Id;
        private string _Name;
        private List<Order> _order;
        private int _orderCount;

        public Customer(int id, string name)
        {
            this._Id = id;
            this._Name = name;
        }
        public void AddOrder(Order order)
        {
            _order.Add(order);
            _orderCount += 1;
        }
        public int Id
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
        public List<Order> Order
        {
            get
            {
                return _order;
            }
        }
        public int OrderCount
        {
            get
            {
                return _orderCount;
            }
        }

    }
}
