using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Taxi : Vehiculo
    {
        private string licencia;

        

        private Taxi(string matricula, string modelo, double potencia) : base(matricula, modelo, potencia)
        {
            /*
            string aux = this.Matricula;

            this.PonerEnMarcha();

            base.matricula = aux;
            */
        }

        public Taxi(string matricula, string modelo, double potencia, string licencia) : base(matricula, modelo, potencia)
        {
            //base.matricula = matricula;
            this.Licencia = licencia;
        }

        public string Licencia { get => licencia; set => licencia = value; }

        public bool HacerCarrera()
        {
            return true;
        }
    }
}
