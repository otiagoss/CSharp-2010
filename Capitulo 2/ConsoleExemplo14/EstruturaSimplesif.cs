using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace ConsoleExemplo04
{

    class EstruturaSimplesif
    {

        public static void Linha()
        {
            string l = "=";
            for(int i = 0; i  < 60; i++)
            {
                Console.Write(l);
            }
        }
        static void Main(string[] args)
        {

            Console.Clear();
            int num = 0;
            try
            {

                Linha();                
                Console.SetCursorPosition(10, 1);
                Console.WriteLine("Estrutura Simples - C#");
                Linha();
                Console.WriteLine("\nDigite o número : ");
                Linha();
                Console.SetCursorPosition(17, 3);
                num = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(0,5);
                if (num >= 100)
                {

                    Console.WriteLine("Verdadeiro");

                }
                if (num < 100)
                {

                    Console.WriteLine("Falso");

                }

            }
            catch (FormatException erro)
            {

                Console.SetCursorPosition(0, 5);
                Console.WriteLine(erro.Message);

            }
            finally
            {

                Linha();
                Console.WriteLine("\nPressione qualquer tecla...");
                Linha();
                Console.ReadKey();

            }
            
        }

    }
}