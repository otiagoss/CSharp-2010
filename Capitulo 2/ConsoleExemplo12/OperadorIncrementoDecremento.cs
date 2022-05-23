using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleExemplo12
{

    class OperadorIncrementoDecremento
    {
        static void Main(string[] args)
        {

            int c = 1;

            Console.Clear();
            Linha();
            Console.SetCursorPosition(10,1);
            Console.WriteLine("Operador de Incremento e Decremento -  C#");
            Linha();
            Console.Write("\n");           
            for (; c <= 20; c++)
            {

                if (c == 11)
                {
                    Console.WriteLine("\n");
                }
                if (c <= 9)
                {
                    Console.Write("0" + c + " ");
                }                
                else
                {
                    Console.Write(c + " ");
                }
                
            }
            Console.WriteLine("");
            Linha();
            Console.WriteLine("");
            for (int j = 20; j >= 1; j--)
            {

                if (j == 10)
                {
                    Console.WriteLine("\n");
                }
                if (j <= 9)
                {
                    Console.Write("0" + j + " ");
                }
                else
                {
                    Console.Write(j + " ");
                }

            }
            Console.WriteLine("");
            Linha();
            Console.Write("\nPressione qualquer tecla....\n");
            Linha();
            Console.ReadKey();

        }
        public static void Linha()
        {
            for (int i = 0; i < 60; i++)
            {
                Console.Write("-");
            }
            
        }
    }

}

