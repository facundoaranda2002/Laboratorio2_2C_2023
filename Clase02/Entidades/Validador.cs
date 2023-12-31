﻿namespace Entidades
{
    public static class Validador
    {
        /// <summary>
        /// funcion que valida un numero entre un rango especifico
        /// </summary>
        /// <param name="mensaje">mensaje a imprimir por pantalla</param>
        /// <param name="valor">es el valor que va a retornar</param>
        /// <param name="min">es el minimo</param>
        /// <param name="max">es el maximo</param>
        public static void ValidarNumero(string mensaje, out int valor, int min, int max)
        {
            Console.WriteLine(mensaje);

            int.TryParse(Console.ReadLine(), out valor);
            while (valor < min || valor > max)
            {
                Console.WriteLine($"Error valor invalido. Ingrese un valor entre {min} y {max}");
                Console.WriteLine(mensaje);
                int.TryParse(Console.ReadLine(), out valor);
            }
        }

        public static void ValidaTexto(string mensaje, out string valor, params string[] valores)
        {
            Console.WriteLine(mensaje);
            valor = Console.ReadLine();

            while (!valores.Contains(valor))
            {
                Console.WriteLine($"Error valor invalido, ingrese valido");
                valor = Console.ReadLine();
            }
        }
    }
}