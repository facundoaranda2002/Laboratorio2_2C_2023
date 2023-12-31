﻿using Entidades.Interfaces;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Modelos
{
    public class Cartero : IMensaje, IGenerica<string>, IGenerica<int>
    {
        private bool estado;

        public string Nombre { get; set; }

        public bool Estado => this.estado;

        public string EnviarMensaje()
        {
            this.estado = !this.estado;
            return "El cartero envia un mensaje";
        }

        /*
        string IMensaje.EnviarMensaje()
        {
            this.estado = !this.estado;
            return "El cartero envia un mensaje explicitamente";
        }
        */

        string IGenerica<string>.EnviarMensaje()
        {
            this.estado = !this.estado;
            return "El cartero envia un mensaje desde la interfaz generica";
        }

        int IGenerica<int>.EnviarMensaje()
        {
            throw new NotImplementedException();
        }
    }
}
