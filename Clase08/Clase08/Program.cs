using Entidades;
using System.Runtime.CompilerServices;

namespace Clase08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Taxi taxi = new Taxi("Hola", "Chau", 2, "QQW1212");
            Autobus autobus = new Autobus("Matrcula", "Modelo", 5, 30);

            List<Vehiculo> lista = new List<Vehiculo>();

            lista.Add(taxi);
            lista.Add(autobus);

            foreach(Vehiculo v in lista)
            {
                /*
                if(v is Taxi)
                {
                    Taxi taxi2 = (Taxi)v;
                    taxi2.HacerCarrera();
                }
                */
                //ES LO MISMO QUE:
                if(v is Taxi taxi2)//EN ESTA LINEA ESTOY PREGUNTANDO SI ES TAXI Y SI LO ES DIRECTAMENTE ME CREA LA VARIABLE CASTEANDOLO DE UNA. VIVE SOLO DENTRO DE ESTE SCOOP
                {
                    Console.WriteLine(taxi2.HacerCarrera());
                }
                else if(v is Autobus autobus2)
                {
                    Console.WriteLine((autobus2));
                }

            }

            Vehiculo vehiculo = taxi;


            //Console.WriteLine(taxi.Matricula);

            //taxi.Matricula; no me deja acceder al atributo, solo a la propiedad, ya que esta no es clase hija
        }
    }
}