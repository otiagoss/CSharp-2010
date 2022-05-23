using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleExemplo10
{
    class OperadoRelaciona
    {
        public static void Linha()
        {

            for (int i = 0; i < 50; i+=1)
            {
                Console.Write("=");
            }

        }
        static void Main(string[] args)
        {

            short a = 30, b = 40, c = 60, d = 10;
            Console.Clear();
            Linha();
            Console.SetCursorPosition(08, 1);
            Console.Write("Operadores Relacionais\n");
            Linha();            
            Console.WriteLine("\nOs Valores são: a = " + a.ToString() + " b = " + b.ToString() + " c = " + c.ToString() + " d = " + d.ToString() +"\n");
            Linha();
            Console.WriteLine();
            if ( a == b ) 
            {

                Console.WriteLine("O valores de a e b são iguais\n");

            }
            if ( b >= d ) 
            {

                Console.WriteLine("O valor b é maior do que d\n");

            }
            if ( b <= c )
            {

                Console.WriteLine("O valor de b é menor que c\n");

            }
            if ( a != c )
            {

                Console.WriteLine("Os valores de a e c são diferentes\n");

            }
            Linha();
            Console.Write("\nPressione qualquer tecla ...\n");
            Linha();
            Console.ReadKey();

        }

    }

}
     