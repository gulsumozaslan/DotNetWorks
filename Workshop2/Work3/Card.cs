using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Work3
{
    internal class Card
    {
        List<Product> products;
        decimal productPrice = 0;

        public Card()
        {
            products = new List<Product>();
        }

        public void AddToCard(Product product)
        {
            products.Add(product);
            Console.WriteLine(product.Name + " sepete eklendi");
        }
        public void RemoveToCard(Product product)
        {
            products.Remove(product);
            Console.WriteLine(product.Name + " sepetten kaldırıldı");

        }
        public List<Product> GetProducts()
        {
            Console.WriteLine("------Sepetteki ürünler------");

            foreach (var product in products)
            {

                Console.WriteLine(product.Name);
            }

            return products;

        }
        public void TotalPrice()
        {
            foreach (var product in products)
            {
                productPrice += product.Price * product.Amount;

            }

            Console.WriteLine("Toplam tutar :" + productPrice);


        }

    }

}
