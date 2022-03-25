using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PersonasWeb.Models
{
    public class GestorPersona
    {
        GestorConexion gc = new GestorConexion();
        private SqlCommand comando;
        private SqlDataReader dr;
        public void AgregarPersona(Persona nuevaPersona)
        {
            gc.AbrirConexion();
            comando = new SqlCommand("insert into Persona (documento, nombre, edad) values (@documento, @nombre, @edad)", gc.conexion);
            comando.Parameters.Add(new SqlParameter("@documento", nuevaPersona.Documento));
            comando.Parameters.Add(new SqlParameter("@nombre", nuevaPersona.Nombre));
            comando.Parameters.Add(new SqlParameter("@edad", nuevaPersona.Edad));
            comando.ExecuteNonQuery();
            gc.CerrarConexion();
        }
        public List<Persona>ListarPersona()
        {
            List<Persona> lista = new List<Persona>();
            gc.AbrirConexion();
            comando = new SqlCommand("select * from Persona", gc.conexion);
            dr = comando.ExecuteReader();
            while(dr.Read())
            {
                int documento = dr.GetInt32(0);
                string nombre = dr.GetString(1);
                int edad = dr.GetInt32(2);
                Persona P = new Persona(documento, nombre, edad);
                lista.Add(P);
            }
            gc.CerrarConexion();
            return lista;
        }
    }
}