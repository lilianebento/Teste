using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Black_Friday
{
    class Program
    {
        static void Main(string[] args)
        {
            double produto;
            double desconto = 60.00 / 100.0;
            double valor_desconto;
            double prod_desc;

            Console.WriteLine("Digite o valor do produto:");
            produto = double.Parse(Console.ReadLine());

            valor_desconto = (produto - (desconto * produto));
            prod_desc = (produto * desconto);

            Console.WriteLine("\n\n");
            Console.WriteLine("O produto custava:  " + produto);
            Console.WriteLine("Com desconto custa:  " + prod_desc);
            Console.WriteLine("Valor do desconto:  " + valor_desconto);

            Console.ReadKey();

        }
    }
}
