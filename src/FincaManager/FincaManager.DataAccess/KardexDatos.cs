using FincaManager.DataAccess;
using FincaManager.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Datos
{
    public class KardexDatos
    {
        private readonly ConexionBD _conexionDatos = new ConexionBD();

        public List<KardexEntidad> MtdConsultar()
        {
            List<KardexEntidad> listaKardex = new List<KardexEntidad>();

            try
            {
                using(SqlConnection conn = _conexionDatos.MtdObtenerConexion())
                {
                    string queryConsultar = @"";

                    using(SqlCommand cmd = new SqlCommand(queryConsultar, conn))
                    {
                        conn.Open();

                        using(SqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                listaKardex.Add(new KardexEntidad
                                {
                                    IdKardex = Convert.ToInt32(rd["IdKardex"]),
                                    IdProducto = Convert.ToInt32(rd["IdProducto"]),
                                    TipoMovimiento = Convert.ToString(rd["TipoMovimiento"]) ?? string.Empty,
                                    CantidadUnidades = Convert.ToDecimal(rd["CantidadUnidades"]),
                                    PesoAparente = Convert.ToDecimal(rd["PesoAparente"]),
                                    PesoReal = Convert.ToDecimal(rd["PesoReal"]),
                                    CostoUnitarioQuetzales = Convert.ToDecimal(rd["CostoUnitarioQuetzales"]),
                                    Fecha = Convert.ToDateTime(rd["Fecha"])
                                });
                            }
                        }
                    }
                }
                return listaKardex;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al consultar Kardex", ex);
            }
        }
    }
}
