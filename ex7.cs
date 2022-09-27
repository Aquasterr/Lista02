using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    /* Crie um programa que leia 6 valores inteiros e, em seguida, mostre na tela os
    valores lidos na ordem inversa. 
    */
    class Exercicio1
    {
        static void Main(string[] args)
        {
            int[] v = new int[6];

            for (int i = 0; i < 6; i++)
            {
                Console.WriteLine("Digite um numero: ");
                v[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Imprime invertido: ");
            for (int i = 5; i >= 0; i--)
            {
                Console.WriteLine(v[i]);
            }
        }
    }
}
