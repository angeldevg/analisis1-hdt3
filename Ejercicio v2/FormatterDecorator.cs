using System;

namespace Ejercicio_2
{
    public abstract class FormatterDecorator : IFormatter{


        protected IFormatter formatterdecorator ;

        public FormatterDecorator(IFormatter formatterdecorator){

           this.formatterdecorator = formatterdecorator;      
        }



        public void Format()
        {
            formatterdecorator.Format();
        }
    }
}