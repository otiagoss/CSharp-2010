using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleExercicioTres
{

    class LoopFor
    {

        public static void Linha()
        {

            
            for(int i = 0; i <= 80; i ++)
            {

                Console.Write("-");
            
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
            for (; n <= 50; n++)
            {

                Console.Write("{0} ", numero);
                numero += 1;
                

            } 
            Console.WriteLine();
            Linha();
            Console.ReadKey();

        }

    }

}
