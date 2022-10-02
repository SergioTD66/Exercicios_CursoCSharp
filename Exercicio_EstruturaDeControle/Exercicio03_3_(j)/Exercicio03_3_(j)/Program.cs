namespace Exercicio03_3__j_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva um programa para determinar se um valor inteiro fornecido pelo usuário é\r\nou não primo");
            Console.WriteLine("\nResposta:\n");

            int i = 1;
            int divisao = 0;
            Console.Write("Digite um numero: ");
            int numero = int.Parse(Console.ReadLine());


            for (; i < numero; i++)
            {
                if (numero % i == 0)
                { 
                    divisao++;
                }
            }
            if (divisao == 2)
            {
                Console.WriteLine("\n{0} É um numero primo", numero);
            }
            else
                Console.WriteLine("\n{0} Não é um numero primo", numero);
        }
    }
}