﻿using System;

namespace pr4n1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Int16 i16 = 1; Int32 i32 = 1; double db = 1;
            i16 = 132;
            i16 = db;
            i32 = i16;
            i32 = db;
            db = 116; db = i32;

        }
    }
}
