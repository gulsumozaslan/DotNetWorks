
int toplam = 0;
int kalan = 0;

Console.Write("Bir sayı giriniz : ");
int girilenSayi = Convert.ToInt32(Console.ReadLine());

for (int i = 1; i <= girilenSayi ; i++)
{
    kalan = girilenSayi % i;
    if (kalan == 0)
    {
        toplam += i;
    }
}
if(toplam == girilenSayi * 2)
{
    Console.WriteLine(girilenSayi + " Mükemmel sayıdır");
}
else
{
    Console.WriteLine(girilenSayi + " Mükemmel sayı değildir");
}

