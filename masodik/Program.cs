using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masodik
{
    class Program
    {
        static void Main(string[] args)
        {
            Random veletlen = new Random();
            string[] lehetoseg = new string[] { "Kő", "Papír", "Olló" };

            int gepValaszt = veletlen.Next(0, 3);

            Console.WriteLine("Gép választása: {0}", lehetoseg[gepValaszt]);

            int jatekosValasz;
            Console.WriteLine("Kő (0) Papír(1) Olló(2)");
            jatekosValasz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Játéks választása: {0}",lehetoseg[jatekosValasz]);
            


            Console.ReadKey();
        }
    }
}
