using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModeloParcial1
{
    public class Estacionamiento
    {
        private int capacidadEstacionamiento;
        private static Estacionamiento estacionamiento;
        private List<Vehiculo> listadoVehiculos;
        private string nombre;

        public List<Vehiculo> ListadoVehiculos
        {
            get { return this.listadoVehiculos; }
        }

        public string Nombre
        {
            get { return this.nombre; }
        }

        private Estacionamiento(string nombre, int capacidad)
        {
            this.listadoVehiculos = new List<Vehiculo>();
            this.nombre = nombre;
            this.capacidadEstacionamiento = capacidad;
        }

        public static Estacionamiento GetEstacionamiento(string nombre, int capacidad)
        {
            if(Estacionamiento.estacionamiento is null)
            {
                Estacionamiento.estacionamiento = new Estacionamiento(nombre, capacidad);
            }
            else
            {
                Estacionamiento.estacionamiento.capacidadEstacionamiento = capacidad;
            }

            return Estacionamiento.estacionamiento;
        }

        public string InformarSalida(Vehiculo vehiculo)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre del estacionamiento: {this.Nombre}");
            sb.AppendLine($"Datos del vehiculo: {vehiculo.ToString()}");
            sb.AppendLine($"Hora de salida: {vehiculo.HoraEgreso}");
            sb.AppendLine($"Cargo del estacionamiento: {(vehiculo.CostoEstadia).ToString("0.00")}");

            return sb.ToString();
        }

        public static bool operator ==(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            foreach (Vehiculo v in estacionamiento.listadoVehiculos)
            {
                if(v == vehiculo)
                return true;
            }
            return false;
        }

        public static bool operator !=(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            return !(estacionamiento == vehiculo);
        }

        public static bool operator +(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if(estacionamiento.ListadoVehiculos.Count < estacionamiento.capacidadEstacionamiento && estacionamiento!=vehiculo)
            {
                estacionamiento.ListadoVehiculos.Add(vehiculo);
                return true;
            }
            return false;
        }

        public static bool operator -(Estacionamiento estacionamiento, Vehiculo vehiculo)
        {
            if (estacionamiento == vehiculo)
            {
                int index = estacionamiento.ListadoVehiculos.IndexOf(vehiculo);
                estacionamiento.ListadoVehiculos.ElementAt(index).HoraEgreso = DateTime.Now;
                estacionamiento.ListadoVehiculos.Remove(vehiculo);
                return true;
            }
            return false;
        }



    }
}
