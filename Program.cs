using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5zad
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string korisnik = Console.ReadLine();
            string[] polje = korisnik.Split(' ');
            int cijeli = Convert.ToInt32(polje[0])* 2;
            double decimalni = Convert.ToDouble(polje[1])* 2;
            Console.WriteLine(cijeli + " " + decimalni);

            Console.ReadKey();
        }
    }
}
