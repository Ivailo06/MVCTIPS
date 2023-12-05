using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_TIP.View
{
    internal class Display
    {
        public double Amount { get; private set; }//input
        public double Percent { get; private set; }
        public double Total { get; set; }//output
        public double TipAmount { get; set; }
        public void Input()
        {
            Console.Write("Suma:");
            Amount = double.Parse(Console.ReadLine());
            Console.Write("Baksisha");
            Percent = double.Parse(Console.ReadLine());
        }

        public void Output()
        {
            Console.WriteLine("---------------------------");
            Console.WriteLine($"baksisha : {TipAmount:C}");
            Console.WriteLine("----------------------------");
            Console.WriteLine($"Cqlata smetka : {Total:C}");
        }
    }
}
