
namespace AplicacionUno
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre = string.Empty;
            string respuestaEdad = string.Empty;
            bool esMayor = false;


            Console.WriteLine("Ingresa tu nombre:");
            nombre = Console.ReadLine();

            Console.WriteLine("Eres Mayor de Edad? (Si/No)");
            respuestaEdad = Console.ReadLine();

            if(respuestaEdad == "Si"){
                // Crear instancia de Objeto
                Persona nuevaPersona = new Persona();
                
                nuevaPersona = nuevaPersona.CrearPersona(nombre);
                
                Console.WriteLine();
                Console.WriteLine();
                Console.WriteLine($"Los datos ingresados son:\n"
                + $"Nombre: {nuevaPersona.Nombre}\n"
                + $"Apellido: {nuevaPersona.Apellido}\n"
                + $"Edad: {nuevaPersona.Edad}\n"
                + $"Correo: {nuevaPersona.Email}\n"
                );
            } else {
                Console.WriteLine("Eres menor de edad no puedes continuar.");
            }
        }
    }
}
