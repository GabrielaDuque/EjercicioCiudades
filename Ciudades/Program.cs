using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ciudades
{
    class Program
    {
        static void Main(string[] args)
        {

            // Fase 1

            Console.WriteLine("Ingresa 6 ciudades");
            string ciudad1;
            string ciudad2;
            string ciudad3;
            string ciudad4;
            string ciudad5;
            string ciudad6;
            ciudad1 = Console.ReadLine();
            ciudad2 = Console.ReadLine();
            ciudad3 = Console.ReadLine();
            ciudad4 = Console.ReadLine();
            ciudad5 = Console.ReadLine();
            ciudad6 = Console.ReadLine();

            Console.WriteLine("Estas son las ciudades");

            Console.WriteLine(ciudad1);
            Console.WriteLine(ciudad2);
            Console.WriteLine(ciudad3);
            Console.WriteLine(ciudad4);
            Console.WriteLine(ciudad5);
            Console.WriteLine(ciudad6);

            Console.ReadKey();

            //FASE 2


            Console.WriteLine("Por orden alfabetico");

            string[] ciudades = { "Barcelona", "Madrid", "Malaga", "Valencia", "Cadiz", "Santander"
        };
            Array.Sort(ciudades);
            foreach (string s in ciudades)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();


            //Fase 3

            string[] ciudadesModificadas = { "B4rcelon4", "M4drid", "M4l4g4", "V4lenci4", "C4diz", "S4nt4nder"
        };
            Array.Sort(ciudadesModificadas);
            foreach (string s in ciudadesModificadas)
            {
                Console.WriteLine(s);
            }
            Console.ReadKey();

            //Fase 4

            string[] Barcelona = new string[9];

            Barcelona[0] = "b";
            Barcelona[1] = "a";
            Barcelona[2] = "r";
            Barcelona[3] = "c";
            Barcelona[4] = "e";
            Barcelona[5] = "l";
            Barcelona[6] = "o";
            Barcelona[7] = "n";
            Barcelona[8] = "a";
            foreach (var item in Barcelona)
            {
                Console.Write(item.ToString());
            }

            Console.ReadKey();


            Array.Reverse(Barcelona);

            // Print.
            foreach (var item in Barcelona)
               
                {
                
                Console.Write(item.ToString());
            }
            Console.WriteLine();

            Console.ReadKey();
        }
    }
}
