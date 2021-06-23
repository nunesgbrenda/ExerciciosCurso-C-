using System;
using System.Globalization;

namespace exer
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Entre com seu nome completo: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Quantos quartos tem em sua casa?: ");
            int quarto = int.Parse(Console.ReadLine());

            Console.WriteLine("Quanto foi a sua Televisão: ");
            double tv = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com seu último nome, idade e altura (mesma linha): ");
            string dados = Console.ReadLine();
            string[] vet = dados.Split(' ');
            string sobremome = vet[0];
            string idade = vet[1];
            string altura = vet[2];

            Console.WriteLine("Você digitou: ");
            Console.WriteLine(nome);
            Console.WriteLine(quarto);
            Console.WriteLine(tv.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine(sobremome);
            Console.WriteLine(idade);
            Console.WriteLine(altura);


        }

    }
}
