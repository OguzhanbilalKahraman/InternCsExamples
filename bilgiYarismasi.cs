using System;

namespace bilgiYarismasi
{
    class Program
    {
        static void Main(string[] args)
        {
         /* 
             
                  Question 1) which one is the spit When it was get angry ? 
                    a)lama
                    b)camel

                  Q-2) which is the closest planet to earth?
                    a)Venus
                    b)Mars

                  Q-3) 5 * 2 + 8 / 2 - 2 = ?
                    a)7
                    b)12

             
             */
                Console.WriteLine("Welcome to the Bank OF Value Program. If u can answer the at least 2 questions correctly U WILL WIN. GOOD LUCK! :)");

                Console.WriteLine(" which one is the spit When it was get angry?  (lama/camel)");
                string answer1 = Console.ReadLine();

                Console.WriteLine("which is the closest planet to earth?  (jupiter/mars) ");
                string answer2 = Console.ReadLine();

                Console.WriteLine(" 5 * 2 + 8  / 2 - 2 = ?  (12/7)  ");
                int answer3 = Convert.ToInt32(Console.ReadLine());


            if (answer1=="lama" && answer2=="jupiter" && answer3==12) //1-3 correct
            {
                Console.WriteLine("WINNER WINNER CHICKEN DINNER");

            }
            else if (answer1=="lama" && answer2=="mars" && answer3==7) // 1-2 correct
            {
                Console.WriteLine("WINNER WINNER CHICKEN DINNER");

            }
            else if (answer1=="camel" && answer2=="mars" && answer3==12) // 2-3 correct
            {
                Console.WriteLine("WINNER WINNER CHICKEN DINNER");

            }
            else if (answer1=="lama" && answer2 == "mars" && answer3==12 )  // all correct
            {

                Console.WriteLine("WINNER WINNER CHICKEN DINNER");

            }
            else
            {
                Console.WriteLine("sorry, COME AGAIN");
            }


        }
    }
}
