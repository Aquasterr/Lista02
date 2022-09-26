using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    /*a) média da idade do grupo;
    b) média da altura das mulheres;
    c) média da idade dos homens;
    d) percentual de pessoas com idade entre 18 e 35 anos (inclusive).
     */
    class Exercicio1
    {
        static void Main(string[] args)
        {
            int idadeF, idadeM;
            for (int i = 0; i < 1000; i++)
            {
                Console.WriteLine(" Informe o Sexo: \n");
                Console.WriteLine(" 0 - Feminino ");
                Console.WriteLine(" 1 - Masculino \n");

                int opc = int.Parse(Console.ReadLine());

                if (opc == 0)
                {
                    Console.WriteLine(" Informe a Idade: \n");
                    int idade = int.Parse(Console.ReadLine());
                }
                if (opc == 1)
                {

                }
            }

        }
    }
}
