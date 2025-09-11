using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_8
{
   public class cart
    {
        private string? _cartID;
        private Dictionary<string, double>? _items;




        public cart() { }

        public cart(string cartID)
        {
            _cartID=cartID;
            _items = new Dictionary<string, double>();
        }

        public void AddItem(string item, double price)
        {
            _items.Add(item, price);
        }

        public void RemoveItem(string item)
        {
            _items.Remove(item);
        }

        public double GetTotal()
        {
            double total = 0;
            foreach (KeyValuePair<string, double> item in _items)
            {
                total += item.Value;
            }
            return total;
        }

        public override string ToString()
        {
            string result = "Cart ID:  " + _cartID + "\n";
            foreach (KeyValuePair<string,double> item in _items)
            {
                result += item.Key + ": $" + item.Value.ToString("F2") + "\n";
            }
            result += "Total: $" + GetTotal().ToString("F2") + "\n";
            return result;  

        }
    }
}
