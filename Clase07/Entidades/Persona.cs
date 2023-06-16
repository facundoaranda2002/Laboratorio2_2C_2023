using System.Text.RegularExpressions;

namespace Entidades
{
    public class Persona
    {
        //public enum ETipo {ALUMNO,PROFESOR};
        //public enum ETipo {PRECEPTOR, ALUMNO = 23, PROFESOR = 23, DIRECTOR}; en este caso el valor del enumerado de preceptor es 0 y el de director es 31 porq si no se aclara es el valor del anterior mas 1  
        //public enum EError {INVALIDO,MAYOR_CERO,IS_NULL};

        private List<int> notas;

        private ETipo tipo;
        private string nombre;
        private string apellido;
        private DateTime fechaDeNacimiento;
        private int dni;

        public Persona(string dni, string apellido, ETipo tipo)
        {
            this.tipo = tipo;
            this.Dni = dni;
            this.Apellido = apellido;
            this.notas = new List<int>();
        }

        public string Dni
        {
            get 
            { 
                return this.dni.ToString(); 
            }
            private set
            {
                Regex regex = new Regex("^[0-9]{8}$");//Esto es una expresion regular, con esta clase estableci un formato de solo numeros con el $, que solo tome numeros del 0 al 9 y que debe tener solo 8 digitos
                if(regex.IsMatch(value))
                {
                    int.TryParse(value, out this.dni);
                }
            }
        }
        /// <summary>
        /// Si el indice es 0 retorna el nombre, si es otro el apellido
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string this[string index]
        {
            get
            {
                if(index == "nombre")
                {
                    return this.nombre;
                }
                else if(index == "apellido")
                {
                    return this.apellido;
                }
                return "indice invalido";
            }
        }

        /// <summary>
        /// indexa las notas
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public string this[int index]
        {
            get
            {
                if (index > -1 && index <= this.notas.Count - 1)
                {
                    return this.notas[index].ToString();
                }
                return "No hay notas o indice invalido";


            }
            set
            {
                this.notas.Add(index);

            }
        }

        public string Nombre { get => nombre; set => nombre = value; }


        public string Apellido
        {
            get { return this.apellido; }
            set
            {
                if (this.ValidaNombreYApellido(value))
                {
                    this.apellido = value;
                }
            }
        }

        public int Edad
        {
            get { return DateTime.Now.Year - this.fechaDeNacimiento.Year; }
        }

        public DateTime FechaDeNacimiento
        {
            set
            {
                if (this.ValidaFecha(value, DateTime.Now))
                {
                    this.fechaDeNacimiento = value;
                }
            }
        }

        public ETipo TipoDePersona { get { return this.tipo; } }


        public int TipoDeNumero { get { return (int)this.tipo; } }


        private bool ValidaNombreYApellido(string value)
        {
            return !string.IsNullOrWhiteSpace(value);
        }

        private bool ValidaFecha(DateTime fechaInicio, DateTime fechaFin)
        {
            return fechaInicio < fechaFin;
        }

        /*
        private void SetDni(int dni)
        {
            if(dni > 0)
            {
                this.dni = dni;
            }            
        }

        private void SetApellido(string apellido)
        {
            if (this.ValidaNombreYApellido(apellido))
            {
                this.apellido = apellido;
            }
        }

        public void SetFechaDeNacimiento(DateTime fechaDeNacimiento)
        {
            this.fechaDeNacimiento = fechaDeNacimiento;
        }

        public int GetDni()
        {
            return this.dni;
        }

        public string GetApellido(string apellido)
        {
            return this.apellido;
        }

        public int GetEdad()
        {
            return DateTime.Now.Year - this.fechaDeNacimiento.Year;
        }
        */


    }
}