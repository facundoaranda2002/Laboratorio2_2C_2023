namespace Clase01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Title = "Proyecto Facundo";

            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Green;

            /*
            int numero = 10;
            string numeroTexto = numero.ToString();
            */

            //float numero = 10.5F; necesito aclarar con la F que es un float porq sino estoy haciendo un casteo invalido

            //int[] numeros = new int[2];
            string[] numeros = new string[2];

            //numeros[0] = 10;
            //numeros[1] = 20;
            numeros[0] = "10";
            numeros[1] = "20";

            foreach (var numero in numeros)//uso el var porque es generico asi que no hay problema pero en realidad tendria que ponerle int ya que se que es un numero 
            {
                Console.WriteLine(numero);
            }

            

            string numeroIngresado;
            int resultado;
            int numeroConvertido;
            bool resultadoConversion;

            Console.WriteLine("Ingrese un numero");
            numeroIngresado = Console.ReadLine();

            resultadoConversion = int.TryParse(numeroIngresado,out numeroConvertido);
            
            if(resultadoConversion)
            {
                Console.WriteLine("Pude convertir");
            }
             else
            {
                Console.WriteLine("No pude convertir");
            }

            resultado = numeroConvertido + 10;

            Console.WriteLine("La suma del numero ingresado mas 10 es {0,40:#.##}", resultado);

            Console.WriteLine($"Esto es una cadena interpolada {resultado.ToString("0.00")} lalalalla {resultado}");

            Console.WriteLine("Hello, World!");
            Console.ReadKey();
        }
    }
}