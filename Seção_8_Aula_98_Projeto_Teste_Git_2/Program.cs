using System;

namespace Seção_8_Aula_98_Projeto_Teste_Git_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Nome: ");
            string name = Console.ReadLine();
            Console.Write("Idade: ");
            int age = int.Parse(Console.ReadLine());
            Console.Write("Doença infectuosa? SIM ou NÃO: ");
            string infectDesease = Console.ReadLine();
            if (age >= 65 && infectDesease == "SIM")
            {
                Console.WriteLine("Atendimento preferencial - Sala Amarela");
            }
            else if (age < 65 && infectDesease == "SIM")
            {
                Console.WriteLine("Atendimento não preferencial - Sala Amarela");
            }
            else if (age >= 65 && infectDesease == "NÃO")
            {
                Console.WriteLine("Atendimento preferencial - Sala Branca");
            }
            else if(age < 65 && infectDesease == "NÃO")
            {
                Console.WriteLine("Atendimento não preferencial - Sala Branca");
            }
            else
            {
                Console.WriteLine("Digite 'SIM' ou 'NÃO' para doença infectuosa");
            }
        }
    }
}
