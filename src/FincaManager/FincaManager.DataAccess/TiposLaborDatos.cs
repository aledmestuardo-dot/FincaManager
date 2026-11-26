using FincaManager.DataAccess;
using FincaManager.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Datos
{
    public class TiposLaborDatos
    {
        private readonly ConexionBD _conexionDatos = new ConexionBD();

        public List<TiposLaborEntidad> MtdConsultar()
        {
            List<TiposLaborEntidad> listaTiposLabor = new List<TiposLaborEntidad>();

            try
            {
                using (SqlConnection conn = _conexionDatos.MtdObtenerConexion())
                {
                    string queryConsultar = @"";

                    using (SqlCommand cmd = new SqlCommand(queryConsultar, conn))
                    {
                        conn.Open();

                        using (SqlDataReader rd = cmd.ExecuteReader())
                        {
                            while (rd.Read())
                            {
                                listaTiposLabor.Add(new TiposLaborEntidad
                                {
                                    IdTipoLabor = Convert.ToInt32(rd["IdTipoLabor"]),
                                    Nombre = Convert.ToString(rd["Nombre"]) ?? string.Empty,
                                    TipoPago = Convert.ToString(rd["TipoPago"]) ?? string.Empty,
                                    TarifaBaseQuetzales = Convert.ToDecimal(rd["TarifaBaseQuetzales"]),
                                    HorarioSugerido = Convert.ToString(rd["HorarioSugerido"]) ?? string.Empty,
                                    Activo = Convert.ToBoolean(rd["Activo"]),
                                    Eliminado = Convert.ToBoolean(rd["Eliminado"])
                                });
                            }
                        }
                    }
                }
                return listaTiposLabor;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al consultar Tipos de Labor", ex);
            }
        }
    }
}
