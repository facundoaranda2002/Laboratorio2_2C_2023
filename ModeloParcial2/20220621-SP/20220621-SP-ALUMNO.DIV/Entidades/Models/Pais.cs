﻿using Entidades.DataBase;
using Entidades.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Extension;

namespace Entidades.Models
{
    //14.	País, implementará el mensaje ObtenerNuevaPalabra, para ello deberá
    //leer desde la tabla “Paises” en base a un ID aleatorio(hasta 35).
    //Reutilizar código.
    public class Pais : ILector
    {
        public string ObtenerNuevaPalabra()
        {
            Random random = new Random();
            return DataBaseManager.GetNuevaPalabra("paises", random.GetRandomID(36));
        }
    }
}
