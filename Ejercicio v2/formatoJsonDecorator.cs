namespace Ejercicio_2
{
    public class formatoJsonDecorator{


                public void addJsonFormat(string[] archivo){

              float a = archivo.Length;
            for (int i = 0; i < a; i++)
            {
                string text = System.IO.File.ReadAllText(@archivo[i]);
                System.Console.WriteLine("\n Archivo No. : " +(i+1));
                System.Console.WriteLine("\n \t\t { 'Cadena "+ (i + 1) +":' \n \t\t\t    " + text+" }\n");
                

                string lineas = "{  "+

                                    "'Ejercico 2': [ \n" +
                                        "\t 'Cadena:' " + text +"  "+ 


                                    "\n  ]}"; 

                System.IO.File.WriteAllText(@"C:\Users\Usuario\Desktop\Ejercicio 2\archivojson"+ i +".json", lineas);



        }


        }



        
    }
}