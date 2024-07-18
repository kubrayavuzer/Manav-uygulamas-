using System;

namespace ManavUygulaması
{
    class Program

    {
        static void Main(string[] args)

        {

            Console.WriteLine("Rüya Manavına hoş geldiniz!");
            Console.WriteLine("Elma = 2 TL.");
            Console.WriteLine("Armut = 3 TL.");
            Console.WriteLine("Çilek = 2 TL.");
            Console.WriteLine("Muz = 3 TL.");
            Console.WriteLine("Diğer bütün meyveler = 4 TL.");

            // Kullanıcıya hangi meyveyi alacağı sorulacak
            Console.WriteLine("\nHangi meyveyi almak istersiniz?");
            string meyve = Console.ReadLine().ToLower(System.Globalization.CultureInfo.CurrentCulture); // Büyük harfi  küçük harfe dönüştürme

            //Fiyat belirleme

            int Fiyat ;

            switch (meyve)
            {

                case "elma":
                case "çilek":
                    Fiyat = 2;
                    break;

                case "armut":
                case "muz":
                    Fiyat = 3;
                    break;

                default:
                    Fiyat = 4;
                    break;
            }

            //Sonuç ekranı

            Console.WriteLine($"Seçtiğiniz {meyve} meyvesinin fiyatı {Fiyat} TL'dir.");
           

        }


    }
}