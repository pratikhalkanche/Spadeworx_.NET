﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstproject
{
    class Unboxing
    {
        // Main Method
        static public void Main()
        {

            // assigned int value
            // 23 to num
            int num = 23;

            // boxing
            object obj = num;

            // unboxing
            int i = (int)obj;

            // Display result
            Console.WriteLine("Value of ob object is : " + obj);
            Console.WriteLine("Value of i is : " + i);
        }
    }




}

