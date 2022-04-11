using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Inicio:
            Console.Clear();

            Console.Write("Digite o primeiro número:");
            double num1 = double.Parse(Console.ReadLine());

            Console.Write("Digite o segundo número:");
            double num2 = double.Parse(Console.ReadLine());

            Console.Write("Escolha a operação (+, -, / ou *): ");
            char op = char.Parse(Console.ReadLine());

            double resultado = 0;

            switch (op)
            {
                default:
                    Console.WriteLine("Erro na opção inválida");
                    break;
                    
                    //Caso de Soma
                case '+':
                    resultado = num1 + num2;
                    Console.WriteLine("O resultado da soma é: " + resultado);
                    break;

                    //Caso de Subtração
                    case '-':
                    resultado = num1 - num2;
                    Console.WriteLine("O resultado da subtração é: " + resultado);
                    break;

                //Caso de Multiplicação
                case '*':
                    resultado = num1 * num2;
                    Console.WriteLine("O resultado da multiplicação é: " + resultado);
                    break;

                //Caso de Divisão
                case '/':
                    if(num1 == 0 || num2 == 0)
                    {
                        Console.WriteLine("Não é possível dividir por 0");
                    } else
                    {
                        resultado = num1 / num2;
                        Console.WriteLine("O resultado da divisão é: " + resultado);
                    }
                    break;
            }
            Console.Write("Continuar calculando (Sim / Não)?");
            string opcao = Console.ReadLine();

            if ( opcao == "Sim" || opcao == "SIM")
            {
                goto Inicio;
            }
            
            //Pausa para verificarmos o resultado.
            Console.ReadKey();

        }
    }
}
