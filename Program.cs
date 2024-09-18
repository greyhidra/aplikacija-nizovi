using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int duzina = int.Parse(Console.ReadLine());
            int[] niz = new int[duzina];

            for (int i = 0; i < niz.Length; i++)
            {
                // Console.WriteLine(i);
                niz[i] = int.Parse(Console.ReadLine());
            }
            for (int i = 0; i < niz.Length; i++)
            {
                if (niz[i] % 2 == 0)
                {
                    Console.WriteLine("Paran broj" + i + "je broj" + niz[i]);
                }
            }
        }
    }
}
