using System;

namespace numberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
        
        
        
         Console.WriteLine("Bir sayi tutun ve enter'a basın");
            Console.ReadLine();


            Console.WriteLine("Tuttugunuz sayiyi iki ile carp ve entera bas");
            Console.ReadLine();

            Console.WriteLine("Buldugun sonucu belirledigin ikinci bir sayi ile topla ve bu ikinci sayiyi ekrana yaz, enterla.");
            double number = Convert.ToDouble(Console.ReadLine());
            
            Console.WriteLine("Buldugun sonucu ikiye bol ve entera bas");
            Console.ReadLine();
            
            Console.WriteLine("Buldugun sonuctan ilk tuttugun sayiyi cikar ve entera bas");
            Console.ReadLine();
            
            string tahmin = (number / 2).ToString();
            
            Console.WriteLine("Tahmin ediyorum, buldugun sayi ="+tahmin+"mi/mu?");
            Console.ReadLine();


          
          
        }
    }
}
