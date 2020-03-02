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

            Console.WriteLine(ciudad1.Replace('a', '4'));
            Console.WriteLine(ciudad2.Replace('a', '4'));
            Console.WriteLine(ciudad3.Replace('a', '4'));
            Console.WriteLine(ciudad4.Replace('a', '4'));
            Console.WriteLine(ciudad5.Replace('a', '4'));
            Console.WriteLine(ciudad6.Replace('a', '4'));
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

            foreach (var item in Barcelona)

            {

                Console.Write(item.ToString());
            }
            Console.WriteLine();

            Console.ReadKey();


            string[] Madrid = new string[6];

            Madrid[0] = "m";
            Madrid[1] = "a";
            Madrid[2] = "d";
            Madrid[3] = "r";
            Madrid[4] = "i";
            Madrid[5] = "d";

            foreach (var item in Madrid)
            {
                Console.Write(item.ToString());
            }
            Console.ReadKey();
            Array.Reverse(Madrid);
            foreach (var item in Madrid)

            {

                Console.Write(item.ToString());
            }
            Console.WriteLine();

            Console.ReadKey();

            string[] Cadiz = new string[5];

            Cadiz[0] = "c";
            Cadiz[1] = "a";
            Cadiz[2] = "d";
            Cadiz[3] = "i";
            Cadiz[4] = "z";
           

            foreach (var item in Cadiz)
            {
                Console.Write(item.ToString());
            }
            Console.ReadKey();
            Array.Reverse(Cadiz);
            foreach (var item in Cadiz)

            {

                Console.Write(item.ToString());
            }
            Console.WriteLine();

            Console.ReadKey();

            string[] malaga = new string[6];

            malaga[0] = "m";
            malaga[1] = "a";
            malaga[2] = "l";
            malaga[3] = "a";
            malaga[4] = "g";
            malaga[5] = "a";
           


            foreach (var item in malaga)
            {
                Console.Write(item.ToString());
            }
            Console.ReadKey();
            Array.Reverse(malaga);
            foreach (var item in malaga)

            {

                Console.Write(item.ToString());
            }
            Console.WriteLine();

            Console.ReadKey();

            string[] Santander = new string[9];

            Santander[0] = "s";
            Santander[1] = "a";
            Santander[2] = "n";
            Santander[3] = "t";
            Santander[4] = "a";
            Santander[5] = "n";
            Santander[6] = "d";
            Santander[7] = "e";
            Santander[8] = "r";
            foreach (var item in Santander)
            {
                Console.Write(item.ToString());
            }
            Console.ReadKey();
            Array.Reverse(Santander);

            foreach (var item in Santander)

            {

                Console.Write(item.ToString());
            }
            Console.WriteLine();

            Console.ReadKey();

            string[] Valencia = new string[8];

            Valencia[0] = "v";
            Valencia[1] = "a";
            Valencia[2] = "l";
            Valencia[3] = "e";
            Valencia[4] = "n";
            Valencia[5] = "c";
            Valencia[6] = "i";
            Valencia[7] = "a";
            
            foreach (var item in Valencia)
            {
                Console.Write(item.ToString());
            }
            Console.ReadKey();
            Array.Reverse(Valencia);

            foreach (var item in Valencia)

            {

                Console.Write(item.ToString());
            }
            Console.WriteLine();

            Console.ReadKey();






        }
    }
}
