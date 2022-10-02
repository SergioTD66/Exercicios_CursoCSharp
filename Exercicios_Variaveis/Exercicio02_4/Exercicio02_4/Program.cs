namespace Exercicio02_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("A empresa Lucro Certo paga R$ 10,00 por hora normal trabalhada, e R$ 15,00 por hora\r\nextra. Faça um programa para calcular e imprimir o salário bruto e o salário líquido de\r\num determinado funcionário. Considere que o salário líquido é igual ao salário bruto\r\ndescontando-se 10% de impostos.\n");
            Console.WriteLine("\nResposta:\n");
            double servico = 10.00, extras = 15.00;
            int normal_horas, extra_horas;
            double salario, extra_salario;
           
            Console.WriteLine("Digite horas trabalhadas: ");
            normal_horas = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite a hora extra: ");
            extra_horas = int.Parse(Console.ReadLine());
            

            if (extra_horas == 0)
            {
                salario = servico * normal_horas;
                extra_salario = salario - ((salario * 10) / 100);
                Console.WriteLine("\nO salário líquido é: R${0}\nE o salário bruto é: R${1}", salario, extra_salario);
            }
            else
            {
                salario = (servico * normal_horas) + (extras * extra_horas);
                extra_salario = salario - ((salario * 10) / 100);
                Console.WriteLine("\nO salário bruto é: R${0}\nE o salário líquido é: R${1:F2}", salario, extra_salario);

            }
          
        }
    }
}