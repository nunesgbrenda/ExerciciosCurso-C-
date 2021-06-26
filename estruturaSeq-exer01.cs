using System;

namespace estruturaSeq-exer01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Digite dois valores inteiros para uma soma: ");
            int n1;
            int n2;
            int soma; 

            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            soma = n1 + n2;
            Console.WriteLine("Soma= "+soma);
        }
    }
}
