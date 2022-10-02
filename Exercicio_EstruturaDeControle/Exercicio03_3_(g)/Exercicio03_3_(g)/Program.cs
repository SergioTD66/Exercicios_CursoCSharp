namespace Exercicio03_3__g_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A tabuada de um determinado número é uma tabela de produtos deste número\r\ncom os números de 1 a 9. Escreva um programa que peça um número ao usuário e\r\nimprima a tabuada deste número na tela. Caso o valor dado seja inválido o programa\r\ndeve apenas exibir uma mensagem de aviso. Escreva um programa usando cada\r\nestrutura de repetição estudada.");
            Console.WriteLine("\nResposta:\n");
            int i = 1;
            Console.Write("Digite o numero de um até 9: ");
            int numero = int.Parse(Console.ReadLine());
            // && = Determina os valores que podem ser usados dentro dos valores das pontas, neste caso do 1 até o 9.
            if (numero > 0 && numero < 10)
            {
                // for = Estrutura de repetição, usada para fazer o sistema trazer na tela varios valores determinando um limite.
                for (; i <= 10; i++)
                {
                    int tabuada = numero * i;
                    Console.WriteLine("{0} x {1} = {2}", numero, i, tabuada);
                }
            }
            else
            {
                Console.WriteLine("Número Inválido");
            }

        }
    }
}