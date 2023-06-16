namespace Entidades
{
    public class MiClaseGenerica<T,U> 
        where T : U
        where U : class, new()
    {
        
        public void ImprimirValor(T generico)
        {
            Console.WriteLine(generico);
        }
    }
}