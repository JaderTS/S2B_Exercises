using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labs
{
    class Lab_3_Arrays
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Array de inteiros");
            int[] array = new int[5] { 10, 20, 30, 40, 50 };
            int i, j;

            for (i = 0; i < 5; i++)
            {
                Console.WriteLine("Indice = " + i + " & Valor = " + array[i]);
            }


            Console.WriteLine("\nArray de strings");
            string[] str = new string[3];
            int iStr;
            str[0] = "Um";
            str[1] = "Dois";
            str[2] = "Tres";
            for (iStr = 0; iStr < 3; iStr++)
            {
                Console.WriteLine("Indice = " + iStr + " & Valor = " + str[iStr]);
            }

            Console.WriteLine("\nArray de datas");
            DateTime[] dt = new DateTime[4];
            int iDate;
            dt[0] = new DateTime(2002, 5, 1);
            dt[1] = new DateTime(2002, 6, 1);
            dt[2] = dt[1].AddYears(10);
            dt[3] = dt[0].AddMonths(18);

            for (iDate = 0; iDate < 4; iDate++)
            {
                Console.WriteLine("Indice = " + iDate + " & Data = " + dt[iDate].ToShortDateString());
            }

            Console.WriteLine("");
            foreach (DateTime d in dt)
            {
                Console.WriteLine("Data = " + d.ToShortDateString());
            }

            //int i, j;
            Random r = new Random();

           
        }
    }
}
