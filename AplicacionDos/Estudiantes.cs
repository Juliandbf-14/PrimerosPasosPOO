using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AplicacionDos
{
    public class Estudiantes
    {
        public string Nombres { get; set; } = string.Empty;

        public int Edad { get; set; }

        public List<double> Calificaciones { get; set; } = new List<double>();

        public Estudiantes CrearEstudiantes(string nombreCompleto, int edad, List<double> calificaciones){
            Estudiantes nuevoEstudiante = new Estudiantes();

            nuevoEstudiante.Nombres = nombreCompleto;
            nuevoEstudiante.Edad = edad;
            nuevoEstudiante.Calificaciones.AddRange(calificaciones);

            return nuevoEstudiante;
        }
    }
}