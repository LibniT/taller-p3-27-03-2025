using System;

namespace ENTITY
{
    public class Veterinario : Persona
    {
        public string Especialidad { get; set; }

        public Veterinario() { }

        public Veterinario(string nombre, string apellidos, int cedula, string telefono, string especialidad)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            Cedula = cedula;
            Telefono = telefono;
            Especialidad = especialidad;
        }

        override
        public string MostrarDatos()
        {
            return $"Veterinario: {Nombre} {Apellidos}, Cédula: {Cedula}, Teléfono: {Telefono}, Especialidad: {Especialidad}";
        }
    }
}