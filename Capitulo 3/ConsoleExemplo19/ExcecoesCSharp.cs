using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleExemplo19
{

    class ExcecoesCSharp
    {

        public static void Linha()
        {

            int l = 0;
            do
            {

                Console.Write("=");
                l += 1;

            } while (l <= 50);

        }

        static void Main(string[] args)
        {
            int x, y;
            Console.Clear();
            Linha();
            try
            {

                Console.SetCursorPosition(8, 1);
                Console.Write("Tratamendo de Exceção em C#\n");
                Linha();
                Console.SetCursorPosition(1, 3);
                Console.Write("Digite o 1º número: ");
                Console.SetCursorPosition(20, 3);
                x = int.Parse(Console.ReadLine());
                Console.SetCursorPosition(1, 4);
                Console.Write("Digite o 2º número: ");
                Console.SetCursorPosition(20, 4);
                y = int.Parse(Console.ReadLine());
                Linha();
                Console.Write("\nO Resultado da divisão : {0}\n", (x / y));
                Linha();

            }
            catch (DivideByZeroException)
            {

                
                Console.WriteLine("\nErro .... divisão por zero !");
                Linha();

            }
            catch (Exception)
            {

                Linha();


                Console.WriteLine("\nDigite apenas números !!!");
                Linha();

            }
            finally
            {

                Console.WriteLine("\nPressione qualquer tecla");
                Linha();
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("*********** FIM DE EXECUÇÃO **********");
                Console.ReadKey();

            }

        }

    }

}