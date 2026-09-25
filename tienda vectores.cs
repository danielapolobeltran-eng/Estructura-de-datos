using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3 
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[] ventas = { 200.000, 302.300, 400.233, 700.432, 100, 233, 99.432, 902.211 };
            double total = 0;
            double mayorVenta = ventas[0];
            double menorVenta = ventas[0];
            int diaMayorVenta = 0;
            int diamenorVenta = 0;

            for (int i = 1; i < ventas.Length; i++)
            {
                total += ventas[i];

                if (ventas[i] > mayorVenta)
                {
                    mayorVenta = ventas[i];
                    diaMayorVenta = i;

                }
                if (ventas[i] > menorVenta)
                {
                    menorVenta = ventas[i];
                    diamenorVenta = i;

                }
            }
            double promedio = total / ventas.Length;
            int diasSobrepromedio = 0;

            for (int i = 0; i < ventas.Length; i++)
                if (ventas[i] > promedio)
                {
                    diasSobrepromedio++;
                }
            Console.WriteLine("============ REPORTE DE VENTAS ============");
            Console.WriteLine();

            Console.WriteLine($"total vendido: ${total}");
            Console.WriteLine($"promedio diario: ${promedio}");
            Console.WriteLine();

            Console.WriteLine($"mayor venta ${mayorVenta} - el Dia {diaMayorVenta + 1}");
            Console.WriteLine($"menor venta ${mayorVenta} - el Dia {diamenorVenta + 1}");

            Console.WriteLine($"dias que superaron el promedio de ventas: ${diasSobrepromedio}");
            Console.WriteLine();

            Console.WriteLine("ventas por dias");
            for (int i = 0; i < ventas.Length; i++)
            {
                Console.WriteLine($"dias {i + 1}: ${ventas[i]:F2}");

            }

        }

        
       
    }
}
