namespace Clase17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            CancellationTokenSource cancellation = new CancellationTokenSource();
            CancellationToken token = cancellation.Token;
            ConsoleKey teclaPresionada;
            //Task task = new Task(ImprimirHora);//le paso un metodo para ejecutar en el hilo secundario, le paso la referencia al metodo porque me pide un delegado
            //task.Start();
            Action delegado = () => { ImprimirHora(cancellation); };
            Task task = Task.Run(delegado, token);//esto es una forma de hacerlo en una sola linea y la que vamos a usar
            

            do
            {
                teclaPresionada = Console.ReadKey().Key;
                Console.WriteLine($"Presiono {teclaPresionada}");
                if(teclaPresionada == ConsoleKey.Spacebar)
                {
                    cancellation.Cancel();
                }
            }
            while (teclaPresionada != ConsoleKey.Escape);
            
            Console.WriteLine("Presiono escape sali del do while");
            */

            Task tarea = Task.Run(MiMetodo);
            Console.WriteLine($"En el main {Thread.CurrentThread.ManagedThreadId}");
            Task tarea2 = Task.Run(MiMetodo);
            Task tarea3 = Task.Run(MiMetodo);
            Console.WriteLine("La tarea esta iniciada e imprimo en paralelo 1");
            Console.WriteLine("La tarea esta iniciada e imprimo en paralelo 2");
            Console.WriteLine("La tarea esta iniciada e imprimo en paralelo 3");
            Console.WriteLine("La tarea esta iniciada e imprimo en paralelo 4");

            tarea.Wait();//con esto espero a que se termine la tarea secundaria antes de cerrar todo

            Console.WriteLine("Termino mis tareas");
            
        }

        static void ImprimirHora(CancellationTokenSource cancellation)
        {
            do
            { 
                Console.WriteLine($"{DateTime.Now}");
                Thread.Sleep( 1000 );
                Console.Clear();
            }while(true && !cancellation.IsCancellationRequested);
            
        }

        static void MiMetodo()//Esta es una tarea costosa por ejemplo, por eso hay que hacerlo en multihilo
        {
            Console.WriteLine($"El id del task en mi metodo es {Task.CurrentId}");
            Console.WriteLine($"En mi metodo {Thread.CurrentThread.ManagedThreadId}");
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"iteracion numero {i}");
                Thread.Sleep(1000);
            }
        }
    }
}