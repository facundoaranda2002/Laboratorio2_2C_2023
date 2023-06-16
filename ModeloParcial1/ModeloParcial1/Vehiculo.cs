using System.Diagnostics;
using System.Text;

namespace ModeloParcial1
{
    public abstract class Vehiculo
    {
        private DateTime horaEgreso;
        private DateTime horaIngreso;
        private string patente;

        public enum EVehiculos {Automovil,Moto};

        public abstract double CostoEstadia { get; }
        public abstract string Descripcion { get; }

        public DateTime HoraEgreso
        {
            get { return this.horaEgreso; }
            set
            {
                if(value > this.HoraIngreso)
                {
                    this.horaEgreso = value;
                }
            }
        }

        public DateTime HoraIngreso
        {
            get { return this.horaIngreso; }
        }

        public string Patente
        {
            get { return this.patente; }
            set
            {
                if(this.ValidarPatente(value))
                {
                    this.patente = value;
                }
            }
        }


        public Vehiculo(string patente, DateTime horaIngreso)
        {
            this.Patente = patente;
            this.horaIngreso = horaIngreso;
        }

        private bool ValidarPatente(string patente)
        {
            if(!String.IsNullOrEmpty(patente) && (patente.Length >= 6 && patente.Length <= 7))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        protected virtual double CargoDeEstacionamiento()
        {
            TimeSpan diferencia;
            diferencia = HoraEgreso - HoraIngreso;
            return diferencia.TotalHours;
        }

        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Patente: {this.Patente}");
            sb.AppendLine($"Hora de ingreso: {this.HoraIngreso}");
            return sb.ToString();
        }

        public static bool operator ==(Vehiculo v1, Vehiculo v2 )
        {
            return v1.Patente == v2.Patente;
        }

        public static bool operator !=(Vehiculo v1, Vehiculo v2)
        {
            return !(v1 == v2);
        }
    }
}