using System;

namespace ExperimentalApp
{
    class Program
    {
        static void Main()
        {
            /*int x = 10;
            int y = 20;
            double z;

            z = x + y;
            Console.WriteLine("Please");
            Console.WriteLine(z);
            Console.WriteLine("please "+z);
            Console.WriteLine();*/

            Console.WriteLine("Input a 1, 2, or 3:");
            SelectionTest(int.Parse(Console.ReadLine()));
        }

        static void SelectionTest(int selector){
            if(selector == 1){
                Console.WriteLine("You've Chosen Poorly");
                Main();
            }
            else if (selector == 2){
                Console.WriteLine("You've Chosen Very Poorly");
                Main();
            }            
            else if (selector == 3){
                Console.WriteLine("You've Chosen Wisely. Congrats");
            }
            else
            {
                Console.WriteLine("You chose so very poorly. I can't believe you've done this. Try again.");
                Main();
            }
        }
    }
}