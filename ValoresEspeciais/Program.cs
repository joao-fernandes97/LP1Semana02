using System;

namespace ValoresEspeciais
{
    class Program
    {
        static void Main(string[] args)
        {
            //Signed whole number types
            Console.WriteLine(sbyte.MaxValue);
            Console.WriteLine(sbyte.MinValue);

            Console.WriteLine(short.MaxValue);
            Console.WriteLine(short.MinValue);

            Console.WriteLine(int.MaxValue);
            Console.WriteLine(int.MinValue);

            Console.WriteLine(long.MaxValue);
            Console.WriteLine(long.MinValue);

            //Unsigned whole number types
            Console.WriteLine(byte.MaxValue);
            Console.WriteLine(byte.MinValue);

            Console.WriteLine(ushort.MaxValue);
            Console.WriteLine(ushort.MinValue);

            Console.WriteLine(uint.MaxValue);
            Console.WriteLine(uint.MinValue);

            Console.WriteLine(ulong.MaxValue);
            Console.WriteLine(ulong.MinValue);

            //Floating point numbers
            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            //Special Values
            Console.WriteLine(double.PositiveInfinity);
            Console.WriteLine(double.NegativeInfinity);
            Console.WriteLine(float.NaN);

            //uint overflow
            uint ui = uint.MaxValue;
            Console.WriteLine($"{ui} +1 = {ui+1}");

            //float overflow
            float fmax = float.MaxValue;
            Console.WriteLine($"{fmax} +1 = {fmax+1}");
            Console.WriteLine($"{fmax} *2 = {fmax*2}");

            //float underflow
            float f1, f2;
            f1 = f2 = 10000.0f;
            Console.WriteLine(f1 == f2 + 0.000001f);
        }
    }
}
