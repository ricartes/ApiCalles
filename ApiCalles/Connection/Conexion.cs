using Npgsql;

namespace ApiCalles.DAO.Connection
{
    public class Conexion
    {
        NpgsqlConnection conexion = new NpgsqlConnection();

        public NpgsqlConnection abrirConexion()
        {
            conexion.ConnectionString = "server=localhost;port=5432;user id=usuario_calles;password=calles2022;database=db_calles;";

            if (conexion.State != System.Data.ConnectionState.Open)
            {
                conexion.Open();
            }

            return conexion;
        }

        public NpgsqlConnection cerrarConexion()
        {
            if (conexion.State == System.Data.ConnectionState.Open)
            {
                conexion.Close();
            }

            

            return conexion;
        }
    }
}