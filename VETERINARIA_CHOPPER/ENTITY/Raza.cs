using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ENTITY
{
    public class Raza
    {
        private Especie especie;

        public string Nombre { get; set; }

        public List<Especie> ObtenerEspecies(){
            return new List<Especie>() { especie };
        
        }


    }
}
