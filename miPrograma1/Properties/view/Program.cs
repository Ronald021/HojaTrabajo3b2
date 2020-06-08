using System;
using System.IO;
using miPrograma1.Properties.service;

namespace miPrograma1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            convert hi = new convert();
            hi.create(args);
            
        }
    }
}