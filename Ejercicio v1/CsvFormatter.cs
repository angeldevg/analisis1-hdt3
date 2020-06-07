using System;


namespace Ejercicio1_CSV
{
    public class CsvFormatter : IFormatter{



        public void Formatt(string[] archivo){


            float a = archivo.Length;
            for (int i = 0; i < a; i++)
            {
                string text = System.IO.File.ReadAllText(@archivo[i]);
                text= text.Replace(" ", ",");
                System.Console.WriteLine("\n Archivo No. : " +(i+1));
                System.Console.WriteLine("\n \t\t" + text+"\n");

                

           }
            
        }
    }
}