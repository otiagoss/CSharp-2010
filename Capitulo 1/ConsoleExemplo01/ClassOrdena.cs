using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleExemplo01
{
    class ClassOrdena
    {

        private int a, b, c, aux;

        public int organizar()
        {
            Console.Clear();
            Console.WriteLine("Digite 3 numeros quaisquer");
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
            //Ordenando os valores
            if (a > b) 
            { 
                aux = a; 
                a = b; 
                b = aux; 

            }
            if (a > c)
            {
                aux = a;
                a = c;
                c = aux;

            }
            if (b > c)
            {
                aux = b;
                b = c;
                c = aux;

            }
            //Exibindo os dados
            Console.Write("Os numeros ordenados : "+ a.ToString() +" "+ b.ToString() +" "+ c.ToString());
            return 0;


        }
    }
}
