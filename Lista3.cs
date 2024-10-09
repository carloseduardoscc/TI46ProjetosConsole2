using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Net.Http.Headers;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TI46ProjetosConsole2
{
    internal class Lista3
    {

        public static void escolherExercicio()
        {
            string input;
            do
            {
                Console.Clear();
                Console.Write("\n----------- LISTA 3 -----------\nDigite o número do exercício para executar [0 sair]: ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        //1.	Faça um programa que receba 3 valores e retorne a soma deles.
                        Console.WriteLine("Exercício 1");
                        exercicio1();
                        break;

                    case "2":
                        //2.	Faça um programa que receba quatro notas e retorne a média.
                        Console.WriteLine("\nExercício 2");
                        exercicio2();
                        break;

                    case "3":
                        //3.	Faça um programa que receba um nome enquanto o nome for diferente de João continuar pedindo o nome. 
                        Console.WriteLine("\nExercício 3");
                        exercicio3();
                        break;

                    case "4":
                        //resultado 49038
                        //4.	Faça um programa que retorne à quantidade de números pares existente entre 35 e 98111.
                        Console.WriteLine("\nExercício 4");
                        exercicio4();
                        break;

                    case "5":
                        //resultado 6250000
                        //5.	FaÇa um programa que some todos os números ímpares de 1 até 5000.
                        Console.WriteLine("\nExercício 5");
                        exercicio5();
                        break;

                    case "6":
                        //6.	Faça um programa que receba um número e usando laços de repetição calcule e mostre a tabuada desse número.
                        Console.WriteLine("\nExercício 6");
                        exercicio6();
                        break;

                    case "0":
                        break;

                    default:
                        Console.WriteLine("Opção inválida!\n\n");
                        break;
                }
                Console.WriteLine("\n[ Enter ]");
                Console.ReadKey();
            } while (input != "0");
        }

        private static void exercicio6()
        {
            Console.Write("Digite um número para obter sua tabuada: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++) {
                Console.WriteLine($"{num} x {i} = {num * i}");
            }
        }

        private static void exercicio5()
        {
            int soma = 0;
            for (int i = 1; i <= 5000; i++)
            {
                if (i % 2 != 0)
                {
                    soma += i;
                }
            }

            Console.WriteLine($"A soma de todos os ímpares entre 1 e 5000 é igual a {soma}");
        }

        private static void exercicio4()
        {
            int qtdNums = 0;
            for (int i = 35;  i < 98111; i++) { 
                if (i % 2 == 0) qtdNums++;
            }

            Console.WriteLine($"Existem {qtdNums} números pares entre 35 e 98111!");
        }

        private static void exercicio3()
        {
            string name;
            do
            {
                Console.Write("Digite um nome: ");
                name = Console.ReadLine();
            } while (name != "João");
        }

        private static void exercicio2()
        {
            Console.WriteLine("Entre com 4 notas");
            float soma = 0;

            for (int i = 0; i < 4; i++) {
                soma += float.Parse(Console.ReadLine());
            }

            float media = soma / 4;

            Console.WriteLine($"A média das notas é igual a {media}");
        }

        private static void exercicio1()
        {
            Console.WriteLine("Digite 3 números: ");
            int soma = 0;
            for (int i = 1; i <= 3; i++)
            {
                soma += int.Parse(Console.ReadLine());
            }
            Console.WriteLine($"A soma deles é igual a: {soma}");
        }
    }
}
