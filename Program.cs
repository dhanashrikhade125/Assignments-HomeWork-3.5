using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    internal class Program
    {
         static void Main(string[] args)
        {
            // 1.  Accept a number & print its table

            //  for (int i = 1; i <= 10; i++)
            //  {
            //       Console.WriteLine(i);
            //  }

            // 2. WAP to print even numbers from 1.- 50

            //  for (int x = 1; x <= 50; x++)
            //   if(x % 2 == 0)
            // {
            //     Console.WriteLine(x);
            // }

            // 3. WAP to print odd numbers from 1 - 50

            // for (int a = 0; a <= 50; a++)
            //   if (a % 2 != 0) 
            //{
            //    Console.WriteLine(a);
            // }


            // 4. Accept a number & print its table

            //int a = 4;
            //int b;
            //for (int i = 1; i <= 10; i++)
            //{
            //    b = a * i;
            //    Cosole.WriteLine(b);
            //}

            // 5.WAP to print series from 100 - 50
            for (int i = 100; i >= 50; i--)
                if(i%2!=0)
            {
                Console.WriteLine(i);
            }


        }
    }
}
      
