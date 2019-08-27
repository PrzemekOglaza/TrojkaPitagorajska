using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrojkaPitagorejska
{      // Napisz program, który dla trzech liczb a, b, c wprowadzonych z klawiatury sprawdza, czy tworz one trójk pitagorejsk
    class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;

            Console.WriteLine("Program sprawdzi czy wpisane liczby: a,b,c, tworzą trójkę pitagorejską.");

            Console.WriteLine("Podaj liczbę a: ");
            a = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj liczbę b: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine("Podaj liczbę c: ");
            c = int.Parse(Console.ReadLine());

            if ((a*a)+(b*b) == (c*c))
            {
                Console.WriteLine("Wprowadzone liczby");
                Console.WriteLine("a =  " +a+ ". ");
                Console.WriteLine("b =  " +b+ ". ");
                Console.WriteLine("c =  " +c);
                Console.WriteLine("  są trójką pitagorejską");
            }
            else
            {
                Console.WriteLine("Wprowadzone liczby");
                Console.WriteLine("a =  " + a + ". ");
                Console.WriteLine("b =  " + b + ". ");
                Console.WriteLine("c =  " + c);
                Console.WriteLine(" nie są trójką pitagorejską");
            }
            Console.Read();
        }
    }
}
