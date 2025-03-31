using System;
using System.Collections.Generic;

namespace ENTITY
{
    public class Especie
    {
        public string Nombre { get; set; }
        public List<Raza> Razas { get; set; }

        public Especie()
        {
            Razas = new List<Raza>();
        }

        public Especie(string nombre)
        {
            Nombre = nombre;
            Razas = new List<Raza>();
        }

        public void AgregarRaza(Raza raza)
        {
            if (raza != null)
            {
                raza.AsignarEspecie(this);
                Razas.Add(raza);
            }
        }

        public List<Raza> ListarRazas()
        {
            return Razas;
        }
    }
}