using FincaManager.DataAccess;
using FincaManager.Entities;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace FincaManager.Datos
{
    public class RolesDatos
    {
        private readonly ConexionBD _conexionDatos = new ConexionBD();

        public List<RolesEntidad> MtdConsultar()
        {
            List<RolesEntidad> listaRoles = new List<RolesEntidad>();

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
                                listaRoles.Add(new RolesEntidad
                                {
                                    IdRol = Convert.ToInt32(rd["IdRol"]),
                                    Nombre = Convert.ToString(rd["Nombre"]) ?? string.Empty,
                                    Descripcion = Convert.ToString(rd["Descripcion"]) ?? string.Empty,
                                    Activo = Convert.ToBoolean(rd["Activo"]),
                                    Eliminado = Convert.ToBoolean(rd["Eliminado"]),
                                });
                            }
                        }
                    }
                }
                return listaRoles;
            }
            catch (Exception ex)
            {

                throw new Exception("Error al consultar Roles", ex);
            }
        }
    }
}
