using CL_Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Capa_Datos
{
    public class DA_Categoria : DA_BASE
    {
        public static bool InsertarCategoria(Categoria objCategoria)
        {
            string strSQL = "Insert into categoria(nombre,descripcion) values (";
            strSQL += "'" + objCategoria.Nombre + "',";
            strSQL += "'" + objCategoria.Descripcion + "');";

            return RealizarTransaccion(strSQL);

        }

        public static DataTable ConsultarCategoria()
        {
            DataTable dt = new DataTable();
            string strSQL = "SELECT * FROM categoria;";

            return ConsultarDatos(strSQL);
        }

        public static bool ActualizarCategoria(Categoria objCategoria)
        {

            string strSQL = "Update categoria set nombre='" +
                objCategoria.Nombre + "',descripcion='" +
                objCategoria.Descripcion + "' WHERE idCategoria = " + objCategoria.idCategoria + ";";


            return RealizarTransaccion(strSQL);

        }
    }
}
