using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int mainigais = 3;

            // < 
            // >
            // == lieto lai salidzinatu vertibas(2 x "=" )
            // !=  2 vertibas nav vienadas
            // >= lielaks vienads
            // <= mazaks vienads

            if(mainigais < 5)
            {
                Console.WriteLine("mazaks");

            }
            else
            {
                Console.WriteLine("lielaks");
                

            }

            string mainigais2 = "si ir virkne";
            if (mainigais2 == "si ir virkne")
            {
                Console.WriteLine("vienads");
            }
            else
            {
                Console.WriteLine("nav vienads");


            }
            Console.ReadLine();
        }
    }
}
