using Entidades;

namespace Clase12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<int> list = new List<int>();
            //MiClaseGenerica<int> miClaseGenerica = new MiClaseGenerica<int>();
            //MiClaseGenerica<string> miClaseGenericaTexto = new MiClaseGenerica<string>();

            //miClaseGenerica.ImprimirValor(10);
            //miClaseGenericaTexto.ImprimirValor("Hello, World!");

            //boxing y unboxing
            int numero = 42;
            object obj = numero;//conversion implicita

            object obj2 = 42;
            int numero2 = (int)obj2;

            //MiClaseGenerica<Persona> miClaseGenerica = new MiClaseGenerica<Persona>();
        }
    }
}