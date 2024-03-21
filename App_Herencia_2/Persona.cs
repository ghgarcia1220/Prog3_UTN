using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Herencia_2
{
    internal class Persona
    {
        //Atributos
        private string apellido;
        private string nombre;
        private int dni;

        public Persona()
        {

        }

        public Persona(string apellido, string nombre, int dni)
        {
            this.apellido = apellido;
            this.nombre = nombre;
            this.dni = dni;
        }

        //Getters & Setters
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

        //Metodo para mostrar datos de la persona
        public void mostrarPersona()
        {
            Console.WriteLine("\n> Apellido: " + apellido + "\n> Nombre: " + nombre + "\n> DNI: " + dni);
        }
    }
}
