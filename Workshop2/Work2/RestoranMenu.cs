using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace Work2
{
    public class RestoranMenu
    {
        private List<Food> menu;

        public RestoranMenu()
        {
            menu = new List<Food>();
        }

        public void AddFood(Food food)
        {
            menu.Add(food);
        }
        public List<Food> GetMenu()
        {
            foreach (var food in menu)
            {
                Console.WriteLine(food);
            }
            return menu;
        }
    }
}
