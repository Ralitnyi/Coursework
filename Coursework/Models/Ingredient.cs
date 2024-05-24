using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.Models
{
    internal class Ingredient
    {
        private static int _currentId = 0;
        private int _id;
        private string _name;
        private decimal _price;
        private int _quantity;
        private DateTime _expirationDate;

        public Ingredient(string name, decimal price, int quantity, DateTime expirationDate)
        {
            Id = _currentId++;
            Name = name;
            Price = price;
            Quantity = quantity;
            ExpirationDate = expirationDate;
        }

        public int Id
        {
            get { return _id; }
            private set { _id = value; }
        }

        public string Name
        {
            get { return _name; }
            set
            {
                if (!string.IsNullOrEmpty(value))
                {
                    _name = value;
                }
                else
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }
            }
        }

        public decimal Price
        {
            get { return _price; }
            set
            {
                if (value >= 0)
                {
                    _price = value;
                }
                else
                {
                    throw new ArgumentException("Price cannot be negative.");
                }
            }
        }

        public int Quantity
        {
            get { return _quantity; }
            set
            {
                if (value >= 0)
                {
                    _quantity = value;
                }
                else
                {
                    throw new ArgumentException("Quantity cannot be negative.");
                }
            }
        }

        public DateTime ExpirationDate
        {
            get { return _expirationDate; }
            set { _expirationDate = value; }
        }

        public bool IsExpired()
        {
            return DateTime.Now > ExpirationDate;
        }
    }
}
