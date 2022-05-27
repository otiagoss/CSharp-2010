using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleExemplo23
{

    class LoopWhile
    {

        static void Main(string[] args)
        {
            Console.Clear();
            Linha line = new Linha();
            line.Montar();
            String cabec = "Laço de repetição - While";
            int lin = cabec.Length;
            lin = (80 - lin) / 2;
            Console.SetCursorPosition(lin, 1);
            Console.WriteLine(cabec);
            line.Montar();
            Console.WriteLine();
            int i = 1;
            int p = 1;
            while(i <= 200)
            {
                
                if (i <= 9)
                {

                    Console.Write("00" + i + " ");

                }
                else if (i >= 9 && i <= 99)
                {

                    Console.Write("0" + i + " ");

                }
                else
                {

                    Console.Write(i + " ");

                }
                i++;
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


