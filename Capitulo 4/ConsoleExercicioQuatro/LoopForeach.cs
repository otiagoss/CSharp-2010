using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleExercicioDois
{

    class LoopDoWhile
    {

        public static void Linha()
        {

            int i = 0;
            do
            {

                Console.Write("=");
                i++;

            } while (i < 40);

        }

        public static void Main(string[] args)
        {

            Console.WriteLine("Todos os nomes da Matriz");
            Linha();
            string[] vetor = { "luis", "maite", "barbara", "Kadu", "Buck" };
            Console.WriteLine();
            foreach (string x in vetor)
            {
                Console.Write(x + ", ");
            }
            Console.WriteLine();
            Linha();
            Console.WriteLine();
            foreach (string x in vetor )
            {
                Console.Write(x.ToUpper()+", ");
            }
            Console.WriteLine();
            Linha();            
            Console.ReadKey();

        }

    }

}