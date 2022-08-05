using System;

namespace manav
{
    class Program
    {
        static void Main(string[] args)
        {
            //manav elma=1, armut=1, çilek=2, muz=3, kivi=5

            try
            {
                Console.WriteLine("Hangi meyveyi istiyorsun:?");
                string meyve = Console.ReadLine();

                Console.WriteLine("kaç adet istiyorsun:?");
                int adet = Convert.ToInt32(Console.ReadLine());

                int toplam;

                switch (meyve)
                {
                    case "elma":
                        Console.WriteLine("elma 1 lira");
                        toplam = adet * 1;
                        break;
                    case "armut":
                        Console.WriteLine("armut 1 lira");
                        toplam = adet * 1;
                        break;
                    case "cilek":
                        Console.WriteLine("cilek 2 lira ");
                        toplam = adet * 2;
                        break;

                    case "muz":
                        Console.WriteLine("muz 3 lira");
                        toplam = adet * 3;
                        break;

                    default:
                        Console.WriteLine("kivi 5 lira");
                       
                        toplam = adet * 5;
                        break;
                }
                if (adet >= 3)
                {
                    Console.WriteLine(toplam+"Lira");
                }
                else
                {
                    Console.WriteLine("getirme ucreti 3 lira");
                    Console.WriteLine(toplam+3+"Lira");
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Lutfen adet girerken sayi, meyveyi secerken yazi giriniz.");
                
           

        }
    }
}
