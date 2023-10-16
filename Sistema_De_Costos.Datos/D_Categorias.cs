using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sistema_De_Costos.Entidades;

namespace Sistema_De_Costos.Datos
{
    public class D_Categorias
    {
        //se hara un muestreo de información de lo que tiene la tabla en la Base de Datos
        public DataTable Listado_ca(string cTexto)
        {
            SqlDataReader Resultado;
            DataTable Tabla = new DataTable();
            SqlConnection SQLCon = new SqlConnection();

            try
            {
                SQLCon = Conexion.getInstancia().CrearConexion();
                SqlCommand Comando = new SqlCommand("USP_Listado_ca", SQLCon);
                Comando.CommandType = CommandType.StoredProcedure;
                Comando.Parameters.Add("@cTexto", SqlDbType.VarChar).Value = cTexto;
                SqlCon.Open();
                Resultado = Comando.ExecuteReader();
                Tabla.Load(Resultado);
                return Tabla;
            }
            }
             catch (Exception ex) 
            {
                throw ex;
            }
             finally
            {
                if(SQLCon.State == ConnectionState.Open) SQLCon.Close();    
            }
        }
    }
}
