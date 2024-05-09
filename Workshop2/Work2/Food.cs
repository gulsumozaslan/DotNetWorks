using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work2
{
    public class Food
    {
        public string FoodName { get; set; }
        public decimal FoodPrice { get; set; }
        public double Popularity { get; set; }

        public Food(string name, decimal price, double rating)
        {
            FoodName = name;
            FoodPrice = price;
            Popularity = rating;
        }

        public override string ToString()    
        {
            return $"{FoodName} - {FoodPrice} TL - Popülerlik: {Popularity} ";

        }

    }
}
