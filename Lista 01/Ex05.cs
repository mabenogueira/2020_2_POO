using System;

namespace Questão5
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, area, perimetro, diagonal;
            Console.WriteLine("Digite a base e a altura do retângulo");
            b = double.Parse(Console.ReadLine());
            a = double.Parse(Console.ReadLine());

            area = b*a;
            perimetro = 2*(b+a);
            diagonal = Math.Sqrt((b*b) + (a*a));

             Console.WriteLine($"Área: {area:0.00} - Perímetro: {perimetro:0.00} - Diagonal: {diagonal:0.00}");

        }
    }
}
