using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial1_2
{
    public class Competencia
    {
        private int cantidaCompetidores;
        private List<Equipo> equipos;
        private string nombre;

        public int CantidaCompetidores { get => cantidaCompetidores; set => cantidaCompetidores = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public List<Equipo> Equipos { get => equipos; }

        private Competencia(string nombre)
        {
            this.CantidaCompetidores = 5;
        }

        public Competencia(string nombre, int cantidaCopetidores): this(nombre)
        {
            this.Nombre = nombre;
            this.equipos = new List<Equipo>();
        }

        public static implicit operator Competencia(string nombre)
        {
            return new Competencia(nombre);
        }

        public static bool operator ==(Competencia torneo, Equipo equipo)
        {
            if(torneo.Equipos.Count > 0)
            {
                foreach(Equipo e in torneo.Equipos)
                {
                    if(e == equipo)
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        public static bool operator !=(Competencia torneo, Equipo equipo)
        {
            return !(torneo == equipo);
        }

        public static Competencia operator +(Competencia torneo, Equipo equipo)
        {
            if(torneo.Equipos.Count < torneo.CantidaCompetidores && torneo != equipo)
            {
                torneo.equipos.Add(equipo);
            }
            return torneo;
        }

        public static string MostrarTorneo(Competencia torneo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre competencia: " + torneo.Nombre);
            sb.AppendLine("Cantidad competidores: " + torneo.CantidaCompetidores);
            foreach(Equipo e in torneo.Equipos)
            {
                sb.AppendLine(e.ToString());
            }
            return sb.ToString();
        }

    }
}
