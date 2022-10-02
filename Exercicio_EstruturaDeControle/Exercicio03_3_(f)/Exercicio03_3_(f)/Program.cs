namespace Exercicio03_3__f_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fazer um programa que dada a altura e peso de uma pessoa, calcule seu índice\r\nde massa corporal. Fórmula: Peso / Altura2. Em seguida, mostre em que faixa\r\nde peso a pessoa se encontra. Faixas: <= 18,5 - abaixo do peso normal; > 18,5 e\r\n<= 25 - peso normal; > 25 e <=30 - peso acima do normal; acima de 30 - peso\r\nexcessivo.");
            Console.WriteLine("\nResposta:\n");
            
            float altura, peso;
            double massa_corporal;
            Console.WriteLine("Calcule seu índice de massa corporal\n");
            Console.Write("Diigite sua altura:");
            altura = float.Parse(Console.ReadLine());
            Console.Write("Diigite seu peso:");
            peso = float.Parse(Console.ReadLine());

            massa_corporal = peso / (altura * altura);

            if (massa_corporal <= 18.5)
            {
                Console.WriteLine("Faixa de peso: {0:F2} - Abaixo do peso normal.", massa_corporal);

            }
            else if (massa_corporal <= 25)
            {
                Console.WriteLine("Faixa de peso: {0:F2} - Peso normal.", massa_corporal);
            }
            else if (massa_corporal <= 30)
            {
                Console.WriteLine("Faixa de peso: {0:F2} - Peso acima do normal.", massa_corporal);
            }
            else
                Console.WriteLine("Faixa de peso: {0:F2} - Peso exessivo.", massa_corporal);
        }
    
    }
}