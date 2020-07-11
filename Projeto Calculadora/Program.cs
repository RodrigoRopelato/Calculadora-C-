using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            
            string opcao;
            bool continuar = true;
            double numero1=0;
            double numero2=0;
                    
            do
            {
                Menu();

                Console.Write("\nOpção: ");
                opcao = Console.ReadLine();
                
                if (opcao != "5" )
                {
                    Console.Write("\nDigite o primeiro numero: ");
                    numero1 = double.Parse(Console.ReadLine());
                    Console.Write("Digite o segundo numero: ");
                    numero2 = double.Parse(Console.ReadLine());
                }

                switch (opcao)
                {
                    case "1":
                        somar(numero1, numero2);
                        break;                           
                    case "2":
                         subtrair(numero1,numero2);
                        break;
                    case "3":
                         multiplicar(numero1,numero2);
                        break;
                    case "4":
                         dividir(numero1,numero2);
                        break;
                    case "5":
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("\nOpção Invalida!");
                        Console.WriteLine("Escolha uma das opções do menu.");
                        break;
                }
                Console.ReadKey();
                Console.Clear();

            } while (continuar);

        }

        private static void Menu()
        {
            Console.WriteLine("Calculadora \n");
            Console.WriteLine("Escolha uma operação a ser executada");
            Console.WriteLine("1-Somar");
            Console.WriteLine("2-Subtrair");
            Console.WriteLine("3-Multiplicar");
            Console.WriteLine("4-Dividir");
            Console.WriteLine("5-Sair do sistema");
        }

        private static void dividir(double num1, double num2)
        {
           
            Console.Clear();
            Console.WriteLine("Operação de divisão selecionada \n");
            double resultado = num1 / num2;
            Console.WriteLine("\n{0} / {1} = {2}", num1, num2, resultado);
            
        }

        public static void multiplicar(double num1, double num2)
        {
            
            Console.Clear();
            Console.WriteLine("Operação de multiplicação selecionada \n");
            double resultado = num1 * num2;
            Console.WriteLine("\n{0} x {1} = {2}", num1, num2, resultado);
            
        }

        private static void subtrair(double num1, double num2)
        {
            Console.Clear();
            Console.WriteLine("Operação de Subtração selecionada \n");
            double resultado = num1 - num2;
            Console.WriteLine("\n{0} - {1} = {2}", num1, num2, resultado);
           
        }

        private static void somar(double num1, double num2)
        {
            Console.Clear();
            Console.WriteLine("Operação de Soma selecionada\n");
            double resultado = num1 + num2;
            Console.WriteLine("\n{0} + {1} = {2}", num1, num2, resultado);
            
        }
    }
}

