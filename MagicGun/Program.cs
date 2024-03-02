using System;

namespace MagicGun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of shots:");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 1; i <= n; i++)
            {
                Console.Write($"{i}: ");
                if(i%3==0)
                {
                    Console.Write("Magic Fire! ");
                }if(i%5==0)
                {
                    Console.Write("Electric Fire!");
                }if(i%3!=0&&i%5!=0)
                {
                    Console.Write("Normal fire :/");
                }
                Console.Write("\n");
            }
        }
    }
}
