using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleExemplo18
{

    class EstruturaSwtich
    {

        public static void Linha()
        {
            for (int x = 1; x < 79; x+=1)
            {

                Console.Write("=");

            }

        }

        static void Main(string[] args)
        {

            Console.Clear();
            Linha();
            String cabecalho = "Estrutura Switch - C#\n";
            int linha = cabecalho.Length;
            linha = (80 - linha) / 2;
            Console.SetCursorPosition(linha, 1);
            Console.Write(cabecalho);
            Linha();
            Console.WriteLine("\nQual linguagem você programa? Escolha entre as opções de 1 a 6:");
            Linha();
            Console.WriteLine();
            Console.WriteLine("1 - C#");
            Console.WriteLine("2 - VB.Net");
            Console.WriteLine("3 - Java");
            Console.WriteLine("4 - Delphi");
            Console.WriteLine("5 - C/C++");
            Console.WriteLine("6 - Outras");
            Linha();
            try
            {
                Console.Write("\nOpção [ ]");
                Console.SetCursorPosition(7, 12);
                int op = int.Parse(Console.ReadLine());
                Linha();
                Console.WriteLine();
                switch (op)
                {
                    case 1: Console.WriteLine("Você programa em C#");
                        break;
                    case 2: Console.WriteLine("Você programa em VB");
                        break;
                    case 3: Console.WriteLine("Você programa em Java");
                        break;
                    case 4: Console.WriteLine("Você programa em Delphi");
                        break;
                    case 5: Console.WriteLine("Você programa em C/C++");
                        break;
                    case 6: Console.WriteLine("Você programa em outra linguagem");
                        break;
                    default: Console.WriteLine("Opção Invalida!!!");
                        break;
                }
                Linha();

            }
            catch (FormatException)
            {

                Linha();
                Console.WriteLine("\nDigite apenas números !!!");
                Linha();

            }
            finally
            {
                
                Console.ReadKey();

            }            

        }

    }

}
