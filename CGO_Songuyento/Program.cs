using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Songuyento
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("nhap so: ");
            number = Convert.ToInt32(Console.ReadLine());
            if (number < 2)
                Console.WriteLine(number + " khong la so nguyen to");
            else
            {
                int i = 2;
                bool check = true;
                while (i <= Math.Sqrt(number))
                {
                    if (number % i == 0)
                    {
                        check = false;
                        break;
                    }
                    i++;
                }
                if (check)
                {
                    Console.WriteLine(number + " la so nguyen to");
                }
                else
                {
                    Console.WriteLine(number + " khong la so nguyen to");
                }
            }
        }
    }
}
