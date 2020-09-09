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

            if (jatekosValasz == gepValaszt) //Döntetlen
            {
                Console.WriteLine("Döntetlen");
            }

            else if (jatekosValasz == 0 && gepValaszt == 1 || jatekosValasz == 1 && gepValaszt ==2 || jatekosValasz ==2 && gepValaszt ==0) //Gép nyer
            {
                Console.WriteLine("Gép nyert");

            }
            else //Játékos nyer
            {
                Console.WriteLine("Játékos nyert");
            }
            


            Console.ReadKey();
        }
    }
}
