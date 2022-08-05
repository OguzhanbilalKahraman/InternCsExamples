using System;

  namespace tryCatch
  {
    class Program
    {
        static void Main(string[] args)
        {

       
       
       
       
       
       try
            {

                Console.WriteLine("Birinci sayiyi giriniz:");
                int number1 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("İkinci sayiyi giriniz:");
                int number2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine(number1 + number2);
            }


            catch (FormatException)
            {
                Console.WriteLine("sayi= 1 2 3 4 5 6 7 8 9 falan girmen lazım sacmalama");

            }
            catch (Exception text)
            {
                Console.WriteLine(text.Message); 
              /* that codes are showing us what is going wrong. */
            
            }
            
            
      }
    }
}
