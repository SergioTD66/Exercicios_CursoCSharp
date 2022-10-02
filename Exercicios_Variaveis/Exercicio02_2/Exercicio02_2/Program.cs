namespace Exercicio02_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nFaça um programa que leia a idade de uma pessoa expressa em anos, meses e dias e\r\nescreva a idade dessa pessoa expressa apenas em dias. Considerar ano com 365 dias e\r\nmês com 30 dias.\n");
            Console.WriteLine("Resposta:\n");
            
            // Indentificando as variaveis, pode ser dividido pela "," para varias de uma vez.
            int dia, mes, ano, calculo;


            Console.WriteLine("Digite o ano do seu nascimento: ");
            ano = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o mes do seu nascimento: ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o dia do seu nascimento: ");
            dia = int.Parse(Console.ReadLine());

            calculo = ((2022 - ano) * 365) + ((mes - 8) * 30) + dia;

            Console.WriteLine("Você tem {0} dias em idade.", calculo);

        }
    }
}