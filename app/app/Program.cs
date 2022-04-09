using app.Domain;
using app.Service;
using System;
using System.Collections.Generic;

namespace app
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Trade> trades = new List<Trade>();
            Creator creator = new Creator(trades);
            Console.WriteLine("Begin :)");
            int cont = 0;   
            Console.Write("Informe a quantidade de transacoes:");
            int transacoes = int.Parse(Console.ReadLine());

            while (cont < transacoes)
            {
                Console.Write("Informe o tipo de pessoa (public ou private):");
                string tipo = Console.ReadLine();

                Console.Write("Informe o valor do trade:");
                double valor = Convert.ToDouble(Console.ReadLine());

                Console.Write("Informe o dia do proximo vencimento:");
                int dd = int.Parse(Console.ReadLine());

                Console.Write("Informe o mes do proximo vencimento:");
                int mm = int.Parse(Console.ReadLine());

                Console.Write("Informe o ano do proximo vencimento:");
                int yyyy = int.Parse(Console.ReadLine());

                creator.GetTraders(valor, tipo.ToLower(), new DateTime(yyyy, mm, dd));

                cont++;
            }

            Console.WriteLine($"Foram efetuadas {transacoes}.");

            foreach (var item in trades)
            {
                Console.WriteLine(item.ToString());
            }
            
            Console.ReadKey();
        }
    }
}
