using Entidades.Exceptions;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades.Files
{
//4.FileManager será estática.
//  a.En el constructor de clase realizar: 
//      i.En el atributo path se almacenará la referencia al escritorio de la pc.
//      Y se le concatenara un el nombre de la carpeta del parcial: ej {path escritorio}
//          +\\20220621SP\\
//      ii.Llamar al método ValidaExistenciaDeDirectorio.
//  b.ValidaExistenciaDeDirectorio:
//      i.Si no existe el directorio almacenado en path, se creará.
//      ii.En caso de producirse una excepción al momento de la creación, esta deberá ser capturada
//      y relanzada en una nueva excepción denominada FileManagerException,
//      la cual contendrá el mensaje: “Error al crear el directorio”.
//  c.Guardar:
//      i.Será genérico y solo permitirá que los elementos a almacenar sean tipos por referencia.
//      ii.Validar la extensión del nombre del archivo. En caso de que sea:
//          1.JSON, se serializará el elemento recibido.
//          2.TXT, se almacena en texto plano.
//          3.Cualquier otra extensión se lanzará una excepción denominada FileManagerException,
//          la cual contendrá el mensaje “Extensión no permitida”.

    public static class FileManager
    {
        private static string path;

        static FileManager()
        {
            FileManager.path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\20220621SP_ARANDA_FACUNDO\\";
            FileManager.ValidaExistenciaDeDirectorio();
        }

        public static void ValidaExistenciaDeDirectorio()
        {
            if(!Directory.Exists(FileManager.path))
            {
                try
                {
                    Directory.CreateDirectory(FileManager.path);
                }
                catch (Exception ex)
                {
                    throw new FileManagerException("Error al crear el directorio", ex);
                }
            }
        }

        public static void Guardar<T>(T elemento, string nombre) where T : class//indico que T(lo que recibe) tiene que ser siempre por referencia
        {
            if(Path.GetExtension(nombre)==".json")//devuelve punto y nombre de la extension
            {
                using (StreamWriter sw = new StreamWriter(FileManager.path + nombre))
                {
                    JsonSerializerOptions opciones = new JsonSerializerOptions();
                    opciones.WriteIndented = true;
                    sw.WriteLine(JsonSerializer.Serialize<T>(elemento, opciones));
                }
            }
            else if (Path.GetExtension(nombre) == ".txt")
            {
                using (StreamWriter sw = new StreamWriter(FileManager.path + nombre))
                {
                    //se almacena en texto plano
                    sw.WriteLine(elemento);
                }
            }
            else
            {
                throw new FileManagerException("Extension no permitida");
            }

            /* Otra forma de hacerlo
            using (StreamWriter sw = new StreamWriter(FileManager.path + nombre))
            {
                if(Path.GetExtension(nombre) == ".json")
                {
                    JsonSerializerOptions opciones = new JsonSerializerOptions();
                    opciones.WriteIndented = true;
                    sw.WriteLine(JsonSerializer.Serialize<T>(elemento, opciones));
                }
                else if (Path.GetExtension(nombre) == ".txt")
                {
                    //se almacena en texto plano
                    sw.WriteLine(elemento);
                }
                else
                {
                    throw new FileManagerException("Extension no permitida");
                }
            }
            */
        }

    }
}
