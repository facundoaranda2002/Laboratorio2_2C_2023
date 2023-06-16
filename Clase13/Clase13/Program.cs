using Entidades.Interfaces;
using Entidades.Modelos;

namespace Clase13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //List<Cartero> carteros = new List<Cartero>();
            List<IMensaje> carteros = new List<IMensaje>();
            Cartero cartero = new Cartero();
            Paloma paloma = new Paloma();

            IMensaje mensajeador = new Paloma();
            IMensaje mensajeador2 = new Whatsapp();
            IMensaje mensajeador3 = new Cartero();
            IMensaje mensajeador4 = new Email();


            ((Cartero)cartero).Nombre = "lalalal";

            //paloma.EnviarMensaje(); no puedo gacer esto asi no mas con la implementacion explicita
            ((IMensaje)paloma).EnviarMensaje();//Tenemos que hacerlo asi

            carteros.Add(cartero);
            carteros.Add(paloma); //Esto no se puede salvo que haga que los 2 hereden e implementen la interfaz explicitamente

            foreach(IMensaje item in carteros)
            {
                Console.WriteLine(item.EnviarMensaje());
            }

            /*
            Console.WriteLine(cartero.EnviarMensaje());
            Console.WriteLine(paloma.EnviarMensaje());
            */
        }
    }
}