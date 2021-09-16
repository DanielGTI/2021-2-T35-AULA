using System;

namespace Aula4
{
    class Program
    {
        static void Main(string[] args)
        {
            short valor = 10;
            int idade = 20;

            double velocidade= 32767;

            valor = Convert.ToInt16(velocidade);

            velocidade = 32768;
            idade = Convert.ToInt32(velocidade);

            Console.WriteLine("Idade = " + idade);
            Console.WriteLine("Valor = " + valor);

            /*
            
            +
            -
            *
            /
            %


            A com B
            A com 5
            30 com C
            (A + B) com C

            >
            >=
            <
            <=
            ==
            !=

            A = 2
            B = 5

            A > B       F
            B <= 5      V
            AV1 >= 6.0
            Media >= 6.0
            idade >= 12

            LÓGICO

            &&
            ||
            ^

             */
        }
    }
}
