﻿using System;
using System.IO;

namespace miPrograma1.Properties.service
{
    public class csvFormater : formatDecorator
    {
        public csvFormater()
        {
            
        }
        public csvFormater(format fDecorator) : base(fDecorator)
        {
        }

        public override void create(string[] archivo)
        {
            System.Console.WriteLine("CSV");
            float tamaño = archivo.Length;
            String lines = "";
            string docPath = Directory.GetCurrentDirectory();;
            File.WriteAllText(Path.Combine(docPath, "csv.csv"), "");
            for (int i = 0; i < tamaño-1; i++)
            {
                string text = System.IO.File.ReadAllText(@archivo[i]);
                text= text.Replace(" ", ",");
                System.Console.WriteLine("Archivo No. : " +(i+1)+"\n"+text + "\n");
                lines = "Archivo No. : " + (i + 1) + "\n" + text + "\n";
                File.AppendAllText(Path.Combine(docPath, "csv.csv"),lines );
                
            }
        }
        
    }
}