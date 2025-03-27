using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public abstract class Persona
    {

        public string Nombre { get; set; }
        public int Cedula { get; set; }
        public string Telefono { get; set; }
        public string Apellidos { get; set; }

        public abstract string MostrarDatos();




    }
}
