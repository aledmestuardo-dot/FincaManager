using FincaManager.DataAccess;
using FincaManager.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Datos
{
    public class LotesSectoresDatos
    {
        private readonly ConexionBD _conexionDatos = new ConexionBD();

        public List<LotesSectoresEntidad> MtdConsultar()
        {
            List<LotesSectoresEntidad> listaLotesSectores = new List<LotesSectoresEntidad>();

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
                                listaLotesSectores.Add(new LotesSectoresEntidad
                                {
                                    IdLoteSector = Convert.ToInt32(rd["IdLoteSector"]),
                                    IdFinca = Convert.ToInt32(rd["IdFinca"]),
                                    Nombre = Convert.ToString(rd["Nombre"]) ?? string.Empty,
                                    AreaTrabajableMetros = Convert.ToDecimal(rd["AreaTrabajableMetros"]),
                                    TotalPlantas = Convert.ToInt32(rd["TotalPlantas"]),
                                    VariedadCultivo = Convert.ToString(rd["VariedadCultivo"]) ?? string.Empty,
                                    Activo = Convert.ToBoolean(rd["Activo"]),
                                    Eliminado = Convert.ToBoolean(rd["Eliminado"])
                                });
                            }
                        }
                    }
                }
                return listaLotesSectores;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al consultar Lotes/Sectores", ex);
            }
        }
    }
}
