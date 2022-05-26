using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleExmplo15
{

    class EstruturaCompostaElse
    {
        public static void Linha()
        {
            string c = "=";
            int x = 0;
            for(; x < 40; x+=1)
            {
                Console.Write(c);
            }
        }

        static void Main(string[] args)
        {
            int valor;
            Console.Clear();
            Linha();
            Console.SetCursorPosition(10,1);
            Console.WriteLine("Estrutura Composta - C#");
            Linha();
            Console.WriteLine("\nDigite um número: ");
            Linha();
            Console.SetCursorPosition(20, 3);
            try
            {      
                
                valor = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(0, 5);
                if (valor > 100)
                {

                    Console.WriteLine("Verdadeiro");

                }
                else
                {

                    Console.WriteLine("Falso");

                }

            }
            catch (Exception)
            {
                Console.WriteLine("\nDados digitados estão incorretos");
                Linha();
                Console.ReadLine();
            }
            finally
            {
                Linha();
                Console.WriteLine("\n Pressione qualquer tecla ....");
                Linha();
                Console.ReadKey();
            }
        }

    }

}
