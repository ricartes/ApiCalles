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
            string query = "INSERT INTO \"CALLE\" (\"STR_MAN_ID\", \"STR_VAN_DESCRIPCION\") VALUES (:STR_MAN_ID, :STR_VAN_DESCRIPCION)";
            NpgsqlConnection conn = conexion.abrirConexion();
            NpgsqlCommand command = new NpgsqlCommand(query, conn);
            command.Parameters.AddWithValue("@STR_MAN_ID",  registro.STR_MAN_ID );
            command.Parameters.AddWithValue("@STR_VAN_DESCRIPCION", registro.STR_VAN_DESCRIPCION);
            command.ExecuteNonQuery();
            conn = conexion.cerrarConexion();


            return registro;
        }

        public long cantidadCalles(CalleDTO registro)
        {
            string query = "SELECT COUNT (\"STR_VAN_ID\") FROM \"CALLE\" WHERE \"STR_VAN_DESCRIPCION\" = :STR_VAN_DESCRIPCION";
            NpgsqlConnection conn = conexion.abrirConexion();
            
            NpgsqlCommand command = new NpgsqlCommand(query, conn);
            command.Parameters.AddWithValue("@STR_VAN_DESCRIPCION", registro.STR_VAN_DESCRIPCION);
            long resultado = (long)command.ExecuteScalar();
            conn = conexion.cerrarConexion();

            return resultado;
        }
    }
}