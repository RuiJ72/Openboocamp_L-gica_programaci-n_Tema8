using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_tema_Ocho
{
    class Persona
    {
        private string edade;
        private string nombre;
        private string telefono;

        public string Edade
        {
            get
            {
                return edade;
            }
            set
            {
                edade = value;
            }
        }

        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = value;
            }
        }

        public string Telefono
        {
            get
            {
                return telefono;
            }
            set
            {
                telefono = value;
            }
        }


        public Persona()
        {
            edade = string.Empty;
            nombre = string.Empty;
            telefono = string.Empty;

        }
    }
}

