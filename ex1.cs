using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //Dados: 10 números digitados pelo usuário. 
    //Construa algoritmo para mostrar os valores negativos 
    //e que calcule e mostre a média dos valores menores que zero.
    class Program
    {
        static void Main(string[] args)
        {
            double num = 0, soma=0;
            int div=0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Digite um Numero ");
                num = double.Parse(Console.ReadLine());
                if (num < 0)
                {
                    soma = soma + num;
                    Console.WriteLine(num);
                    div++;
                }
            }
            Console.WriteLine(soma /div);
        }
    }
}
