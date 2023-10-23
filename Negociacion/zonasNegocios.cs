using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Datos;
using Datos.Zonas;

namespace Negociacion
{
    public class zonasNegocios
    {
        LeerZonas ReadZonas = new LeerZonas();
        GuardarZonas SaveZonas = new GuardarZonas();
        public DataTable listadoDeptos()
        {
            return ReadZonas.departamentos();
        }
        public DataTable listadoMunis(int id_depto)
        {
            return ReadZonas.municipios(id_depto);
        }
        public DataTable listadoZonas(int codigoMuni)
        {
            return ReadZonas.listaZonas(codigoMuni);
        }
        public DataTable datosZona(int codigoZona)
        {
            return ReadZonas.datosZonas(codigoZona);
        }
        public bool guardarZona(string nombreZona, int codigoMuni)
        {
            return SaveZonas.GuardarZona(nombreZona, codigoMuni);
        }
        public bool editarZona(int codigoZona,string nombreZona, int codigoMuni)
        {
            return SaveZonas.editarZona(codigoZona,nombreZona, codigoMuni);
        }
        public bool editarDisponibilidades(int codigoZona, List<int> servicios)
        {
            return SaveZonas.editarDisponibilidades(codigoZona, servicios);
        }
    }
}
