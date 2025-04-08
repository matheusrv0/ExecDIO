using System.Diagnostics;

namespace questoes
{

    using System;

    public class Operacoes
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Escreva a questão que deseja fazer:");
            int opcao = Convert.ToInt32(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    ExibirNumeroRecebido();
                    break;
                case 2:
                    RealizarSoma();
                    break;
                case 3:
                    ConverterParaInteiro();
                    break;
                case 4:
                    ExibirNome();
                    break;
                case 5:
                    Console.WriteLine("---Cálculo da área do retângulo---");
                    Console.WriteLine("Indique o valor da base do retângulo:");
                    double baseR = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("Indique o valor da altura do retângulo:");
                    double alturaR = Convert.ToDouble(Console.ReadLine());
                    double resultado = CalcularAreaRetangulo( baseR, alturaR);
                    Console.WriteLine("A área do retângulo é: " + resultado);
                    break;
                case 6:
                    CalcularMaiorIdade();
                    break;
                case 7:
                    ContarNumero1_10();
                    break;
                case 8:
                    ContarNumeroPositivo();
                    break;
                case 9:
                    PedirSenhaCorreta();
                    break;


                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }


        public static void ExibirNumeroRecebido()
        {
            Console.WriteLine("Digite um número inteiro:");
            int numeroRecebido = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("O número recebido é " + numeroRecebido);
        }


        public static void RealizarSoma()
        {
            Console.WriteLine("Insira dois números para realizar a soma:");
            double num1 = Convert.ToDouble(Console.ReadLine());
            double num2 = Convert.ToDouble(Console.ReadLine());
            double resultado = num1 + num2;
            Console.WriteLine("O resultado da soma é " + resultado);
        }

        public static void ConverterParaInteiro()
        {
            Console.WriteLine("Insira um número decimal:");
            double numDecimal = Convert.ToDouble(Console.ReadLine());
            int numInteiro = (int)numDecimal;
            Console.WriteLine("O número convertido para inteiro é " + numInteiro);
        }


        public static void ExibirNome()
        {
            Console.WriteLine("Digite seu nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Bem-vindo(a) " + nome);
        }


        public static double CalcularAreaRetangulo(double baseR, double alturaR)
        {
           return baseR * alturaR;
            
        }
        public static void CalcularMaiorIdade()
        {
            Console.WriteLine("Informe sua idade: ");
            int idade = Convert.ToInt32(Console.ReadLine());
            if (idade >= 18)
            {
                Console.WriteLine("Voce é maior de idade");
            }
            else
            {
                Console.WriteLine("Voce é menor de idade");
            }
        }
        public static void ContarNumero1_10()
        {
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        public static void ContarNumeroPositivo()
        {
            Console.WriteLine("Escreva um numero :");
            double numeroEscolhido = Convert.ToDouble(Console.ReadLine());
            if (numeroEscolhido <= 0)
            {
                Console.WriteLine("Indique um valor positivo: ");

            }
            else
            {
                while (numeroEscolhido < 10)
                {
                    numeroEscolhido += 1;
                    Console.WriteLine(numeroEscolhido);
                }
            }
        }
        public static void PedirSenhaCorreta()
        {
            string senhaCorreta = "123";
            Console.WriteLine("Indique a senha correta: ");
            string senhaUsuario;
            do
            {
                Console.WriteLine("Digite a senha:");
                senhaUsuario = Console.ReadLine();
                if (senhaUsuario != senhaCorreta)
                {
                    Console.WriteLine("Senha incorreta.");
                }

            } while (senhaUsuario != senhaCorreta);
            Console.WriteLine("Senha correta! Acesso permitido.");
        }
    }
}