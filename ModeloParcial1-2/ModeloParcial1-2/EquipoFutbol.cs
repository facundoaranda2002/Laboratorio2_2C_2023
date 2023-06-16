using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial1_2
{
    public class EquipoFutbol : Equipo
    {
        private bool jugadoresEstrellas;

        public EquipoFutbol(string nombre) : base(nombre)
        {
            this.jugadoresEstrellas = false;
        }

        public EquipoFutbol(string nombre, bool jugadoresEstrellas) : this(nombre)
        {
            this.jugadoresEstrellas = jugadoresEstrellas;
        }

        public override int GetDificultad()
        {
            Random rnd = new Random();
            int dificultad = rnd.Next(7, 11);
            if(this.jugadoresEstrellas)
            {
                dificultad = dificultad * 2;
            }
            return dificultad;
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Futbol -" + base.MostrarDatos());
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
