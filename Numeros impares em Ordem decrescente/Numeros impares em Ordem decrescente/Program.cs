using System;

namespace Numeros_impares_em_Ordem_decrescente
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Números impares\n\n");
            Console.WriteLine("Aperte enter pra continuar");
            Console.ReadKey();
            int a, b, x, y;

            Console.Write("Digite um valor: ");
            x = int.Parse(Console.ReadLine());
            Console.Write("Digite outro valor: ");
            y = int.Parse(Console.ReadLine());

            if(x >= y)
            {
                a = x;
            }
            else
            {
                a = y;
            }
            if (x <= y)
            {
                b = x;
            }
            else
            {
                b = y;
            }
            Console.WriteLine("\n");
            for (int i = a; i > b; i--)
            {
                if (i % 2 != 0)
                {
                    Console.WriteLine(+i);
                }
            }
            Console.ReadKey();
        }
    }
}
