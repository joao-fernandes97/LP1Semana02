using System;

namespace SmoothOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Insere numero nao-negativo:" );
            string str = Console.ReadLine();
            byte n = byte.Parse(str);
            Console.WriteLine(--n);
            Console.WriteLine(++n);

            Console.WriteLine(n/2);
            Console.WriteLine(n<<3);
            Console.WriteLine(n^5);
            Console.WriteLine(n>10);
        }
    }
}
