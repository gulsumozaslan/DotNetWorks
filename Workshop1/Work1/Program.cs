

double toplamTutar = 0;

Console.WriteLine("Kaç ürün almak istiyorsunuz?");
int urunSayisi = Convert.ToInt32(Console.ReadLine());


for (int i = 1; i <= urunSayisi; i++)
{
    Console.WriteLine($"Ürün {i} için fiyatı giriniz:");
    double urunFiyati = Convert.ToDouble(Console.ReadLine());
    toplamTutar += urunFiyati;
}

Console.WriteLine("Toplam alışveriş tutarı: " + toplamTutar);








