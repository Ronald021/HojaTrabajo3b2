﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace miPrograma1.Properties.service
{
    public class jsonFormater : formatDecorator
    {
        public jsonFormater() { }
        public jsonFormater(format fDecorator) : base(fDecorator)
        {
        }

        public override void create(string[] archivo)
        {


            float tamaño = archivo.Length;
            String lines = "";
            string docPath = Directory.GetCurrentDirectory();;
            File.WriteAllText(Path.Combine(docPath, "json.json"), "");
            System.Console.WriteLine("\nArchivo(s) Formato JSON\n");
            for (int i = 0; i < tamaño-1; i++)
            {
                string text = System.IO.File.ReadAllText(@archivo[i]);
                List<string> result = text.Split(' ').ToList();
                System.Console.WriteLine("\"Archivo No"+ (i+1)+"\": [");
                File.AppendAllText(Path.Combine(docPath, "json.json"), ("\"Archivo No"+ (i+1)+"\": [") );
                result.ForEach(delegate(String name)
                {
                    Console.WriteLine("\t {\"" +name+"\"" + "},");
                    lines = "\t {\"" +name+"\"" + "},";
                    File.AppendAllText(Path.Combine(docPath, "json.json"),lines );
                });
                System.Console.WriteLine("\t ]\n");
                File.AppendAllText(Path.Combine(docPath, "json.json"), ("\t ]\n"));
            }
        }
    }
}