using System;

namespace dortgenAlanHesap
{
    class Program
    {
        static void Main(string[] args)
        {
    


            #region DataCasting
            //konsol üzerinden küçük kenarı ve büyük kenarı girilen bir dikdörtgenin çevresini hesaplayan uygulamayı yazınız.

            Console.WriteLine("uzun kenarı giriniz");
            string uzunKenar = Console.ReadLine();


            Console.WriteLine("kısa kenarı giriniz");
            string kisaKenar = Console.ReadLine();
            //int x = Convert.ToInt32(uzunKenar); ToInt64=float ToInt16=Short ToInt32=Int
            // int x = int.Parse(uzunKenar);
            // int y = int.Parse(kisaKenar);
            double x = double.Parse(uzunKenar);
            double y = double.Parse(kisaKenar);
            double alan = x * y;
            Console.WriteLine(alan);


            #endregion
        }
    }
}
