namespace Exercicio03_3__d_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Leia três números quaisquer, imprimindo-os em ordem crescente.");
            Console.WriteLine("\nResposta:\n");

            Console.Write("Digite o primeiro numero: ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Digite o segundo numero: ");
            int numero2 = int.Parse(Console.ReadLine());
            Console.Write("Digite o terceiro numero: ");
            int numero3 = int.Parse(Console.ReadLine());

            if (numero1 > numero2 && numero1 > numero3 && numero2 > numero3)
            {
                Console.WriteLine("{0} {1} {2}", numero3, numero2, numero1);
            }
            else if (numero1 > numero2 && numero1 > numero3 && numero3 > numero2)
            {
                Console.WriteLine("{0} {1} {2}", numero2, numero3, numero1);
            }
            else if (numero2 > numero1 && numero2 > numero3 && numero1 > numero3)
            {
                Console.WriteLine("{0} {1} {2}", numero3, numero1, numero2);
            }
            else if (numero2 > numero1 && numero2 > numero3 && numero3 > numero1)
            {
                Console.WriteLine("{0} {1} {2}", numero1, numero3, numero2);
            }
            else if (numero3 > numero1 && numero3 > numero2 && numero1 > numero2)
            {
                Console.WriteLine("{0} {1} {2}", numero2, numero1, numero3);
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", numero1, numero2, numero3);
            }
        }
    }
}