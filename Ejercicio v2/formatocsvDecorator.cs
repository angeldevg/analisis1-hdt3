namespace Ejercicio_2
{
    public class formatocsvDecorator{


        public void addCsvFormat(string[] archivo){

              float a = archivo.Length;
            for (int i = 0; i < a; i++)
            {
                string text = System.IO.File.ReadAllText(@archivo[i]);
                text= text.Replace(" ", ",");
                System.Console.WriteLine("\n Archivo No. : " +(i+1));
                System.Console.WriteLine("\n \t\t" + text+"\n");


                string lineas = text;
                 System.IO.File.WriteAllText(@"C:\Users\Usuario\Desktop\Ejercicio 2\archivocsv.csv", lineas);

                
        }


        }
        
    }
}