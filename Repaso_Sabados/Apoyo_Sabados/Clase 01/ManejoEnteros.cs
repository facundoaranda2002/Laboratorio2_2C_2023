using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Especiales
{
    internal class ManejoEnteros
    {

        public static void MostrarNumeros(int[] listaNumeros)
        {
            /*
            for (int i = 0; i < listaNumeros.Length; i++)
            {
                Console.WriteLine(listaNumeros[i]);
            }
            */
            foreach (int n in listaNumeros)
            {
                Console.WriteLine(n);
            }

        }


        public static bool PedirNumero(out int numero)
        {
            string? lectura;
            bool estado;
            Console.WriteLine("Ingrese un numero: ");//clase Console, metodo WriteLine(este es un metodo estatico)
            lectura = Console.ReadLine();
            estado = int.TryParse(lectura, out numero);

            return estado;
        }
    }

}
