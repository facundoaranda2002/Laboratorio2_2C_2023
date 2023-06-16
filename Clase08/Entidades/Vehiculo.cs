using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Vehiculo
    {
        protected string matricula;
        protected string modelo;
        protected double potencia;

        public Vehiculo(string matricula, string modelo, double potencia)
        {
            this.Matricula = matricula;
            this.Modelo = modelo;
            this.Potencia = potencia;
        }

        public string Matricula { get => matricula; set => matricula = value; }
        public string Modelo { get => modelo; set => modelo = value; }
        public double Potencia { get => potencia; set => potencia = value; }

        public string PonerEnMarcha()
        {
            return "Estoy funcionando.....";
        }
    }
}
