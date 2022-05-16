using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleExemplo03
{
    
    class TipoFloat
    {

        static void Linha()
        {

            for (int linha = 1; linha <= 40; linha += 1)
            {

                Console.Write("-");

            }

        }
        static void Main(string[] args)
        {

            int x = 3;
            float y = 4.5F;
            short z = 5;
            Linha();
            Console.WriteLine("\nO Resultado :{0}", x * y / z);
            Linha();
            Console.Write("\n\nPressione qualquer tecla...\n\n");
            Linha();
            Console.ReadKey();

        }        

    }

}