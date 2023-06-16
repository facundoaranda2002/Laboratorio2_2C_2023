using entidades;

namespace Clase03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            /*
            //alejandro
            string nombre;
            string apellido;
            int edad;

            //lucas
            string nombre2;
            string apellido2;
            int edad2;
            */

            /* 
            Persona personaUno = new Persona(); Esto podria hacerlo si tuviera el constructor por defecto puesto en la clase Persona ya sea escrito o teniendolo implicitamente al no generar un constructor por mi mismo en la clase
            personaUno.nombre = "Alejandro";
            personaUno.apellido = "Bongionanni";
            personaUno.edad = 35;
            */
            Persona personaUno = new Persona("Alejandro", "Bongionanni");
            Console.WriteLine(personaUno.edad);

            /*
            Persona personaDos = new Persona();
            personaDos.nombre = "Franco";
            personaDos.apellido = "Perrota";
            personaDos.edad = 45;
            */
            Persona personaDos = new Persona("Franco", "Perrota");
            Console.WriteLine(personaDos.edad);

            Console.WriteLine(personaDos.nombre);
            Persona.CambiarNombre(personaDos);
            Console.WriteLine(personaDos.nombre);

            
            Perro miPerro = new Perro();
            miPerro.duenio = personaUno;
            miPerro.edad = 3;
            miPerro.nombre = "Bobby";

            Perro miPerroDos = new Perro();
            miPerroDos.duenio = personaUno;
            miPerroDos.edad = 3;
            miPerroDos.nombre = "Pucci";

            Perro perroReferencia = miPerroDos;

            Console.WriteLine(miPerro.duenio.nombre);



            Console.WriteLine(Persona.familia);

            Persona.CambiarFamilia("LALALA");

            Console.WriteLine(Persona.familia);



            Console.WriteLine(miPerro.Saludar());

            Console.WriteLine(miPerroDos.Saludar());

            perroReferencia.nombre = "lalal";

            Console.WriteLine(perroReferencia.Saludar());

            Console.WriteLine(miPerroDos.Saludar());

            Console.WriteLine(personaDos.Saludar());
        }
    }
}