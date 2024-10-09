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
    internal class Lista4
    {

        public static void escolherExercicio()
        {
            string input;
            do
            {
                Console.Clear();
                Console.Write("\n----------- LISTA 4 -----------\nDigite o número do exercício para executar [0 sair]: ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        //o Escreva um programa que solicite um número ao usuário e verifique se ele é par ou ímpar.
                        Console.WriteLine("Exercício 1");
                        exercicio1();
                        break;

                    case "2":
                        //o Peça ao usuário para inserir sua idade e classifique-o como "Criança" (0-12), "Adolescente" (13-17), "Adulto" (18-64), ou "Idoso" (65+).
                        Console.WriteLine("\nExercício 2");
                        exercicio2();
                        break;

                    case "3":
                        //o Crie um programa que receba uma nota (0 a 10) e exiba se o aluno foi "Aprovado" (nota maior ou igual a 6), "Recuperação" (nota entre 4 e 5.9) ou "Reprovado" (nota menor que 4).
                        Console.WriteLine("\nExercício 3");
                        exercicio3();
                        break;

                    case "4":
                        //o Peça ao usuário para informar seu peso e altura e, em seguida, calcule o Índice de Massa Corporal (IMC) e determine sua categoria: "Abaixo do peso", "Peso normal", "Sobrepeso" ou "Obesidade".
                        Console.WriteLine("\nExercício 4");
                        exercicio4();
                        break;

                    case "5":
                        //o Escreva um programa que receba dois números do usuário e exiba qual é o maior, ou informe se os números são iguais.
                        Console.WriteLine("\nExercício 5");
                        exercicio5();
                        break;

                    case "6":
                        //o Peça ao usuário sua idade e informe se ele é obrigado a votar (18-70 anos), voto facultativo (16-17 ou acima de 70), ou se não pode votar (abaixo de 16 anos).
                        Console.WriteLine("\nExercício 6");
                        exercicio6();
                        break;

                    case "7":
                        //o Crie um programa que receba o valor de uma compra e aplique um desconto de 10% caso o valor seja superior a R$100.
                        Console.WriteLine("\nExercício 7");
                        exercicio7();
                        break;

                    case "8":
                        //o Peça ao usuário para informar a temperatura em graus Celsius e classifique se está "Frio" (abaixo de 15°C), "Agradável" (15-25°C), ou "Quente" (acima de 25°C).
                        Console.WriteLine("\nExercício 8");
                        exercicio8();
                        break;

                    case "9":
                        //o Solicite três números ao usuário e calcule a média. Caso a média seja maior que 7, exiba "Aprovado", senão exiba "Reprovado".
                        Console.WriteLine("\nExercício 9");
                        exercicio9();
                        break;

                    case "10":
                        //o Peça ao usuário que insira um ano e verifique se ele é bissexto (divisível por 4 e não divisível por 100, exceto se for divisível por 400).
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
            Console.Write("Insira um ano para verificar se é bissexto: ");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine( (year % 4 == 0) && (year % 100 != 0 || year % 400 == 400 )  ? "Bissexto" : "Não é bissexto"  );
        }

        private static void exercicio9()
        {
            int qtdNotas = 3;
            float somaNotas = 0;
            Console.WriteLine($"Digite {qtdNotas} as  notas: ");

            for (int i = 0; i < qtdNotas; i++)
            {
                somaNotas += float.Parse(Console.ReadLine());
            }

            float media = somaNotas / qtdNotas;

            Console.Write( media > 7 ? "Aprovado" : "Reprovado" );
            Console.WriteLine($" com uma média de {media}");
        }

        private static void exercicio8()
        {
            Console.Write("Digite a temperatura: ");
            float temp = float.Parse(Console.ReadLine());
            Console.WriteLine(
                temp < 15 ? "Frio" : temp < 25 ? "Agradável" : "Quente"
                );
        }

        private static void exercicio7()
        {
            float discount = 0.1f;
            float minPrice = 100;

            Console.Write("Digite o valor do produto: ");
            float price = float.Parse(Console.ReadLine());
            float finalPrice = price >= minPrice ? price - (price * discount) : price;

            Console.WriteLine($"O valor final do produto {(price >= minPrice ? "descontado" : "")} é de {finalPrice}");
        }

        private static void exercicio6()
        {
            Console.Write("Digite sua idade: ");
            int age = int.Parse(Console.ReadLine());

            if (age == 16 || age == 17 || age >= 70)
            {
                Console.WriteLine("Voto facultativo");
            }else if (age < 16)
            {
                Console.WriteLine("Não vota");
            }
            else
            {
                Console.WriteLine("Voto obrigatório");
            }
        }

        private static void exercicio5()
        {
            Console.WriteLine("Informe dois números");

            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine(
                n1 > n2 ? n1.ToString() : n2 > n1 ? n2.ToString() : "São iguais"
                );
        }

        private static void exercicio4()
        {
            Console.Write("Digite seu peso: ");
            float weight = float.Parse(Console.ReadLine());
            Console.Write("Digite sua altura: ");
            float height = float.Parse(Console.ReadLine());

            float imc = weight / (height * height);

            Console.WriteLine(
                imc < 18.5 ? "Abaixo do peso" : imc < 24.9 ? "Peso normal" : imc < 29.9 ? "Acima do peso" : "Obesidade"
                );
        }

        private static void exercicio3()
        {
            Console.Write("Digite uma nota: ");
            float nota = float.Parse(Console.ReadLine());
            Console.WriteLine(nota >= 6 ? "Aprovado" : nota >= 4 ? "Recuperação" : "Reprovado");
        }

        private static void exercicio2()
        {
            Console.Write("Insira sua idade: ");
            int age = int.Parse(Console.ReadLine());
            if (age < 12)
            {
                Console.WriteLine("Criança");
            }
            else if (age < 17)
            {
                Console.WriteLine("Adolescente");
            }
            else if (age < 64)
            {
                Console.WriteLine("Adulto");
            }
            else
            {
                Console.WriteLine("Idoso");
            }
            }

        private static void exercicio1()
        {
            Console.Write("Digite um número para verificar se é par ou ímpar: ");
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine((num % 2 == 0) ? "É par" : "É ímpar" );
        }
    }
}
