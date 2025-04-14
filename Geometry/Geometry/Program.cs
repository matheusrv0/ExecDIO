using System;
using static Geometry.CalculoFiguras;
internal class Program
{
    
    static void Main(string[] args)
       

    {
        Console.WriteLine("==================================================");

        Console.WriteLine("CALCULO AREA DO TRIANGULO");
        
        Console.WriteLine("Diga o valor da base:");
        double ParteDeBaixo = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Diga o valor da altura:");
        double altura = Convert.ToDouble(Console.ReadLine());

        double resultAT = CalcularAreaTriangulo(ParteDeBaixo, altura);
        Console.WriteLine("O valor da area é " + resultAT);

        Console.WriteLine("==================================================");

        Console.WriteLine("CALCULO PERIMETRO DO TRIANGULO");

        Console.WriteLine("Digite os valores dos 3 lados");
        double a1 = Convert.ToDouble(Console.ReadLine());
        double a2 = Convert.ToDouble(Console.ReadLine());
        double a3 = Convert.ToDouble(Console.ReadLine());

        double resultPT = CalcularPerimetroTriangulo(a1, a2, a3);
        Console.WriteLine("o valor do perimetro é " + resultPT);

        Console.WriteLine("==================================================");

        Console.WriteLine("CALCULO AREA DO RETANGULO");

        Console.WriteLine("Digite o valor da base do retangulo");
        double baseR = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor da altura do retangulo");
        double alturaR = Convert.ToDouble(Console.ReadLine());

        double resultAR = CalcularAreaRetangulo(baseR, alturaR);
        Console.WriteLine("O valor da area do retangulo é "+ resultAR);

        Console.WriteLine("==================================================");

        Console.WriteLine("CALCULO DO PERIMETRO DO RETANGULO");
        Console.WriteLine("Digite o valor da base");
        double basePR = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Digite o valor da altura");
        double alturaPR = Convert.ToDouble(Console.ReadLine());

        double resultPR = CalcularPerimetroRetangulo(basePR, alturaPR);
        Console.WriteLine("O valor do perimetro do retangulo " +resultPR);

        Console.WriteLine("==================================================");



    }
}