using System.Text;
using Clases_Especiales;

namespace Clase_01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            bool estado;

            string nombre = "pepe";
            //StringBuilder sb = new StringBuilder();

            bool cargo = ManejoEnteros.PedirNumero(out numero);

            Console.WriteLine($"Cargo: {cargo}");
            Console.WriteLine($"El numero es: {numero} y su nombre es: {nombre}");
            //Console.WriteLine("El numero es: {0} y el nombre es: {1}", numero, nombre);
            //Console.WriteLine($"El numero es: " + numero + " y su nombre es: " + nombre);


            int[] miArray = new int[5];
            //int[] miArray = { 5, 6, 8, 9, 7 };
            //Object[] objetos = {"cadena", 1, 2.3, true};

            for (int i = 0; i < miArray.Length; i++)
            {
                do
                {
                    estado = ManejoEnteros.PedirNumero(out numero);
                }
                while (estado == false);
                
                miArray[i] = numero;
            }

            ManejoEnteros.MostrarNumeros(miArray);
        }


    }
}