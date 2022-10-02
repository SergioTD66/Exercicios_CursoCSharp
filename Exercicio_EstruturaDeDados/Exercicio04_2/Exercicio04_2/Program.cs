namespace Exercicio04_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(HashSet) Construa um método que recebe uma lista encadeada de números inteiros e\r\nretorna uma lista sem repetições, ou seja, uma lista onde cada número apareça apenas\r\numa vez.\r\nExemplo:\r\n12 5 -7 8 5 9 12 1 8 → 12 5 -7 8 9 1");
            Console.WriteLine("\nResposta:\n");

            //A HashSet<T> classe fornece operações de conjunto de alto desempenho. Um conjunto é uma coleção que
            //não contém elementos duplicados e cujos elementos não estão em nenhuma ordem específica.
            HashSet<int> numeros = new HashSet<int>();
            int resposta = 1;
            while (resposta != 0)
            {
                Console.Write("Digite um numero: ");
                resposta = int.Parse(Console.ReadLine());
                Console.WriteLine("\nAperte 0 para gerar resposta");
                
            
                if (resposta != 0)
                {
                    numeros.Add(resposta);

                }
            }
            Console.WriteLine("\n");
            foreach (int i in numeros)
            {
                Console.Write(" " + i);
            }
        }
    }
}