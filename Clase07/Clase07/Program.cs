using Entidades;

namespace Clase07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona p = new Persona("12345678", "Perez", ETipo.ALUMNO);

            //p.SetDni(-95200);
            //p.Dni = 90000;

            p.FechaDeNacimiento = new DateTime(1970, 02, 01);

            Console.WriteLine(p.Dni);
            Console.WriteLine(p.TipoDePersona);
            Console.WriteLine(p.TipoDeNumero);

            Console.WriteLine((int)ETipo.ALUMNO == 1);


            p.Nombre = "Jose";
            string value = p[0];
            string value2 = p["nombre"];
            Console.WriteLine(value);
            Console.WriteLine(value2);


        }
    }
}