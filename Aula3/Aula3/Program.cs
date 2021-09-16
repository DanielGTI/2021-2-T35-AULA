using System;

namespace Aula3
{
    class Program
    {
        static void Main(string[] args)
        {
            double av1, av2, media;

            Console.Write("Digite a AV1: ");
            av1 = Convert.ToDouble( Console.ReadLine() );

            Console.Write("Digite a AV2: ");
            av2 = Convert.ToDouble( Console.ReadLine() );

            media = (av1 + av2) / 2;

            Console.WriteLine("Media do aluno = " + media);

            Console.ReadKey();

        }
    }
}
