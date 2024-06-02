using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.Models
{
    public class Ingredient: BaseIngredient
    {
        private decimal _price;
        private DateTime _expirationDate;

        public Ingredient(string name, decimal price, float quantity, DateTime expirationDate)
            : base(name, quantity)
        {
            Price = price;
            ExpirationDate = expirationDate;
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
