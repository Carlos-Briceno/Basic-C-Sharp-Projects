﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i < 10)
            {
                Console.WriteLine("i = {0}", i);
                i++;
            }


            int j = 0;
            do
            {
                Console.WriteLine("j = {0}", j);
                j++;
                
                if (j > 5)
                    break;

            } while (j < 10);

            Console.ReadLine();
        }
    }
}
