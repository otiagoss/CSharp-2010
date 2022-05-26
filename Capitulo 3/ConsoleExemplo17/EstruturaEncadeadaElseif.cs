using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleExemplo17
{

    class EstruturaEncadeadaElseif
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

            int x;
            String msg1 = "O número digitado é menor que 100.";
            String msg2 = "O número digitado é maior que 100.";
            String msg3 = "O número digitado é igual a 100.";
            Console.Clear();
            Linha();
            Console.SetCursorPosition(10, 1);
            Console.Write("Estrutura else if - C#\n");
            Linha();
            Console.WriteLine("\nDigite um número :");            
            try
            {
                Console.SetCursorPosition(20, 3);
                x = int.Parse(Console.ReadLine());
                Linha();
                if (x < 100)
                {
                    
                    Console.WriteLine("\n"+msg1);

                }
                else if (x > 100)
                {

                    Console.WriteLine("\n" + msg2);

                }
                else if (x == 100)
                {

                    Console.WriteLine("\n" + msg3);

                }

            }
            catch(Exception)
            {

                Linha();
                Console.WriteLine("\n O dado digitado é invalido!!!");
                
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
