using System;


namespace Exercicio1
{
    class QuintoProjeto1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Some dois valores. Por favor, digite o primeiro número:");
            int n_1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Agora digite o segundo número:");
            int n_2 = int.Parse(Console.ReadLine());
            int n_3 = n_1 + n_2;
            Console.WriteLine($"A soma é equivalente a: {n_3}!");

            Console.WriteLine("");
            
            Console.WriteLine("Some dois valores. Por favor, digite o primeiro número e, separado por um único espaço, digite o segundo número:");
            string[] v_nums = Console.ReadLine().Split(' ');
            int v_num_1 = int.Parse(v_nums[0]);
            int v_num_2 = int.Parse(v_nums[1]);
            int v_num_3 = v_num_1 + v_num_2;
            Console.WriteLine($"A soma é equivalente a: {v_num_3}!");
        }
    }
}