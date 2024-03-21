using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Herencia_1
{
    internal class Persona
    {
        private string nombre;
        private string apellido;
        private int dni;

        public Persona()
        {

        }

        public Persona(string nombre, string apellido, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
        }

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

        public int DNI
        {

            get { return dni; }
            set { dni = value; }

        }

        public void mostrarDatosPersona()
        {
            Console.WriteLine("\n> Apellido: " + apellido + "\n> Nombre: " + nombre + "\n> DNI: " + dni);
        } 
    }
}
