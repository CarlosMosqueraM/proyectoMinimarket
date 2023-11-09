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
    public  class CN_Categoria
    {
        public static bool InsertarCategoria(Categoria objCategoria)
        {
            return DA_Categoria.InsertarCategoria
                (objCategoria);
        }

        public static DataTable ConsultarCategoria()
        {
            return DA_Categoria.ConsultarCategoria();

        }

        public static bool ActualizarCategoria(Categoria objCategoria)
        {
            return DA_Categoria.ActualizarCategoria(objCategoria);
        }
    }
}
