using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleExemplo11
{

    class OperadorLogico
    {

        public static void Linha()
        {

            for (int x = 0; x < 50; x++)
            {

                Console.Write("=");

            }

        }

        static void Main(string[] args)
        {
            //int a = 170, b = 270, c = 370, d = 470;
            int a = 100, b = 100, c = 100, d = 100;
            Console.Clear();
            Linha();
            Console.SetCursorPosition(15, 1);
            Console.WriteLine("Operadores lógicos - C#");
            Linha();
            Console.WriteLine("\nOs valores são: a = "+ a.ToString() + " b = " + b.ToString() + " c = "+ c.ToString() +" c = "+ c.ToString()+"\n");
            //Verifica o número Maior
            if (a > b && a > c && a > d)
            {

                Console.WriteLine("O maior númeoro é {0}" , a + " está na variável a\n");

            }
            if (b > a && b > c && b > d)
            {

                Console.WriteLine("O maior númeoro é {0}", b + " está na variável b\n");

            }
            if (c > a && c > b && b > d)
            {

                Console.WriteLine("O maior númeoro é {0}", c + " está na variável c\n");

            }
            if (d > a && d > b && d > c)
            {

                Console.WriteLine("O maior númeoro é {0}", d + " está na variável d\n");

            }
            //Verifica o número Menor
            if (a < b && a < c && a < d)
            {

                Console.WriteLine("O menor númeoro é {0}", a + " está na variável a\n");

            }
            if (b < a && b < c && b < d)
            {

                Console.WriteLine("O menor númeoro é {0}", b + " está na variável b\n");

            }
            if (c < a && c < b && b < d)
            {

                Console.WriteLine("O menor númeoro é {0}", c + " está na variável c\n");

            }
            if (d < a && d < b && d < c)
            {

                Console.WriteLine("O menor númeoro é {0}", d + " está na variável d\n");

            }
            //Verifica se são todo iguais
            if ( a == b && b == c && c == d && d == a)
            {
                Console.WriteLine("São iguais na sequência.");
            }
            Linha();
            Console.WriteLine("\nPressione qualquer tecla ..." +
                "");
            Linha();
            Console.ReadKey();
        }

    }
}

