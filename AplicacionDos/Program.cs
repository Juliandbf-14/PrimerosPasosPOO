using System.Security.Cryptography.X509Certificates;

namespace AplicacionDos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una clase estudiante con propiedades como nombre, edad y calificaciones.  Luego permite a los usuarios ingresar información sobre varios estudiantes y muestra sus datos.
            string respuesta = "";
            string nombreCompleto = string.Empty;
            int edad = 0;
            double nota = 0.0;
            List<double> calificaciones = new List<double>();
            List<Estudiantes> listaEstudiantes = new List<Estudiantes>();
            
            Console.WriteLine("Quiere ingresar información de los estudiantes? (Si/No)");
            respuesta = Console.ReadLine();

            while (respuesta == "Si")
            {
                Console.WriteLine("Ingresa el nombre completo del estudiante: ");
                nombreCompleto = Console.ReadLine();

                Console.WriteLine("Ingresa la edad del estudiante: ");
                edad = int.Parse(Console.ReadLine());

                string respuestaCalificaciones = "Si";

                while (respuestaCalificaciones == "Si")
                {
                    Console.WriteLine("Ingrese la nota del estudiante: ");
                    nota = double.Parse(Console.ReadLine());
                    Console.WriteLine(nota);

                    if(nota != 0){
                        calificaciones.Add(nota);

                        Console.WriteLine("¿Quieres ingresar otra nota? (Si/No)");
                        respuestaCalificaciones = Console.ReadLine();
                    } else {
                        Console.WriteLine("Esa nota no está en el formato correcto.");
                        Console.WriteLine("¿Quieres volver a intentar ingresar otra nota? (Si/No)");
                        respuestaCalificaciones = Console.ReadLine();
                    }
                }

                Estudiantes nuevoEstudiante = new Estudiantes();
                nuevoEstudiante = nuevoEstudiante.CrearEstudiantes(nombreCompleto, edad, calificaciones);

                listaEstudiantes.Add(nuevoEstudiante);

                Console.WriteLine("¿Quieres ingresar otro estudiante? (Si/No)");
                respuesta = Console.ReadLine();
                Console.WriteLine(".");
                Console.WriteLine(".");
                Console.WriteLine(".");
                InformacionEstudiantes(listaEstudiantes);
            }

            static void InformacionEstudiantes(List<Estudiantes> estudiantes){
                Console.WriteLine($"Hay información de {estudiantes.Count} en el Sistema\n");
                Console.WriteLine();
                Console.WriteLine("Su información es la siguiente:");

                foreach (Estudiantes itemEstudiante in estudiantes)
                {
                    Console.WriteLine($"El nombre del estudiante es: {itemEstudiante.Nombres}\n"
                    + $"Su edad es: {itemEstudiante.Edad}\n"
                    + "Sus calificaciones son:");
                    itemEstudiante.Calificaciones.ForEach(x => {
                        Console.WriteLine(x.ToString());
                    });
                }
            }

        }
    }
}