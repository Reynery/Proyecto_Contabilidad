using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Sistema_De_Costos.Entidades;
using Sistema_De_Costos.Datos;


namespace Sistema_De_Costos.Negocio
{
    public class N_Categorias
    {
        public static DataTable Listado_ca(string cTexto)
        {
            D_Categorias Datos = new D_Categorias();
            return Datos.Listado_ca(cTexto);
        }
    }
}
