

/* Bir mağazanın günlük satış miktarını, ürün adı ve fiyatını bir dizi olarak tutan ve toplam satış gelirini hesaplayan bir algoritma yazınız. */


Console.Write("Günük satış miktarı : ");
int salesAmount = Convert.ToInt32(Console.ReadLine());

string[] productNames = new string[salesAmount];
int[] productPrices = new int[salesAmount];
double salesRevenue = 0;


for(int i = 0; i< salesAmount; i++)
{
    Console.Write($"Ürün {i+1}'in adı : " );
    string productName = Console.ReadLine();
    productNames[i] = productName;
    Console.Write($"Ürün {i+1}'in fiyatı : ");
    int productPrice = Convert.ToInt32(Console.ReadLine());
    productPrices[i] = productPrice;
    salesRevenue += productPrices[i];
    

}
Console.WriteLine("Toplam satış geliri : " + salesRevenue);
