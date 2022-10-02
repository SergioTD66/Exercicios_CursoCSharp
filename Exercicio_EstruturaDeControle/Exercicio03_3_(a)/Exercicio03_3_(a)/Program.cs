namespace Exercicio03_3__a_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ler os valores de quatro notas escolares de um aluno. Calcular a média aritmética e\r\napresentar a mensagem “Aprovado” se a média obtida for maior ou igual a 5; caso\r\ncontrário, apresentar a mensagem “Reprovado”. Informar com cada mensagem o\r\nvalor da média obtida;\n");
            Console.WriteLine("Resposta:\n");

            Console.Write("Digite nota da P1: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite nota  da P2: ");
            double nota2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a nota de trabalho: ");
            double nota3 = double.Parse(Console.ReadLine());
            Console.Write("Digite a nota de prévia: ");
            double nota4 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3 + nota4) / 4;
            if (media >= 5)
            {
                Console.WriteLine("\nAprovado média: {0}", media);
            }
            else
            {
                Console.WriteLine("\nReprovado média: {0}", media);

            }
        }
    }
}