
using Work3;

/* Kullanıcının seçtiği ürünleri, fiyatlarını ve sepete eklenen miktarları bir dizi ile tutan algoritma yazınız.*/

Product product1 = new Product();
product1.Id = 1;
product1.Name = "Ceket";
product1.Price = 500;
product1.Amount = 3;

Product product2 = new Product();
product2.Id = 2;
product2.Name = "Pantolon";
product2.Price = 600;
product2.Amount = 2;

Product product3 = new Product();
product3.Id = 2;
product3.Name = "kaban";
product3.Price = 1500;
product3.Amount = 1;


Card card = new Card();
card.AddToCard(product1);
card.AddToCard(product2);
card.AddToCard(product3);
card.GetProducts();

card.TotalPrice();

//card.RemoveToCard(product3);
//card.GetProducts();


