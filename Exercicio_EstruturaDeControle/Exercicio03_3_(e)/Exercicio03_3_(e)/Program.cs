namespace Exercicio03_3__e_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("No ensino público, normalmente as notas são dadas através de conceitos (A, B, C,\r\nD, E). Elabore um programa que leia uma nota numérica de 0 a 10 e exiba o conceito\r\nrelativo a esta nota, conforme tabela abaixo.\r\n\nNota Conceito:\r\nDe 0.0 à 1.9 E\r\nDe 2.0 à 4.9 D\r\nDe 5.0 à 6.9 C\r\nDe 7.0 à 8.9 B\r\nDe 9.0 à 10.0 A");
            Console.WriteLine("\nResposta:\n");

            Console.Write("Digite a nota do aluno entre 0 a 10: ");
            float nota = float.Parse(Console.ReadLine());
            // Neste caso qualquer nota abaixo do campo declarado vai entrar no if else determinado minimo na tabela.
            if (nota <= 1.9)
            {
                Console.WriteLine("Sua nota é E.");
            }
            else if (nota <= 4.9)
            {
                Console.WriteLine("Sua nota é D.");
            }
            else if (nota <= 6.9)
            {
                Console.WriteLine("Sua nota é C.");
            }
            else if (nota <= 8.9)
            {
                Console.WriteLine("Sua nota é B.");
            }
            else
                Console.WriteLine("Sua nota é A.");
        }
    
    }
}