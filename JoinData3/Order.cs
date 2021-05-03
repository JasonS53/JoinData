using System;
using System.Collections.Generic;
using System.Text;

namespace JoinData3
{
    class Order
    {
        //fields
        private string _customerName;
        private string _item;
        private decimal _price;
        private int _quantity;

        //properties
        public string CustomerName
        {
            get { return this._customerName; }
            set { this._customerName = value; }
        }
        public string Item
        {
            get { return this._item; }
            set { this._item = value; }
        }
        public decimal Price
        {
            get { return this._price; }
            set { this._price = value; }
        }
        public int Quantity
        {
            get { return this._quantity; }
            set { this._quantity = value; }
        }

        //constructor
        public Order(string customerName, string item, decimal price, int quantity)
        {
            this._customerName = customerName;
            this._item = item;
            this._price = price;
            this._quantity = quantity;
        }

        public Order()
        {
            
        }

        //method
        public override string ToString()
        {
            decimal total = this._price * this._quantity;
            return string.Format("\t{0, -20} {1, -20} {2, -21} {3, 0}", this._item, this._price, this._quantity, total);
        }
    }
}
