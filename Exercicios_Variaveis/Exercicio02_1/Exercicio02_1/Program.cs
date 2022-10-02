namespace Exercicio02_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Titulo do exercicio 
            Console.Write("\n1) Escreva um programa que armazene o valor 10 em uma variável A e o valor 20 em\r\numa variável B. A seguir (utilizando apenas atribuições entre variáveis) troque os seus\r\nconteúdos fazendo com que o valor que está em A passe para B e vice-versa. Ao final,\r\nescrever os valores que ficaram armazenados nas variáveis.\n");
            // "\n" Comando usado para pular linha.
            // "\r" usado para dar limite finalizando um texto, pode ser combinado com \n \t e etc "\r\n" (Terminar e continuar na proxima linha)
            Console.WriteLine("\nResposta:");
            

            // Identificando as variaveis.
            int A = 10; 
            int B = 20;
            int C = A; // Variavel para ocorrer a mudança.

            // Formula para fazer a mudança de valores entre A e B.
            A = B;
            B = C;

            // Comando para trazer a respota na tela, sepre começa por {0} e não pode pular.
            Console.WriteLine("\nValor de A: {0} - valor de B: {1}", A, B);
        }
    }
}