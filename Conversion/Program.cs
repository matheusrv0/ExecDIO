using System;
namespace Conversion
{

    public class Program
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("----------------Conversor de temperatura----------");
            Console.WriteLine("Digite a temperatura: ");
            double temperatura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Escolha a opção de conversão: ");
            Console.WriteLine("1 - Celsius");
            Console.WriteLine("2 - Farenheit");
            Console.WriteLine("3 - Kelvin");
                int opcao = Convert.ToInt32(Console.ReadLine());

                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("Celsius para Farenheit: " + Conversores.cParaF(temperatura));
                            Console.WriteLine("Celsius para Kelvin: " + Conversores.CParaK(temperatura));
                            break;
                        case 2:
                            Console.WriteLine("Farenheit para Celsius: " + Conversores.FParaC(temperatura));
                            Console.WriteLine("Farenheit paraKelvin: " + Conversores.FParaK(temperatura));
                            break;
                        case 3:
                            Console.WriteLine("Kelvin para Celsius: " + Conversores.KParaC(temperatura));
                            Console.WriteLine("Kelvin para Farenheit: " + Conversores.KParaF(temperatura));
                            break;
                        default:
                            Console.WriteLine("Opção Invalida");
                           break;

            }
        }


    }
}