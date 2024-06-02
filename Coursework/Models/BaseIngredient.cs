using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Coursework.Models
{
    public class BaseIngredient
    {
        private static int _currentId = 0;
        private string _name;
        private float _quantity;
        private int _id;

        public BaseIngredient(string name, float quantity)
        {
            Id = _currentId++;
            Name = name;
            Quantity = quantity;
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
                    _name = value.Replace(' ', '_');
                }
                else
                {
                    throw new ArgumentException("Name cannot be null or empty.");
                }
            }
        }

        public float Quantity
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
    }
}
