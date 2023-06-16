using entidades;

namespace Clase04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int entero = 5;
            float flotante = 10f;

            Calculadora calculadora = new Calculadora();
            Console.WriteLine(calculadora.Sumar(2, 2));

            //Sumar(1,2,3)
            Console.WriteLine(calculadora.Sumar(1, 2, 3));

            Console.WriteLine(calculadora.Sumar(entero, flotante));


            string[] materias = { "matematica", "estadistica" };
            Alumno alumno = new Alumno(1, "facu", "tope", materias);
            Alumno alumno2 = new Alumno(1, "facu", "tope", materias);

            Console.WriteLine(alumno == alumno2);//si no tuviera la sobrecarga del == me compararia la referencia de los objetos


            string nombreCompleto = alumno;
            int legajo = (int)alumno;

            Console.WriteLine(nombreCompleto);
            Console.WriteLine(legajo);


        }
    }
}