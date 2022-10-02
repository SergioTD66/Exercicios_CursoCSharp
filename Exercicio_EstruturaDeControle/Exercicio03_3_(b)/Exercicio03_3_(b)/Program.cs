namespace Exercicio03_3__b_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ler os valores de quatro notas escolares de um aluno. Calcular a média aritmética e\r\napresentar a mensagem “Aprovado” se a média obtida for maior ou igual a 7; caso\r\ncontrário, o programa deve solicitar a nota de exame do aluno e calcular uma nova\r\nmédia aritmética entre a nota de exame e a primeira média aritmética. Se o valor\r\nda nova média for maior ou igual a cinco, apresentar a mensagem “Aprovado em\r\nexame”; caso contrário, apresentar a mensagem “Reprovado”. Informar junto com\r\ncada mensagem o valor da média obtida;");
            Console.WriteLine("\nResposta:\n");

            Console.Write("Digite nota da P1: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite nota  da P2: ");
            double nota2 = double.Parse(Console.ReadLine());
            Console.Write("Digite a nota de trabalho: ");
            double nota3 = double.Parse(Console.ReadLine());
            Console.Write("Digite a nota de prévia: ");
            double nota4 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2 + nota3 + nota4) / 4;
            
            if (media >= 7)
            {
                Console.WriteLine("Aprovado média: {0:F1}", media);
            }
            else
            {
                Console.WriteLine("Aluno terá que cursar exame, pois media é: {0:F1}", media);
                Console.Write("Digite a nota do exame: ");
                float exame = float.Parse(Console.ReadLine());
                double recuperacao = (media + exame) / 2;
                // Para casos de sim ou não, pode ser feito um if/else dentro de outro if.
                if (recuperacao >= 5)
                {
                    Console.WriteLine("Aprovado média: {0:F1}", recuperacao);
                }
                else
                {
                    Console.WriteLine("Reprovado média: {0:F1}", recuperacao);
                }
            }
        }
    }
}