using Entidades;
using System.Collections;
using System.Collections.Generic;
namespace Clase06
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            /*
            
            //ARRAYS

            int[] edades = { 1, 2, 3};

            int[,] edades2 = { {1, 2} };
            
            Array.Resize(ref edades, 5);//le estoy pasando por referencia al array(por eso el ref) para que le cambia el tamaño

            Console.WriteLine(edades[4]);

            Console.WriteLine(edades2[0,0]);
            */

            //COLECCIONES GENERICAS

            List<int> edades;
            
            edades = new List<int>();

            edades.Add(1);
            edades.Add(3);
            edades.Add(3);
            edades.Add(3);
            edades.Add(3);

            foreach(int edad in edades)
            {
                Console.WriteLine(edad);
            }

            Console.WriteLine($"cantidad de elementos: {edades.Count}");


            Persona p1 = new Persona(34, "Pepe", "Argento");
            Persona p2 = new Persona(36, "Colo", "Barco");
            Persona p3 = new Persona(30, "Cristian", "Pavon");

            List<Persona> jugadores = new List<Persona>() {p1, p2, p3};

            Console.WriteLine("Primera impresion");
            foreach (Persona item in jugadores)
            {
                Console.WriteLine(item.Saludar());
            }

            jugadores.Clear();

            Console.WriteLine("Segunda impresion");
            foreach (Persona item in jugadores)
            {
                Console.WriteLine(item.Saludar());
            }

            jugadores.Add(p1);
            jugadores.Add(p2);

            Console.WriteLine("Tercera impresion");
            foreach (Persona item in jugadores)
            {
                Console.WriteLine(item.Saludar());
            }

            jugadores.Remove(p2);//no le importa la posicion en que este, la busca por valor y la remueve

            Console.WriteLine("Cuarta impresion");
            foreach (Persona item in jugadores)
            {
                Console.WriteLine(item.Saludar());
            }

            List<int> numeros = new List<int>() { 1, 5, 3, 2, 9, 7 };

            numeros.Sort();

            foreach(var item in numeros)
            {
                Console.WriteLine(item); 
            }

            numeros.Sort(FuncionCriterio);

            foreach (var item in numeros)
            {
                Console.WriteLine(item);
            }

            jugadores.Sort(FuncionCriterioPersonaEdad);
            Console.WriteLine("Quinta impresion");
            foreach (Persona item in jugadores)
            {
                Console.WriteLine(item.Saludar());
            }

            jugadores.Sort(FuncionCriterioPersonaNombre);
            Console.WriteLine("Sexta impresion");
            foreach (Persona item in jugadores)
            {
                Console.WriteLine(item.Saludar());
            }

            int FuncionCriterio(int num1, int num2)//la funcion sort hace un comparison el cual evalua si hay un valor menor o mayor a 0 y con ese resultado sabe como ir ordenando(si da igual a cero son iguales asi que los deja juntitos). Esto lo puedo hacer porq estoy trabajando con numeros
            {
                return num2 - num1;
            }

            int FuncionCriterioPersonaEdad(Persona p1, Persona p2)
            {
                return p2.getEdad() - p1.getEdad();
            }

            int FuncionCriterioPersonaNombre(Persona p1, Persona p2)
            {
                return String.Compare(p1.getNombre(), p2.getNombre());
            }

            //COLECCIONES NO GENERICAS

            ArrayList lista = new ArrayList();

            //COMO TODO DERIVA DE LA CLASE OBJECT ME DEJA AGREGAR CUALQUIER COSA
            lista.Add(p1);
            lista.Add("Hola mundo");
            lista.Add(2);

            foreach (var p in lista)
            {
                if(p is Persona)
                {
                    Console.WriteLine(((Persona)p).Saludar());
                }
                Console.WriteLine(p);
            }

            //COLECCIONES GENERICAS DICTIONARY  

            Dictionary<int, string> dic = new Dictionary<int, string>();

            dic.Add(1111, "Alejandro");
            //dic.Add(1111, "Pepe"); No me deja ya que la clave 90 ya esta ocupada
            dic.Add(2222, "Pepe");

            Console.WriteLine(dic[1111]);
            Console.WriteLine(dic[2222]);

            Dictionary<string, string> dic2 = new Dictionary<string, string>();

            dic2.Add("Hola", "Alejandro");
            //dic2.Add("Hola", "Pepe"); No me deja ya que la clave 90 ya esta ocupada
            dic2.Add("Como", "Pepe");

            Console.WriteLine(dic2["Hola"]);
            Console.WriteLine(dic2["Como"]);
            foreach(KeyValuePair<string, string> item in dic2)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            if (dic2.ContainsKey("Hola"))
            {
                dic2.Remove("Como");
            }
            foreach (KeyValuePair<string, string> item in dic2)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            dic2.Clear();
            foreach (KeyValuePair<string, string> item in dic2)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            /*
            Dictionary<string, List<Persona>> dic3 = new Dictionary<string, List<Persona>>();

            dic3.Add("Argentinos", jugadores);
            */

            //COLECCIONES GENERICAS QUEUE

            Queue<int> cola = new Queue<int>();

            cola.Enqueue(1);
            cola.Enqueue(2);
            cola.Enqueue(3);

            Console.WriteLine("cantidad: {0}", cola.Count);
            Console.WriteLine("recupero pero no elimino {0}", cola.Peek());
            Console.WriteLine("cantidad: {0}", cola.Count);
            Console.WriteLine("item: {0}", cola.Dequeue());
            Console.WriteLine("cantidad: {0}", cola.Count);
            foreach (int item in cola)
            {
                Console.WriteLine(item);
            }
            if (cola.Count > 0)
            {
                cola.Clear();
            }
            foreach(int item in cola)
            {
                Console.WriteLine(item);
            }

            /* ESTO NO SE PUEDE HACER YA QUE ESTOY CAMBIANDO EL TAMAÑO DE LO QUE ESTA RECORRIENDO EL FOREACH    
            foreach (int item in cola)
            {
                Console.WriteLine(cola.Dequeue());
            }
            */

            //COLECCIONES GENERICAS STACK

            Stack<int> pila = new Stack<int>();

            pila.Push(1);
            pila.Push(2);
            pila.Push(3);

            foreach(var p in  pila)
            {
                Console.WriteLine(p);
            }

            Console.WriteLine(pila.Pop());

            Console.WriteLine(pila.Peek());

            //COLECCIONES GENERICAS SORTED LIST

            SortedList<int, string> sortedList = new SortedList<int, string> ();

            sortedList.Add(90, "hola");
            sortedList.Add(1, "mundo");

            foreach(var item in sortedList)
            {
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

        }
    }
}