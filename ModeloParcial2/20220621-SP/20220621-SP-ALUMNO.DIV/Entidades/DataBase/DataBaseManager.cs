using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Entidades.Exceptions;

namespace Entidades.DataBase
{
    //8.DataBaseManager será estática:
    //  a.En el constructor de clase inicializar el string connection.
    //  b.GetNuevaPalabra, recibirá el nombre de la tabla sobre la cual realizar el select y
    //  el id de la palabra a obtener. Retornada la palabra leída desde la BD.

    public static class DataBaseManager
    {
        private static string stringConnection;
        private static SqlConnection connection;
        static DataBaseManager()
        {
            DataBaseManager.stringConnection = "Server=.;Database=20220621SP;Trusted_Connection=True;";
        }

        public static string GetNuevaPalabra(string tabla, int id)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(DataBaseManager.stringConnection))
                {
                    string query = $"SELECT * FROM {tabla} WHERE id =@id";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("id", id);
                    DataBaseManager.connection.Open();

                    SqlDataReader reader = cmd.ExecuteReader();
                    if (reader.Read())
                    {
                        //le paso el numero de columna
                        return reader.GetString(1);
                    }
                    throw new DataBaseManagerException("El id es inexistente");
                }
            }
            catch (Exception ex)
            {
                throw new DataBaseManagerException($"Error al intentar leer de la tabla {tabla}", ex);
            }
        }
    }
}
