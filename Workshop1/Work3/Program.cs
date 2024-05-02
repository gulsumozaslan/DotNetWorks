
int kullaniciSayi = 0;

Random randomSayi = new Random();
int tahminiSayi = randomSayi.Next(1,10);

Console.WriteLine("1 ile 10 arasında bir sayı giriniz");

while (kullaniciSayi != tahminiSayi )
{
    kullaniciSayi = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine(kullaniciSayi == tahminiSayi ? "Tebrikler doğru tahmin" : "Yanlış tahmin tekrar deneyiniz!");

}


    


