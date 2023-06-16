namespace entidades
{
    public class Persona //la clase no tiene que ser static porque sino no podria crear objetos(generar instancias)
    {
        public static string familia = "Mono"; //una clase no estatica si que puede tener atributos estaticos
        public int edad;
        public string nombre;
        public string apellido;


        static Persona()//no lleva modificadores de acceso ya que es el encargado de inicializar los atributos estaticos, es el primer constructor que se ejecuta(lo hace una sola vez, apenas entra en la clase) y no lo vamos a poder invocar desde afuera de la clase, por eso no recibe parametros
        {
            Persona.familia = "Mono";//esta es la manera correcta de escribir lo de arriba
        }

        /*
        public Persona() { }//Constructor por defecto sin parametros, no hace falta escribirlo, inicializa cada elemento ya sea en null o 0 dependiendo del tipo de dato 
        */

        public Persona(string nombre, string apellido)//Constructor parametrizado, puedo tenerlo junto con el de arriba haciendo una sobrecarga
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = 56;//si no lo escribiera en este caso al ser un int el valor por defecto con el que se inicializa es 0 
        }


        public static void CambiarFamilia(string familia)
        {
            Persona.familia = familia;//no puedo llamar la variable static con this ya que es una constante asi que tengo que llamarla con Persona.familia
        }

        public string Saludar()
        {
            return $"Soy una persona y mi nombre es {this.nombre}";
        }

        public static void CambiarNombre(Persona p)
        {
            p.nombre = "Nombre cambiado";
        }
    }
}