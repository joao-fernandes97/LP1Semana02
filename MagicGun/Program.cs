using System;

namespace MagicGun
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Number of shots:");
            int n = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < n; i++)
            {
                if(i%3==0)
                {
                    Console.WriteLine("Magic Fire!");
                }else if(i%5==0)
                {
                    Console.WriteLine("Electric Fire!");
                }else
                {
                    Console.WriteLine("Normal fire :/");
                }
            }
        }
    }
}
