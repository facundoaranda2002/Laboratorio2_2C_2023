using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial1_2
{
    public class EquipoBasket : Equipo
    {
        private ELiga liga;

        public enum ELiga { NBA, Euroleague, ACB};

        public EquipoBasket(string nombre) : base(nombre)
        {
            this.liga = ELiga.NBA;
        }

        public EquipoBasket(string nombre, ELiga liga) : this(nombre)
        {
            this.liga = liga;
        }

        public override int GetDificultad()
        {
            Random rnd = new Random();
            int dificultad;
            switch(this.liga)
            {
                case ELiga.NBA:
                    dificultad = rnd.Next(8, 11);
                    break;
                case ELiga.Euroleague:
                    dificultad = rnd.Next(5, 11);
                    break;
                default:
                    dificultad = rnd.Next(1, 8);
                    break;
            }
            return dificultad;
        }

        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Basket -" + base.MostrarDatos());
            return sb.ToString();
        }

        public override string ToString()
        {
            return this.MostrarDatos();
        }
    }
}
