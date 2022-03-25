using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace PersonasWeb.Models
{
    public class GestorConexion
    {
        public SqlConnection conexion;
        public void AbrirConexion()
        {
            conexion = new SqlConnection("Data Source=DESKTOP-E8FRIUV\\SQLEXPRESS01;Initial Catalog=Persona;User ID=sa;Password=giandjoe");
            conexion.Open();
        }
        public void CerrarConexion()
        {
            conexion.Close();
            conexion.Dispose();
        }
    }
}