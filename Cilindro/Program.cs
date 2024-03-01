using System;

namespace Cilindro
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Altura do cilindro:");
            string height = Console.ReadLine();
            float a = float.Parse(height);

            Console.Write("Raio do cilindro:");
            string radius = Console.ReadLine();
            float r = float.Parse(radius);
            
            float vol= MathF.PI*MathF.Pow(r,2)*a;
            Console.WriteLine(vol);
        }
    }
}
