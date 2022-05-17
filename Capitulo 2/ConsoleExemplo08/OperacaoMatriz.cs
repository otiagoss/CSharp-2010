using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleExemplo08
{

    class OperacaoMatriz
    {
        public static void Linha()
        {

            int j = 1;
            do
            {
                Console.Write("=");
                j++;
                
            } while (j <= 50);


        }

        static void Main(string[] args)
        {

            int[] numero = new int[5];
            int col = 17;
            Console.Clear();
            try
            {

                Console.Clear();
                Linha();
                Console.SetCursorPosition(15, 1);
                Console.Write("Aplicação com Matriz");
                Console.WriteLine();
                Linha();
                Console.WriteLine("\nDigite 5 numeros: ");
                Linha();

                for (int i = 0; i <= 4; i += 1)
                {

                    Console.SetCursorPosition(col, 3);
                    numero[i] = int.Parse(Console.ReadLine());
                    col += 5;

                }
                Console.WriteLine();
                Console.SetCursorPosition(0, 5);
                Console.Write("Os valores multiplicados por 2 : ");
                Console.SetCursorPosition(33,5);
                for (int j = 0; j <= 4; j++)
                {
                    numero[j] = numero[j] * 2;
                    Console.Write(numero[j].ToString()+ " ");

                }
                Console.WriteLine();
                Linha();

            }
            catch (Exception)
            {

                Console.WriteLine("Dados inválidos !!");

            }
            finally
            {
                
                Console.Write("\nPressiona qualquer tecla ....\n");
                Linha();
                Console.ReadKey();

            }

        }

    }

}