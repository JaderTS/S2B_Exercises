using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    class Lab_2_DataTypes
    {
        static void Main_2(String[] args)
        {
            Console.WriteLine("Exer 1");
            byte b;
            b = byte.MaxValue;
            Console.WriteLine("Valor máximo de b:" + b);
            b++;
            Console.WriteLine("Valor máximo de b+1:" + b);
            int ii = int.MaxValue;
            Console.WriteLine("Valor máximo de i:" + ii);
            long l = long.MaxValue;
            Console.WriteLine("Valor máximo de l:" + l);

            Console.WriteLine("");

            string strPrimeira = "Alo ";
            string strSegunda = "mundo";
            string strTerceira = strPrimeira + strSegunda;
            Console.WriteLine(strTerceira);
            int cchTamanho = strTerceira.Length;
            string strQuarta = "Tamanho: " + cchTamanho.ToString();
            Console.WriteLine(strQuarta);
            Console.WriteLine(strTerceira.Substring(0, 5));

            Console.WriteLine("");

            DateTime dt = new DateTime(2010, 1, 6);
            string strQuinta = dt.ToString();
            Console.WriteLine(strQuinta);
            Console.ReadLine();

            
        }
    }
}
