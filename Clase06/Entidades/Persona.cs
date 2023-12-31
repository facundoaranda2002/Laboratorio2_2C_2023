﻿namespace Entidades
{
    public class Persona
    {
        int edad;
        string nombre;
        string apellido;

        public Persona(int edad, string nombre, string apellido)
        {
            this.edad = edad;
            this.nombre = nombre;
            this.apellido = apellido;
        }

        public int getEdad()
        {
            return this.edad;
        }

        public string getNombre() 
        {
            return this.nombre;
        }

        public string getApellido()
        {
            return this.apellido;
        }

        public string Saludar()
        {
            return $"Soy {this.nombre} {this.apellido} {this.edad}";
        }
    }
}