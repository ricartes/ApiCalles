using Npgsql;
using System.Configuration;

namespace ApiCalles.DAO.Connection
{
    public class Conexion
    {
        NpgsqlConnection conexion = new NpgsqlConnection();
        public NpgsqlConnection abrirConexion()
        {
            string conectionStringCalles = ConfigurationManager.ConnectionStrings["dbcalles"].ConnectionString;
            conexion.ConnectionString = conectionStringCalles;
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