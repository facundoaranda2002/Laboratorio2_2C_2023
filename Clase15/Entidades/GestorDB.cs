using System.Data.SqlClient;
using System.Runtime.CompilerServices;

namespace Entidades
{
    public class GestorDB
    {
        static string stringConnection = "Server=.;Database=Clase 15;Trusted_Connection=True;";

        
        public static List<Empleado> GetEmpleados()
        {
            List<Empleado> empleados = new List<Empleado>();
            using (SqlConnection connection = new SqlConnection(stringConnection))//como usamos el using no hace falta usar el connection.close
            {
                string sentencia = "SELECT * FROM EMPLEADOS";
                SqlCommand cmd = new SqlCommand(sentencia, connection);
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                //cmd.ExecuteNonQuery(); para todas las sentencias que no sean de lectura
                while(reader.Read())
                {
                    empleados.Add(new Empleado(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3)));
                }
            }
            return empleados;
        }

        public static Empleado GetUnEmpleado(int id)
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))//como usamos el using no hace falta usar el connection.close
            {
                string sentencia = "SELECT * FROM EMPLEADOS WHERE ID = @id";
                SqlCommand cmd = new SqlCommand(sentencia, connection);
                cmd.Parameters.AddWithValue("id", id);//con esto evito una posible inyeccion sql en la linea de arriba
                connection.Open();
                SqlDataReader reader = cmd.ExecuteReader();
                //cmd.ExecuteNonQuery(); para todas las sentencias que no sean de lectura
                while (reader.Read())
                {
                    return new Empleado(reader.GetInt32(0), reader.GetString(1), reader.GetString(2), reader.GetInt32(3));
                }
                throw new Exception("No existe el empleado con ese id");
            }
        }

        public static int InsertEmpleado(Empleado empleado)
        {
            using (SqlConnection connection = new SqlConnection(stringConnection))//como usamos el using no hace falta usar el connection.close
            {
                string sentencia = "INSERT INTO EMPLEADOS (NOMBRE, APELLIDO, ID_SECTOR) VALUES (@nombre, @apellido, @idSector)";
                SqlCommand cmd = new SqlCommand(sentencia, connection);
                cmd.Parameters.AddWithValue("nombre", empleado.Nombre);
                cmd.Parameters.AddWithValue("apellido", empleado.Apellido);
                cmd.Parameters.AddWithValue("idSector", empleado.IdSector);
                connection.Open();
                return cmd.ExecuteNonQuery();//retorna la cantidad de filas afectadas
            }
        }

    }
}