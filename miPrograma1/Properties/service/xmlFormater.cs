﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace miPrograma1.Properties.service
{
    public class xmlFormater : formatDecorator
    {
        public xmlFormater() { }
        
        public xmlFormater(format fDecorator) : base(fDecorator)
        {
        }

        public override void create(string[] archivo)
        {
            float tamaño = archivo.Length;
            string docPath = Directory.GetCurrentDirectory();;
            File.WriteAllText(Path.Combine(docPath, "xml.xml"), "");
            for (int i = 0; i < tamaño-1; i++)
            {
                string text = System.IO.File.ReadAllText(@archivo[i]);
                System.Console.WriteLine("<Archivo" + (i + 1)+">");
                File.AppendAllText(Path.Combine(docPath, "xml.xml"), ("<Archivo" + (i + 1)+">"));
                
                    Console.WriteLine("   <parrafo> " + text + " </parrafo>");
                    File.AppendAllText(Path.Combine(docPath, "xml.xml"), ("   <parrafo> " + text + " </parrafo>"));
                
                System.Console.WriteLine("</Archivo" + (i + 1)+"> \n");
                File.AppendAllText(Path.Combine(docPath, "xml.xml"), ("</Archivo" + (i + 1)+"> \n"));
            }
        }
    }
}