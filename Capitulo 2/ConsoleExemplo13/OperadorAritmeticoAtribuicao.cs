using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleExemplo13
{

    class OperadorAritmeticoAtribuicao
    {
        
        public static void Linha()
        {
            for( int i = 0; i <= 60; i++)
            {
                Console.Write("=");
            }
        }

        static void Main(string[] args)
        {
            double a;
            Console.Clear();
            Console.SetCursorPosition(8,0);            
            Console.Write("" +
                " Operadores Aritméticos de Atribuição - C#\n");
            Linha();
            Console.SetCursorPosition(1,2);
            Console.WriteLine("Digite um número qualquer: ");
            Linha();
            try
            {                
                Console.SetCursorPosition(29, 2);
                a = double.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("A soma dos números : {0}", a += 10);
                Console.WriteLine("A diferença dos números : {0}", a -= 10);
                Console.WriteLine("O produto dos números : {0}", a *= 10);
                Console.WriteLine("A divisão dos números : {0}", a /= 10);
                Linha();
            }
            catch (Exception)
            {
                Console.WriteLine();
                Console.WriteLine("Digite apenas números !!!");
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

