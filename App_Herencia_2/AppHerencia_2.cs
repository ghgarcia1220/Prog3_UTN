namespace App_Herencia_2
{
    internal class AppHerencia_2
    {
        static void Main(string[] args)
        {

            string apellido, nombre;
            int dni;

            Persona persona = new Persona("Garcia", "Gabriel", 31109888);

            Console.WriteLine("");

            persona.mostrarPersona();

            Console.WriteLine("\n==========================================");

            // >>>> Tambien se puede hacer pasando directamente lo ingresado a al atributo de la clase <<<<
            
            /* Console.WriteLine("\nModificar los datos de la persona");

            Console.Write("> Ingrese el nuevo Apellido: ");
            persona.Apellido = Console.ReadLine();

            Console.Write("> Ingrese el nuevo Nombre: ");
            persona.Nombre = Console.ReadLine();

            Console.Write("> Ingrese el nuevo DNI: ");
            persona.DNI = Convert.ToInt32(Console.ReadLine()); */

            Console.Write("> Ingrese el nuevo apellido: ");
            apellido = Console.ReadLine();

            Console.Write("> Ingrese le nuevo nombre: ");
            nombre = Console.ReadLine();

            Console.Write("> Ingrese le nuevo DNI: ");
            dni = Convert.ToInt32(Console.ReadLine());

            persona.Apellido = apellido;
            persona.Nombre = nombre;
            persona.DNI = dni;

            persona.mostrarPersona();
        }
    }
}
