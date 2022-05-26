using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleExemplo16
{

    class EstrutraEncadeada
    {
        public static void Linha()
        {

            for(int i = 0; i < 50; i++)
            {

                Console.Write("=");

            }

        }

        static void Main(string[] args)
        {

            int num;
            Console.Clear();
            Linha();
            Console.SetCursorPosition(15, 1);
            Console.WriteLine("Estrutra Encadeada - C#");
            Linha();
            Console.SetCursorPosition(0, 3);
            Console.WriteLine("Digite um número: ");           

            try
            {
                Console.SetCursorPosition(20, 3);
                num = int.Parse(Console.ReadLine());
                String msg1 = "O número digitado é menor que 100.";
                String msg2 = "O número digitado é maior que 100.";
                String msg3 = "O número digitado é igual a 100.";
                Linha();
                if (num < 100)
                {

                    Console.WriteLine("\n" + msg1);

                }
                if (num > 100)
                {

                    Console.WriteLine("\n" + msg2);

                }
                if (num == 100)
                {

                    Console.WriteLine("\n" + msg3);

                }

            }
            catch(Exception)
            {

                Linha();
                Console.WriteLine("\nO dado digitado é inválido!!!");

            }
            finally
            {

                Linha();
                Console.WriteLine("\n Pressione qualquer tecla...");
                Linha();
                Console.ReadKey();

            }

        }

    }

}


