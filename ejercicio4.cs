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
            double NUM1, NUM2, NUM3, intermedio;
            string linea;

            Console.Write("INGRESE PRIMER NÚMERO: "); linea = Console.ReadLine();
            NUM1 = double.Parse(linea);
            Console.Write("INGRESE SEGUNDO NÚMERO: "); linea = Console.ReadLine();
            NUM2 = double.Parse(linea);
            Console.Write("INGRESE TERCER NÚMERO: "); linea = Console.ReadLine();
            NUM3 = double.Parse(linea);
            Console.WriteLine();

           
           
            Console.WriteLine("EL NÚMERO INTERMEDIO ES: " + intermedio);
            Console.Write("Pulse una Tecla:"); Console.ReadLine();
        }
    }
}