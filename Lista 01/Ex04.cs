using System;

namespace Questão4
{
    class Program
    {
        static void Main(string[] args)
        {   
            Console.WriteLine("Digite a nota do primeiro bimestre da disciplina: ");
            int n1 = int.Parse(Console.ReadLine()); 

            Console.WriteLine("Digite a nota do segundo bimestre da disciplina: ");
            int n2 = int.Parse(Console.ReadLine());

            Console.WriteLine(((n1*2)+(n2*3))/5);
        }
    }
}
