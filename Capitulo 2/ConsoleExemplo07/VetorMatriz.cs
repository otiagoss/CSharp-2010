using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleExemplo07
{
    class VetorMatriz
    {
        static void Main(string[] args)
        {

            String[] array1 = new String[5];
            array1[0] = "João";
            array1[1] = "André";
            array1[2] = "Eduardo";
            array1[3] = "Gabriel";
            array1[4] = "Maitê";

            //Declara uma matriz unidimendional e atribui valores fixos
            int[] array2 = new int[] { 1, 3, 5, 7, 9 };

            //Declaração Alterantica para uma matriz unidimensional
            //com atribuição de valores fixos
            int[] array3 = { 1, 2, 3, 4, 5, 6 };

            //Declaração de uma matriz com duas dimensões
            int[,] multiDimensionalArray1 = new int[2, 3];
            multiDimensionalArray1[0, 0] = 10;
            multiDimensionalArray1[0, 1] = 20;
            multiDimensionalArray1[0, 2] = 30;
            multiDimensionalArray1[1, 0] = 40;
            multiDimensionalArray1[1, 1] = 50;
            multiDimensionalArray1[1, 2] = 60;

            //Declaração de uma matriz com duas dimensões
            // com atribuição de valores fixos
            int[,] multiDimensionalArray2 = { { 100, 200, 300 }, { 400, 500, 600 } };

            Console.WriteLine("Dados do array 1: ");
            
            for(int x = 0; x< 5; x++)
            {

                Console.Write(array1[x] + ", ");
                if (x == 4)
                {

                    Console.SetCursorPosition(36, 1);
                    Console.Write(".");

                }

            }

            Linha();
            Console.WriteLine("\nDados do array 2: ");
            foreach (int i in array2)
            {

                 Console.Write(i + " ");

            }

            Linha();
            Console.WriteLine("\nDados do array 3: ");
            foreach(int x in array3)
            {

                Console.Write(x + " ");

            }

            Linha();
            Console.WriteLine("\nDados do multiDimendionalArray1");
            foreach (int z in multiDimensionalArray1)
            {

                Console.Write(z + " ");

            }

            Linha();
            Console.WriteLine("\nDados do multiDimendionalArray2");
            foreach(int a in multiDimensionalArray2)
            {

                Console.Write(a + " ");

            }
            Linha();
            Console.ReadLine();
        }
        public static void Linha()
        {

            int x = 1;
            Console.WriteLine("\n");
            while (x <= 40)
            {
                Console.Write("=");
                x += 1;

            }

        }
    }

}