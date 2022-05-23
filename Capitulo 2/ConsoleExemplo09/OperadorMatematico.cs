using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleExemplo09
{
    class OperadorMatematico
    {
        public static void Linha()
        {
            int i = 1;
            do
            {
                Console.Write("=");
                i++;
            } while (i <= 50);

        }
        static void Main(string[] args)
        {

            float a = 4.5F;
            float b = 5.5F;
            Console.Clear();
            Linha();
            Console.SetCursorPosition(10, 1);
            Console.Write("Operadores Aritméticos\n");
            Linha();
            Console.Write("\nOs valores para operação são : {0}", a + " e " + b + "\n");
            Console.WriteLine("\nA Soma dos valores : {0}", a + b );
            Console.WriteLine("\nA Diferença dos valores : {0}", a - b);
            Console.WriteLine("\nO Produto dos valores : {0}", a * b);
            Console.WriteLine("\nA Divisão dos valores : {0}", a / b);
            Console.WriteLine("\nO Resto da divisão inteira de : " + a + " é {0}", a % 2 );
            Console.WriteLine("\nO Resto da divisão inteira de : " + b + " é {0}", b % 2);
            Linha();
            Console.Write("\nPressione qualeure tecla para continuar.....\n");
            Linha();
            Console.ReadKey();
;

        }

    }

}
