using System;
using System.Collections.Generic;

namespace ENTITY
{
    public class Mascota
    {
        public string Nombre { get; set; }
        public int Edad { get; set; }
        public Raza Raza { get; set; }
        public Propietario Propietario { get; set; }
        private List<ConsultaVeterinaria> _historialConsultas;

        public Mascota()
        {
            _historialConsultas = new List<ConsultaVeterinaria>();
        }

        public Mascota(string nombre, int edad, Raza raza, Propietario propietario)
        {
            Nombre = nombre;
            Edad = edad;
            Raza = raza;
            Propietario = propietario;
            _historialConsultas = new List<ConsultaVeterinaria>();
        }

        public void AgregarConsulta(ConsultaVeterinaria consulta)
        {
            _historialConsultas.Add(consulta);
        }

        public List<ConsultaVeterinaria> ObtenerHistorialConsultas()
        {
            return _historialConsultas;
        }

        public string ObtenerEspecie()
        {
            return Raza?.ObtenerEspecie()?.Nombre;
        }

        public string MostrarDatos()
        {
            return $"Mascota: {Nombre}, Edad: {Edad}, Raza: {Raza?.Nombre}, Especie: {ObtenerEspecie()}, Propietario: {Propietario?.Nombre} {Propietario?.Apellidos}";
        }
    }
}