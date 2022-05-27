using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleExemplo25
{

    class Loopfor
    {

        static void Main(string[] args)
        {

            Console.Clear();
            Linha line = new Linha();
            line.Montar();
            String cabec = "Laço de repetição - For";
            int lin = cabec.Length;
            lin = (80 - lin) / 2;
            Console.SetCursorPosition(lin, 1);
            Console.WriteLine(cabec);
            line.Montar();
            Console.WriteLine();            
            int p = 1;
            int n = 1;
            for (n = 1; n <= 200; n++)       
            {

                if (n < 10)
                {

                    Console.Write("00" + n + " ");

                }
                else if (n >= 10 && n < 100)
                {

                    Console.Write("0" + n + " ");

                }
                else
                {

                    Console.Write(n + " ");

                }               
                p++;
                if (p == 21)
                {

                    p = 1;
                    Console.WriteLine();

                }

            }
            line.Montar();
            Console.ReadKey();

        }

    }

}