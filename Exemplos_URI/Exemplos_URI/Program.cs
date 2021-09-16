using System;

namespace Exemplos_URI
{
    class Program
    {

        public static void p1001()
        {
            int a, b, x;
            a = Convert.ToInt32(Console.ReadLine());
            b = Convert.ToInt32(Console.ReadLine());
            x = a + b;
            Console.Write("X = {0}\n", x);
        }
        public static void p1002()
        {
            double area, raio;
            raio = Convert.ToDouble(Console.ReadLine());
            area = 3.14159 * Math.Pow(raio, 2);
            Console.Write("A={0}\n", area.ToString("0.0000"));
        }

        public static void p1010()
        {
            string linha1, linha2;
            int cod1, quant1, cod2, quant2;
            double preco1, preco2, valor_total;

            linha1 = Console.ReadLine();
            linha2 = Console.ReadLine();

            //  VALORES DA LINHA 1
            //  [ 12 , 1 , 5.30 ]
            string[] valor = linha1.Split(" ");
            cod1 = Convert.ToInt32(valor[0]);
            quant1 = Convert.ToInt32(valor[1]);
            preco1 = Convert.ToDouble(valor[2]);

            //  VALORES DA LINHA 2
            valor = linha2.Split(" ");
            cod2 = Convert.ToInt32(valor[0]);
            quant2 = Convert.ToInt32(valor[1]);
            preco2 = Convert.ToDouble(valor[2]);

            valor_total = (quant1 * preco1) + (quant2 * preco2);

            Console.Write("VALOR A PAGAR: R$ {0}\n", valor_total.ToString("0.00") );
        }

        static void Main(string[] args)
        {
            int prog;
            do
            {
                Console.Write("\n\t| 0 para sair |\nDigite o programa desejado: ");
                prog = Convert.ToInt32(Console.ReadLine());
                if( prog == 0 )
                {
                    Console.Write("\nObrigado por utilizar nossos programas.\n\n");
                    break;
                }

                switch ( prog )
                {
                    case 1001:  Program.p1001();  break;
                    case 1002:  Program.p1002();  break;
                    case 1010:  Program.p1010();  break;

                    default:    Console.Write("\nOpção inválida.\n");   break;
                }                    
            } while ( prog != 0 );
        }
    }
}
