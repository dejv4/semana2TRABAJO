using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            double NUM1, NUM2, NUM3, MAYOR, MENOR;
            string linea;

            Console.Write("INGRESE PRIMER NÚMERO: "); linea = Console.ReadLine();
            NUM1 = double.Parse(linea);
            Console.Write("INGRESE SEGUNDO NÚMERO: "); linea = Console.ReadLine();
            NUM2 = double.Parse(linea);
            Console.Write("INGRESE TERCER NÚMERO: "); linea = Console.ReadLine();
            NUM3 = double.Parse(linea);
            Console.WriteLine();

    
            MAYOR = NUM1;
            if (NUM2 > MAYOR) MAYOR = NUM2;
            if (NUM3 > MAYOR) MAYOR = NUM3;

            MENOR = NUM1;
            if (NUM2 < MENOR) MENOR = NUM2;
            if (NUM3 < MENOR) MENOR = NUM3;

            Console.WriteLine("EL NÚMERO MAYOR ES: " + MAYOR);
            Console.WriteLine("EL NÚMERO MENOR ES: " + MENOR);
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
    }
}