using Labs.ClassesAndInheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    class Lab_5_ClassesAndInheritance
    {
        static void Main(string[] args)
        {
            Circulo circ1 = new Circulo();
            Console.WriteLine(circ1);
            Console.WriteLine("");            Circulo circ2 = new Circulo(2.4, 5, 3);
            Console.WriteLine(circ2);
            Console.ReadLine();
        }
    }
}
