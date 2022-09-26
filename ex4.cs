using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        /*a) média da idade do grupo;
        b) média da altura das mulheres;
        c) média da idade dos homens;
        d) percentual de pessoas com idade entre 18 e 35 anos (inclusive).
        */
        static void Main(string[] args)
        {
            int homem = 0, mulher = 0, idadeF = 0, idadeM = 0, idadeP = 0;
            double alturaF = 0, alturaM = 0;
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine(" Informe o Sexo: \n");
                Console.WriteLine(" 0 - Feminino ");
                Console.WriteLine(" 1 - Masculino \n");

                int opc = int.Parse(Console.ReadLine());

                if (opc == 0)
                {
                    mulher++;
                    Console.WriteLine(" Informe a Idade: \n");
                    int idade = int.Parse(Console.ReadLine());
                    if (idade > 17 && idade < 36) { idadeP++; }
                    idadeF += idade;

                    Console.WriteLine(" Informe a Altura: \n");
                    double altura = double.Parse(Console.ReadLine());
                    alturaF += altura;


                }
                if (opc == 1)
                {
                    homem++;
                    Console.WriteLine(" Informe a Idade: \n");
                    int idade = int.Parse(Console.ReadLine());
                    if (idade > 17 && idade < 36) { idadeP++; }
                    idadeM += idade;

                    Console.WriteLine(" Informe a Altura: \n");
                    double altura = double.Parse(Console.ReadLine());
                    alturaM += altura;
                }
            }
            double mediaIdadeG, mediaAlturaF, mediaIdadeM;

            mediaIdadeG = idadeF + idadeM / 4;
            Console.WriteLine("Média da idade do grupo: " + mediaIdadeG);

            mediaAlturaF = alturaF / mulher;
            Console.WriteLine("Média de altura das mulheres: " + mediaAlturaF);

            mediaIdadeM = idadeM / homem;
            Console.WriteLine("Média da idade dos homens: " + mediaAlturaF);

            double percentual = (idadeP / 4) / 100;
            Console.WriteLine(idadeP);
            Console.WriteLine("Percentual de pessoas com idade entre 18 e 35 anos: " + percentual);
        }
    }
}
