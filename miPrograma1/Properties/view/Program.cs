﻿using System;
using miPrograma1.Properties.service;

namespace miPrograma1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            String form = args[(args.Length - 1)];
            formatMaker hi = new formatMaker();
            hi.convert(args,form);
        }
    }
}