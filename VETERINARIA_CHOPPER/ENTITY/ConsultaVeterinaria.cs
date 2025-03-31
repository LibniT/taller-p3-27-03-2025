using System;

namespace ENTITY
{
    public class ConsultaVeterinaria
    {
        public DateTime Fecha { get; set; }
        public Veterinario Veterinario { get; set; }
        public string Diagnostico { get; set; }
        public string Tratamiento { get; set; }
        public Mascota Mascota { get; set; }

        public ConsultaVeterinaria() { }

        public ConsultaVeterinaria(DateTime fecha, Veterinario veterinario, string diagnostico, string tratamiento, Mascota mascota)
        {
            Fecha = fecha;
            Veterinario = veterinario;
            Diagnostico = diagnostico;
            Tratamiento = tratamiento;
            Mascota = mascota;
        }

        public string MostrarDatos()
        {
            return $"Fecha: {Fecha.ToShortDateString()}, Veterinario: {Veterinario?.Nombre}, " +
                   $"Mascota: {Mascota?.Nombre}, Diagnóstico: {Diagnostico}, Tratamiento: {Tratamiento}";
        }
    }
}