namespace App_Herencia_1
{
    public class App_Herencia
    {
        static void Main(string[] args)
        {

            /*Persona persona = new Persona("Gabriel", "Garcia", 31109888);

            persona.mostrar();

            Console.WriteLine("");*/

            Empleado empleado = new Empleado("Maria", "Quintana", 32097851 , "Ingeniera");

            empleado.mostrarDatosPersona();
            empleado.empleado();

            Console.WriteLine("\n=== Apellido modificado ===");

            empleado.Apellido = "Leiva";

            empleado.mostrarDatosPersona();
            empleado.empleado();

        }
    }
}
