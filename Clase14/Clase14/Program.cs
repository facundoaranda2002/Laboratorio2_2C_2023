using Entidades;
using System.Reflection.Emit;
using System.Text.Json;
using System.Xml.Serialization;

namespace Clase14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            char separador = Path.DirectorySeparatorChar;
            string carpeta = "Archivos clase 14";
            string nombreArchivo = "miArchivo.txt";
            //ruta = $"{ruta}{separador}{carpeta}{separador}{nombreArchivo}";

            ruta = Path.Join(ruta, carpeta, nombreArchivo);
            Console.WriteLine(ruta);
            //File.Create(@"C:\Users\gbera\OneDrive\Escritorio\Archivos clase 14\miArchivo.txt");

            using(StreamWriter sw = new StreamWriter(ruta))//con este using nos ahorramos el tener que cerrar el archivo manualmente 
            {
                sw.WriteLine("Hola a todos");
            }

            using (StreamWriter sw = new StreamWriter(ruta, true))//con este true indicamos que queremos agregar data, no pisar la que ya esta, pero si quisieramos pisarlo podemos poner false en vez de true tambien(va a pisar todo el contenido, al igual que cuando no pongo ni true ni false) 
            {
                sw.WriteLine("Como estan?");
            }

            using(StreamReader sr = new StreamReader(ruta))
            {
                string lectura = sr.ReadToEnd();
                Console.WriteLine(lectura);
            }

            //Directory.CreateDirectory(ruta);//crea un directorio, en este caso me va a dar un error porq tengo una extension .txt, ademas si ya existe el directorio no me lo va a crear ni a modificar ni nada

            //XML

            Persona persona = new Persona("Facundo", "Aranda");

            nombreArchivo = "miXml.xml";
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta = Path.Join(ruta, carpeta, nombreArchivo);
            Console.WriteLine(ruta);

            using (StreamWriter sw = new StreamWriter(ruta))
            {
                XmlSerializer xml = new XmlSerializer(typeof(Persona));//el constructor me pide el tipo de un objeto
                xml.Serialize(sw, persona);//con esto serializamos
            }

            using (StreamReader sr = new StreamReader(ruta))
            {
                XmlSerializer xml = new XmlSerializer (typeof(Persona));
                Persona persona2 = (Persona)xml.Deserialize(sr);//para deserializar tengo que castear al objeto que quiero ya que por default me lo devuelve como tipo object

                Console.WriteLine(persona2.Nombre);
                Console.WriteLine(persona2.Apellido);
            }

            //JSON
            Persona personaB = new Persona("Lucas", "Ferrini");
            nombreArchivo = "miJson.json";
            ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            ruta = Path.Join(ruta, carpeta, nombreArchivo);
            Console.WriteLine(ruta);

            using (StreamWriter sw = new StreamWriter(ruta))
            {
                //JsonSerializerOptions opciones = new JsonSerializerOptions();
                //opciones.WriteIndented = true;//sirve para organizar mejor el json, me divide los datos por linea 
                //string json = JsonSerializer.Serialize<Persona>(persona, opciones);
                string json = JsonSerializer.Serialize<Persona>(persona);//no hay constructor, es un metodo estatico que devuelve un string
                Console.WriteLine(json);//asi se ve un json literal
                sw.WriteLine(json);//asi se escribe en un json, la serializacion en si, estoy escribiendo en el archivo

                json = JsonSerializer.Serialize<Persona>(personaB);
                sw.WriteLine(json);
            }

            using (StreamReader sr = new StreamReader(ruta))
            {
                /* Para hacer esto tendria que tener las personas dentro de unos corchetes separados por comas en el json para indicarle que es una lista
                string json = sr.ReadToEnd();
                List<Persona> lista = JsonSerializer.Deserialize<List<Persona>>(json);

                foreach(Persona p in lista)
                {
                    Console.WriteLine(p.Nombre);
                    Console.WriteLine(p.Apellido);
                    Console.WriteLine("***********");
                }
                */
                
                string json = sr.ReadLine();
                string json2 = sr.ReadLine();

                Persona persona3 = JsonSerializer.Deserialize<Persona>(json) as Persona;//deserializar

                Console.WriteLine(persona3.Nombre);
                Console.WriteLine(persona3.Apellido);

                persona3 = JsonSerializer.Deserialize<Persona>(json2) as Persona;//deserializar

                Console.WriteLine(persona3.Nombre);
                Console.WriteLine(persona3.Apellido);
                
            }

        }
    }
}