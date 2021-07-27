using System;

namespace Pretty_Calculator 
{
    class Program
    {
        static void Main(string[] args)
        {
            double n1,n2, resultado= 0;// resultado igual a 0 está sendo declarado porque embaixo ta contatenando (juntar uma coisa com a outra)
            string operacao;//string campo escrito
            bool continuar = true;

            while (true)
            {
                 Console.WriteLine("Digite um número ");
                 n1 = double.Parse(Console.ReadLine());

                 Console.WriteLine("Digite a operação desejada (+, -, * ou /): ");
                 operacao = Console.ReadLine();

                 Console.WriteLine("Digite o próximo número: ");
                 n2 = double.Parse(Console.ReadLine());
            while(continuar)
                {
                 switch (operacao)
                 {
                     case "+":
                         resultado = n1 + n2;
                         break;
                     case "-":
                         resultado = n1 - n2;
                         break;
                     case "*":
                         resultado = n1 * n2;
                         break;
                     case "/":
                         resultado = n1 / n2;
                         break;
                     default:
                         Console.WriteLine("Operação Inválida! Por favor, digite uma das quatro operações: +, -, * ou /");
                         break;
                 }
                 Console.WriteLine("O resultado da operação é: " + resultado);
                 Console.ReadLine();

                 Console.WriteLine("\nDeseja realizar mais 1 operação? (S - Sim; N - Não");
                 string escolha = Console.ReadLine();
                    if (escolha.ToLower() == "s")// tolower significa ele vai converter , vai continuar quando voce digitar S, caso não, ele repete
                    {
                        n1 = resultado;
                        Console.WriteLine("Digite a operação desejada (+, -, * ou /): ");
                        operacao = Console.ReadLine();

                        Console.WriteLine("Digite o segundo valor: ");
                        n2 = double.Parse(Console.ReadLine());
                    }
                    else
                    {
                        continuar = false;
                    }
                    Console.Clear();//ele vai limpar a tela após o colocar o numero
                }
            }
        }
    }
}
