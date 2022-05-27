using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleExemplo27
{

    class loopForeach
    {

        static void Main(string[] args)
        {
                        
            Console.Clear();
            Linha line = new Linha();
            line.Montar();
            String cabec = "Estrutura foreach - Foreach";
            int lin = cabec.Length;
            lin = (80 - lin) / 2;
            Console.SetCursorPosition(lin, 1);
            Console.WriteLine(cabec);
            line.Montar();
            Console.WriteLine("\nDigite 10 números:");
            line.Montar();
            //método construtor da classe Declara para acess público dos atributos
            Declara va = new Declara();            
            try
            {
                //Rotina para carrregar a matriz
                for (va.i = 0; va.i < 10; va.i += 1)
                {

                    Console.SetCursorPosition(va.col + 20, 3);
                    va.numero[va.i] = int.Parse(Console.ReadLine());
                    va.col += 3;

                }
                //Rotina para varrer a matriz e exibir os dados digitados
                Console.SetCursorPosition(0, 6);
                line.Montar();
                va.col = 26;
                Console.SetCursorPosition(0, 5);
                Console.WriteLine("Os dados da Matriz são: ");
                Console.SetCursorPosition(va.col, 5);
                foreach(int x in va.numero)
                {
                    va.col += 3;
                    Console.WriteLine(x.ToString());
                    Console.SetCursorPosition(va.col, 5);

                }
            }
            catch (Exception ex)
            {

                Console.SetCursorPosition(0, 5);
                Console.WriteLine("Messagem :");
                Console.SetCursorPosition(11,5);
                Console.WriteLine(ex.Message);
                line.Montar();

            }
            finally
            {

                Console.WriteLine("\n\nPressione qualquer tecla....");
                line.Montar();
                Console.ReadKey();

            }

        }

    }

}