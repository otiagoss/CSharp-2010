using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleExercicioParImpar
{

    class ParImpar
    {

       public static void Linha()
        {
            int l = 0;
            for (; l < 100; l += 1)
            {

                Console.Write("=");

            }            

        }

        static void Main(string[] args)
        {

            Console.Clear();
            Linha();
            String cabec = "Verificação de números";            
            int linha = cabec.Length;
            linha = (100 - linha) / 2;
            Console.SetCursorPosition(linha, 1);
            Console.Write(cabec);
            Console.WriteLine();
            Linha();
            Console.SetCursorPosition(1,3);
            Console.WriteLine("Digite um número :");
            try
            {

                Linha();
                Console.SetCursorPosition(20, 3);
                int num = int.Parse(Console.ReadLine());                
                if (num % 2 == 0)
                {

                    Console.Write("\n O número {0} é um número PAR\n", num);    

                }
                else
                {

                    Console.Write("\n O número {0} é um número ÍMPAR\n", num);

                }
                Linha();

            }
            catch (Exception e)
            {
               
                Console.WriteLine("\n"+e.Message+"\n\n O dado digitado não está em um formato correto!!!");
                Linha();

            }
            finally
            {
                               
                Console.WriteLine("\nPressione qualquer tecla...");
                Linha();
                Console.ReadKey();

            }

        }

    }

}


