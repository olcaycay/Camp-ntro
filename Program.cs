using System;

namespace Campİntro
{
    class Program
    {
        static void Main(string[] args)
        {

            double dolarDun = 7.45;
            double dolarBugun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("azalış oku");
            }

            else if (dolarDun<dolarBugun)
            {
                Console.WriteLine("artış oku");
            }
            else
            {
                Console.WriteLine("değişmedi oku");
            }


            }
        }

        
    }

