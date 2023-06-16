using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado
    {
        int id;
        string nombre;
        string apellido;
        int idSector;

        public Empleado(int id, string nombre, string apellido, int idSector)
        {
            this.Id = id;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.IdSector = idSector;
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public int IdSector { get => idSector; set => idSector = value; }
    }
}
