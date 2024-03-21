using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace App_Herencia_1
{
    class Empleado : Persona
    {
        private string posicion;

        public Empleado(string nombre, string apellido, int dni, string posicion) : base(nombre, apellido, dni)
        {
            this.posicion = posicion;
        }

        public void empleado()
        {
            Console.WriteLine("> Estudia: " + posicion);
        }
    }

}
