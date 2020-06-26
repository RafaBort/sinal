using System;

namespace sinal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("digite um número:");
            String  sinal = Console.ReadLine();
            Decimal Sinal2 = Convert.ToDecimal(sinal);
            Console.WriteLine(Math.Sign(Sinal2));

            Console.WriteLine("se for 1 o número é positivo");
            Console.WriteLine("se for -1 o número é negativo");
            Console.WriteLine("se for 0 o número é nulo, é zero");

        }
    }
}
