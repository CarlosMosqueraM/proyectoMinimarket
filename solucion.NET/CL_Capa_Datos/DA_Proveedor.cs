using CL_Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Capa_Datos
{
    public class DA_Proveedor : DA_BASE
    {
        public static bool InsertarProveedor(Proveedor objProveedor)
        {
            string strSQL = "Insert into proveedor(nit,razonSocial,telefono,correo,nomenclatura,ciudad,departamento) values (";
            strSQL += "'" + objProveedor.Nit + "',";
            strSQL += "'" + objProveedor.RazonSocial + "',";
            strSQL += "'" + objProveedor.Telefono + "',";
            strSQL += "'" + objProveedor.Correo + "',";
            strSQL += "'" + objProveedor.Nomenclatura + "',";
            strSQL += "'" + objProveedor.Ciudad + "',";
            strSQL += "'" + objProveedor.Departamento + "');";

            return RealizarTransaccion(strSQL);


        }


        public static DataTable ConsultarProveedor()
        {
            DataTable dt = new DataTable();
            string strSQL = "SELECT * FROM proveedor;";

            return ConsultarDatos(strSQL);
        }

        public static bool ActualizarProveedor(Proveedor objProveedor)
        {

            string strSQL = "UPDATE proveedor SET razonSocial='" +
                objProveedor.RazonSocial + "',telefono='" +
                objProveedor.Telefono + "',correo='" +
                objProveedor.Correo + "',nomenclatura='" +
                objProveedor.Nomenclatura + "',ciudad='" +
                objProveedor.Ciudad + "',departamento='" +
                objProveedor.Departamento + "' WHERE idProveedor = " + objProveedor.idProveedor + ";";


            return RealizarTransaccion(strSQL);

        }
    }
}
