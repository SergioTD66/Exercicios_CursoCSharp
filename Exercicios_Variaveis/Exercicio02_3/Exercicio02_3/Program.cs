namespace Exercicio02_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("As maçãs custam R$ 1,30 cada se forem compradas menos de uma dúzia, e R$ 1,00 se\r\nforem compradas pelo menos 12. Escreva um programa que leia o número de maçãs\r\ncompradas, calcule e escreva o custo total da compra.");
            Console.WriteLine("\nResposta:\n");

            int macas = 0;
            // Para valores que não são inteiros usa-se o double.
            // Quando usa "=" em uma variavel quer dizer que quando a ser chamada, será altomaticamente
            // substituida pelo valor ou demais variavel associadas.
            double preco1 = 1.00, preco2 = 1.30, calculo; 

            Console.WriteLine("Digite numero de maças desejada: ");
            macas = int.Parse(Console.ReadLine());

            // if e else são condições de "se ou senão", neste caso trazer o primeiro preço se for abaixo
            // do valor dito se não trazer o outro valor para superior.
            if (macas >= 12)
            {
               // O "F2" siginifica casas decimas apos a virgula permitidas
               // (F0=0 / F1=0,0 / F2=0,00 / F3=0,000 / F4=0,000 /...)
                calculo = macas * preco1;
                Console.WriteLine("Total da compra é: R${0:F0}", calculo);
            }
            else
            {
                calculo = macas * preco2;
                Console.WriteLine("Total da compra é: R${0:F2}", calculo);
            }
        }
    }
}