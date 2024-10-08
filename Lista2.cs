using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace TI46ProjetosConsole2
{
    internal class Lista2
    {

        public static void escolherExercicio()
        {
            string input;
            do
            {
                Console.Clear();
                Console.Write("\n----------- LISTA 2 -----------\nDigite o número do exercício para executar [0 sair]: ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        //1.	Escreva um algoritmo que leia um número e o imprima caso ele seja maior que 20.
                        Console.WriteLine("Exercício 1");
                        exercicio1();
                        break;

                    case "2":
                        //2.	Ler um valor e escrever a mensagem É MAIOR QUE 10! se o valor lido for maior que 10, caso contrário escrever NÃO É MAIOR QUE 10!
                        Console.WriteLine("\nExercício 2");
                        exercicio2();
                        break;

                    case "3":
                        //3.	Faça um algoritmo que leia os valores A, B, C e imprima na tela se a soma de A + B é menor que C. 
                        Console.WriteLine("\nExercício 3");
                        exercicio3();
                        break;

                    case "4":
                        //4.	Construa um algoritmo que leia dois valores numéricos inteiros e efetue a adição; caso o resultado seja maior que 10, apresentá-lo
                        Console.WriteLine("\nExercício 4");
                        exercicio4();
                        break;

                    case "5":
                        //5.	Faça um algoritmo que leia o nome, o sexo e o estado civil de uma pessoa. Caso sexo seja “F” e estado civil seja “CASADA”, solicitar o tempo de casada (anos). 
                        Console.WriteLine("\nExercício 5");
                        exercicio5();
                        break;

                    case "6":
                        //6.	Faça um algoritmo para receber um número qualquer e informar na tela se é par ou ímpar. 
                        Console.WriteLine("\nExercício 6");
                        exercicio6();
                        break;

                    case "7":
                        //7.	Faça um algoritmo que leia dois valores inteiros A e B se os valores forem iguais deverá se somar os dois, caso contrário multiplique A por B. Ao final de qualquer um dos cálculos deve-se atribuir o resultado para uma variável C e mostrar seu conteúdo na tela. 
                        Console.WriteLine("\nExercício 7");
                        exercicio7();
                        break;

                    case "8":
                        //8.	Encontrar o dobro de um número caso ele seja positivo e o seu triplo caso seja negativo, imprimindo o resultado. 
                        Console.WriteLine("\nExercício 8");
                        exercicio8();
                        break;

                    case "9":
                        //9.	Faça um algoritmo que leia 3 valores retorno do maior para o menor ordenados.
                        Console.WriteLine("\nExercício 9");
                        exercicio9();
                        break;

                    case "10":
                        Console.WriteLine("\nExercício 10");
                        exercicio10();
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

        private static void exercicio10()
        {
        }

        private static void exercicio9()
        {
            Console.WriteLine("Digite 3 números: ");
            int[] nums = new int[3];

            for (int i = 0; i <= nums.Length; i++)
            {
                nums[i] = int.Parse(Console.ReadLine());
            }

            int maior = nums[0];

            foreach (var num in nums)
            {
                if (num > maior)
                {
                    maior = num;
                }
            }
        }

        private static void exercicio8()
        {
            Console.WriteLine("Informe um número");
            int num = int.Parse(Console.ReadLine());

            if (num >= 0)
            {
                Console.WriteLine("O dobro deste número é igual a "+(num * 2));
            }
            else
            {
                Console.WriteLine("O triplo deste número é igual a "+(num * 3));
            }
        }

        private static void exercicio7()
        {
            Console.WriteLine("Digite os valores de A e B consecutivamente: ");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            if (a == b) Console.WriteLine($"A soma é igual a {a + b}");
            else Console.WriteLine($"A multiplicação é igual a {a * b}");
        }

        private static void exercicio6()
        {
            Console.Write("Informe um número: ");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("É par");
            }
            else
            {
                Console.WriteLine("É ímpar");
            }
        }

        private static void exercicio5()
        {
            Console.Write("CADASTRO GENÉRICO\nNome:");
            string name = Console.ReadLine();
            Console.Write("Sexo [F/M]: ");
            char sexo = char.Parse(Console.ReadLine());
            Console.Write("Estado civíl: ");
            string estCivil = Console.ReadLine();
            int anosDeCasamento;
            if (sexo == 'F' && estCivil == "CASADA")
            {
                Console.WriteLine("Quantos Anos de casada");
                anosDeCasamento = int.Parse(Console.ReadLine());
            }
        }

        private static void exercicio4()
        {
            Console.WriteLine("Digite 2 números: ");
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            int soma = n1 + n2;

            if (soma > 10)
            {
                Console.WriteLine(soma);
            }

        }

        private static void exercicio3()
        {
            Console.WriteLine("Digite os valores de A, B e C: ");
            double[] nums = new double[3];
            for (int i = 0; i <= nums.Length; i++)
            {
                nums[i] = double.Parse(Console.ReadLine());
            }

            if (nums[0] + nums[1] < nums[2])
            {
                Console.WriteLine($"A soma de A {nums[0]} + B {nums[1]} é menor que C {nums[2]}");
            }

        }

        private static void exercicio2()
        {
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());

            if (num > 10)
            {
                Console.WriteLine("É MAIOR QUE 10!");
            }
            else
            {
                Console.WriteLine("NÃO É MAIOR QUE 10!");
            }
        }

        private static void exercicio1()
        {
            Console.Write("Digite um número: ");
            int num = int.Parse(Console.ReadLine());
            if (num > 20)
            {
                Console.WriteLine("É maior que 20!");
            }
        }
    }
}
