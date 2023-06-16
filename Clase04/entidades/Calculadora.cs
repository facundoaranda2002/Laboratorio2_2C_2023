using System.Reflection.Emit;

namespace entidades
{
    public class Calculadora
    {
        public int resultado;

        public Calculadora()
        {
            this.resultado = 0;
        }

        public Calculadora(int resultado)
        {
            this.resultado = resultado;
        }


        //Cambien los parametros
        //1-Cambie la cantidad de parametros

        public int Sumar(int numero1, int numero2)
        {
            return numero1 + numero2;
        }

        public int Sumar(int numero1, int numero2, int numero3)
        {
            return this.Sumar(numero1, numero2) + numero3;//numero1 + numero2 + numero3
        }

        //2-Cambie el tipo de los parametros

        public float Sumar(float numero1, float numero2)
        {
            return numero2 + numero1;
        }

        //3-Cambie el prden de los parametros

        public float Sumar(float numero1, int numero2)
        {
            return numero2 + numero1;
        }

        public float Sumar(int numero1, float numero2)
        {
            return numero2 + numero1;
        }


    }
}