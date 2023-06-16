namespace Entidades
{
    public class Autobus : Vehiculo
    {
        private int numeroPlazas;

        

        private Autobus(string matricula, string modelo, double potencia) : base(matricula, modelo, potencia)
        {
            
        }

        public Autobus(string matricula, string modelo, double potencia, int numeroPlazas) : this(matricula, modelo, potencia)
        {
            this.NumeroPlazas = numeroPlazas;
        }

        public int NumeroPlazas { get => numeroPlazas; set => numeroPlazas = value; }
    }
}