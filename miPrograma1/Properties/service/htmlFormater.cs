﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace miPrograma1.Properties.service
{
    public class htmlFormater : formatDecorator
    {
        public htmlFormater() { }
        public htmlFormater(format fDecorator) : base(fDecorator)
        {
        }

        public override void create(string[] archivo)
        {
            float tamaño = archivo.Length;
            String lines = "";
            string docPath = Directory.GetCurrentDirectory();;
            File.WriteAllText(Path.Combine(docPath, "html.html"), "<html> \n <head>\n <title> 'HTML' </title>\n </head>\n <body>\n");
            for (int i = 0; i < tamaño-1; i++)
            {
                string text = System.IO.File.ReadAllText(@archivo[i]);
                List<string> result = text.Split(' ').ToList();
                System.Console.WriteLine("\nArchivo No. : " +(i+1));
                File.AppendAllText(Path.Combine(docPath, "html.html"), ("<h3> Archivo No. : " +(i+1))+ "</h3>");
                result.ForEach(delegate(String newText)
                {
                    Console.WriteLine("<p> "+newText+" </p>");
                    lines = "<p> " + newText + " </p>";
                    File.AppendAllText(Path.Combine(docPath, "html.html"),lines );
                });
            }

            File.AppendAllText(Path.Combine(docPath, "html.html"), "</body>\n </html>");
        }
    }
}