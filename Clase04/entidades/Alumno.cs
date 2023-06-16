using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entidades
{
    public class Alumno
    {
        private int legajo;
        private string nombre;
        private string apellido;
        private string[] materias;

        public Alumno(int legajo, string nombre, string apellido, string[] materias) : this(legajo, nombre, apellido)
        {
            this.materias = materias;
        }

        public Alumno(int legajo, string nombre, string apellido)
        {
            this.legajo = legajo;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public static bool operator ==(Alumno alumno1, Alumno alumno2)
        {
            return alumno1.legajo == alumno2.legajo;
        }

        public static bool operator !=(Alumno alumno1, Alumno alumno2)
        {
            return !(alumno1 == alumno2);//siempre se hace esto para reutilizar codigo
        }

        public static implicit operator string(Alumno alumno)
        {
            return $"{alumno.nombre} {alumno.apellido}";
        }

        public static explicit operator int(Alumno alumno)
        {
            return alumno.legajo;
        }


    }
}
