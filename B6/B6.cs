﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B6
{
    internal class B6
    {
        class Program
        {
            static void Main(string[] args)
            {
                string[] names = { "David", "Jane", "Peter", "John", "Mark" };
                foreach (string item in names.OrderBy(s => s)) {
                    Console.WriteLine(item);
                }
                Console.ReadLine();
            }
        }
    }
}
