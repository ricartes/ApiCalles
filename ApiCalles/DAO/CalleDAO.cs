using ApiCalles.DAO.Connection;
using ApiCalles.DTO;
using ApiCalles.Interfaces;
using Npgsql;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ApiCalles.DAO
{
    public class CalleDAO : CalleInterface
    {
        private Conexion conexion ;

        public CalleDAO()
        {
            conexion = new Conexion();
        }
        
        public  CalleDTO insertar(CalleDTO registro)
        {
            string query = "INSERT INTO \"QRY_CALLES\" (\"CITY_NAME\", \"STREET\", \"FECHA\") VALUES (:CITY_NAME, :STREET, :FECHA)";
            NpgsqlConnection conn = conexion.abrirConexion();
            NpgsqlCommand command = new NpgsqlCommand(query, conn);
            command.Parameters.AddWithValue("@CITY_NAME",  registro.CITY_NAME);
            command.Parameters.AddWithValue("@STREET", registro.STREET);
            command.Parameters.AddWithValue("@FECHA", registro.FECHA);
            command.ExecuteNonQuery();
            conn = conexion.cerrarConexion();


            return registro;
        }

        public long cantidadCalles(CalleDTO registro)
        {
            string query = "SELECT COUNT (\"STREET\") FROM \"QRY_CALLES\" WHERE UPPER(\"STREET\") = UPPER(:STREET) AND UPPER(\"CITY_NAME\") = UPPER(:CITY_NAME)";
            NpgsqlConnection conn = conexion.abrirConexion();
            NpgsqlCommand command = new NpgsqlCommand(query, conn);
            command.Parameters.AddWithValue("@STREET", registro.STREET);
            command.Parameters.AddWithValue("@CITY_NAME", registro.CITY_NAME);

            long resultado = (long)command.ExecuteScalar();
            conn = conexion.cerrarConexion();

            return resultado;
        }
    }
}