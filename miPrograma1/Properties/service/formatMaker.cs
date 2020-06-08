﻿using System;

namespace miPrograma1.Properties.service
{
    public class formatMaker
    {
        private formatDecorator fCSV;
        private formatDecorator fHTML;
        private formatDecorator fJSON;
        private formatDecorator fXML;

        public formatMaker()
        {
            fCSV = new csvFormater();
            fHTML = new htmlFormater();
            fJSON = new jsonFormater();
            fXML = new xmlFormater();
        }

        public void convert(String[] archivo, String format)
        {
            switch (format)
            {
                case "csv":
                    fCSV.create(archivo);
                    break;
                case "html":
                    fHTML.create(archivo);
                    break;
                case "json":
                    fJSON.create(archivo);
                    break;
                case "xml":
                    fXML.create(archivo);
                    break;
                default:
                    Console.WriteLine("Formato no existe");
                    break;
            }
        }
        
    }
}