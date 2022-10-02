namespace Exercicio03_3__i_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("O fatorial de um número inteiro positivo é o produto dele por todos os seus\r\nantecessores até 1, representa-se N!. Por definição o fatorial de 0! = 1 e o fatorial\r\nde 1! = 1!. Exemplo: 5! = 5 * 4 * 3 * 2 * 1 = 120. Faça um programa que peça um\r\nnúmero ao usuário e imprima o fatorial deste número na tela.");
            Console.WriteLine("\nResposta:\n");

            double i, numero;
            Console.WriteLine("Fatorial\n");
            Console.Write("Digite um número: ");
            numero = double.Parse(Console.ReadLine());

            double fatorial = numero;
            for (i = numero - 1; i >= 1; i--)
            {
                Console.WriteLine("{0} * {1}", fatorial, i);

                fatorial = fatorial * i; 
            }
            Console.WriteLine("Fatorial de {0} é {1}", numero, fatorial);

        }
    }
 }
