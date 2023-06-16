using Entidades.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades.Models
{
    public class Calculadora
    {
        private int numeroA;
        private int numeroB;

        public Calculadora(string numeroA, string numeroB)
        {
            this.ConvierteNumero(numeroA, out this.numeroA);
            this.ConvierteNumero(numeroB, out this.numeroB);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentoInvalidoException"></exception>
        public double Dividir()
        {
            /*
            try
            {
                return this.numeroA / this.numeroB;
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"Error al dividir {ex.Message}");
                return -1;
            }
            */
            try
            {
                return this.numeroA / this.numeroB;
            }
            catch (DivideByZeroException ex)
            {
                throw new ArgumentoInvalidoException("El divisor no puede ser cero", ex);
            }
            
        }

        public double Multiplicar()
        {
            return this.numeroA * this.numeroB;
        }

        public double Sumar()
        {
            return this.numeroA + this.numeroB;
        }

        public double Restar()
        {
            return this.numeroA - this.numeroB;
        }

        private void ConvierteNumero(string numero, out int resultado)
        {
            /*
            try
            {
                resultado = int.Parse(numero);
                Console.WriteLine("Esto no se ejecuta si hay un error");//Esto no va a llegar a ejecutarse si hay algun error
                return true;
            }
            catch(FormatException e)//con esto me va a detallar el tipo de excepcion sino podria poner Exception e no mas
            {
                Console.WriteLine($"Error de formato{e.Message}");
                resultado = 0;
            }
            Console.WriteLine("Si se ejecuta");
            return false;
            */

            resultado = int.Parse(numero);
        }
    }
}
