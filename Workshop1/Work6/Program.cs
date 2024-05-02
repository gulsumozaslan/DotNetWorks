
Console.WriteLine("Toplam öğrenci sayısını giriniz : ");
int toplamOgrenciSayisi = Convert.ToInt32(Console.ReadLine());

for(int i=1; i<=toplamOgrenciSayisi; i++)
{
    double notOrtalamasi = 0;
    Console.WriteLine($"Öğrenci {i} adını giriniz :");
    Console.ReadLine();
    Console.WriteLine($"Öğrenci {i} soyadını giriniz :");
    Console.ReadLine();
    Console.WriteLine($"Öğrenci {i}'in 1. sınav notunu giriniz :");
    int not1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Öğrenci {i}'in 2. sınav notunu giriniz :");
    int not2 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine($"Öğrenci {i}'in 3. sınav notunu giriniz :");
    int not3 = Convert.ToInt32(Console.ReadLine());
    notOrtalamasi += (not1 + not2 + not3)/3;
    Console.WriteLine($"Öğrenci {i}'in not ortalaması" +notOrtalamasi);

}