namespace Ejercicio_2
{
    public class formatoXmlDecorator{


        public void addXmlFormat(string[] archivo){

              float a = archivo.Length;
            for (int i = 0; i < a; i++)
            {
                string text = System.IO.File.ReadAllText(@archivo[i]);
             
                System.Console.WriteLine("\n Archivo No. : " +(i+1));
                System.Console.WriteLine(string.Format("\n \t\t <cadena> "+  text + " </cadena> \n"));





                string lineas= string.Format("\n  <?xml version=1.0  encoding= ISO-8859-1?> \n"
                                                    +"\t<Ejercicio 2>\n"
                                                     +"\t\t\t<cadena>"+  text + "</cadena> \n"
                                                     +"\t</Ejercicio 2>");
                                                    

                System.IO.File.WriteAllText(@"C:\Users\Usuario\Desktop\Ejercicio 2\archivox.xml", lineas);

        }

           
        
    }
}

}