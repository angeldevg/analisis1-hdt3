using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Ejercicio_2
{
    public class formatoHtmlDecorator
    {
        

        public void addHtmlFormat(string[] archivo){


             float a = archivo.Length;
            System.Console.WriteLine("Archivo(s) Formato HTML");
            for (int c = 0; c < a; c++)
            {
                string text = System.IO.File.ReadAllText(@archivo[c]);
                List<string> result = text.Split(' ').ToList();
                var standardOutput = Console.Out;
                System.Console.WriteLine("\nArchivo No. : " +(c+1));
                result.ForEach(delegate(string name)
                    {
                        Console.WriteLine("<p> " + name + " </p>");
                        System.IO.File.WriteAllText(@"C:\Users\Usuario\Desktop\Ejercicio 2\archivox.html",("<p> " + name + " </p>"));
                    });

 

                
            }
        }
    }
}