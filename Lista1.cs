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
    internal class Lista1
    {

        public static void escolherExercicio()
        {
            string input;
            do
            {
                Console.Clear();
                Console.Write("\n----------- LISTA 1 -----------\nDigite o número do exercício para executar [0 sair]: ");
                input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        //1) Escreva um programa que mostre na tela a mensagem "Olá, Mundo!"
                        Console.WriteLine("Exercício 1");
                        exercicio1();
                        break;

                    case "2":
                        //2) Faça um programa que leia o nome de uma pessoa e mostre uma mensagem de boasvindas para ela:
                        //Ex:
                        //Qual é o seu nome? João da Silva
                        //Olá João da Silva, é um prazer te conhecer!
                        Console.WriteLine("\nExercício 2");
                        exercicio2();
                        break;

                    case "3":
                        //3) Crie um programa que leia o nome e o salário de um funcionário, mostrando no
                        //final uma mensagem.
                        //Ex:
                        //Nome do Funcionário: Maria do Carmo
                        //Salário: 1850,45
                        //O funcionário Maria do Carmo tem um salário de R$1850,45 em Junho.
                        Console.WriteLine("\nExercício 3");
                        exercicio3();
                        break;

                    case "4":
                        //4) Desenvolva um algoritmo que leia dois números inteiros e mostre o somatório
                        //entre eles.
                        //Ex:
                        //Digite um valor: 8
                        //Digite outro valor: 5
                        //A soma entre 8 e 5 é igual a 13.
                        Console.WriteLine("\nExercício 4");
                        exercicio4();
                        break;

                    case "5":
                        //5) Faça um programa que leia as duas notas de um aluno em uma matéria e mostre
                        //na tela a sua média na disciplina.
                        //Ex:
                        //Nota 1: 4.5
                        //Nota 2: 8.5
                        //A média entre 4.5 e 8.5 é igual a 6.5
                        Console.WriteLine("\nExercício 5");
                        exercicio5();
                        break;

                    case "6":
                        //6) Faça um programa que leia um número inteiro e mostre o seu antecessor e seu
                        //sucessor.
                        //Ex:
                        //Digite um número: 9
                        //O antecessor de 9 é 8
                        //O sucessor de 9 é 10
                        Console.WriteLine("\nExercício 6");
                        exercicio6();
                        break;

                    case "7":
                        //7) Crie um algoritmo que leia um número real e mostre na tela o seu dobro e a
                        //sua terça parte.
                        //Ex:
                        //Digite um número: 3.5
                        //O dobro de 3.5 é 7.0
                        //A terça parte de 3.5 é 1.16666
                        Console.WriteLine("\nExercício 7");
                        exercicio7();
                        break;

                    case "8":
                        //8) Desenvolva um programa que leia uma distância em metros e mostre os valores
                        //relativos em outras medidas.
                        //Ex:
                        //Digite uma distância em metros: 185.72
                        //A distância de 85.7m corresponde a:
                        //0.18572Km
                        //1.8572Hm
                        //18.572Dam
                        //1857.2dm
                        //18572.0cm
                        //185720.0mm
                        Console.WriteLine("\nExercício 8");
                        exercicio8();
                        break;

                    case "9":
                        //9) Faça um algoritmo que leia quanto dinheiro uma pessoa tem na carteira (em R$)
                        //e mostre quantos dólares ela pode comprar.Considere US$1,00 = R$3,45.
                        Console.WriteLine("\nExercício 9");
                        exercicio9();
                        break;

                    case "10":
                        //10) Faça um algoritmo que leia a largura e altura de uma parede, calcule e
                        //mostre a área a ser pintada e a quantidade de tinta necessária para o serviço,
                        //sabendo que cada litro de tinta pinta uma área de 2metros quadrados.
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
            Console.Write("Digite a largura da parede: ");
            double lar = double.Parse(Console.ReadLine());
            Console.Write("Digite a altura da parede: ");
            double alt = double.Parse(Console.ReadLine());
            double area = lar * alt;
            double metrosQuadradosPorBalde = 2;
            Console.WriteLine($"Para uma parede de {area}M² será necessário {area / metrosQuadradosPorBalde} baldes de tinta com 2 litros para cobrir");
        }

        private static void exercicio9()
        {
            var br = new CultureInfo("pt-BR");
            var en = new CultureInfo("en-US");

            Console.Write("Quantos reais você possúi? ");
            double amount = double.Parse(Console.ReadLine());
            const double COTACAO_DOLAR = 3.45;

            Console.WriteLine($"É possível comprar até {(amount / COTACAO_DOLAR).ToString("C",en)} com {amount.ToString("C",br)}");
        }

        private static void exercicio8()
        {
            Dictionary<string, double> medidas = new Dictionary<string, double>()
            {
                {"Km",1000 },
                {"Hm", 100 },
                {"Dam", 10 },
                {"dm", 0.1},
                {"cm", 0.01 },
                {"mm", 0.001 }
            };

            Console.Write("Digite uma distância em metros: ");
            double dist = double.Parse(Console.ReadLine());

            foreach (var par in medidas)
            {
                Console.WriteLine($"{dist/par.Value}{par.Key}");
            }

        }

        private static void exercicio7()
        {
            Console.Write("Digite um número real: ");
            double n = double.Parse(Console.ReadLine());
            Console.WriteLine($"O dobro de {n} é {n*2}\nA terça parte de {n} é {n/3}");
        }

        private static void exercicio6()
        {
            Console.Write("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"O antecessor de {n1} é {n1-1}\nO sucessor de {n1} é {n1+1}");
        }

        private static void exercicio5()
        {
            Console.Write("Nota 1: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.Write("Nota 2: ");
            double n2 = double.Parse(Console.ReadLine());
            double media = (n1 + n2) / 2;
            Console.WriteLine($"A média entre {n1} e {n2} é igual a {media}");
        }

        private static void exercicio4()
        {
            Console.Write("Digite um número: ");
            int n1 = int.Parse(Console.ReadLine());
            Console.Write("Digite outro número: ");
            int n2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"A soma dos números é igual a {n1+n2}");
        }

        private static void exercicio3()
        {
            var br = new CultureInfo("pt-BR");
            Console.WriteLine("CADASTRO DE USUÁRIO");
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Salário: ");
            double salary = double.Parse(Console.ReadLine());
            Console.WriteLine($"Nome do funcionário: {name}\nSalário: {salary}\nO funcionário {name} tem um salário de {salary.ToString("C",br)} em Junho.");
        }

        private static void exercicio2()
        {
            Console.Write("Qual seu nome? ");
            string name = Console.ReadLine();
            Console.WriteLine($"Olá {name}, é um prazer te conhecer!");
        }

        private static void exercicio1()
        {
            Console.WriteLine("Olá mundo!");
        }
    }
}
