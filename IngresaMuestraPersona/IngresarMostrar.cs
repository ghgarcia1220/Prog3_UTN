namespace IngresaMuestraPersona
{
    public class IngresarMostrar
    {
        static void Main(string[] args)
        {
            
            Persona persona = new Persona("Mengano", "Juan", 30);

            Console.WriteLine("\n\tPersona 1\n");

            persona.mostrarNombreCompleto();

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Apellido modificado de Persona 1\n");

            persona.Apellido = "Fulano";

            persona.mostrarNombreCompleto();

            Console.WriteLine("\n===================================================\n");

            Console.WriteLine("\tPersona 2\n");

            Persona persona1 = new Persona("Quintana", "Maria", 33);

            persona1.mostrarNombreCompleto();

            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("\tApellido modificado de Persona 2\n");

            persona1.Apellido = "Vidal";

            persona1.mostrarNombreCompleto();

        }
    }
}
