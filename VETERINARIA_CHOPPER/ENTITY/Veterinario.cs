using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Veterinario : Persona
    {

        public string Especialidad { get; set; }
        




        public Veterinario() { }
        override
        public string MostrarDatos()
        {
            return "";
        }

    }
}
