using System;

namespace AplicacionUno
{
    public class Persona
    {
        public string Nombre { get; set; } = string.Empty;

        public string Apellido { get; set; } = string.Empty;

        public int Edad { get; set; }

        public string Email { get; set; } = string.Empty;
    
        public Persona CrearPersona(string nombre){
            Persona nuevaPersona = new Persona();

            nuevaPersona.Nombre = nombre;

            Console.WriteLine("Ingresa tu Apellido: ");
            nuevaPersona.Apellido = Console.ReadLine();

            Console.WriteLine("Ingresa tu Edad: ");
            nuevaPersona.Edad = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingresa tu Correo Electrónico: ");
            nuevaPersona.Email = Console.ReadLine();
            
            return nuevaPersona;
        }

    }
}