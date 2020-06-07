using System;

namespace Ejercicio_2
{
    public class FormatterFacade{

        private formatoXmlDecorator xml;
        private formatocsvDecorator csv;
        private formatoJsonDecorator json;
        private formatoHtmlDecorator html;


        public FormatterFacade(){

            xml = new formatoXmlDecorator();
            csv = new formatocsvDecorator();
            json = new formatoJsonDecorator();
            html = new formatoHtmlDecorator();
        }


        public void darFormatoxml(String[] archivo){

            xml.addXmlFormat(archivo);

        }

        public void darFormatocsv(String[] archivo){

            csv.addCsvFormat(archivo);
        }


        public void darFormatojson(String[] archivo){

            json.addJsonFormat(archivo);

        }

        public void darFormatoHtml(String[] archivo){

            html.addHtmlFormat(archivo);

        }


        
    }
}