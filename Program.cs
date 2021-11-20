using System;

namespace tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero, resultado;
           
            Console.WriteLine(" digite um numero para cont");
            numero = Convert.ToUInt16(Console.ReadLine());
            Console.WriteLine();

            for (int x = 0; x <= 10; x++)
             {
                  resultado = numero * x;
                  Console.WriteLine(x+" * "+numero+" = "+resultado);

                Console.ReadLine();
             }



        }
    }
}
