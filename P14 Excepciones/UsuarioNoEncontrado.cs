using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace P14_Excepciones
{
    //creando exception
    public class UsuarioNoEncontrado : Exception
    {
        //constructor
        public UsuarioNoEncontrado()
        {

        }
        //metodos
        public UsuarioNoEncontrado(string message) : base(message)
        {
            
        }

        public UsuarioNoEncontrado(string message, Exception ex) : base(message, ex)
        {
            //logica para la exception
        }
    }
}