using Entidades;
using System.Configuration;
namespace Clase15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            GestorDB.InsertEmpleado(new Empleado(1234, "Facundo", "Aranda", 1));
            List<Empleado> listaEmpleados = GestorDB.GetEmpleados();
            foreach(Empleado e in listaEmpleados)
            {
                Console.WriteLine(e.Nombre);
            }
            Console.WriteLine(GestorDB.GetUnEmpleado(2).Apellido);
            
            /*
            ESTO DE ACA ABAJO NO LO VOY A USAR PARA NADA, ESTOY USANDO UN ARCHIVO DE CONFIGURACION EN MI APLICACION
            Console.WriteLine(ConfigurationManager.AppSettings["saludo"]);
            Console.WriteLine(ConfigurationManager.ConnectionStrings["miConection"]);
            Console.WriteLine(Properties.Resources.cadenaDeConexion);
            */

        }
    }
}