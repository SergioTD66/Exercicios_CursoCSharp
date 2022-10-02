namespace Exercicio02_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nElabore um programa que tenha como parâmetros de entrada um vetor de 3 posições\r\n(cujos elementos são do tipo float) e forneça como saída a média aritmética dos\r\nnúmeros do vetor.");
            Console.WriteLine("\nResposta:\n");

            float[] nota = new float[3];
            float soma = 0, media = 0;


            for (int i = 0; i < nota.Length; i++)
            {
                Console.WriteLine("Digite as notas: ");
                nota[i] = Convert.ToInt32(Console.ReadLine());
                soma = soma + nota[i];
            }

            media = soma / 3;
            Console.WriteLine("A média é: {0:F2}", media);

        }
    }
}