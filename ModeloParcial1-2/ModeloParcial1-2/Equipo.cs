using System.Text;

namespace ModeloParcial1_2
{
    public abstract class Equipo
    {
        protected string nombre;
        protected int partidosEmpatados;
        protected int partidosGanados;
        protected int partidosJugados;
        protected int partidosPerdidos;
        protected int puntuacion;

        public string Nombre { get { return this.nombre; } }
        public string Tipo { get { return this.GetType().Name; } }
        public int PE { get => partidosEmpatados; set => partidosEmpatados = value; }
        public int PG { get => partidosGanados; set => partidosGanados = value; }
        public int PJ { get => partidosJugados; set => partidosJugados = value; }
        public int PP { get => partidosPerdidos; set => partidosPerdidos = value; }
        public int Puntuacion { get => puntuacion; set => puntuacion = value; }

        protected Equipo(string nombre) 
        {
            this.nombre = nombre;
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.Nombre);
            return sb.ToString();
        }

        public static bool JugarPartido(Equipo equipoA, Equipo equipoB)
        {
            if(equipoA.Equals(equipoB))
            {
                equipoA.PJ++;
                equipoB.PJ++;
                if(equipoA.GetDificultad() > equipoB.GetDificultad())
                {
                    equipoA.PG++;
                    equipoA.Puntuacion += 3;
                    equipoB.PP++;
                }
                else if(equipoA.GetDificultad() < equipoB.GetDificultad())
                {
                    equipoB.PG++;
                    equipoB.Puntuacion += 3;
                    equipoA.PP++;
                }
                else
                {
                    equipoA.PE++;
                    equipoB.PE++;
                    equipoA.Puntuacion++;
                    equipoB.Puntuacion++;
                }
                return true;
            }
            return false;
        }

        public abstract int GetDificultad();

        public static bool operator ==(Equipo equipoA, Equipo equipoB)
        {
            return equipoA.Equals(equipoB) && (equipoA.Nombre == equipoB.Nombre);
        }

        public static bool operator !=(Equipo equipoA, Equipo equipoB)
        {
            return !(equipoA == equipoB);
        }

        public override bool Equals(object? obj)
        {
            if (obj is not null && obj is Equipo && ((Equipo)obj).Tipo == this.Tipo)
                return true;
            else
                return false;
        }
    }
}