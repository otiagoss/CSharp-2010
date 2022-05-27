using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleExercicioUm
{

    class LoopWhile
    {

        public static void Linha()
        {

            int i = 0;
            while(i < 80 )
            {

                Console.Write("-");
                i++;
            }

        }

        public static void Main(string[] args)
        {

            Linha();
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("Digite um número: ");
            Console.SetCursorPosition(20, 1);
            int numero = int.Parse(Console.ReadLine());            
            Linha();
            Console.WriteLine();
            int n = 1;
            while (n <= 50)
            {

                Console.Write("{0} ", numero);
                numero += 1;
                n++;               

            }
            Console.WriteLine();
            Linha();
            Console.ReadKey();

        }

    }

}
