using System;

namespace ENTITY
{
    public class Raza
    {
        private Especie _especie;

        public string Nombre { get; set; }

        public Raza() { }

        public Raza(string nombre)
        {
            Nombre = nombre;
        }

        public void AsignarEspecie(Especie especie)
        {
            _especie = especie;
        }

        public Especie ObtenerEspecie()
        {
            return _especie;
        }
    }
}