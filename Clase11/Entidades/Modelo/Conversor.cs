using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Excepciones;

namespace Entidades.Modelo
{
    public class Conversor
    {
        public static string ConvertirANumeroRomano(int numero)
        {
            /*
            if (numero == 1)
            {
                return "I";
            }
            else if (numero == 2)
            {
                return "II";
            }
            return "III";
            */
            return Conversor.convertirUnidades(numero);
        }

        private static string convertirUnidades(int numero)
        {
            StringBuilder sb = new StringBuilder();
            if (numero > 0 && numero <= 3)
            {
                sb.Append('I', numero);//va a realizar un append de ese caracter segun el numero de veces especificadas
                return sb.ToString();
            }

            if(numero == 4)
            {
                return "IV";
            }

            if(numero > 4 && numero < 9)
            {
                sb.Append("V");
                sb.Append('I', numero - 5);
                return sb.ToString();
            }

            if(numero == 9)
            {
                return "IX";
            }

            if (numero == 10)
            {
                return "X";
            }

            //throw new Exception("Numero invalido");
            throw new NumeroInvalidoException("Numero Invalido");

        }
    }
}
