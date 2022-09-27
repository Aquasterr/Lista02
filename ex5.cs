using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    /* 
    */
    class Exercicio1
    {
        static void Main(string[] args)
        {
            int[] num = new int[10], quadrado = new int[10];

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Digite um valor real: ");
                num[i] = int.Parse(Console.ReadLine());

                quadrado[i] = num[i] * num[i];
                Console.WriteLine("{0} e o seu quadrado é: {1}", num[i], quadrado[i]);
            }
        }
    }
}
