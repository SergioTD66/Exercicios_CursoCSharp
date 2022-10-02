namespace Exercicio04_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("(Dictionary) Monte uma lista de chamada com número e o nome do aluno de uma sala\r\nde aula com 20 alunos, depois informe o nome do aluno número 7.");
            Console.WriteLine("\nRersposta:\n");

            // O exemplo de código a seguir cria um vazio Dictionary<TKey,TValue> de cadeias de caracteres com
            // chaves de cadeia de caracteres e usa o Add método para adicionar alguns elementos. O exemplo
            // demonstra que o Add método gera uma ArgumentException ao tentar adicionar uma chave duplicada.

            Dictionary<int, string> chamada = new Dictionary<int, string>();
            string nome;
            Console.WriteLine("Sala de Aula- chamada");


            for (int i = 1; i <= 20; i++)
            {
                Console.Write("nome:");
                nome = Console.ReadLine();
                chamada.Add(i, nome);
            }
            Console.WriteLine("\nNúmero 7 - Nome: :{0}", chamada[7]);
        }
    }
}
