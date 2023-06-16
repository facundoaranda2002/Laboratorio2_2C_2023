using System.Linq;
using System.Text;
using Entidades;

namespace Clase02
{
    internal class Program
    {
        /*
        Nombre de la mascota
        Edad(Validar 1 - 12)
        Tipo: (Validar “gato”, “perro”, “hamster”)
        Peso: (Validar 0 - 50)
        Diagnostico: (Validar  “otitis”, “alergias”)

        Informes:

        Nombre de la mascota más vieja
        Cantidad de mascotas con parásitos
        Nombre, edad y diagnóstico de la mascota más joven ingresada.
        */

        static void Main(string[] args)
        {
            string? nombreMascota;
            int edadMascota;
            //string ingresoEdadMascota;
            string tipoMascota;
            int pesoMascota;
            string diagnostico;

            Console.WriteLine("Ingrese el nombre de la mascota");
            nombreMascota = Console.ReadLine();



            Validador.ValidarNumero("Ingrese la edad de la mascota", out edadMascota, 1, 12);
            //Entidades.Validador.ValidarNumero("Ingrese la edad de la mascota", out edadMascota, 1, 12);
            //ValidarNumero("Ingrese la edad de la mascota", out edadMascota, 1, 12);
            /*
            Console.WriteLine("Ingrese la edad de la mascota");
            //ingresoEdadMascota = Console.ReadLine();
            //int.TryParse(ingresoEdadMascota, out edadMascota);
            int.TryParse(Console.ReadLine(), out edadMascota);
            while(edadMascota < 1 || edadMascota > 12)
            {
                Console.WriteLine("Error edad invalida (1-12)");
                Console.WriteLine("Ingrese la edad de la mascota");
                int.TryParse(Console.ReadLine(), out edadMascota);
            }
            */


            Validador.ValidaTexto("Ingrese el tipo de mascota (gato, perro, hamster)", out tipoMascota, "gato", "perro", "hamster");
            //ValidaTexto("Ingrese el tipo de mascota (gato, perro, hamster)", out tipoMascota, "gato", "perro", "hamster");

            /*
            Console.WriteLine("Ingrese el tipo de mascota (gato, perro, hamster)");
            tipoMascota = Console.ReadLine();
            while(tipoMascota != "gato" && tipoMascota != "perro" && tipoMascota != "hamster")
            {
                Console.WriteLine("Error tipo invalido (gato, perro, hamster)");
                Console.WriteLine("Ingrese el tipo de mascota (gato, perro, hamster)");
                tipoMascota = Console.ReadLine();
            }
            */


            Validador.ValidarNumero("ingrese el peso de la mascota", out pesoMascota, 0, 50);
            //ValidarNumero("ingrese el peso de la mascota", out pesoMascota, 0, 50);
            /*
            Console.WriteLine("Ingrese el peso de la mascota");
            int.TryParse(Console.ReadLine(), out pesoMascota);
            while (pesoMascota < 0 || pesoMascota > 50)
            {
                Console.WriteLine("Error peso invalido (0-50)");
                Console.WriteLine("Ingrese el peso de la mascota");
                int.TryParse(Console.ReadLine(), out pesoMascota);
            }
            */

            Validador.ValidaTexto("Ingrese el diagnostico (otitis, alergias)", out diagnostico, "otitis", "alergias");
            //ValidaTexto("Ingrese el diagnostico (otitis, alergias)", out diagnostico, "otitis", "alergias");
            /*
            Console.WriteLine("Ingrese el diagnostico de la mascota (otitis, alergias)");
            diagnostico= Console.ReadLine();
            while (diagnostico != "otitis" && diagnostico != "alergias")
            {
                Console.WriteLine("Error. Ingrese el diagnostico de la mascota (otitis, alergias)");
                diagnostico = Console.ReadLine();
            }
            */

            Console.WriteLine(edadMascota);
            Console.WriteLine(nombreMascota);
            Console.WriteLine(tipoMascota);
            Console.WriteLine(pesoMascota);
            Console.WriteLine(diagnostico);



            /*
            void ValidarNumero(string mensaje, out int valor, int min, int max)
            {
                Console.WriteLine(mensaje);

                int.TryParse(Console.ReadLine(), out valor);
                while (valor < min || valor > max)
                {
                    Console.WriteLine($"Error valor invalido. Ingrese un valor entre {min} y {max}");
                    Console.WriteLine(mensaje);
                    int.TryParse(Console.ReadLine(), out valor);
                }
            }

            void ValidaTexto(string mensaje, out string valor, params string[] valores)
            {
                Console.WriteLine();
                valor = Console.ReadLine();

                while (!valores.Contains(valor))
                {
                    Console.WriteLine($"Error valor invalido, ingrese valido");
                    valor = Console.ReadLine();
                }
            }
            */


            
            //string cadena = string.Empty;
            string cadena = "Hola " + "Mundo";

            for (int i = 0; i < cadena.Length; i++)
            {
                Console.WriteLine(cadena[i]);
            }

            cadena = cadena.Insert(1, "lalal");


            foreach (char s in cadena)
            {
                Console.WriteLine(s);
            }


            StringBuilder sb = new StringBuilder("Hola");

            sb.Append(cadena);
            sb.AppendFormat("lalala {0}", cadena);
            sb.AppendLine("Chau Mundo");

            Console.WriteLine(sb);

            DateTime dateTime = DateTime.Now;

            Console.WriteLine(dateTime.Year);

            Console.WriteLine(dateTime);
                      

            Console.ReadKey();
        }
    }
}