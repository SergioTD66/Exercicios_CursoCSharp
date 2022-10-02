namespace Exercicio05_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Num programa que lê um valor inteiro, faça a sua validação através do tratamento de uma exceção. Caso não\r\nseja inteiro continuar pedindo a introdução do valor inteiro.");
            Console.WriteLine("\nResposta:\n");

            float numero = 0;
            bool valor_aceito = false;

            while (!valor_aceito)
            {
                // O bloco try contém o código protegido que pode causar a exceção. O bloco é executado até que
                // uma exceção seja lançada ou ele seja concluído com êxito. Por exemplo, a tentativa a seguir
                // de converter um objeto null gera a exceção
                try
                {
                    Console.Write("Informe um número inteiro: ");
                    numero = float.Parse(Console.ReadLine());
                    valor_aceito = true;
                }
                // Embora a cláusula catch possa ser usada sem argumentos para capturar qualquer tipo de exceção,
                // esse uso não é recomendado. Em geral, você deve capturar apenas as exceções das quais você
                // sabe se recuperar. Portanto, você sempre deve especificar um argumento de objeto derivado de
                // System.Exception. O tipo de exceção deve ser o mais específico possível para evitar a
                // aceitação incorreta de exceções que o manipulador de exceção realmente não é capaz de resolver.
                // Assim, prefira exceções concretas em vez do tipo base Exception
                catch (Exception)
                {
                    Console.WriteLine("Opção Inválida, um numero ao inves de caracter ou letra novamente!");
                    Console.ReadKey();
                }
            }
        }
    }
}