using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Sistema_De_Costos.Datos
{
    public class Conexion
    {
        //Se definen las variables
        private string Base;
        private string Servidor;
        private string Usuario;
        private string Clave;
        private bool Seguridad;
        private static Conexion Con = null;

        private Conexion ()
        {
            //Se definen los datos
            this.Base = "BD_SISTEMA_COSTOS";
            this.Servidor = "JOSUE";
            this.Usuario = "Sistemas";
            this.Clave = "soporte";
            this.Seguridad = false;
        }

        public SqlConnection CrearConexion()
        {
            //Se genera todo el proceso de conectividad
            SqlConnection Cadena = new SqlConnection();
            try
            {
                Cadena.ConnectionString = "server=" + this.Servidor + "; Database=" + this.Base + ";";
                if (Seguridad)
                {
                    Cadena.ConnectionString = Cadena.ConnectionString + "Integrated Security = SSPI";  //Se genera de forma integrada
                }
                else
                {
                    Cadena.ConnectionString=Cadena.ConnectionString+"User Id="+this.Usuario+"; Password="this.Clave; //Forma de autenticación de SQL Server
                }
            }
            catch (Exception ex)
            {
                Cadena = null;
                throw ex;
            }
            return Cadena;
        }

        public static Conexion getInstancia() //Se realizara una conexión estatica en caso de que la conexión publica falle.
        {
            if (Con == null)
            {
                Con = new Conexion();
            }
            return Con;
        }
    }
}
