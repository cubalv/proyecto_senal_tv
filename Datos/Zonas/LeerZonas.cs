﻿using Datos.DB;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos.Zonas
{
    public class LeerZonas
    {
        ConexionLinqSqlDataContext linqConect = new ConexionLinqSqlDataContext(ConexionSql.route);

        public DataTable departamentos()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("nombre");
            try
            {
                var deptos = (from depto in linqConect.departamento
                              select depto).ToList();
                foreach (var depto in deptos)
                {
                    dt.Rows.Add(depto.id_depto, depto.nombre_depto);
                }
            }
            catch { }

            return dt;
        }

        public DataTable municipios(int id_depto)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("id");
            dt.Columns.Add("nombre");
            try
            {
                var munis = (from muni in linqConect.municipio
                             where muni.id_depto.Equals(id_depto)
                              select muni).ToList();
                foreach (var muni in munis)
                {
                    dt.Rows.Add(muni.id_muni, muni.nombre_muni);
                }
            }
            catch { }

            return dt;
        }
        public DataTable listaZonas(int codigoMuni)
        {
            linqConect = new ConexionLinqSqlDataContext(ConexionSql.route);
            DataTable dt = new DataTable();
            dt.Columns.Add("codigo");
            dt.Columns.Add("nombre");

            try
            {
                var zonass = (from zona in linqConect.zonas
                             where zona.id_muni.Equals(codigoMuni)
                             select zona).ToList();
                foreach (var zona in zonass)
                {
                    dt.Rows.Add(zona.id_zona, zona.nombre_zona);
                }
            }
            catch { }
            return dt;
        }
        public DataTable datosZonas(int codigoZona)
        {
            linqConect = new ConexionLinqSqlDataContext(ConexionSql.route);
            DataTable dt = new DataTable();
            dt.Columns.Add("codigo");
            dt.Columns.Add("nombre");

            try
            {
                var zonass = (from zona in linqConect.zonas
                              where zona.id_zona.Equals(codigoZona)
                              select zona).FirstOrDefault();
                dt.Rows.Add(zonass.id_zona, zonass.nombre_zona);
            }
            catch { }
            return dt;
        }
        public DataTable listadoZonasConsMasServicio(int codigoMuni)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Zona");
            dt.Columns.Add("CantidadServicios");

            try
            {

                var Repeticiones = linqConect.contrato_cliente_plan
                    .Where(y => y.zonas.id_muni.Equals(codigoMuni))
                   .GroupBy(p => p.zonas.nombre_zona)
                   .Select(g => new { Zona = g.Key, Repeticiones = g.Count() });

                foreach (var item in Repeticiones)
                {
                    dt.Rows.Add(item.Zona, item.Repeticiones);
                }

            }
            catch { }

            return dt;
        }
        public DataTable listadoPopularidaPlanes()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Plan");
            dt.Columns.Add("No. Contrataciones");

            try
            {
                var listado = linqConect.contrato_cliente_plan
                             .GroupBy(g => g.planes.nombre_plan)
                             .Select(s => new { Plan= s.Key, Repet = s.Count() });

                foreach (var item in listado)
                {
                    dt.Rows.Add(item.Plan, item.Repet);
                }

            }
            catch { }

            return dt;
        }
    }
}
