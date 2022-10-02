using System.Collections;


namespace Exercicio04_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(Stack) Escreva um programa solicite ao usuário uma sequência de caracteres sem\r\nlimite de máximo de tamanho e realize as seguintes operações usando uma pilha:\r\na) Imprimir o texto na ordem inversa;\r\nb) Verificar se o texto é um palíndromo, ou seja, se a string é escrita da mesma\r\nmaneira de frente para trás e de trás para frente. Ignore espaços e pontos.");
            Console.WriteLine("\nResposta:\n");

            // Stack = Representa uma coleção não genérica simples UEPS (último a entrar, primeiro a sair) de objetos.
            Stack lista1 = new Stack();
            char resposta = ' ';


            while (resposta != '-')
            {
                Console.WriteLine("Digite apenas um caractere: ");
                Console.WriteLine("- Sair");
                resposta = char.Parse(Console.ReadLine());

                if (resposta == resposta)
                {
                    lista1.Push(resposta);
                }
            }
            Console.Write("\nOrdem dos valores digitados:\n");
            foreach (var elemento in lista1)
            {
                Console.Write("{0}", elemento);
            }

            Stack lista2 = new Stack(lista1.ToArray());

            Console.Write("\nOrdem inversa:\n");
            foreach (var numero in lista2)
            {
                Console.Write(numero);
            }
        }
    }
}