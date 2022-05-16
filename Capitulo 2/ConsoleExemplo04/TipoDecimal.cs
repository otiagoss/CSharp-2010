using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleExemplo04
{
    class TipoDecimal
    {
        static void Linha()
        {

            for (int linha = 0; linha <= 30; linha+=1)
            {

                Console.Write("-");

            }         

        }
        static void Main(string[] args)
        {

            decimal d = 9.1m;
            int y = 3;
            Linha();
            Console.SetCursorPosition(8, 1);
            Console.Write("Tipo decimal em C#\n");
            Linha();
            Console.WriteLine("\nO Resultado : {0}", (d+y));
            Linha();
            Console.Write("\n\nPressione qualquer tecla ...\n\n");
            Linha();
            Console.ReadKey();

        }        

    }

}
