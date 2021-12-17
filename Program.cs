using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, resultado;

            Console.WriteLine("Digite um número para a Tabuada");
            numero = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine();

            for (int x = 0; x <= 10; x++)
            {
                resultado = numero * x;
                Console.WriteLine($"{x} * {numero}  = {resultado}");
            }
            Console.ReadLine();
        }
    }
}
