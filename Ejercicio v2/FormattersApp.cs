using System;

namespace Ejercicio_2
{
    class FormattersApp
    {
        static void Main(string[] args){

          

            
            FormatterFacade makerFormat = new FormatterFacade();

                String formato = args[args.Length - 1];
                Array.Resize(ref args, args.Length - 1);


                 switch (formato)
            {case "csv": 
                        makerFormat.darFormatocsv(args);
                break;
             case "html":
                        makerFormat.darFormatoHtml(args);
                 break;
             case " xml":
                        makerFormat.darFormatoxml(args);
                 break;
             case "json":
                        makerFormat.darFormatojson(args); 
                 break;
             default: System.Console.WriteLine("No ha especificado ningun formato");
                    break;
            }


          
            
            
                  


        }
    }
}
