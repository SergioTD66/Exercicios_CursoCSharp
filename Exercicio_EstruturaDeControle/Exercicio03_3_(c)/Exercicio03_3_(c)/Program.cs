namespace Exercicio03_3__c_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ler cinco valores numéricos inteiros, identificar e apresentar o maior e o menor\r\nvalores informados;");
            Console.WriteLine("\nResposta:\n");

            Console.Write("Digite um primeiro valor : ");
            int numero1 = int.Parse(Console.ReadLine());
            Console.Write("Digite um segundo valor : ");
            int numero2 = int.Parse(Console.ReadLine());
            Console.Write("Digite um terceiro valor : ");
            int numero3 = int.Parse(Console.ReadLine());
            Console.Write("Digite um quarto valor : ");
            int numero4 = int.Parse(Console.ReadLine());
            Console.Write("Digite um quinto valor : ");
            int numero5 = int.Parse(Console.ReadLine());

            //Lista para os maiores
            if (numero1 > numero2 && numero1 > numero3 && numero1 > numero3 && numero1 > numero5)
            {
                Console.WriteLine("\nValor maior é: {0}", numero1);
            }
            else if (numero2 > numero1 && numero2 > numero3 && numero2 > numero3 && numero2 > numero5)
            {
                Console.WriteLine("\nValor maior é: {0}", numero2);
            }
            else if (numero3 > numero1 && numero3 > numero2 && numero3 > numero4 && numero3 > numero5)
            {
                Console.WriteLine("\nValor maior é: {0}", numero3);
            }
            else if (numero4 > numero1 && numero4 > numero2 && numero4 > numero3 && numero4 > numero5)
            {
                Console.WriteLine("\nValor maior é: {0}", numero4);
            }
            else
                Console.WriteLine("\nValor maior é: {0}", numero5);
            
            //Lista dos menores
            if (numero1 < numero2 && numero1 < numero3 && numero1 < numero3 && numero1 < numero5)
            {
                Console.WriteLine("\nValor menor é: {0}", numero1);
            }
            else if (numero2 < numero1 && numero2 < numero3 && numero2 < numero3 && numero2 < numero5)
            {
                Console.WriteLine("\nValor menor é: {0}", numero2);
            }
            else if (numero3 < numero1 && numero3 < numero2 && numero3 < numero4 && numero3 < numero5)
            {
                Console.WriteLine("\nValor menor é: {0}", numero3);
            }
            else if (numero4 < numero1 && numero4 < numero2 && numero4 < numero3 && numero4 < numero5)
            {
                Console.WriteLine("\nValor menor é: {0}", numero4);
            }
            else
                Console.WriteLine("\nValor menor é: {0}", numero5);
        }
    }
}