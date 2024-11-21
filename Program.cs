using System;

class Program
{
    static void Main()
    {
        double sayi1, sayi2, sonuc;
        int secim;
        string devam;

        do
        {
            Console.Write("Birinci sayıyı girin: ");
            sayi1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("İkinci sayıyı girin: ");
            sayi2 = Convert.ToDouble(Console.ReadLine());

         
            Console.WriteLine("\nYapmak istediğiniz işlemi seçin:");
            Console.WriteLine("1. Toplama");
            Console.WriteLine("2. Çıkarma");
            Console.WriteLine("3. Çarpma");
            Console.WriteLine("4. Bölme");

            Console.Write("Seçiminizi yapın (1/2/3/4): ");
            secim = Convert.ToInt32(Console.ReadLine());

           
            switch (secim)
            {
                case 1:
                    sonuc = sayi1 + sayi2;
                    Console.WriteLine($"Sonuç: {sonuc}");
                    break;
                case 2:
                    sonuc = sayi1 - sayi2;
                    Console.WriteLine($"Sonuç: {sonuc}");
                    break;
                case 3:
                    sonuc = sayi1 * sayi2;
                    Console.WriteLine($"Sonuç: {sonuc}");
                    break;
                case 4:
                    if (sayi2 != 0)  
                    {
                        sonuc = sayi1 / sayi2;
                        Console.WriteLine($"Sonuç: {sonuc}");
                    }
                    else
                    {
                        Console.WriteLine("Hata: Bir sayıyı sıfıra bölemezsiniz!");
                    }
                    break;
                default:
                    Console.WriteLine("Geçersiz işlem seçimi.");
                    break;
            }

           
            Console.Write("\nBaşka bir işlem yapmak ister misiniz? (Evet/Hayır): ");
            devam = Console.ReadLine().ToLower();

        } while (devam == "evet"); 

        Console.WriteLine("Programdan çıkılıyor...");
    }
}
