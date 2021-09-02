using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomplexaDatatyperKata
{
    class OnlineOrder
    {
        public int orderNr;
        public DateTime orderDate;
        public string productName;
        public decimal totalPrice;
        public string customerName;
        public string customerAddress;

        private static int _nextNumber = 1;


        public OnlineOrder(string Item, decimal Price, string Name, string Address)
        {
            orderNr = _nextNumber;
            _nextNumber++;

            orderDate = DateTime.Now;

            productName = Item;

            totalPrice = Price;

        }
    }
}
