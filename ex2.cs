using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program
{
    /*Numa danceteria, numa noite, estiveram 150 clientes, desses, muitos pagaram suas 
	contas com cheque, cartão de credito e cédulas. Construa algoritmo para somar o total 
	de valores pagos em cédulas, cheques e cartões de credito, e a receita total que 
	obteve a danceteria.
     */
    class Exercicio1
    {
        //sa porra deve ta errada
        static void Main(string[] args)
        {
            int pag;
            double pagValor = 0, cheques = 0, cedulas = 0, cartcred = 0;
		    for (int i = 0; i < 150; i++)
            {
                Console.WriteLine("Digite a Forma de Pagamento: ");
                Console.WriteLine("1 - CHEQUE");
                Console.WriteLine("2 - CARTÃO DE CREDITO");
                Console.WriteLine("3 - CÉDULAS");

                pag = int.Parse(Console.ReadLine());

                switch(pag)
                {
                    case 1:
                        Console.WriteLine("Digite o valor: ");
                        pagValor = double.Parse(Console.ReadLine());
                        cheques = pagValor + cheques;
                        break;
                    case 2:
                        Console.WriteLine("Digite o valor: ");
                        pagValor = double.Parse(Console.ReadLine());
                        cartcred = pagValor + cartcred;
                        break;
                    case 3:
                        Console.WriteLine("Digite o valor: ");
                        pagValor = double.Parse(Console.ReadLine());
                        cedulas = pagValor + cedulas;
                        break;
                }
            }

            Console.WriteLine("O Total da Receita é de: \n");
            double receita = cheques + cartcred + cedulas;
            Console.WriteLine(receita);

        }
    }
}
