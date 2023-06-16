using Entidades;

namespace Clase16
{
    internal class Program
    {
        public delegate void MiDelegado();//aca genere mi delegado
        public delegate string MiDelegado2();
        static void Main(string[] args)
        {
            List<Persona> lista = new List<Persona>()
            {
                new Persona("Pepe", 50),
                new Persona("Raul", 44),
                new Persona("Lucas", 52),
            };
            /*
            Action action = () => { Console.WriteLine("Hola muno desde mi Action"); };

            action();
            */
            
            //Comparison<Persona> comparison = FuncionCriterio;
            //Comparison<Persona> comparison = (p1, p2)=>p1.Edad-p1.Edad;//aca estoy usando expresion lambda para hacer lo mismo que arriba
            //arriba estoy diciendo que con esos parametros de entrada(izquierda) retorno el resultado de una operacion(la derecha)
            //lista.Sort(comparison);
            //lista.Sort(FuncionCriterio);
            lista.Sort((p1, p2)=>p1.Edad-p2.Edad);
            Persona p = lista.Find(p => p.Edad == 50);

            bool result = lista.Exists(p => p.Nombre == "Lucas");

            //Action<int, int> b = (a, b) => { Console.WriteLine(b); };

            Func<int, double> CalcularPotenciaAlCuadrado = (numero) => numero * numero;

            Func<string, string, bool> ejemplo = (val1, val2) =>
            {


                return true;
            };//si yo pongo llaves despues de las flechas necesito explicitar el return, sino ya viene implicito 

            Console.WriteLine(p.ToString());

            Console.WriteLine(result);

            Console.WriteLine(CalcularPotenciaAlCuadrado(2));

            /*
            foreach(Persona persona in lista)
            {
                Console.WriteLine(persona.ToString());
            }
            */


            /*
            //Action van a ser delegados que no retornan valores
            //Action<int> delegado = HacerAlgo;
            Action delegado = HacerAlgo;//no pongo parentesis porq estoy guardanado la referencia a la funcion, con los parentesis lo estoy ejecutando

            //Func van a ser delegados que retornan un tipo generico y pueden recibir parametros
            Func<int, string> delegadoFunc = Saludar;//el primer int es el parametro que recibe y el segundo el que retorna

            //Predicate van a ser delegados que reciben un parametro y retornan bool
            Predicate<string> delegadoPredicate = Saludar2;

            //Comparison van a ser delegados que reciben 2 genericos y retornan int
            Comparison<Persona> comparison = FuncionCriterio;
            */

            /*
            MiDelegado miDelegado = new MiDelegado(MetodoParaMiDelegado);//esto es lo mismo que lo de abajo
            //MiDelegado miDelegado = MetodoParaMiDelegado;//esto es lo mismo que lo de arriba
            
            miDelegado();//ejecuto el metodo

            miDelegado += MetodoParaMiDelegado2;//miDelegado tiene 2 metodos encapsulados ahora

            miDelegado();//por lo que hice arriba ahora voy a ejecutar los 2 metodos

            miDelegado += MetodoParaMiDelegado2;//como lo agregue devuelta ahora va a ejecutar el metodo 2, 2 veces

            miDelegado();

            miDelegado -= MetodoParaMiDelegado2;//con esto resto

            miDelegado();

            miDelegado = MetodoParaMiDelegado2;//aca estaria pisando todo, asi que solo tendria una llamada a esta funcion

            miDelegado();
            
            //miDelegado.GetInvocationList(); con esto veo la lista de delegados y puedo ir ejecutando uno a uno

            miDelegado += MetodoParaMiDelegado2;

            MiDelegado2 miDelegado2 = MetodoParaMiNuevoDelegado;
            miDelegado2 += MetodoParaMiNuevoDelegado2;
            string resultado = miDelegado2();
            Console.WriteLine(resultado);

            foreach(MiDelegado2 d in miDelegado2.GetInvocationList())
            {
                string algo = d();//tambien se puede hacer como string algo = d.Invoke();
                Console.WriteLine(algo);
            }
            */

            Func<string, string, string> login = Ejecutar(3);
            Console.WriteLine(login("Pepe", "1234"));
            Console.WriteLine(login("Pepe", "1234"));
            Console.WriteLine(login("Pepe", "1234"));
            Console.WriteLine(login("Pepe", "1234"));

            Console.ReadKey();
        }

        static Func<string, string, string> Ejecutar(int cantidad)//este metodo retorna un delegado
        {
            Console.WriteLine("Me inicializo");
            string usuarioValido = "admin";
            string passwordValido = "12345";
            int intentos = 0;
            return (usuario, password) =>
            {
                Console.WriteLine("Me ejecuto");
                if (intentos < cantidad)
                {
                    if (usuario == usuarioValido && password == passwordValido)
                    {
                        return "Bienvenido admin";
                    }
                    intentos++;
                    return "Usuario o password invalido";
                }
                Console.WriteLine("Ya no me ejecuto mas");
                return "Usuario bloqueado";
            };
        }

        static void HacerAlgo()
        {
            Console.WriteLine("Hola mundo");
        }
        static string Saludar(int numero)
        {
            return "Hola mundo";
        }
        static bool Saludar2(string value)
        {
            return value == "Hola mundo";
        }
        static int FuncionCriterio(Persona personaA, Persona personaB)
        {
            return personaA.Edad - personaB.Edad;
        }
        static void MetodoParaMiDelegado()
        {
            Console.WriteLine("Hola Mundo Desde mi Metodo Para Mi Delegado");
        }
        static void MetodoParaMiDelegado2()
        {
            Console.WriteLine("Hola Mundo Desde mi Metodo Para Mi Delegado 2");
        }
        static void MetodoParaMiDelegado3()
        {
            Console.WriteLine("Hola Mundo Desde mi Metodo Para Mi Delegado 3");
        }

        static string MetodoParaMiNuevoDelegado()
        {
            return "Hola Mundo Desde mi Metodo Para Mi Nuevo Delegado";
        }

        static string MetodoParaMiNuevoDelegado2()
        {
            return "Hola Mundo Desde mi Metodo Para Mi Nuevo Delegado 2";
        }


    }
}