using CL_Capa_Datos;
using CL_Capa_Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CL_Capa_Negocio
{
    public class CN_Proveedor
    {
        public static bool InsertarProveedor(Proveedor objProveedor)
        {
            return DA_Proveedor.InsertarProveedor(objProveedor);
        }

        public static bool ActualizarProveedor(Proveedor objProveedor)
        {
            return DA_Proveedor.ActualizarProveedor(objProveedor);
        }

        public static DataTable ConsultarProveedor()
        {
            return DA_Proveedor.ConsultarProveedor();

        }

    }
}
