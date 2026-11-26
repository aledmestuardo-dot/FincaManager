using FincaManager.DataAccess;
using FincaManager.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Datos
{
    public class UnidadesMedidaDatos
    {
        private readonly ConexionBD _conexionDatos = new ConexionBD();

        public List<UnidadesMedidaEntidad> MtdConsultar()
        {
            List<UnidadesMedidaEntidad> listaUnidadesMedida = new List<UnidadesMedidaEntidad>();

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
                                listaUnidadesMedida.Add(new UnidadesMedidaEntidad
                                {
                                    IdUnidadMedida = Convert.ToInt32(rd["IdUnidadMedida"]),
                                    Nombre = Convert.ToString(rd["Nombre"]) ?? string.Empty,
                                    Abreviatura = Convert.ToString(rd["Nombre"]) ?? string.Empty,
                                    Activo = Convert.ToBoolean(rd["Activo"]),
                                    Eliminado = Convert.ToBoolean(rd["Eliminado"])
                                });
                            }
                        }
                    }
                }
                return listaUnidadesMedida;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al consultar Unidades de Medida", ex);
            }
        }
    }
}
