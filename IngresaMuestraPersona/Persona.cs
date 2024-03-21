using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IngresaMuestraPersona
{
    public class Persona
    {

        //Atributos
        private string apellido;
        private string nombre;
        private int edad;
        public Persona()
        {
        }

        public Persona(string apellido, string nombre, int edad)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.edad = edad;
        }

        //Propiedades getters y setters
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public int Edad
        {
            get { return edad; }
            set {  edad = value; }
        }

        //Metodo
        public void mostrarNombreCompleto()
        {
            Console.WriteLine("Apellido: " + apellido + "\nNombre: " + nombre + "\nEdad: " + edad + " años");
        }
    }
}
