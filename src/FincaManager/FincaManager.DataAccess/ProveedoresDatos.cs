using FincaManager.DataAccess;
using FincaManager.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Datos
{
    public class ProveedoresDatos
    {
        private readonly ConexionBD _conexionDatos = new ConexionBD();

        public List<ProveedoresEntidad> MtdConsultar()
        {
            List<ProveedoresEntidad> listaProveedores = new List<ProveedoresEntidad>();

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
                                listaProveedores.Add(new ProveedoresEntidad
                                {
                                    IdProveedor = Convert.ToInt32(rd["IdProveedor"]),
                                    Nit = Convert.ToString(rd["Nit"]) ?? string.Empty,
                                    NombreRazonSocial = Convert.ToString(rd["NombreRazonSocial"]) ?? string.Empty,
                                    Direccion = Convert.ToString(rd["Direccion"]) ?? string.Empty,
                                    Telefono = Convert.ToString(rd["Telefono"]) ?? string.Empty,
                                    Activo = Convert.ToBoolean(rd["Activo"]),
                                    Eliminado = Convert.ToBoolean(rd["Eliminado"])
                                });
                            }
                        }
                    }
                }
                return listaProveedores;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al consultar Proveedores", ex);
            }
        }
    }
}
