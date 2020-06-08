using System;
using System.IO;

namespace miPrograma1.Properties.service
{
    public class convert
    {
        public void create(String[] archivo)
        {
  
            float a = archivo.Length;
            for (int c = 0; c < a; c++)
            {
                string text = System.IO.File.ReadAllText(@archivo[c]);
                text= text.Replace(" ", ",");
                System.Console.WriteLine("Archivo No. : " +(c+1));
                System.Console.WriteLine(text+"\n");
                
            }

        } 
    }
}

