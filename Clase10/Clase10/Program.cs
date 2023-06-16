using Entidades.Models;
using Entidades.Exceptions;
namespace Clase10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string numeroA;
            string numeroB;
            Calculadora calculadora;
            //Exception e = new Exception();
            Console.WriteLine("Ingrese el primer numero");
            numeroA= Console.ReadLine();
            Console.WriteLine("Ingrese el segundo numero");
            numeroB = Console.ReadLine();

            try
            {
                calculadora = new Calculadora(numeroA, numeroB);
                //Console.WriteLine($"El resultado es {calculadora.Sumar()}");
                Console.WriteLine($"El resultado es {calculadora.Dividir()}");
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FormatException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)//FUI PASANDO DE TRATAR DE CAPTURAR LAS EXCEPCIONES MAS DETALLADAS A LA MAS GENERICA, ESTA LA PONEMOS A LO ULTIMO YA QUE SIEMPRE LA VAMOS A CAPTURAR
            {
                Console.WriteLine(ex.Message);
                Exception bucle = ex.InnerException;
                while (bucle != null)
                {
                    Console.WriteLine(bucle.Message);
                    bucle = bucle.InnerException;
                }
            }
            /*
            finally
            {
                Console.WriteLine("Se ejecuta siempre");
            }
            */


            Console.ReadKey();

            /* ESTO ES PARA VER COMO FUNCIONA EL INNER EXCEPTION    
            Exception e = new Exception("Primer excepcion");
            ArgumentoInvalidoException a = new ArgumentoInvalidoException("mensaje A", e);
            ArgumentoInvalidoException b = new ArgumentoInvalidoException("mensaje B", a);
            ArgumentoInvalidoException c = new ArgumentoInvalidoException("mensaje C", b);

            Console.WriteLine(c.Message);
            Exception bucle = c.InnerException;
            while(bucle != null)
            {
                Console.WriteLine(bucle.Message);
                bucle = bucle.InnerException;
            }
            */

        }
    }
}