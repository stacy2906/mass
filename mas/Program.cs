using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mas
{
    internal class Program
    {
        static void Main(string[] args)
        {   // 1
            //int[] mass = new int[8];
            //for(int i=0;i<8;i++)
            //{
            //    Console.Write($"mass[{i}]=");
            //    mass[i] = Convert.ToInt32(Console.ReadLine());
            //}
            //for(int i=0;i<8;i++)
            //{
            //    Console.WriteLine($"mass[{i}]={mass[i]}");
            //}

            // 2
            //double[] mass = new double[8] { -1.3, 5.87, 49, -69.5, 1.5, 1.35, 5, 89 };
            //for (int i = 0; i < mass.Length; i++)
            //{
            //    if (mass[i] > 0)
            //    {
            //        Console.WriteLine(mass[i]);
            //    }
            //}

            // 3
            //int[] mass = new int[6] { -7, 10, 5, 16, -4, 18 };
            //int n = mass.Length;
            //int k = n / 2;
            //int temp;
            //for (int i = 0; i < k; i++)
            //{
            //    temp = mass[i];
            //    mass[i] = mass[n - i - 1];
            //    mass[n - i - 1] = temp;
            //}
            //foreach (int i in mass)
            //{
            //    Console.WriteLine($"{i}");
            //}

            // 4
            //Random random = new Random();
            //int h = 12;
            //int[] mass = new int[h];
            //for (int i = 0; i < h; i++)
            //{
            //    mass[i] = random.Next(163, 190);
            //}
            //foreach (int elem in mass)
            //{
            //    Console.WriteLine("{0}", elem);
            //}
            Console.ReadKey();
        }
    }
}
