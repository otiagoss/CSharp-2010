using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleExemplo05
{

    class TipoDouble
    {
        static void Linha()
        { 
        
            for(int linha = 1; linha <= 30; linha += 1)
            {

                Console.Write("-");

            }

        }

        static void Main(string[] args)
        {

            int x = 3;
            float y = 4.5f;
            short z = 5;
            double w = 1.7E+3;
            Linha();
            Console.SetCursorPosition(8, 1);
            Console.Write("Tipo souble em C#\n");
            Linha();
            Console.Write("\nO Resultado :{0}", x + y + z + w +"\n");
            Linha();
            Console.Write("\n\nPressione qualquer tecla.... \n\n");
            Linha();
            Console.ReadKey();

        }

    }

}

