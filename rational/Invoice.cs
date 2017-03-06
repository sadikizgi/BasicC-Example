using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP01042016
{
    class Invoice
    {
        string part_number;
        string part_description;
        int quantity;
        decimal price_per_item;

        public string Part_number
        {
            get
            {
                return part_number;
            }

            set
            {
                part_number = value;
            }
        }

        public string Part_description
        {
            get
            {
                return part_description;
            }

            set
            {
                part_description = value;
            }
        }

        public int Quantity
        {
            get
            {
                return quantity;
            }

            set
            {
                if (value < 0)
                    value = 0;
                quantity = value;
            }
        }

        public decimal Price_per_item
        {
            get
            {
                return price_per_item;
            }

            set
            {
                if (value < 0)
                    value = 1;
                price_per_item = value;
            }
        }
        public Invoice(string number,string description,int qty,decimal price)
        {
            Part_number = number;
            Part_description = description;
            Quantity = qty;
            Price_per_item = price;
        }
       
        public decimal GetInvoiceAmount()
        {
            return price_per_item*quantity;
        }
        
    }
}
