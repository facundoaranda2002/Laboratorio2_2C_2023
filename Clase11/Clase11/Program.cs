using Entidades.MetodoDeExtension;
using Entidades.Modelo;

namespace Clase11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 10;
            Conversor c = new Conversor();

            //ASI NO SE USAAAA(funciona pero no debe aplicarse de esta manera)
            Console.WriteLine(MisMetodosDeExtension.CantidadDeLetras("lalala"));//sigue siendo un metodo estatico por lo lo tanto puedo usarlo como un metodo estatico

            //ASI SI
            Console.WriteLine(numero.ElevarAlCuadrado());
            Console.WriteLine(c.ExtenderConversor());
            Console.WriteLine("Hello, World!".CantidadDeLetras());

            Console.WriteLine("Hola".Concatenar("Mundo", "Como", "Estas").Concatenar("Otra cosa"));

        }
    }
}