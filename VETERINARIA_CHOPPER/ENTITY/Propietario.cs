using System;
using System.Collections.Generic;

namespace ENTITY
{
    public class Propietario : Persona
    {
        private List<Mascota> _mascotas;

        public Propietario() 
        {
            _mascotas = new List<Mascota>();
        }
        
        public Propietario(string nombre, string apellidos, int cedula, string telefono)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Cedula = cedula;
            Telefono = telefono;
            _mascotas = new List<Mascota>();
        }

        public void AgregarMascota(Mascota mascota)
        {
            _mascotas.Add(mascota);
        }
        
        public List<Mascota> ObtenerMascotas()
        {
            return _mascotas;
        }

        override
        public string MostrarDatos()
        {
            return $"Propietario: {Nombre} {Apellidos}, Cédula: {Cedula}, Teléfono: {Telefono}, Cantidad de mascotas: {_mascotas.Count}";
        }
    }
}