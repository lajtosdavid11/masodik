using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace masodik
{
    class Program
    {
        static int embernyer(int gep, int ember)
        {
            if (ember == gep) //Döntetlen
            {
                return 0;
            }

            else if (ember == 0 && gep == 1 || ember == 1 && gep == 2 || ember == 2 && gep == 0) //Gép nyer
            {
                Console.WriteLine("Gép nyert");
                return 1;

            }
            else //Játékos nyer
            {
                Console.WriteLine("Játékos nyert");
                return 2;
            }
        }

        static void eredmenykiiras(int gep, int ember)
        {
            switch (embernyer(gep, ember))
            {
                case 0:
                    Console.WriteLine("Döntetlen");
                    break;
                case 1:
                    Console.WriteLine("Gép nyert");
                    break;
                case 2:
                    Console.WriteLine("Játékos nyert");
                    break;

            }
        }

        static void Main(string[] args)
        {
            Random veletlen = new Random();
            string[] lehetoseg = new string[] { "Kő", "Papír", "Olló" };

            int gepValaszt = veletlen.Next(0, 3);

            Console.WriteLine("Gép választása: {0}", lehetoseg[gepValaszt]);

            int jatekosValasz;
            Console.WriteLine("Kő (0) Papír(1) Olló(2)");
            jatekosValasz = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Játéks választása: {0}", lehetoseg[jatekosValasz]);


            eredmenykiiras(gepValaszt, jatekosValasz);

            Console.ReadKey();
        }
    }
}
