using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleExemplo06
{

    enum Dias
    {
        Domingo=1,
        Segunda,
        Terça,
        Quarta,
        Quinta,
        Sexta,
        Sábado,
    }

    class TipoEnum
    {

        static void Linha()
        {

            for(int linha = 1; linha <= 40; linha += 1)
            {

                Console.Write("-");

            }

        }

        static void LinhaSaida()
        {
            Console.WriteLine();
            for (int linha = 1; linha <= 40; linha += 1)
            {

                Console.Write("-");

            }
            Console.SetCursorPosition(2, 5);
            Console.Write("O dia da semana :");
            Console.SetCursorPosition(22, 5);

        }

        static void Main(string[] args)
        {

            int d = 0;
            Console.Clear();
            Linha();
            Console.SetCursorPosition(9, 1);
            Console.Write("Tipo enumerados = C#\n");
            Linha();
            try
            {
                Console.SetCursorPosition(2, 3);
                Console.Write("Digite um número entre 1-7 : ");
                Console.SetCursorPosition(31, 3);
                d = int.Parse(Console.ReadLine());
                Linha();
                Console.SetCursorPosition(2, 5);

                switch (d)
                {

                    case 1:
                        LinhaSaida();
                        Console.Write(Dias.Domingo);
                        break;
                    case 2:
                        LinhaSaida();
                        Console.Write(Dias.Segunda + " Feira");
                        break;
                    case 3:
                        LinhaSaida();
                        Console.Write(Dias.Terça + " Feira");
                        break;
                    case 4:
                        LinhaSaida();
                        Console.Write(Dias.Quarta + " Feira");
                        break;
                    case 5:
                        LinhaSaida();
                        Console.Write(Dias.Quinta + " Feira");
                        break;
                    case 6:
                        LinhaSaida();
                        Console.Write(Dias.Sexta + " Feira");
                        break;
                    case 7:
                        LinhaSaida();
                        Console.Write(Dias.Sábado);
                        break;
                    default:
                        LinhaSaida();
                        Console.Write("Entrada inválida");
                        break;

                }

            }
            catch (Exception)
            {
                Linha();
                Console.SetCursorPosition(2, 5);
                Console.Write("Erro nos dados tente novamente!!\n");
                Linha();
            }
            finally
            {
                Console.Write("\n\nPressione qualquer tecla ....\n\n");
                Linha();
                Console.ReadKey();

            }

        }

    }

}
