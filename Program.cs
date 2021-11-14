using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oefening1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaratie
            int intGetal1, intGetal2, intSom;
            //Initialisatie
            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.Write("Geef getal 1: ");
            intGetal1 = Convert.ToInt32(Console.ReadLine());
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("Geef getal 2: ");
            intGetal2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            //Verwerking
            intSom = intGetal1 + intGetal2;
            //Uitvoer
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("De som bedraagt: {0}", intSom.ToString());
            Console.ReadLine();
        }
    }
}
