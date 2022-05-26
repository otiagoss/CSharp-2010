using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleExemplo20
{

    class MinhaExcecao
    {

        static void Linha()
        {

            int l = 1;
            do
            {

                Console.Write("=");
                l += 1;

            } while (l <= 79);

        }
        
        static void Dado(int x)
        {

            if (x > 5)
            {

                throw new ArgumentOutOfRangeException();

            }
            else
            {

                Linha();
                Console.Write("\nO valor informado é válido!!!\n");
                Linha();

            }
        }

        static void Main (string[] args)
        {

            try
            {
                Int16 n = 0;
                string cabec = "Minha exceção - Throw em C#\n";
                int linha = cabec.Length;
                linha = (80 - linha) / 2;
                Linha();
                Console.SetCursorPosition(linha, 1);
                Console.Write(cabec);
                Linha();
                Console.WriteLine("\nDigite um número :");
                Console.SetCursorPosition(19,3);
                n = Convert.ToInt16(Console.ReadLine());
                Dado(n);
            }
            catch (FormatException ex)
            {
                Linha();
                Console.WriteLine("\n"+ex.Message+"\n\nO dado que digitou não corresponde" +
                    "" +
                    " ao número");
                Linha();

            }
            catch (Exception)
            {
                Linha();
                Console.SetCursorPosition(0,4);
                Console.Write("\nErro!!! O valor está fora do intervalo válido !!!\n");
                Linha();
            }
            finally
            {

                Console.WriteLine("\n Pressione qualquer tecla....");
                Linha();
                Console.ReadKey();

            }

        }

    }

}
